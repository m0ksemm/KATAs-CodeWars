using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class TheRoad_KillDetective
    {
        public static string RoadKill(string photo)
        {
            var animals = Preloaded.ANIMALS; // список відомих тварин

            // 1. Залишаємо тільки букви
            string cleaned = Regex.Replace(photo.ToLower(), "[^a-z]", "");

            // 2. Стискаємо повтори (aaa -> a)
            string compressed = Regex.Replace(cleaned, "(.)\\1+", "$1");

            // 3. Шукаємо серед відомих
            foreach (var animal in animals)
            {
                if (compressed == animal.ToLower())
                    return animal; // повертаємо "нормальне" ім’я з масиву
            }

            // 4. Якщо не знайдено
            return "??";
        }
    }
}
