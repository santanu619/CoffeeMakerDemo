using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerDemoLive
{
    public class FakeStarbucksStore : IMakeACoffee
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
        {
            return "Your Order is received.";
        }
    }
}

