using SimpleFactory1;
using SimpleFactory2;
using SimpleFactory3;
using SimpleFactory4;

public class Program

{
    public static void Main(string[] args)
    {
        // muammo:
        var coffee1 = new Coffee { CoffeType = CoffeType.Mocha, Parameters = new List<CoffeeParameters>() };

        var coffee2 = new Coffee { CoffeType = CoffeType.Cappucino, Parameters = new List<CoffeeParameters>() };


        // yechim:
        var myMorningCoffee = SimpleFactory1.Coffee.Create(SimpleFactory1.CoffeType.Americano);
        var myLunchCoffee = SimpleFactory2.Coffee.NewLatte();
        var myEveningCoffee = SimpleFactory3.Coffee.Factory.NewMocha();
        var myNightCoffee = SimpleFactory4.CoffeeFactory.Create(SimpleFactory4.CoffeType.FlatWhite);
    }
}


public class Coffee
{
    public CoffeType CoffeType;
    public List<CoffeeParameters> Parameters;
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