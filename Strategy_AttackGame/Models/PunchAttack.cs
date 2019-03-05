using Strategy_AttackGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Models
{
    public class PunchAttack : IAttackStrategy
    {
        public void Execute(ICharacter character)
        {
            character.Injuries.Add(new Injury()
            {
                Name = "BruiseWound",
                Damage = 2
            });
        }
    }
}
