internal class Program
{
    private static void Main(string[] args)
    {
        string? operacao;
        string? loop = "y";
        double y,x;
        Metodos m;
        try
        {
            while(loop == "y"){
                Console.WriteLine("Digite X - Multiplicar");
                Console.WriteLine("Digite M - Somar");
                Console.WriteLine("Digite S - Subtrair");
                Console.WriteLine("Digite D - Divisão");

                operacao = Console.ReadLine();
                m = new Metodos();
                try
                {
                    Console.WriteLine("Digite um valor");
                    y = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro valor");
                    x = double.Parse(Console.ReadLine());
               
                

                    switch (operacao)
                    {
                        case "X":
                            Console.WriteLine("O valor da multiplicação é :" + m.mult(x, y));
                            break;
                        case "M":
                            Console.WriteLine("O valor da soma é :" + m.sum(x, y));
                            break;
                        case "S":
                            Console.WriteLine("O valor da Subtração é :" + m.sub(x, y));
                            break;
                        case "D":
                            Console.WriteLine("O valor da Subtração é :" + m.div(x, y));
                            break;
                    }
                 }
                catch (NullReferenceException erro)
                {
                    
                    Console.WriteLine(erro.Message);
                }

                Console.WriteLine("Deseja fazer mais operações? [y]/[n]");
                loop = Console.ReadLine();
            }
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}

public class Metodos
    {
        public double sum(double x, double y){
            return x+y;
        }

        public double mult(double x, double y){
            return x*y;
        }

        public double div(double x, double y){
            return y/x;
        }

        public double sub(double x, double y){
            return y-x;
        }
    }
    


    





