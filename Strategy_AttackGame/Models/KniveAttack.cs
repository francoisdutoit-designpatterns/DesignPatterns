using Strategy_AttackGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Models
{
    public class KniveAttack : IAttackStrategy
    {
        public void Execute(ICharacter character)
        {
            character.Injuries.Add(new Injury()
            {
                Name = "StabWound",
                Damage = 5
            });
        }
    }
}
