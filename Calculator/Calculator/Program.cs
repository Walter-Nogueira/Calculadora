using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculator
            
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("Escolha a operacao");
            Console.WriteLine("1. Soma\n2. Subtracao\n3. Divisao\n4. Multiplicacao");
            Console.Write("\nDigite o numero da operacao: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 0 || choice > 4)
            {
                Console.WriteLine("\nERRO");
                Environment.Exit(0);
            }

            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        Soma();
                        Repetir();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Sub();
                        Repetir();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Div();
                        Repetir();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Mult();
                        Repetir();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("\nCalculador encerrada");
            Environment.Exit(0);
            Console.ReadLine();
        }
        
        // Aqui ficam todos os metodos
        static void Repetir()
        {
            Console.WriteLine("\ne agora?");
            Console.WriteLine("0. Sair\n1. Soma\n2. Subtracao\n3. Divisao\n4. Multiplicacao");
            Console.Write("\nDigite o numero da operacao: ");
        }
        
        static void Soma()
        {
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", v1, v2, Math.Round((v1 + v2), 2));

        }
        
        static void Sub()
        {
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} - {1} = {2}", v1, v2, Math.Round((v1 - v2), 2));

        }
        
        static void Div()
        {
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            if (v1 == 0 || v2 == 0)
            {
                Console.WriteLine("\n Nao e possivel dividir por zero");
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", v1, v2, Math.Round((v1 / v2), 2));
            }
        }
        
        static void Mult()
        {
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} = {2}", v1, v2, Math.Round((v1 * v2), 10));

        }
    }
}
