using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErmakovTicket_7
{
    class Variable
    {
        double enter = 0;
        double tempMax = 0;

        public void Metod()
        {
            Console.WriteLine("Введите 5 значений");
            for (int i = 0; i < 5; i++)
            {
                this.enter = Convert.ToDouble(Console.ReadLine());

                if (this.tempMax < this.enter)
                {
                    this.tempMax = this.enter;
                }
            }
            Console.WriteLine("Максимальное значение = " + this.enter);
            Console.ReadLine();
        }
    }    
}
