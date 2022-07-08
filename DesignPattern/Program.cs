namespace DesignPattern
{
    interface IChair
    {
        void HasLegs();
        void SitOn();
    }

    class VictorrianChair : IChair
    {
        public void HasLegs() => Console.WriteLine("Victorrian chair HasLegs");
        public void SitOn() => Console.WriteLine("Victorrian chair SitOn");
    }


    class ModernChair : IChair
    {
        public void HasLegs() => Console.WriteLine("Modern Chair HasLegs");
        public void SitOn() => Console.WriteLine("Modern Chair SitOn");
    }


    interface ISofa
    {
        void HasLegs();
        void SitOn();
    }

    class VictorrianSofa : ISofa
    {
        public void HasLegs() => Console.WriteLine("Victorrian Sofa HasLegs");
        public void SitOn() => Console.WriteLine("Victorrian Sofa SitOn");
    }


    class ModernSofa : ISofa
    {
        public void HasLegs() => Console.WriteLine("Modern Sofa HasLegs");
        public void SitOn() => Console.WriteLine("Modern Sofa SitOn");
    }


    interface ICoffeTable
    {
        void HasLegs();
    }

    class VictorrianCoffeTable : ICoffeTable
    {
        public void HasLegs() => Console.WriteLine("Victorrian CoffeTable HasLegs");
    }


    class ModernCoffeTable : ICoffeTable
    {
        public void HasLegs() => Console.WriteLine("Modern CoffeTable HasLegs");
    }


    interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeTable CreateCoffeTable();
    }

    class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorrianChair();

        public ICoffeTable CreateCoffeTable() => new VictorrianCoffeTable();

        public ISofa CreateSofa() => new VictorrianSofa();
    }

    class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();

        public ICoffeTable CreateCoffeTable() => new ModernCoffeTable();

        public ISofa CreateSofa() => new ModernSofa();
    }


    public class Program
    {
        static void Main(string[] args)
        {
            IFurnitureFactory? furnitureFactory = null;

            while (true)
            {
                Console.WriteLine("\n1: Victorian\n2: Modern Other: Exit");

                Console.Write("\nEnter choice: ");

                furnitureFactory = Console.ReadLine() switch
                {
                    "1" => new VictorianFurnitureFactory(),
                    "2" => new ModernFurnitureFactory(),
                    _ => null
                };

                if (furnitureFactory == null)
                    break;

                furnitureFactory.CreateChair().HasLegs();
                furnitureFactory.CreateCoffeTable().HasLegs();
                furnitureFactory.CreateSofa().HasLegs();
            }

        }
    }

}