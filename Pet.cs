class Pet(Menu menu)
{
    public int Health, Hunger, Thirst;
    public string Name, Type;
    public int Feed = 20;
    public int Water = 20;

    public void Feeding()
    {
        Console.Write("Введите колличество корма: ");
        var feedCount = int.Parse(Console.ReadLine());

        if (feedCount <= 0 && feedCount > Feed && Hunger == menu.MaxHunger)
            Console.Write("Некорректное количество корма");
        else
        {
            Feed -= feedCount;
            Hunger += feedCount;
        } 
            
    }
    public void GiveDrink()
    {
        Console.Write("Введите колличество воды: ");
        var waterCount = int.Parse(Console.ReadLine());

        if (waterCount <= 0 && waterCount > Water && Thirst == menu.MaxThirst)
            Console.WriteLine("Сейчас вы не можете покормить питомца");

        else 
        {
            Water -= waterCount;
            Thirst += waterCount;
        }
        
    }
}
