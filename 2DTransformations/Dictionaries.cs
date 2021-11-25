using _2DTransformations.Enums;
using System.Collections.Generic;

namespace _2DTransformations
{
    static class Dictionaries
    {
        public readonly static Dictionary<ActionEnum, string> ActionTypesDictionary = new()
        {
            { ActionEnum.NoAction, "Brak" },
            { ActionEnum.Draw, "Rysowanie" },
            { ActionEnum.MouseMove, "Przesuwanie myszą" },
            { ActionEnum.MoveKeyboard, "Przesuwanie polami\n tekstowymi" },
            { ActionEnum.Scale, "Skalowanie" },
            { ActionEnum.Rotate, "Obrót" },
        };
    }
}
