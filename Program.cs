string userPet = null;
userPet = PetInput(userPet);


string PetInput(string userPet)
{
    string[] pets = { "собака", "кошка", "попугай" };

    bool isOpen = true;
    while (isOpen)
    {
        Console.WriteLine("'1' - Выбрать питомца.\n'2' - рандомный питомец.");
        Console.Write("Ваш выбор: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear(); Console.SetCursorPosition(0, 3);

                Console.WriteLine("Питомцы:"); foreach (string str in pets) Console.Write(" | " + str);
                Console.Write(" |");
                Console.SetCursorPosition(0, 0);
                Console.Write("Ваш выбор: ");
                switch (Console.ReadLine())
                {
                    case "собака": userPet = pets[0]; break;
                    case "кошка": userPet = pets[1]; break;
                    case "попугай": userPet = pets[2]; break;
                    default: WriteError(); break;
                }
                Console.ReadKey(); Console.Clear(); isOpen = false; break;

            case "2":
                Console.Clear();
                Random randPet = new Random();
                int i = randPet.Next(0, 2);
                userPet = pets[i];

                Console.Write($"Вам подарили {userPet}\b");
                if (userPet == pets[0] || userPet == pets[1]) Console.Write("у");
                else Console.Write("я"); isOpen = false; break;
            default: WriteError(); break;
        }
    }
    Console.Write("\nПридумайте имя для вашего питомца: ");
    string petName = Console.ReadLine();
    Console.WriteLine($"\nУ вас {userPet} по имени {petName}");
    return userPet;
}
void WriteError()
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неизвестная команда");
    Console.ForegroundColor = defaultColor;
}
