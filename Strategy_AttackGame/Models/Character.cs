using Strategy_AttackGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Models
{
    public class Character : ICharacter
    {
        private List<IAttackStrategy> _attackStrategies;


        public string Name { get; set; }

        public List<Injury> Injuries { get; set; }

        public Character(List<IAttackStrategy> attackStrategies)
        {
            _attackStrategies = attackStrategies;
        }

        public void Attack(ICharacter character)
        {
            _attackStrategy.Execute(character);
        }
    }
}
