using Strategy_AttackGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Models
{
    public class Character : ICharacter
    {
        public string Name { get; set; }

        public List<Injury> Injuries { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public void Attack(ICharacter characterToAttack, IAttackStrategy attackStrategy)
        {
            attackStrategy.Execute(characterToAttack,this);
        }
    }
}
