using BattleShip_Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Server
{
    class OBJ_Game
    {
        #region VARS

        private Guid _id;
        private String _name;
        private int _height;
        private int _width;
        private Dictionary<int, int> _boats;
        private OBJ_Client _player1 = null;
        private OBJ_Client _player2 = null;

        #endregion

        #region GETTERS/SETTERS

        public Guid ID { get { return this._id; } set { this._id = value; } }
        public String Name { get { return this._name; } set { this._name = value; } }
        public int Height { get { return this._height; } set { this._height = value; } }
        public int Width { get { return this._width; } set { this._width = value; } }
        public Dictionary<int, int> Boats { get { return this._boats; } set { this._boats = value; } }
        public MSG_Game MSG_Game { get { return this._get_MSG_Game(); } }
        public OBJ_Client Player1 { get { return this._player1; } set { this._player1 = value; } }
        public OBJ_Client Player2 { get { return this._player2; } set { this._player2 = value; } }

        #endregion

        #region PUBLIC METHODS

        public OBJ_Game(Guid guid, OBJ_Client creator, MSG_Game game = null)
        {
            this._id = guid;
            this._player1 = creator;
            this._boats = new Dictionary<int, int>();

            if(null != game)
            {
                this._name = game.Name;
                this._width = game.Width > 20 ? 20 : game.Width;
                this._height = game.Height > 20 ? 20 : game.Width;
                this._boats = game.Boats;
            }
        }

        private MSG_Game _get_MSG_Game()
        {
            MSG_Game game = new MSG_Game();

            game.ID = this._id;
            game.By = this._player1.Login;
            game.Name = this._name;
            game.Width = this._width;
            game.Height = this._height;
            game.Boats = this._boats;

            return game;
        }

        #endregion
    }
}
