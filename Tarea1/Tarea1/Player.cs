using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Player
    {
        public int Life;
        public int Damage;

        public Player(int life, int damage)
        {
            Life = life <= 100 ? life : 100; 
            Damage = damage <= 100 ? damage : 100;
        }

        public void ReceiveDamage(int rd)
        {
            if(rd >0)
            {
                Life -= rd;
                if(Life < 0)
                {
                    Life = 0;
                }
            }
        }

        public int GetDamage()
        {
            return Damage;
        }
    }
}
