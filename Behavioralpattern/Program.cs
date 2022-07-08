namespace Behavioralpattern
{
    abstract class GameAI
    {
        public abstract void CollectResources();
        public abstract void BuildStructures();
        public abstract void BuildUnits();
        public abstract void Attack();

        public abstract void sendScouts(int position);
        public abstract void sendWarriors(int position);
    }

    class OrcsAI : GameAI
    {
        int pos = 0;

        public override void Attack() => Console.WriteLine("OrcsAI Attack");
        public override void BuildStructures() => Console.WriteLine("OrcsAI BuildStructures");
        public override void BuildUnits() => Console.WriteLine("OrcsAI BuildUnits");
        public override void CollectResources() => Console.WriteLine("OrcsAI CollectResources");
        public override void sendScouts(int position) => pos++;
        public override void sendWarriors(int position) => pos++;
    }


    class MonstersAI : GameAI
    {
        int pos = 0;

        public override void Attack() => Console.WriteLine("MonstersAI Attack");
        public override void BuildStructures() => Console.WriteLine("MonstersAI BuildStructures");
        public override void BuildUnits() => Console.WriteLine("MonstersAI BuildUnits");
        public override void CollectResources() => Console.WriteLine("MonstersAI CollectResources");
        public override void sendScouts(int position) => pos++;
        public override void sendWarriors(int position) => pos++;
    }



    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}