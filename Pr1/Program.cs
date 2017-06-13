using System; 
namespace Pr1 //пространство имён Pr1
{
    class Program //Класс Programm
    {
        static void Main(string[] args) //объявлен метод Main, который возщвращает значение void
        {
            Console.WriteLine("Hello World!"); //Использован метод WriteLine внутри класса Console, выводящий на экран строку "Hello World!"
            Console.WriteLine("Нажмите любую клавишу для выхода"); //вывод на экран соответствующего собщения о закрытии программы
            Console.ReadKey(); //ввод клавиши для выхода из программы
        }
    }
}
