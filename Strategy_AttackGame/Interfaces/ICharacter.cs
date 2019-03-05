using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Interfaces
{
    public interface ICharacter
    {
        void Attack(ICharacter character);
    }
}
