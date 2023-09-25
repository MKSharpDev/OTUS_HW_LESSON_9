using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{

    public class Messeger
    {

        public void helloMessege()
        {
            Console.WriteLine("Привет! Это игра Угадай число");
        }

        public void startGame()
        {
            Console.WriteLine("Игра началась! Введи число!");

        }

        public void retryTakingValue(string value)

        {
            Console.WriteLine($"Нет! Загаданное число {value}! Попробуй еще раз!");
        }
        public void retryTakingValueAndAttemp(string value, int attemps)

        {
            Console.WriteLine($"Нет! Загаданное число {value}! Осталось {attemps} попыток!");
        }

        public void success() 
        {
            Console.WriteLine("Правильно! Поздравляю ты выйграл!");
        }

        public void failure()
        {
            Console.WriteLine("Попытки угадать закончились! Ты проиграл");
        }   

        public void error(Exception Ex)
        {
            Console.WriteLine($"Что то не так! \n{Ex.Message} \nПопробуй еще раз! ");
        }


        public void attemp()
        {
            Console.WriteLine("Введите число попыток");
        }

        public void range()
        {
            Console.WriteLine("Введите диапазон чисел");
        }

    }

}
