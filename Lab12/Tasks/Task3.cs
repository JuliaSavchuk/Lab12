namespace Lab12
{
    internal class Task3
    {
        public static void Tas3()
        {
            var studen = new List<Student>
        {
            new Student { FirstName = "John", LastName = "Doe", Age = 20, University = "MIT" },
            new Student { FirstName = "Jane", LastName = "Smith", Age = 22, University = "Oxford" },
            new Student { FirstName = "Boris", LastName = "Johnson", Age = 21, University = "Harvard" },
            new Student { FirstName = "Alex", LastName = "Brown", Age = 18, University = "Stanford" },
            new Student { FirstName = "Brooklyn", LastName = "Smith", Age = 25, University = "Oxford" }
        };

            // Отримати весь масив студентів
            var allStudents = studen;

            // Отримати список студентів з ім'ям Boris
            var borisStudents = studen.Select(s => s.FirstName == "Boris").ToList();

            // Отримати список студентів з прізвищем, яке починається з Bro
            var broStudents = studen.Where(s => s.LastName.StartsWith("Bro")).ToList();

            // Отримати список студентів, старших 19 років
            var olderThan19 = studen.Where(s => s.Age > 19).ToList();

            // Отримати список студентів, старших 20 років і молодших 23 років
            var between20And23 = studen.Where(s => s.Age >= 20 && s.Age <= 23).ToList();

            // Отримати список студентів, які навчаються в MIT
            var mitStudents = studen.Where(s => s.University == "MIT").ToList();

            // Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років
            var oxfordStudentsOver18 = studen.Where(s => s.University == "Oxford" && s.Age > 18)
                                               .OrderByDescending(s => s.Age).ToList();

            // Вивести інформацію про студентів
            PrintStudents(allStudents);
            PrintStudents(broStudents);
            PrintStudents(olderThan19);
            PrintStudents(between20And23);
            PrintStudents(mitStudents);
            PrintStudents(oxfordStudentsOver18);
        }
        static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
            }
            Console.WriteLine();
        }
    }
}
