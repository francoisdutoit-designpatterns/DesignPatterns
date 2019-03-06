using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Interfaces
{
    public interface IAttackStrategy
    {
        void Execute(ICharacter characterToAttack, ICharacter attackingCharacter);
    }
}
