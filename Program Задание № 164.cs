using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program164
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Код единицы (1 — кг, 2 — мг, 3 — г, 4 — т, 5 — ц): ");
            if (!int.TryParse(Console.ReadLine(), out int unit)) { Console.WriteLine("Ошибка."); return; }

            Console.Write("Масса: ");
            if (!double.TryParse(Console.ReadLine(), out double value) || value < 0) { Console.WriteLine("Ошибка значения."); return; }

            double kg;

            switch (unit)
            {
                case 1: kg = value; break;                 // кг
                case 2: kg = value / 1_000_000.0; break;  // мг → кг
                case 3: kg = value / 1000.0; break;       // г → кг
                case 4: kg = value * 1000.0; break;       // т → кг
                case 5: kg = value * 100.0; break;        // ц → кг
                default:
                    Console.WriteLine("Неверная единица.");
                    return;
            }

            Console.WriteLine($"{value} в килограммах: {kg:F3}");
        }
    }
}