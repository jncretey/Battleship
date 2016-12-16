using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Messages
{
    public class MSG_Game
    {
        #region VARS

        private String _by;
        private Guid _id;
        private String _name;
        private int _height;
        private int _width;
        private Dictionary<int, int> _boats;

        #endregion

        #region GETTERS/SETTERS

        public Guid ID { get { return this._id; } set { this._id = value; } }
        public String By { get { return this._by; } set { this._by = value; } }
        public String Name { get { return this._name; } set { this._name = value; } }
        public int Height { get { return this._height; } set { this._height = value; } }
        public int Width { get { return this._width; } set { this._width = value; } }
        public Dictionary<int, int> Boats { get { return this._boats; } set { this._boats = value; } }

        #endregion

        #region PUBLIC METHODS

        public MSG_Game()
        {
            this._boats = new Dictionary<int, int>();
        }

        #endregion
    }
}
