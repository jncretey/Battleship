using BattleShip_Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Server
{
    class OBJ_Client
    {
        #region VARS

        TcpClient _client = null;
        String _login = null;
        String _ip = null;
        int _port = 0;
        StreamWriter _writer = null;
        StreamReader _reader = null;
        private Boolean _connected = false;

        #endregion

        #region GETTERS/SETTERS

        public String IP { get { return this._ip; } }
        public String Login { get { return this._login; } }
        public int Port { get { return this._port; } }
        public Boolean Connected { get { return this._connected; } }

        #endregion

        #region PUBLIC METHODS

        public OBJ_Client(TcpClient client)
        {
            this._client = client;

            this._ip = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
            this._port = ((IPEndPoint)client.Client.RemoteEndPoint).Port;

            this._writer = new StreamWriter(this._client.GetStream(), Encoding.ASCII);
            this._reader = new StreamReader(this._client.GetStream(), Encoding.ASCII);

            this._connected = true;
        }

        public void send(MSG_MESSAGE message)
        {
            this._writer.WriteLine(this._serialiseMessage(message));
            this._writer.Flush();
        }

        public MSG_MESSAGE listen()
        {
            String read = this._reader.ReadLine();
            MSG_MESSAGE message = null;

            if (null == read)
            {
                this._closeClient();
            }

            else
            {
                message = this._deserialiseMessage(read);
            }

            return message;
        }

        #endregion

        #region PRIVATE METHODS

        private void _closeClient()
        {
            this._client.Close();
            this._connected = false;
        }

        private String _serialiseMessage(MSG_MESSAGE message)
        {
            return JsonConvert.SerializeObject(message);
        }

        private MSG_MESSAGE _deserialiseMessage(String message)
        {
            try
            {
                return JsonConvert.DeserializeObject<MSG_MESSAGE>(message);
            }

            catch(Exception ex)
            {
                return new MSG_MESSAGE("ERROR", ex.Message);
            }
        }

        #endregion

    }
}
