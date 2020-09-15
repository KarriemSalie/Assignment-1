using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    abstract class Enemy :Character
    {
        protected Random randomobj;

        public Random Randomobj
        {
            get { return randomobj; }
            set { randomobj = value; }
        }

        public Enemy(int Xvalue, int Yvalue,int HP, int max_HP, int Enemy_damage, char symbol) : base(Xvalue, Yvalue, symbol)
        {
            this.HP = HP;
            this.Max_HP = max_HP;
            this.Damage = Enemy_Damage;
        }

        public override string ToString()
        {
            return string.Format(this.GetType() + " at " + "[" + this.Xvalue + ", " + this.Yvalue + "]" + "(" + this.Damage + ")");
        }
    }

    class Goblin : Enemy
    {
        public Goblin(int Xvalue, int Yvalue) : base(Xvalue, Yvalue,10, 10, 1, 'G')
        {

        }

        public override Movement MoveReturn(Movement move)
        {
            switch (move)
            {
                case Movement.No_movement:
                    return Movement.No_movement;

                case Movement.Up:
                    return Movement.Up;

                case Movement.Down:
                    return Movement.Down;

                case Movement.Left:
                    return Movement.Left;

                case Movement.Right:
                    return Movement.Right;

                default:
                    return Movement.No_movement;
            }
        }

    }

}
