using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IBuilder
    {
        public void SetName(string name);

        public void SetHealth(int health);

        public void SetStamina(int stamina);

        public void SetDifficulty(int difficulty);
    }
}
