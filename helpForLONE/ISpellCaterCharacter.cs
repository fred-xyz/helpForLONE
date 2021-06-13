using System;
using System.Collections.Generic;
using System.Text;

namespace helpForLONE
{
    public interface ISpellCaterCharacter
    {
        void ThrowFrostNova();
        void ThrowMagicMisile();
        void Teleport(int x, int y);
    }
}
