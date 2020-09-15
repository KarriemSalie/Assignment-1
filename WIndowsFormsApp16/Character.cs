using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
 abstract class Character
    {
        protected int hP;
        protected int max_HP;
        protected int damage;
        protected Tile[] char_vision;


        public Character(int X, int Y, char symbol) : base(X, Y)
        {

        }
        public int HP
        {
            get { return hP; }
            set { hP = value; }
        }

        public int Max_HP
        {
            get { return max_HP; }
            set { max_HP = value; }
        }

        public int Damage  
        {
            get { return damage; }
            set { damage = value; }
        }

        public Tile[] Char_vision  
        {
            get { return char_vision; }
            set { char_vision = value; }
        }
        public enum Movement  
        {
            No_movement,    
            Up,             
            Down,          
            Left,
            Right
        }
        public virtual void Attack(Character target)
        {
            target.HP = target.HP - this.Damage;
        }
        public bool IsDead()
        {
            if (this.HP >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual bool CheckRange(Character target)   
        {
            if (DistanceTo(target) <= 1)
            {
                return true;
               
            }
            else
            {
                return false;
               
            }
        }

        private int DistanceTo(Character target)
        {
            int distance = (this.Xvalue - target.Xvalue) + (this.Yvalue - target.Yvalue);  
          

            int absoluteVal = Math.Abs(distance);    
            return absoluteVal;
        }

        public void Move(Movement move)
        {   
            switch (move)
            {
                case Movement.No_movement:  
                    this.Xvalue = this.Xvalue;
                    this.Yvalue = this.Yvalue;
                    break;
                case Movement.Up:       
                    this.Xvalue = this.Xvalue;
                    this.Yvalue = this.Yvalue + 1;
                    break;
                case Movement.Down:    
                    this.Xvalue = this.Xvalue;
                    this.Yvalue = this.Yvalue - 1;
                    break;
                case Movement.Left:     
                    this.Xvalue = this.Xvalue - 1;
                    this.Yvalue = this.Yvalue;
                    break;
                case Movement.Right:   
                    this.Xvalue = this.Xvalue + 1;
                    this.Yvalue = this.Yvalue;
                    break;
                default:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);

        public abstract override string ToString();
    }



}