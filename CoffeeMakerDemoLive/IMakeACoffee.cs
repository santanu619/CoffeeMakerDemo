using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemoLive
{
    public interface IMakeACoffee
    {
        bool CheckIngredientAvailability();
        string CoffeeMaking(int sugerPerSpoon, int CoffeePack);
    }

}
