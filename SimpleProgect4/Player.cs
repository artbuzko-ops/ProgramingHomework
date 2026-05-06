using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimpleProgect4
{
    public class Player
    {
        public string Name { get; private set; }
        public ChangingParameters Health { get; private set; }
        public ChangingParameters Mana { get; private set; }
        public ChangingParameters Energy { get; private set; }
        public Inventory Inventory { get; private set; }
        public Player(string name, int health, int mana, int energy)
        {
            Name = name;
            Health = new ChangingParameters(health);
            Mana = new ChangingParameters(mana);
            Energy = new ChangingParameters(energy);
            Inventory = new Inventory();
        }
    }
}