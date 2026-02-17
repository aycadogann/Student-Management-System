using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StundentManagement.Core
{
    public class GradeCalculator
    {
        private const double vizeEtkisi= 0.4;
        private const double finalEtkisi= 0.6;

        public static double OrtalamaHesapla(double vize, double final)
        {
            return (vize*vizeEtkisi)+(final * finalEtkisi);
        }

        public static string HarfNotuGetir(double ortalama)
        {
            if (ortalama >= 90) return "AA";
            if (ortalama >= 85) return "BA";
            if (ortalama >= 80) return "BB";
            if (ortalama >= 75) return "CB";
            if (ortalama >= 70) return "CC";
            if (ortalama >= 60) return "DC";
            if (ortalama >= 50) return "DD";

            return "FF";
        }

        public static bool GectiMi(double ortalama)
        {
            return ortalama >= 50 ? true : false;
        }

    }
}
