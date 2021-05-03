using System;
using System.Collections.Generic;

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
            decimal UN3 = 3.0M, UN2 = 2.0M, UN4 = 4.0M;
            string sect = "BSIT-BN 1-1";

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            
            Console.WriteLine("School Year 1920 First Semester");
            
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Admission Status" + "\n " + "    Continuing");
            Console.WriteLine("Scholastic Status" + "\n" + "    Regular");
            Console.WriteLine("Course Code & Description" + "\n" + "    BSIT-BN BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY (BINAN)");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Accounting Principles");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + ACCO);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Introduction to Computing");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + COMP1);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Computer Programming 1");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + COMP2);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Civic Welfare Training Service 1");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + CWTS);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Mathematics in the Modern World");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + GEED1);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Purposive Communication");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + GEED2);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Filipinolohiya at Pambansang Kaunlaran");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + GEED3);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: General Calculus");
            Console.WriteLine("Units: " + UN4);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + MATH);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("DESCTRIPTION: Physical Fitness and Self-Testing Activities");
            Console.WriteLine("Units: " + UN2);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + PHED);
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.ReadLine();

            decimal GPA = (ACCO + COMP1 + COMP2 + CWTS + GEED1 + GEED2 + GEED3 + MATH + PHED) / 9;

            if (GPA <= 3)
            {
                Console.Write("GPA (excludes NSTP and subjects with non-numeric ratings): " + GPA + "\n");
                Console.WriteLine("The Student Pass" + "\n");
            }
            else
            {
                Console.WriteLine("The Student Failed" + "\n");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            
            
            
            
            Console.ReadLine();

            
            
            
            List<decimal> grades = new List<decimal>() { 1.00M, 1.50M, 2.00M, 2.50M, 2.75M, 3.00M, 4.00M, 5.00M };

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");
            Console.WriteLine("School Year 1920 Semester");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Admission Status" + "\n " + "    Continuing");
            Console.WriteLine("Scholastic Status" + "\n" + "    Regular");
            Console.WriteLine("Course Code & Description" + "\n" + "    BSIT-BN BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY (BINAN)");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    Computer Programming 2"); 
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[3]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    Discrete Structure 1");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[5]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    Civic Welfare Training Service 2");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[0]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    Reading in Philippine History");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[2]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    Pagsasalin sa Kontekstong Filipino");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[1]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    Politics, Governance and Citizenship");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[2]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    Rhythmic Activities");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[2]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.WriteLine("Description:" + "\n" + "    General Physics");
            Console.WriteLine("Units: " + UN3);
            Console.WriteLine("Sect Code: " + sect);
            Console.WriteLine("Final Grade: " + (grades[3]));
            Console.WriteLine("Grade Status: " + pass + "\n");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------" + "\n");

            Console.ReadLine();

            decimal AVE = (grades[3] + (grades[5]) + (grades[0]) + (grades[2]) + (grades[1]) + (grades[2]) + (grades[2]) + (grades[3])) / 8;

            if (AVE <= 3)
            {
                Console.Write("GPA (excludes NSTP and subjects with non-numeric ratings): " + AVE + "\n");
                Console.WriteLine("The Student Pass" + "\n");
            }
            else
            {
                Console.WriteLine("The Student Failed" + "\n");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
        }
    }
}
