using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Messages
{
    public class MSG_MESSAGE
    {
        #region VARS

        private String _message;
        private Object _values;

        #endregion

        #region GETTERS/SETTERS

        public String Message { get { return this._message; } set { this._message = value; } }
        public Object Values { get { return this._values; } set { this._values = value; } }

        #endregion

        #region PUBLIC METHODS

        public MSG_MESSAGE(String message = null, Object values = null)
        {
            this._message = message;
            this._values = values;
        }

        #endregion
    }
}
