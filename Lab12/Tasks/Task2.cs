namespace Lab12
{
    internal class Task2
    {
        public static void Tas2()
        {
            List<string> cities = new List<string>() { "Kyiv", "Lviv", "Odesa", "Kharkiv", "Dnipro", "Rivne", "Zaporizhzhia" };

            // Отримати весь масив міст.
            var allCities = cities;

            // Отримати міста з довжиною назви, що дорівнює заданому.
            int length = 5;
            var citiesWithLength = cities.Where(city => city.Length == length);

            // Отримати міста, назви яких починаються з літери A.
            var citiesStartsWithA = cities.Where(city => city.StartsWith("A"));

            // Отримати міста, назви яких закінчуються літерою M.
            var citiesEndsWithM = cities.Where(city => city.EndsWith("M"));

            // Отримати міста, назви яких починаються з літери N і закінчуються літерою K.
            var citiesStartsWithNAndEndsWithK = cities.Where(city => city.StartsWith("N") && city.EndsWith("K"));

            // Отримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням.
            var citiesStartsWithNe = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(city => city);

            // Виведення інформації
            PrintCities("All cities:", allCities);
            PrintCities($"Cities with length {length}:", citiesWithLength);
            PrintCities("Cities starting with 'A':", citiesStartsWithA);
            PrintCities("Cities ending with 'M':", citiesEndsWithM);
            PrintCities("Cities starting with 'N' and ending with 'K':", citiesStartsWithNAndEndsWithK);
            PrintCities("Cities starting with 'Ne' in descending order:", citiesStartsWithNe);
        }

        static void PrintCities(string message, IEnumerable<string> cities)
        {
            Console.WriteLine(message);
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }
    }
}
