using System;

namespace Ex_Seven_Delegate
{
    public delegate double DelegateForOperators(double x, double y);
    class LOperators
    {
        double x, y;
        Operations operation;
        public DelegateForOperators Add = (x, y) => x + y;
        public DelegateForOperators Sub = (x, y) => x - y;
        public DelegateForOperators Mult = (x, y) => x * y;
        public DelegateForOperators Div = (x, y) => { if (0 != y) return x / y; return -1; };

        public void GetX ()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Enter x:");
                x = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number, try again");
                Console.ReadKey();
                GetX();
            }
        }
        public void GetY()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Enter y:");
                y = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number, try again");
                Console.ReadKey();
                GetY();
            }
        }
        public void GetOper()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Enter operation:\n0 - Add\n1 - Sub\n2 - Mult\n3 - Div");
                operation = (Operations)Int32.Parse(Console.ReadLine());
                Calculate(operation, x, y);
            }
            catch
            {
                Console.WriteLine("Invalid operation, try again");
                Console.ReadKey();
                GetOper();
            }
        }
        
        public void Calculate(Operations op, double x, double y)
        {
            switch (op)
            {
                case Operations.Add:
                    Console.WriteLine("Result: " + Add(x, y));
                    break;
                case Operations.Sub:
                    Console.WriteLine("Result: " + Sub(x, y));
                    break;
                case Operations.Mult:
                    Console.WriteLine("Result: " + Mult(x, y));
                    break;
                default:
                    if (0 == y)
                        Console.WriteLine("Division by zero.");
                    else
                        Console.WriteLine("Result: " + Div(x, y));
                    break;
            }
            Console.ReadKey();
        } 
    }
}
