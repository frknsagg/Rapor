using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rapor1_Abstract
{
      abstract class  GameCalculator
    {
        public abstract void Hesapla();
        
        public void GameOver()
        {
            Console.WriteLine("OYun bitti");
        }
    }
}
