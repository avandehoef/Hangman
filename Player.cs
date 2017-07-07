﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Player
    {
        public Player(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
                Name = name;            
        }

        public Player() : this("anoniem")
        {

        }


        public string Name { get; set; }


    }
}
