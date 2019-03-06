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


        }
    }
}
