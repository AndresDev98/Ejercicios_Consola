using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_LeetCode
{
    class Array_Exercises
    {        

        // Buscar numeros consecutivos y contar el maximo
        public void ConsecutiveNumbers()
        {
            int[] nums = { 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
            int positivo = 1;
            int contador = 0;
            int contador1 = 0;
            int contador0 = 0;
            string spaceLong = "-----------------------------------------------------";
            string spaceShort = "----------------";
            int guardar1 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("El Registro --> " + nums[i] + " es el registro numero " + contador++);

                // Vale separamos los 1 de los 0
                // Obtenemos los datos del array lo transformamos a cadena y comparamos
                if (nums.GetValue(i).ToString() == positivo.ToString())
                {
                    contador1++;

                    // Aqui solamente decimos si es 1 o 0
                    Console.WriteLine("Es 1");
                    Console.WriteLine(spaceShort);
                }
                else
                {
                    contador0++;

                    if (guardar1 >= contador1)
                    {

                    }
                    else
                    {
                        guardar1 = contador1;
                    }

                    if (contador0 == 1)
                    {
                        contador1 = 0;
                        contador0 = 0;
                    }

                    // Aqui solamente decimos si es 1 o 0
                    Console.WriteLine("Es 0");
                    Console.WriteLine(spaceShort);

                }


            }
            // Aqui con el Math.max() lo que hacemos es meter 2 parametros y saca el mayor
            Console.WriteLine("El maximo es: " + Math.Max(contador1, guardar1));


            Console.WriteLine("");
            Console.WriteLine(spaceLong);
            Console.WriteLine("En total hay " + nums.Length + " registros que esta relleno entre 1 y 0 ");
            Console.WriteLine(spaceLong);
        }

        // Este es el mismo que el de arriba (ConsecutiveNumbers()) pero sin meter parametros
        // Aqui lo que tendria que pasarle los parametros
        public int LeetCodeFindMaxConsecutiveOnes(int[] nums)
        {
            var n = nums.Length;
            if (n == 0) return 0;
            var max = nums[0] == 1 ? 1 : 0;
            var cur = 1;
            for (int i = 1; i < n; i++)
            {
                if (nums[i - 1] == nums[i] && nums[i] == 1)
                {
                    cur++;
                }
                else
                {
                    cur = 1;
                }

                if (nums[i] == 1)
                {
                    max = Math.Max(max, cur);
                }
            }

            return max;
        }

        // Buscar numeros pares e impares
        public void FindEvenNumbers()
        {
            int[] nums = { 12, 345, 2, 6, 7896 }; 
            int dos = 2;
            int contador = 0; 
            string spaceLong = "-----------------------------------------------------------------------";
            string spaceShort = "----------------";
            List<string> listaPares = new List<string>();
            List<string> listaImpares = new List<string>();


            for (int i = 0; i < nums.Length; i++)
            {
                int numerosx = (int)nums.GetValue(i);
                int conjunto = numerosx % dos ;

               

                Console.WriteLine("El Numero --> " + nums[i] + " es el registro numero " + contador++);
                
                //even
                if ( conjunto == 0 )
                {
                    listaPares.Add(numerosx.ToString());

                    // Aqui solamente decimos si es par o impar
                    Console.WriteLine("El numero " + nums[i] + " es par");
                    Console.WriteLine(spaceShort);
                }
                else
                {
                    listaImpares.Add(numerosx.ToString());
                    // Aqui solamente decimos si es par o impar
                    Console.WriteLine("El numero " + nums[i] + " es impar");
                    Console.WriteLine(spaceShort);
                }

            }

            Console.WriteLine("");
            Console.WriteLine(spaceLong);
            Console.WriteLine("En total hay " + nums.Length + " registros que esta relleno entre numeros pares e impares ");
            Console.WriteLine(spaceLong);
            foreach (var i in listaPares)
            {
                if (listaPares.Count() > 1)
                {
                    Console.WriteLine(" De los cuales " + i + " es par");
                }
                else
                {
                    Console.WriteLine(" De el cual " + i + " es par");
                }
            }
            Console.WriteLine(spaceLong);
            foreach (var i in listaImpares)
            {
                if(listaImpares.Count() > 1)
                {
                    Console.WriteLine(" De los cuales  --> " + i + " son impares");
                }
                else
                {
                    Console.WriteLine(" De el cual --> " + i + " es impar");
                }
                
            }

            Console.WriteLine(spaceLong);

        }

        // Este es el mismo que el de arriba (FindEvenNumbers()) pero sin meter parametros
        // Aqui lo que tendria que pasarle los parametros
        public int LeetCodeFindEvenNumber(int[] nums)
        {
            {
                int evenCount = 0;
                foreach (int entry in nums)
                {
                    if (Math.Floor(Math.Log10(Math.Abs(entry)) + 1) % 2 == 0)
                    {
                        evenCount += 1;
                    }
                }
                return evenCount;
            }
        }

        //Ordenar descendiente y ascendiente la matriz
        public void SquaresSortedArray()
        {
            int[] nums = { -4, 1, -10, 6, 4, 2, -5, -20, 0 };             
            int[] orderByDesc = nums.OrderByDescending(x => x).ToArray();
            Console.WriteLine("Ordenado Descendiente --> " + String.Join( " , ", orderByDesc));
            int[] orderByAsc = nums.OrderBy(x => x).ToArray();
            Console.WriteLine("Ordenado Ascendiente --> "+String.Join( " , " , orderByAsc));

        }

        // Este es el mismo que el de arriba (SquaresSortedArray()) pero sin meter parametros
        // Aqui lo que tendria que pasarle los parametros por consola, en LeetCode funciona
        public int[] LeetCodeSquaresSortedArray(int[] nums) 
        {
            var arr = new int[nums.Length];
            int begIndex = 0;
            int endIndex = nums.Length - 1;
            int end = endIndex;
            while (begIndex <= endIndex)
                arr[end--] = Math.Abs(nums[endIndex]) > Math.Abs(nums[begIndex])
                    ? nums[endIndex] * nums[endIndex--]
                    : nums[begIndex] * nums[begIndex++];
            return arr;

            //{
            //    int[] orderByDesc = nums.OrderByDescending(x => x).ToArray();
            //    return orderByDesc;
            //}
        }

        // 
        public void DuplicateZeros()
        {
            int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (var j = arr.Length - 2; j > i; j--)
                    {
                        arr[j + 1] = arr[j];
                    }

                    if (i < arr.Length - 1)
                    {
                        arr[i + 1] = 0;
                        i++;
                    }
                }
            }


            foreach (var i in arr)
            {
                Console.Write( i +"," );
            }
            
        }


        public void InvertirCadena()
        {
            string text = "Andres";
            string textResult = "";

            for (int i = text.Length-1; i>0; i--)
            {

                textResult += text[i];

            }

            Console.WriteLine(textResult);
        }


        public void InvertirCadena2()
        {
            string text = "Andres";
            string textResult = "";

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            textResult = new String(chars);

            Console.WriteLine(textResult);
        }

        public void BuscarLetra()
        {
            string text = "asxcmkodfbpltrñltñok3490asujc8qghn3rbasnjcmokzbñmlhgvpjesf89we";
            string letra = "";

            Console.WriteLine("Ingresa la letra que quieres buscar:");
            letra = Console.ReadLine();

            int n = 0;

            foreach (var c in text)
            {
                if (c.ToString() == letra)
                 n++; 
            }

            Console.WriteLine($"Se repite la letra {letra} {n} veces");

        }

        public void DistanciaText()
        {
            string text1 = "coche";
            string text2 = "motos";

            int n = 0;

            if (text1.Length != text2.Length)
                throw new Exception("Longitudes distintas");

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] != text2[i])
                    n++;
            }

            Console.WriteLine($"Distancia es de: " + n);

        }


    } //Fin 
}
