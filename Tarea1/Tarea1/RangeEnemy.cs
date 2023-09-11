using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class RangeEnemy
    {
        public int Life;
        public int Damage;
        public int Bullets;

        public RangeEnemy(int life, int damage, int bullets)
        {
            Life = life;
            Damage = damage;
            Bullets = bullets;
        }

        public void ReceiveDamage(int rd)
        {
            if(rd > 0)
            {
                Life -= rd;
                if(Life <0)
                {
                    Life = 0;
                }
            }
        }

        public int GetDamage()
        {
            if(Bullets > 0)
            {
                Bullets--;
                return Damage;
            }
            else
            {
                return 0;
            }
        }

        public bool IsAlive()
        {
            return Life > 0;
        }

    }
}
