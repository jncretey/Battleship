using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Messages
{
    public class MSG_Login
    {
        #region VARS

        private String _name;

        #endregion

        #region GETTERS/SETTERS

        public String Name { get { return this._name; } set { this._name = value; } }

        #endregion
    }
}
