namespace SimpleFactory3
{
    public class Coffee
    {
        public static class Factory
        {
            public static Coffee NewCappucino()
            {
                var coffeeParams = new List<CoffeeParameters>();
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1, Order = 2 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.MilkFoam, Count = 1, Order = 3 });
                return new Coffee(coffeeParams);
            }

            public static Coffee NewLatte()
            {
                var coffeeParams = new List<CoffeeParameters>();
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1.7, Order = 2 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.MilkFoam, Count = 0.3, Order = 3 });
                return new Coffee(coffeeParams);
            }

            public static Coffee NewMacchiato()
            {
                var coffeeParams = new List<CoffeeParameters>();
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 0.5, Order = 2 });
                return new Coffee(coffeeParams);
            }

            public static Coffee NewMocha()
            {
                var coffeeParams = new List<CoffeeParameters>();
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Chocolate, Count = 0.4, Order = 2 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1.6, Order = 3 });
                return new Coffee(coffeeParams);
            }

            public static Coffee NewAmericano()
            {
                var coffeeParams = new List<CoffeeParameters>();
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Water, Count = 2, Order = 2 });
                return new Coffee(coffeeParams);
            }

            public static Coffee NewFlatWhite()
            {
                var coffeeParams = new List<CoffeeParameters>();
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 2, Order = 2 });
                return new Coffee(coffeeParams);
            }

            public static Coffee NewEspresso()
            {
                var coffeeParams = new List<CoffeeParameters>();
                coffeeParams.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
                return new Coffee(coffeeParams);
            }
        }

        private Coffee(List<CoffeeParameters> parameters)
        {

        }
        private class CoffeeParameters
        {
            public IngredientType IngredientType;
            public double Count { get; set; }
            public int Order { get; set; }
        }

        private enum IngredientType
        {
            MilkFoam,
            SteamedMilk,
            Chocolate,
            Espresso,
            Water
        }
    }
}
