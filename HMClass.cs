using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class HMClass
    {
        public HMClass(Player player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));
            Player = player;            
        }

        public HMClass() : this(new Player())
        {

        }

        
        public Player Player { get; set; }

        public List<string> Wordlist { get; set; }
        public string Word { get; set; }
        public Outcome Outcome { get; set; }

        public void Guess(char letter)
        {

        }
    }
}
