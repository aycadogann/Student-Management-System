using StundentManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Öğrenci Not Hesaplama Sistemi----------");
            Console.WriteLine(" ");

            Console.WriteLine("Adı:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Soyadı:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Vize Notu:");
            double midTermGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Final Notu:");
            double finalGrade =double.Parse(Console.ReadLine());


            double avarage = GradeCalculator.OrtalamaHesapla(midTermGrade, finalGrade);
            string letterGrade = GradeCalculator.HarfNotuGetir(avarage);

            Console.WriteLine("Ortalama: {0}",avarage);
            Console.WriteLine("Harf Notu: {0}",letterGrade);



            Console.ReadKey();

        }
    }
}
