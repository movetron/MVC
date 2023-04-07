using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
  class DivideResult : DivideResult1
    {
        private readonly DivideShow show;

        public DivideResult(DivideShow show)
        {
            this.show = show;
        }

        public void Run()
        {
            while (true)
            {
                Console.Write("Введите дробь в виде 4/2: ");
                string fraction1 = Console.ReadLine();
                Console.Write("Введите дробь в виде 4/2: ");
                string fraction2 = Console.ReadLine();
                Console.Write("Хотите поделить? - введите да: ");
                string operation = Console.ReadLine();

                int num_1, den_1, num_2, den_2;
                if (!TryParseFraction(fraction1, out num_1, out den_1) ||
                    !TryParseFraction(fraction2, out num_2, out den_2))
                {
                    Console.WriteLine("Неправильная дробь");
                    continue;
                }

                int resultNum, resultDen;
                switch (operation)
                {

                    case "да":
                        if (num_2 == 0)
                        {
                            Console.WriteLine("Делить на ноль нельзя");
                            continue;
                        }

                        show.DivideFractions(num_1, den_1, num_2, den_2, out resultNum, out resultDen);
                        Console.WriteLine("{0}/{1} / {2}/{3} = {4}/{5}", num_1, den_1, num_2, den_2, resultNum, resultDen);
                        break;

                    default:
                        Console.WriteLine("Не правильно");
                        break;
                }
            }
        }
        private bool TryParseFraction(string input, out int num, out int den)
        {
            num = 0;
            den = 0;

            string[] division = input.Split('/');
            if (division.Length != 2)
            {
                return false;
            }

            if (!int.TryParse(division[0], out num) || !int.TryParse(division[1], out den) || den == 0)
            {
                return false;
            }

            return true;
        }
    }

    
}
