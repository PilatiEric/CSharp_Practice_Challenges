// See https://aka.ms/new-console-template for more information


//C# Players Guide - Boss Battle "Hunting the Manticore" pg. 124

bool dist_set = false;
bool battle_over = false;
int mant_distance = 0;
int max_city_hp = 15;
int city_hp = max_city_hp;
int max_mant_hp = 10;
int mant_hp = max_mant_hp;
int round = 1;


int amount_of_damage(int round)
{
    if (round % 3 == 0 || round % 5 == 0)
    {
        return 3;
    }
    else if (round % 3 == 0 && round % 5 == 0)
    {
        return 10;
    }
    else
    {
        return 1;
    }
}


//Player one setting a distance between 0 and 100
while (dist_set == false)
{
    Console.WriteLine("Player 1, how far away from the city do you want to station the manticore.");
    Console.Write("Distance must be between 0 and 100: ");
    mant_distance = Convert.ToInt32(Console.ReadLine());

    if (mant_distance < 0 || mant_distance > 100)
    {
        Console.WriteLine("As a reminder, the distance must be between 0 and 100.");
    }
    else
    {
        dist_set = true;
        Console.Clear();
    }
}






while (battle_over == false)
{
    // Status and Player 2 set distance to fire at

    //Status Message - color
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("STATUS:  ");

    //Round Message - color
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write($"Round: {round}  ");

    //City HP Message - color
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write($"City: {city_hp}/{max_city_hp}  ");

    //Manticore HP Message - color
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Manticore: {mant_hp}/{max_mant_hp}");
    
    //Estimated Damage Message - color
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"The cannon is expected to deal {amount_of_damage(round)} damage this round.");
    
    //Cannon Distance Input Message - color
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter desired cannon range (0 - 100): ");
    int cannon_distance = Convert.ToInt32(Console.ReadLine());

    //Determine if distance set is within correct range
    if (cannon_distance < 0 || cannon_distance > 100)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("As a reminder, the distance must be between 0 and 100.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        //Determine if shot hits target and how much damage is done
        if (cannon_distance > mant_distance)
        {
            Console.WriteLine("That round OVERSHOT the target.");
            Console.WriteLine("--------------------------------------------");
            city_hp--;
            round++;
        }
        else if (cannon_distance < mant_distance)
        {
            Console.WriteLine("That round FELL SHORT of the target.");
            Console.WriteLine("--------------------------------------------");
            city_hp--;
            round++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("That round was a DIRECT HIT!");
            Console.WriteLine("--------------------------------------------");
            mant_hp -= amount_of_damage(round);
            if (mant_hp > 0)
            {
                city_hp--;
            }
            round++;
        }
    }

    //Determine if city or manticore hp has been reduced to 0
    if (mant_hp <= 0)
    {
        //Victory Message - color
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("The Manticore has been destroyed.");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("However, many innocent lives were lost in the process.");
        battle_over = true;

    }
    else if (city_hp <= 0)
    {
        //Defeat Message - color
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city has been reduced to rubble.");
        Console.WriteLine("The entire population has been slaughtered.");
        Console.WriteLine("You have failed and all hope is lost.");
        battle_over = true;
    }
}