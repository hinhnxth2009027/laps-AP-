namespace lap8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var animalGeneric = new AnimalGeneric<Animal>();
            animalGeneric.Add(new Cat
            {
                Id = 12,
                Name = "niu",
                Dob = "hello"
            });
            
            animalGeneric.Add(new Cat
            {
                Id = 12,
                Name = "niu",
                Dob = "hello"
            });
            animalGeneric.Add(new Cat
            {
                Id = 12,
                Name = "niu",
                Dob = "hello"
            });
            animalGeneric.Add(new Dog()
            {
                Id = 12,
                Name = "lag",
                Dob = "ga"
            });
            
            animalGeneric.ShowInformation();




        }
    }
}