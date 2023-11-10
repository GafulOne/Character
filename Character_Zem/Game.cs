using Character_Zem;
using System.ComponentModel;
using System.Globalization;

public class Game
{
    List<Character> list = new List<Character>();
    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("" +
                        "Выберите действие:\n" +
                        "1. Создать персонажа\n" +
                        "2. Вывод информации о персонаже\n" +
                        "3. Движение\n" +
                        "0. Выйти из приложения\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    CreateCharacter();
                    break;
                case 2:
                    InfoOut();
                    break;
                case 3:
                    Move();
                    break;

            }
        }
        
    }

    public void CreateCharacter()
    {
        Console.WriteLine("Введите имя персонажа: ");
        string name = Console.ReadLine();
        Console.WriteLine("Введите координату x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите принадлежность к лагерю: ");
        bool camp = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Введите максимальное количество HP: ");
        int maxHP = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите текущее количество HP: ");
        int currentHP = Convert.ToInt32(Console.ReadLine());

        Character character = new Character(name, x, y, camp, maxHP, currentHP);

        list.Add(character);

        Console.WriteLine("Персонаж успешно создан\n");
    }

    public void InfoOut()
    {
        foreach (Character character in list)
        Console.WriteLine(
            $"--------------------------------\n" +
            $"Имя: {character._name}\n" +
            $"Координаты: {character._x};{character._y}\n" +
            $"Лагерь: {character._camp}\n" +
            $"Масимальное/нынешнее HP: {character._max_HP}/{character._current_HP}\n" +
            $"--------------------------------\n");
    }

    public void Move()
    {
        Console.WriteLine("Выбирети одно направление:");
        Console.WriteLine("\n");
        Console.WriteLine("                Вверх(8)                 ");
        Console.WriteLine("Влево(4)                        Вправо(6)");
        Console.WriteLine("                Вниз(2)                   ");
        Console.WriteLine("\n");

        int move = Convert.ToInt32(Console.ReadLine());
        foreach (Character character in list)
        {
            if (move == 8)
            {
                if (character._y > 10)
                    {
                        Console.WriteLine("Вы не можете пройти дальше!\n");
                    }
                else
                    {
                        character._y++;
                    }
                }
            if (move == 2)
            {
                if (character._y < -9)
                {
                    Console.WriteLine("Вы не можете пройти дальше!\n");
                }
                else
                {
                    character._y--;
                }
            }
            if (move == 4)
            {
                if (character._x < -9)
                {
                    Console.WriteLine("Вы не можете пройти дальше!\n");
                }
                else
                {
                    character._x--;
                }
            }
            if (move == 6)
            {
                if (character._x > 10)
                {
                    Console.WriteLine("Вы не можете пройти дальше!\n");
                }
                else
                {
                    character._x++;
                }
            }

        }
    }
}