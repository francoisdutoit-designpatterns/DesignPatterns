using Strategy_AttackGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_AttackGame.Models
{
    public class Injury
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public ICharacter InflictedBy { get; set; }
    }
}
