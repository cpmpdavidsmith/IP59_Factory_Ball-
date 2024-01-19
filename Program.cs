using System;

namespace IP59_Factory_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            BallFactory f1 = new BasketballMaker();
            BallFactory f2 = new BaseballMaker();

            SportsBall bb1 = f1.createBall();
            SportsBall bb2 = f2.createBall();

            Console.WriteLine(bb1.type);
            Console.WriteLine(bb2.type);
            Console.Read();
        }
    }
}
