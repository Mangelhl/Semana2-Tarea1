using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class MeleeEnemy
    {
        public int Life;
        public int Damage;

        public MeleeEnemy(int life, int damage)
        {
            Life = life;
            Damage = damage;
        }

        public void ReceiveDamage(int rd)
        {
            if(rd > 0)
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

        public bool IsAlive()
        {
            return Life > 0;
        }
    }
}
