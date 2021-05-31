using System;

namespace NPNet.Strategy
{
    public abstract class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Croaking...");
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swimming...");
        }

        public abstract void Display();
    }

    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am mallard duck...");
        }
    }

    public class RubberDuck: Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Squeaking...");
        }
        public override void Display()
        {
            Console.WriteLine("I am rubber duck...");
        }
    }

    /*
            Duck mallardDuck = new MallardDuck();
            Duck rubberDuck = new RubberDuck();

            mallardDuck.Quack();
            mallardDuck.Swim();
            mallardDuck.Display();

            Console.WriteLine("-------------------");

            rubberDuck.Quack();
            rubberDuck.Swim();
            rubberDuck.Display();

            
    */
    class Program
    {
        static void Main(string[] args)
        {
            Character king = new King();
            king.Fight();
            king.setWeapon(new AxeBehavior());
            king.Fight();
            Console.ReadKey();
        }
    }
}
