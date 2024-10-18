namespace Home_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Task1
            //// Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. 

            //Console.WriteLine("Reqemi yazin");
            //int imput = Convert.ToInt32(Console.ReadLine());
            //int number1 = 0;
            //int number2 = 0;

            //do
            //{
            //    number1 = imput % 10;
            //    imput = imput - number1;
            //    imput /= 10;
            //    number2++;

            //} while (imput != 0);
            //Console.WriteLine("Cavab");
            //Console.WriteLine(number2);
            //#endregion




            #region Task2
            // Verilmiş n tam ədədinin sadə və ya mürəkkəb olduğunu tapan alqoritm. 
            Console.WriteLine("Reqemi Daxil Edin :");
            int imput = Convert.ToInt32(Console.ReadLine());
            if (imput == 2 || imput == 3 || imput == 5 || imput == 7)
            {
                Console.WriteLine("Sadedir");
            }
            else if (imput == 0 || imput == 1)
            {
                Console.WriteLine("Ne sadedir Ne murekkeb");
            }
            else if (imput % 2 == 0 || imput % 3 == 0 || imput % 5 == 0 || imput % 7 == 0)
            {
                Console.WriteLine("Murekkebdir");
            }
            else
            {
                Console.WriteLine("Sadedir");
            }

            #endregion





        }
    }
}
