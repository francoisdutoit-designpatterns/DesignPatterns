using System;
using System.Collections.Generic;
using System.Text;

namespace AttackExample
{
    public class EnemyTank : IEnemyAttacker
    {
        Random generator = new Random();

        public void assignDriver(string driverName)
        {
            Console.WriteLine($"{driverName} is driving the tank.");
        }

        public void driveForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine($"Enemy tank moves {movement} spaces.");
        }

        public void fireWeapon()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine($"Enemy tank does {attackDamage} damage.");
        }
    }
}
