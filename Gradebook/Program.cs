using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("You can view you Grades \n");

            char pass = 'P';
            decimal ACCO = 2.25M, COMP1 = 2.00M, COMP2 = 2.75M, CWTS = 2.00M, GEED1 = 2.25M, GEED2 = 2.50M, GEED3 = 1.50M, MATH = 2.50M, PHED = 1.50M;
            decimal UN1 = 3.0M, UN2 = 2.0M, UN3 = 4.0M;
            string sect = "BSIT-BN 1-1";



            Console.WriteLine("DESCTRIPTION: Accounting Principles");
            Console.WriteLine("Units: " + UN1);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + ACCO);
            Console.WriteLine("Grade Status: " + pass + "\n");


            Console.WriteLine("DESCTRIPTION: Introduction to Computing");
            Console.WriteLine("Units: " + UN1);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + COMP1);
            Console.WriteLine("Grade Status: " + pass + "\r");



            Console.WriteLine("DESCTRIPTION: Computer Programming 1");
            Console.WriteLine("Units: " + UN1);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + COMP2);
            Console.WriteLine("Grade Status: " + pass + "\n");



            Console.WriteLine("DESCTRIPTION: Civic Welfare Training Service 1");
            Console.WriteLine("Units: " + UN1);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + CWTS);
            Console.WriteLine("Grade Status: " + pass + "\t");



            Console.WriteLine("DESCTRIPTION: Mathematics in the Modern World");
            Console.WriteLine("Units: " + UN1);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + GEED1);
            Console.WriteLine("Grade Status: " + pass + "\n");



            Console.WriteLine("DESCTRIPTION: Purposive Communication");
            Console.WriteLine("Units: " + UN1);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + GEED2);
            Console.WriteLine("Grade Status: " + pass + "\t");



            Console.WriteLine("DESCTRIPTION: Filipinolohiya at Pambansang Kaunlaran");
            Console.WriteLine("Units: " + UN1);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + GEED3);
            Console.WriteLine("Grade Status: " + pass + "\n");


            Console.WriteLine("DESCTRIPTION: General Calculus");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + MATH);
            Console.WriteLine("Grade Status: " + pass + "\t");



            Console.WriteLine("DESCTRIPTION: Physical Fitness and Self-Testing Activities");
            Console.WriteLine("Units: " + UN2);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + PHED);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.ReadLine();

            decimal GPA = (ACCO + COMP1 + COMP2 + CWTS + GEED1 + GEED2 + GEED3 + MATH + PHED) / 9;

            if (GPA <= 3)
            {
                Console.Write("GPA " + GPA + "\n");
                Console.WriteLine("The Student Pass");
            }
            else
            {
                Console.WriteLine("The Student Failed");
            }
        }
    }
}
