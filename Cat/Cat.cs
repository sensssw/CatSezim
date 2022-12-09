
using System.Diagnostics;

namespace HungryCat{
    public class Cat
    {
        Random rnd=new Random();
        public string Name { get; set; }
        //public int StartingHunger{ get; set; }
        public int DesiredHunger { get; set; } 
        public int Hunger{ get; set; }
         List<Food>menu=new List<Food>()
        {   new Food(1,"whiskas",23),
            new Food(2,"felix",45),
            new Food(3,"kiticat",3),
            new Food(4,"pivo",1)
        };
        
        public void ShowFood()
        {
            Console.WriteLine("Menu:\nID\tName\tEnergy");

            foreach (Food food in menu)
            {
                Console.WriteLine("{0}\t{1}\t{2}",food.Id,food.Name,food.Energy);
            }
        }
        
       public void Eat()
        {
            int choise=rnd.Next(1,menu.Count-1);
            Console.WriteLine($"Computer choise's {choise}");
            foreach (Food food in menu)
            {
                if (food.Id == choise)
                {
                    Hunger += food.Energy;
                    Console.WriteLine($"{Name} ate {food.Name} and his energy increased by {Hunger}");
                    break;
                }
            }
            //int choise = 0;
            //Console.WriteLine("Choose a food\nEnter number of food");
            //while (!Int32.TryParse(Console.ReadLine(), out choise)||choise>menu.Count-1)
            //{
            //    Console.Write("Error, enter a number!");
            //}
            //foreach (Food food in menu)
            //{

            //    if (choise == food.Id)
            //    {
            //        Console.WriteLine($"Cat eat {food.Name}");
            //        Hunger += food.Energy;
            //        Console.WriteLine($"{Name} ate  and his energy increased by {Hunger}");
            //        break;
            //    }
                 
            //    }
            }

        public Cat(string name)
        {
            Name = name;
            int hunger = rnd.Next(0,100);
            Hunger =hunger;
            int desiredhunger = rnd.Next(hunger, 100); 
            DesiredHunger = desiredhunger;
            Console.WriteLine($"Cat {Name} is created!\nStarting hunger: {Hunger}\nDesired hunger: {DesiredHunger}\nLet's feed the cat!");
        }
        public void GoOnDiet()
        {
            Console.WriteLine("Cat goes on a diet!\nHe will drink water and walk a lot)");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name}'s full, now he wants to sleep");
        }
        public void ThrowUp()
        {
            Console.WriteLine($"{Name}'s going to throw up");
            GoOnDiet();
        }

    }} 