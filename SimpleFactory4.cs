namespace SimpleFactory4
{
    public static class CoffeeFactory
    {
        public static Coffee Create(CoffeType coffeType)
        {
            switch (coffeType)
            {
                case CoffeType.Americano:
                    return new Americano();
                case CoffeType.Cappucino:
                    return new Cappucino();
                case CoffeType.Espresso:
                    return new Espresso();
                case CoffeType.FlatWhite:
                    return new FlatWhite();
                case CoffeType.Latte:
                    return new Latte();
                case CoffeType.Macchiato:
                    return new Macchiato();
                case CoffeType.Mocha:
                    return new Mocha();
                default:
                    throw new Exception("Unknown Coffee Type");
            }
        }
    }

    public abstract class Coffee
    {
       protected abstract List<CoffeeParameters> Params { get; set; }

    }

    public class Americano : Coffee
    {
        protected override List<CoffeeParameters> Params { get; set ; }

        public Americano()
        {
            Params = new List<CoffeeParameters>();
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Water, Count = 2, Order = 2 });
        }
    }

    public class Cappucino : Coffee
    {
        protected override List<CoffeeParameters> Params { get; set; }

        public Cappucino()
        {
            Params = new List<CoffeeParameters>();
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1, Order = 2 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.MilkFoam, Count = 1, Order = 3 });
        }
    }

    public class Latte : Coffee
    {
        protected override List<CoffeeParameters> Params { get; set; }

        public Latte()
        {
            Params = new List<CoffeeParameters>();
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1.7, Order = 2 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.MilkFoam, Count = 0.3, Order = 3 });
        }
    }

    public class Mocha : Coffee
    {
        protected override List<CoffeeParameters> Params { get; set; }
        public Mocha()
        {
            Params = new List<CoffeeParameters>();
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Chocolate, Count = 0.4, Order = 2 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1.6, Order = 3 });
        }
    }
    public class FlatWhite : Coffee
    {
        protected override List<CoffeeParameters> Params { get; set; }
        public FlatWhite()
        {
            Params = new List<CoffeeParameters>();
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 2, Order = 2 });
        }
    }

    public class Macchiato : Coffee
    {
        protected override List<CoffeeParameters> Params { get; set; }

        public Macchiato()
        {
            Params = new List<CoffeeParameters>();
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 0.5, Order = 2 });
        }

    }

    public class Espresso : Coffee
    {
        protected override List<CoffeeParameters> Params { get; set; }
        public Espresso()
        {
            Params = new List<CoffeeParameters>();
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
        }
    }

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

    public class CoffeeParameters
    {
        public IngredientType IngredientType;
        public double Count { get; set; }
        public int Order { get; set; }
    }

    public enum IngredientType
    {
        MilkFoam,
        SteamedMilk,
        Chocolate,
        Espresso,
        Water
    }

    
}
