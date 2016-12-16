using DLL_Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BattleshipServer
{
    public partial class FRM_Server : Form
    {
        #region VARS

        private BattleshipServer _server = null;

        #endregion

        #region DELEGATE METHODS

        delegate void Callback_Log(String message);

        #endregion

        #region PUBLIC METHODS

        public FRM_Server()
        {
            InitializeComponent();
        }

        #endregion

        #region ACTIONS

        private void BTN_StartStop_Click(object sender, EventArgs e)
        {
            if (null == this._server || !this._server.IsRunning)
            {
                this._server = new BattleshipServer(4242, this._log);
                this._server.Start();

                if (this._server.IsRunning)
                {
                    this.BTN_StartStop.Text = "STOP";
                }
            }

            else
            {
                this._server.Stop();

                if (!this._server.IsRunning)
                {
                    this.BTN_StartStop.Text = "START";
                }
            }
        }

        #endregion

        #region PRIVATE METHODS

        private void _log(String message)
        {
            if (this.RTB_Logs.InvokeRequired)
            {
                Callback_Log d = new Callback_Log(_log);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                this.RTB_Logs.AppendText("[" + DateTime.Now.ToString() + "] " + message + Environment.NewLine);
                this.RTB_Logs.ScrollToCaret();
            }
        }

        #endregion

        
    }
}
