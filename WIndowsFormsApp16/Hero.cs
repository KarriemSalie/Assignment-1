using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    class Hero : Character
    {

        public Hero(int X, int Y, int Hero_HP, int Hero_MaxHP) : base(X, Y, 'H')
        {
            this.Damage = 2;
        }

        public override Movement ReturnMove(Movement move = Movement.No_movement)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("Player Stats: \n" + "HP: " + this.HP + "/ " + this.Max_HP + "\n" +
                                    "Damage: 2 \n" + "[" + this.Xvalue + "," + this.Yvalue + "]");
        }
    }
}