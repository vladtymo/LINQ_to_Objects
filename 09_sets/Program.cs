using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_sets
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> result;

            string[] soft = { "Blue", "Grey", "Yellow", "Cyan", "Grey", "Yellow" };
            string[] hard = { "Yellow", "Magenta", "White", "Blue" };

            // Except -----------------------        
            // з колекції А видаляються елементи колекції В (без дублікатів)
            result = soft.Except(hard);           

            // Intersect ---------------------------
            // отримуємо елементи колекції А, які присутні в колекції В (без дублікатів)
            result = soft.Intersect(hard);           

            // Union ---------------------------
            // з'єднує елементи двох колекцій (без дублікатів)
            result = soft.Union(hard);

            // Concat -------------
            // з'єднує елементи двох колекцій
            result = soft.Concat(hard);

            // Distinct ----------------
            // видаляє дублікати
            result = soft.Distinct();

            foreach (string s in result)
                Console.WriteLine(s);
        }
    }
}
