using Strategy_AttackGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Models.AttackModels
{
    public class KniveAttack : IAttackStrategy
    {
        public void Execute(ICharacter characterToAttack, ICharacter attackingCharacter)
        {
            characterToAttack.Injuries.Add(new Injury()
            {
                Name = "StabWound",
                Damage = 5
            });
        }
    }
}
