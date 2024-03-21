Menu menu = new Menu();
Pet pet = new Pet(menu);
TypeSelection();

var isOpen = true;

while (pet.Health > 0 && isOpen)
{
    menu.PrintMenu(pet);
}

void TypeSelection()
{
    Console.SetCursorPosition(30, 0);
    Console.WriteLine("| Мой Виртуальный Питомец |");

    Console.WriteLine("'1' - Собака; '2' - Кошка; '3' - Хомяк; '4' - Попугай;");
    Console.Write("Выберите животное: ");
    switch (Console.ReadLine())
    {
        case "1":
            pet.Type = "Собака";
            pet.Health = 100; pet.Hunger = 60; pet.Thirst = 50;
            menu.Max(pet);
            break;
        case "2":
            pet.Type = "Кошка";
            pet.Health = 80; pet.Hunger = 80; pet.Thirst = 40;
            menu.Max(pet);
            break;
        case "3":
            pet.Type = "Хомяк";
            pet.Health = 20; pet.Hunger = 25; pet.Thirst = 20;
            menu.Max(pet);
            break;
        case "4":
            pet.Type = "Попугай";
            pet.Health = 30; pet.Hunger = 15; pet.Thirst = 10;
            menu.Max(pet);
            break;
    }

    Console.Write("Придумайте имя для питомца: ");
    pet.Name = Console.ReadLine(); Console.Clear();
}