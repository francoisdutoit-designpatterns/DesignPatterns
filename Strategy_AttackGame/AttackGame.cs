using Common.Interfaces;
using Strategy_AttackGame.Interfaces;
using Strategy_AttackGame.Models;
using Strategy_AttackGame.Models.AttackModels;
using System;
using System.Collections.Generic;

namespace Strategy_AttackGame
{
    public class AttackGame : IProgram
    {
        public void Execute()
        {
            var firstCharacter = new Character("James") {};
            var secondCharacter = new Character("John") {};

            firstCharacter.Attack(secondCharacter, new GunAttack() { });
            firstCharacter.Attack(secondCharacter, new KniveAttack() { });
            secondCharacter.Attack(firstCharacter, new PunchAttack() { });

            Console.WriteLine("firstCharacter");
            foreach(var injury in firstCharacter.Injuries)
            {
                Console.WriteLine($"{injury.Name}, {injury.Damage}");
            }

            Console.WriteLine("secondCharacter");
            foreach (var injury in secondCharacter.Injuries)
            {
                Console.WriteLine($"{injury.Name}, {injury.Damage}");
            }

            Console.ReadKey();

        }
    }
}
