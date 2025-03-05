namespace NameSpaceDeliverable.Calc{        
    public class Calculator{
        public int Addition(int x, int y){
            return x + y;
        }
        public int Subtraction(int x, int y){
            return x - y;
        }
        public int Multiplication(int x, int y){
            return x * y;
        }
       public double Division(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Don't cause a singularity, don't divide by zero T_T");
                return double.NaN; 
            }
            return (double)x / y;
        }
        public double Exponent(int x, int y){
            return (int)System.Math.Pow(x, y);
    }
    }
}