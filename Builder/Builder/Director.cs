using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildDefaultNPC()
        {
            builder.SetName("The Guard");
            builder.SetHealth(50);
            builder.SetStamina(64);
            builder.SetDifficulty(7);
        }

        public void BuildCustomNPC(string name, int health, int stamina, int difficulty)
        {
            builder.SetName(name);
            builder.SetHealth(health);
            builder.SetStamina(stamina);
            builder.SetDifficulty(difficulty);
        }
    }
}
