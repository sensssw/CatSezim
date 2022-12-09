namespace HungryCat
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Energy { get; set; }
        public Food(int id,string name, int energy)
        {
            Id = id;
            Name = name;
            Energy = energy;
        }



    }
}