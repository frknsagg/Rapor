using System;

namespace Rapor1_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            WomenGameCalculator womenGameCalculator = new WomenGameCalculator();
            MenGameCalculator menGameCalculator = new MenGameCalculator();
            KidGameCalculator kidGameCalculator = new KidGameCalculator();
            womenGameCalculator.Hesapla();
            menGameCalculator.Hesapla();
            kidGameCalculator.Hesapla();
            
            

            
        }
    }
}
