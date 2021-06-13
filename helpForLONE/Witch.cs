﻿using System;
using System.Collections.Generic;
using System.Text;

namespace helpForLONE
{
    public class Witch : ICharacter, ISpellCaterCharacter
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }

        public void ThrowFrostNova()
        {
            throw new NotImplementedException();
        }

        public void ThrowMagicMisile()
        {
            throw new NotImplementedException();
        }
    }
}
