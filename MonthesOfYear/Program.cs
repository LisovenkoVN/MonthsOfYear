namespace MonthsOfYear
{
    internal class Program
    {
        public enum Months
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Введите число месяца:");

                if (IsValid(Console.ReadLine(), out int Input))
                {
                    Console.WriteLine($"Ваш месяц: {Enum.GetName(typeof(Months), Input)}");
                }

                Console.WriteLine("-----------------------");
            }
        }

        static bool IsValid(string input, out int converted)
        {
            converted = 0;

            try
            {
                if (input == null)
                    throw new Exception($"Некорректный ввод. Перевведите число");

                try
                {
                    converted = int.Parse(input);
                }
                catch
                {
                    throw new Exception($"Некорректный ввод: {input}. Должно быть число"); 
                }

                if (converted < 1 || converted > 12)
                {
                    throw new Exception($"Некорректный ввод: {input}. Число должно быть от 1 до 12");
                }          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}

