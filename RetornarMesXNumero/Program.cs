using System;

namespace RetornarMesXNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string en = "Enero".ToUpper();
            string fe = "Febrero".ToUpper();
            string ma = "Marzo".ToUpper();
            string ab = "Abril".ToUpper();
            string may = "Mayo".ToUpper();
            string ju = "Junio".ToUpper();
            string jul = "Julio".ToUpper();
            string ag = "Agosto".ToUpper();
            string se = "Septiembre".ToUpper();
            string oc = "Octubre".ToUpper();
            string no = "Noviembre".ToUpper();
            string dc = "Diciembre".ToUpper();

            Console.WriteLine("Seleccione un numero");
            string valnumeromes = Console.ReadLine();
            int numeromes = Convert.ToInt32(valnumeromes);

            switch (numeromes) {
                case 1:
                    Console.WriteLine("El mes es {0}",en);
                    break;
                case 2:
                    Console.WriteLine("El mes es {0}", fe);
                    break;
                case 3:    
                    Console.WriteLine("El mes es {0}", ma);
                    break;
                case 4:
                    Console.WriteLine("El mes es {0}", ab);
                    break;
                case 5:
                    Console.WriteLine("El mes es {0}", may);
                    break;
                case 6:
                    Console.WriteLine("El mes es {0}", ju);
                    break;
                case 7:
                    Console.WriteLine("El mes es {0}", jul);
                    break;
                case 8:
                    Console.WriteLine("El mes es {0}", ag);
                    break;
                case 9:
                    Console.WriteLine("El mes es {0}", se);
                    break;
                case 10:
                    Console.WriteLine("El mes es {0}", oc);
                    break;
                case 11:
                    Console.WriteLine("El mes es {0}",no);
                    break;
                case 12:
                    Console.WriteLine("El mes es {0}",dc);
                    break;

                default:
                    Console.WriteLine("Digite el numero de mes correcto");
                    break;

            }

        }
    }
}
