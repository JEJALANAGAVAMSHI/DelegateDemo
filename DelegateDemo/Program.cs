namespace DelegateDemo
{
    internal class Program
    {
        delegate void GreetingDelegate(string message);
        static void Main(string[] args)
        {
            GreetingDelegate greetingDelegate = new GreetingDelegate(Greet);
            greetingDelegate("Delegate is ok");
        }
        static void Greet(string info)
        {
            Console.WriteLine(info);
        }

        static void Print()
        {

        }

        class Demo
        {
            GreetingDelegate greeting = new GreetingDelegate(Greet);
            greeting("Hi");
        }
    }
}
