class Menu()
{
    Random rand = new Random();
    public int MaxHealth, MaxHunger, MaxThirst;
    public int Days = 0;
    

    public void PrintMenu(Pet pet1)
    {
        bool isOpen = true;
        while (pet1.Health > 0 && isOpen)
        {
            Console.SetCursorPosition(0, 10);
            Console.WriteLine($"Здоровье - {pet1.Health}/{MaxHealth}, голод - {pet1.Hunger}/{MaxHunger}, жажда - {pet1.Thirst}/{MaxThirst}");

            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"Питомец - {pet1.Type}, имя- {pet1.Name}, дней - {Days}, количество корма - {pet1.Feed}, количество воды - {pet1.Water}");

            Console.SetCursorPosition(30, 0);
            Console.WriteLine("| Мой Виртуальный Питомец |");

            Console.SetCursorPosition(0, 14);
            Console.WriteLine("'1' - Новый день\n'2' - Покормить\n'3' - Дать воды\n'4' - Выход");

            Console.SetCursorPosition(0, 2);
            Console.Write("Ваш выбор: ");

            char choice = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (choice)
            {
                case '1':
                    NewDay(pet1);
                    break;
                case '2':
                    pet1.Feeding();
                    Console.Clear();
                    break;
                case '3':
                    pet1.GiveDrink();
                    Console.Clear();
                    break;
                case '4':
                    isOpen = false;
                    break;
            }
            if(pet1.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Ваш питомец умер потому что вы чертов изверг");
                Console.ReadKey();
            }
                
        }
    }
    public void NewDay(Pet pet1)
    {
        if (pet1.Hunger <= 10 || pet1.Thirst <= 10)
        {
            pet1.Health -= rand.Next(5, 35);
            pet1.Hunger = 1; pet1.Thirst = 1;
        }
        else
        {
            Days++;
            pet1.Feed += rand.Next(5, 20);
            pet1.Thirst += rand.Next(5, 20);

            var i = pet1.Hunger / 2;
            pet1.Hunger -= rand.Next(10, i);

            var j = pet1.Thirst / 2;
            pet1.Thirst -= rand.Next(10, j);
        }
        
    }
    public void Max(Pet pet1)
    {
        MaxHealth = pet1.Health;
        MaxHunger = pet1.Hunger;
        MaxThirst = pet1.Thirst;
    }
}
