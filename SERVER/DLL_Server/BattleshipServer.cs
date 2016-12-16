using BattleShip_Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DLL_Server
{
    public class BattleshipServer
    {
        #region VARS

        private TcpListener _server;
        private Boolean _isRunning;
        private int _port = 0;
        private Action<String> _callbackLog = null;
        private Thread _waitingClient = null;

        #endregion

        #region GETTERS/SETTERS

        public Boolean IsRunning { get { return this._isRunning; } }

        #endregion

        #region PUBLIC METHODS


        public BattleshipServer(int port = 4242, Action<String> callbackLog = null)
        {
            this._port = port;
            this._callbackLog = callbackLog;
        }

        public void Stop()
        {
            this._server.Stop();
            this._waitingClient.Abort();

            this._isRunning = false;

            this._log("Server Stoped");
        }

        public void Start()
        {
            this._server = new TcpListener(IPAddress.Any, this._port);
            this._server.Start();

            this._waitingClient = new Thread(new ThreadStart(LoopClients));
            this._waitingClient.Start();

            this._isRunning = true;
            this._log("Server Started");
        }

        public void LoopClients()
        {
            try
            {
                while (_isRunning)
                {
                    // wait for client connection
                    TcpClient newClient = _server.AcceptTcpClient();


                    // client found.
                    // create a thread to handle communication
                    Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                    t.Start(newClient);
                }
            }

            catch (Exception)
            {

            }
        }

        public void HandleClient(object obj)
        {
            // Init client
            TcpClient tcpClient = (TcpClient)obj;
            OBJ_Client client = new OBJ_Client(tcpClient);

            // Log connect
            this._log("New Client from : " + client.IP + ":" + client.Port.ToString());

            client.send(new MSG_MESSAGE("WELCOME"));

            // Read from client
            MSG_MESSAGE listen = null;
            while (client.Connected)
            {
                listen = client.listen();

                if (null != listen)
                {
                    this._action(listen);
                }
            }
        }

        #endregion

        #region PRIVATE METHODS

        private void _action(OBJ_Client from, MSG_MESSAGE message)
        {
            switch (message.Message)
            {
                case "LOGIN":
                    this._actionLogin(from, message);
                    break;

                default:
                    break;
            }
        }

        private void _actionLogin(OBJ_Client from, MSG_MESSAGE message)
        {
            MSG_Login login = (MSG_Login)message.Values;
        }

        private void _log(String message)
        {
            if (null != this._callbackLog)
            {
                this._callbackLog(message);
            }
        }

        #endregion

    }
}
