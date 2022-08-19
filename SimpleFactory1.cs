namespace SimpleFactory1
{
    public enum CoffeType
    {
        Americano,
        Cappucino,
        Espresso,
        FlatWhite,
        Latte,
        Macchiato,
        Mocha
    }

    public class Coffee
    {
        public static Coffee Create(CoffeType coffeType)
        {
            switch (coffeType)
            {
                case CoffeType.Americano:
                    return NewAmericano();
                case CoffeType.Cappucino:
                    return NewCappucino();
                case CoffeType.Espresso:
                    return NewEspresso();
                case CoffeType.FlatWhite:
                    return NewFlatWhite();
                case CoffeType.Latte:
                    return NewLatte();
                case CoffeType.Macchiato:
                    return NewMacchiato();
                case CoffeType.Mocha:
                    return NewMocha();
                default:
                    throw new Exception("Unknown Coffee Type");
            }
        }
        private static Coffee NewCappucino()
        {
            var coffeeParams = new List<Parameters>();
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.SteamedMilk, Count = 1, Order = 2 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.MilkFoam, Count = 1, Order = 3 });
            return new Coffee(coffeeParams);
        }

        private static Coffee NewLatte()
        {
            var coffeeParams = new List<Parameters>();
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.SteamedMilk, Count = 1.7, Order = 2 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.MilkFoam, Count = 0.3, Order = 3 });
            return new Coffee(coffeeParams);
        }

        private static Coffee NewMacchiato()
        {
            var coffeeParams = new List<Parameters>();
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.SteamedMilk, Count = 0.5, Order = 2 });
            return new Coffee(coffeeParams);
        }

        private static Coffee NewMocha()
        {
            var coffeeParams = new List<Parameters>();
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Chocolate, Count = 0.4, Order = 2 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.SteamedMilk, Count = 1.6, Order = 3 });
            return new Coffee(coffeeParams);
        }

        private static Coffee NewAmericano()
        {
            var coffeeParams = new List<Parameters>();
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Water, Count = 2, Order = 2 });
            return new Coffee(coffeeParams);
        }

        private static Coffee NewFlatWhite()
        {
            var coffeeParams = new List<Parameters>();
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.SteamedMilk, Count = 2, Order = 2 });
            return new Coffee(coffeeParams);
        }

        private static Coffee NewEspresso()
        {
            var coffeeParams = new List<Parameters>();
            coffeeParams.Add(new Parameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            return new Coffee(coffeeParams);
        }

        private Coffee(List<Parameters> parameters)
        {

        }

        private class Parameters
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
