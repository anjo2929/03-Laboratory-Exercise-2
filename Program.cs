using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LaboratoryExercise2
{
    internal class Program
    {
        static void Main(string[] args)

        {
         string DTP = @"C:\Users\doc";

            string[] FilesCheck = 
            {
                "GOODMORAL.docx",
                "FORM137.docx",
                "SHSDIPLOMA.docx",
                "PSA.docx",
                "MEDCERT.docx",
            };
            
            Console.WriteLine("STI  ");
            Console.WriteLine("------------------------");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("please pick your course");
            Console.WriteLine("------------------------");

            Console.WriteLine("------------------------");
            Console.WriteLine(".....BSCS......IT......");
            Console.WriteLine("------------------------");

            Console.Write("Enter your course: ");
            string course = Console.ReadLine();
            Console.WriteLine("------------------------");

            if (course == "BSCS" || course == "bscs" || course == "Bscs")
            {
                Console.WriteLine("You Choose " + course);
            }
            else if (course == "BSIT" || course == "bsit" || course == "Bsit")
            {
                Console.WriteLine("You Choose " + course);
            }

            else
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Invalid Please choose your courses");
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("----PICK---YOUR---PAYMENT----");
            Console.WriteLine(".....Cash.....Installment.....");
            Console.Write(": ");
            String cashin = Console.ReadLine();

            if (cashin == "CASH" || cashin == "Cash" || cashin == "cash")
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("You pick cash");
                Console.WriteLine("That will be 32,000");
                Console.WriteLine("------------------------");
            }
            else if (cashin == "INSTALLMENT" || cashin == "Installment" || cashin == "installment")
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("You choose " + cashin);
                Console.WriteLine("The deposit will be P 10,000 pesos");
                Console.WriteLine("That will be 6,250 pesos per quarter ");
                Console.WriteLine("------------------------");
            }

            else
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("invalid choose again");
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------Requiments-------");
            Console.WriteLine("GOODMORAL");
            Console.WriteLine("FORM137");
            Console.WriteLine("MEDCERT");
            Console.WriteLine("PSA");
            Console.WriteLine("SHSDIPLOMA");
            Console.WriteLine("------------------------");


            foreach (string file in FilesCheck)
            {
                string name1 = Path.Combine(DTP, file);
                if (File.Exists(name1))
                {

                    Console.WriteLine($"The File {file} exists");


                }
                else
                {
                    Console.WriteLine($"The File {file} does not exists");

                }

            }

        }
    }
}
