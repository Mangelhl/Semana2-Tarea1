using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Game
    {
        private Player player;
        private List<MeleeEnemy> meleeEnemies;
        private List<RangeEnemy> rangeEnemies;

        public Game(Player player, List<MeleeEnemy> meleeEnemies, List<RangeEnemy> rangeEnemies)
        {
            this.player = player;
            this.meleeEnemies = meleeEnemies;
            this.rangeEnemies = rangeEnemies;
        }

        public void PlayerTurn()
        {
            foreach (var enemy in meleeEnemies)
            {
                if(enemy.IsAlive())
                {
                    enemy.ReceiveDamage(player.GetDamage());
                }
            }

            foreach (var enemy in rangeEnemies)
            {
                if(enemy.IsAlive())
                {
                    enemy.ReceiveDamage(player.GetDamage());
                }
            }
        }

        public void EnemyTurn()
        {
            foreach (var enemy in meleeEnemies)
            {
                if(enemy.IsAlive())
                {
                    player.ReceiveDamage(enemy.GetDamage());
                }
            }

            foreach (var enemy in rangeEnemies)
            {
                if(enemy.IsAlive())
                {
                    player.ReceiveDamage(enemy.GetDamage());
                }
            }
        }

        public void Play()
        {
            while(true)
            {
                if(meleeEnemies.TrueForAll(e => !e.IsAlive()) && rangeEnemies.TrueForAll(e => !e.IsAlive()))
                {
                    Console.WriteLine("¡Win!");
                    break;
                }
                else if(player.Life <= 0)
                {
                    Console.WriteLine("¡Lose!");
                    break;
                }

                PlayerTurn();
                EnemyTurn();
            }
        }
    }
}
