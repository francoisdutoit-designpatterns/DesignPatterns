using Strategy_AttackGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Interfaces
{
    public interface ICharacter
    {
        List<Injury> Injuries { get; set; }
        void Attack(ICharacter character, IAttackStrategy attackStrategy);
    }
}
