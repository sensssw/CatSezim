using HungryCat;
public class Program
{
    private static void Main(string[] args)
    {
        Cat garfield = new Cat("Garfield");
        garfield.ShowFood();
        if (garfield.Hunger > garfield.DesiredHunger)
        {
            garfield.GoOnDiet();
        }
        else {
            while (garfield.Hunger < garfield.DesiredHunger)
            {
                garfield.Eat();
            }if (garfield.Hunger == garfield.DesiredHunger)
            {
                garfield.Sleep();
            }
            else {
                garfield.ThrowUp();

            }

        }
        
         


    }
}