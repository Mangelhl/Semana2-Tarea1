using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    class Program
    {        
        static void Main()
        {
            Console.WriteLine("Enter the player's life (less than or equal to 100): ");
            int lifePlayer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's damage (less than or equal to 100): ");
            int damagePlayer = Convert.ToInt32(Console.ReadLine());

            Player player = new Player(lifePlayer, damagePlayer);

            List<MeleeEnemy> meleeEnemy = new List<MeleeEnemy>
        {
            new MeleeEnemy(50, 10),
            new MeleeEnemy(60, 15)
        };

            List<RangeEnemy> rangeEnemy = new List<RangeEnemy>
        {
            new RangeEnemy(30, 15, 5),
            new RangeEnemy(40, 20, 3)
        };

            Game game = new Game(player, meleeEnemy, rangeEnemy);
            game.Play();
        }
    }
}
