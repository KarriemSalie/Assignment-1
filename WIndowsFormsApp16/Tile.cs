using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    abstract class Tile
    {
        protected int x;
        protected int y;


        public int Xvalue
        {
            get { return x; }
            set { x = value; }
        }

        public int Yvalue
        {
            get { return y; }
            set { y = value; }
        }

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        public Tile(int X, int Y)
        {
            X = 0;
            Y = 0;
            Xvalue = X;
            Yvalue = Y;
        }
    }

    class ObstacleSubClass : Tile
    {
        public ObstacleSubClass(int X, int Y) : base(X, Y)
        {

        }
    }

    class EmptyTile : Tile
    {
        public EmptyTile(int X, int Y) : base(X, Y)
        {

        }
    }
}
