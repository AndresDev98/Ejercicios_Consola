
namespace Proyectos_LeetCode
{

    class Program
    {

        static void Main(string[] args)
        {

            Array_Exercises apprenticeships = new Array_Exercises();
            string line;

            do
            {              
                //Console.Clear();
                Console.Write("");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.Write("");
                Console.WriteLine("Ingresa un numero del 1 al 5:");
                Console.WriteLine(" 1 -> Numeros Consecutivos ");
                Console.WriteLine(" 2 -> Buscar numeros pares ");
                Console.WriteLine(" 3 -> Ordenar array ");
                Console.WriteLine(" 4 -> Duplicados de 0 ");
                Console.WriteLine(" 5 -> Invertir Cadenas ");
                Console.WriteLine(" 6 -> Invertir Cadenas 2 forma ");
                Console.WriteLine(" 7 -> Buscar letra ");
                Console.WriteLine(" 8 -> Distancia entre letras ");
                Console.WriteLine(" 9 -> Cerrar programa ");

                line = Console.ReadLine();

                if (line == "1")
                     apprenticeships.ConsecutiveNumbers();

                else if (line == "2")
                    apprenticeships.FindEvenNumbers();

                else if (line == "3")
                    apprenticeships.SquaresSortedArray();

                else if (line == "4")
                    apprenticeships.DuplicateZeros();

                else if (line == "5")
                    apprenticeships.InvertirCadena();

                else if (line == "6")
                    apprenticeships.InvertirCadena2();

                else if (line == "7")
                    apprenticeships.BuscarLetra();

                else if (line == "8")
                    apprenticeships.DistanciaText();

                else if (line == "9")
                    Console.WriteLine("FIN");

            } while (line != "9");

        }

    }
}