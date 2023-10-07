namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Case4();
        }


        void Case1()
        {

            //Saknades ";" efter första WriteLine och ett space i "else If"
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre");
            }
            else if (number < 3)
            {
                Console.WriteLine("Talet är mindre än tre");
            }
        }


        void Case2()
        {
            // Saknades ett "=" efter "<"
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

        }

        void Case3()
        {
            // Saknades "++" efter i och j i slutet av looparna
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void Case4()
        {

            //saknades något att använda som output i console.Write
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    
                }

                Console.WriteLine();
                i++;
            }
        }

        static void Case5()
        {

            //saknas en break efter case 1
            int i = 1;

            switch (i)
            {
                case 1:
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }

        static void Case6()
        {
            //Saknas ett "=" i if
            int i = 10;

            if (i == 5)
            {
                Console.WriteLine("i är 5");
            }
        }
    }
}