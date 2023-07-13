// See https://aka.ms/new-console-template for more information

// C# Players Guide - Challenge "Consolas Telim" pg. 26

//Inform that bread is ready and ask who it's for
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");

//Get input from user for name of bread recipient (bread_name)
string bread_name = Console.ReadLine();

//Inform them that bread_name this
Console.WriteLine("Noted: " + bread_name + " got bread.");








//C# Players Guide - Challenge "The Thing Namer 3000" pg. 31

Console.WriteLine("What kind of thing are we talking about?");

//Variable for storing user input to above question
string a = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

/* Input to above question requires a descriptor or adjective */
string b = Console.ReadLine();

Console.WriteLine("The " + b + " " + a + " of Doom 3000!");








//C# Players Guide - Challenge "The Variable Shop" pg. 45

//One of each of the 14 variables types must be created
//Assign each a value using a literal of the correct type

//Integer Types
byte shop_byte = 245;
short shop_short = -16_584;
int shop_int = 1_624_213_725;
long shop_long = -4_004_347_105_655_321_745;
sbyte shop_sbyte = -119;
ushort shop_ushort = 65_534;
uint shop_uint = 4_107_456_845;
ulong shop_ulong = 11_245_600_743_105_411_625L;

//Text Types
char shop_char = 'f';
string shop_string = "Fuck off!";

//Floating-Point Types
float shop_float = 3.62362e31f; //Same as 3.62362 x 10^31
double shop_double = 5.147e297; //Same as 5.147 x 10^297
decimal shop_decimal = -6.512e21m; //Same as -6.512 x 10^21

//Boolean Type
bool shop_bool = false;








//C# Players Guide - Challenge "The Triangle Farmer" pg. 53

//Build program that takes input from user on base and height and returns the area
Console.WriteLine("What is the size of the base?");

var base_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the size of the height?");

var height_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The size of the triangle is " + ((base_size * height_size) / 2) + ".");








//C# Players Guide - Challenge "The Four Sisters and the Duckbear" pg. 56

Console.WriteLine("How many Chocolate Eggs are there?");

//Have user specify how many eggs there are
int total_eggs = Convert.ToInt32(Console.ReadLine());

//Show how many the sisters get
int sisters_eggs = total_eggs / 4;

//Show the remainder that the Duckbear gets
int duckbear_eggs = total_eggs % 4;

Console.WriteLine("The sisters each get " + sisters_eggs +
    " eggs, while the Duckbear gets " + duckbear_eggs + " eggs.");








//C# Players Guide - Challenge "The Dominion of Kings" pg. 57

int holding_points = 0;

//Get user to enter how many Provinces, Duchies, and Estates they have

Console.WriteLine("How many Provinces do you have?");
int provinces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many Duchies do you have?");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many Estates do you have?");
int estates = Convert.ToInt32(Console.ReadLine());

//Use Incremental Operators to find out their total value
//Estates = 1 point
//Duchies = 3 points
//Provinces = 6 points
holding_points += (provinces * 6) + (duchies * 3) + (estates * 1);

Console.WriteLine("Your holdings points total is " + holding_points + ".");








//C# Players Guide - Challenge "The Defense of Consolas" pg. 68

Console.Title = "Defense of Consolas";
Console.ForegroundColor = ConsoleColor.Green;

//Get Coordinates
Console.Write("Which column? Column number must be greater than 1.  ");
int consolas_column = Convert.ToInt32(Console.ReadLine());
Console.Write("Which row? Row number must be greater than 1.  ");
int consolas_row = Convert.ToInt32(Console.ReadLine());

//Get deployment coordinates
string consolas_north = $"({consolas_row + 1}, {consolas_column})"; //displays (number, number)
string consolas_south = $"({consolas_row - 1}, {consolas_column})";
string consolas_west = $"({consolas_row}, {consolas_column - 1})";
string consolas_east = $"({consolas_row}, {consolas_column + 1})";


Console.WriteLine("Deploy to:");
Console.WriteLine(consolas_north);
Console.WriteLine(consolas_south);
Console.WriteLine(consolas_west);
Console.WriteLine(consolas_east);

Console.Beep();








//C# Players Guide - Challenge "Repairing the Clocktower" pg. 75

//Get number and display "Tick" if it is even or "Tock" if it is odd

Console.Write("Enter a whole number: ");
int clock_number = Convert.ToInt32(Console.ReadLine());

if (clock_number % 2 == 0)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");








//C# Players Guide - Challenge "Watchtower" pg. 78

//Get x and y coordinates
Console.Write("Enter a number less than, equal to, or great than 0 for the X axis:  ");
int coord_x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number less than, equal to, or great than 0 for the X axis:  ");
int coord_y = Convert.ToInt32(Console.ReadLine());

if (coord_x < 0 && coord_y > 0)
    Console.WriteLine("The enemy is to the northwest!");
else if (coord_x == 0 && coord_y > 0)
    Console.WriteLine("The enemy is to the north!");
else if (coord_x > 0 && coord_y > 0)
    Console.WriteLine("The enemy is to the northeast!");
else if (coord_x < 0 && coord_y == 0)
    Console.WriteLine("The enemy is to the west!");
else if (coord_x == 0 && coord_y == 0)
    Console.WriteLine("The enemy is here!");
else if (coord_x > 0 && coord_y == 0)
    Console.WriteLine("The enemy is to the east!");
else if (coord_x < 0 && coord_y < 0)
    Console.WriteLine("The enemy is to the southwest!");
else if (coord_x == 0 && coord_y < 0)
    Console.WriteLine("The enemy is to the south!");
else
    Console.WriteLine("The enemy is to the southeast!");








//C# Players Guide - Challenge "Buying Inventory" pg. 82

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");

int choice = Convert.ToInt32(Console.ReadLine());
string item_price;

item_price = choice switch
{
    1 => "Rope costs 10 golds",
    2 => "Torches cost 15 gold.",
    3 => "Climbing Equipment costs 25 gold.",
    4 => "Clean Water costs 1 gold.",
    5 => "Machetes cost 20 gold.",
    6 => "Canoes cost 200 gold.",
    _ => "Food Supplies cost 1 gold."
};
Console.WriteLine(item_price);







//C# Players Guide - Challenge "Discounted Inventory" pg. 83

Console.Write("What is your name? ");
string customer_name = Console.ReadLine();

if (customer_name == "Eric")
{
    Console.WriteLine("The following items are available:");
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 - Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.Write("What number do you want to see the price of? ");

    int store_choice = Convert.ToInt32(Console.ReadLine());
    string item_price_discount;

    item_price_discount = store_choice switch
    {
        1 => "Rope costs 15 golds",
        2 => "Torches cost 7 gold.",
        3 => "Climbing Equipment costs 12 gold.",
        4 => "Clean Water costs 0 gold.",
        5 => "Machetes cost 10 gold.",
        6 => "Canoes cost 100 gold.",
        _ => "Food Supplies cost 0 gold."
    };
    Console.WriteLine(item_price_discount);
}

else
{
    Console.WriteLine("The following items are available:");
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 - Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.Write("What number do you want to see the price of? ");

    int store_choice = Convert.ToInt32(Console.ReadLine());
    string item_price_full;

    item_price_full = store_choice switch
    {
        1 => "Rope costs 10 golds",
        2 => "Torches cost 15 gold.",
        3 => "Climbing Equipment costs 25 gold.",
        4 => "Clean Water costs 1 gold.",
        5 => "Machetes cost 20 gold.",
        6 => "Canoes cost 200 gold.",
        _ => "Food Supplies cost 1 gold."
    };
    Console.WriteLine(item_price_full);
}







//C# Players Guide - Challenge "The Prototype" pg. 88

//Get pilots number
Console.WriteLine("User 1, enter a number between 0 and 100: ");
int pilot_pick = Convert.ToInt32(Console.ReadLine());
Console.Clear();

//Get hunters guess
int hunter_guess;
Console.WriteLine("User 2, guess the number.");
do
{
    Console.WriteLine("What is your next guess: ");
    hunter_guess = Convert.ToInt32(Console.ReadLine());

    if (hunter_guess > pilot_pick)
    {
        Console.WriteLine($"{hunter_guess} is too high.");
        continue;
    }
    else if (hunter_guess < pilot_pick)
    {
        Console.WriteLine($"{hunter_guess} is too low.");
        continue;
    }
    else
    {
        break;
    }
}
while (hunter_guess != pilot_pick);

Console.WriteLine("You guessed the number!");







//C# Players Guide - Challenge "The Magic Cannon" pg. 89

for (int turn = 1; turn <= 30; turn++)
{
    if (turn % 3 != 0 && turn % 5 != 0)
    {
        Console.WriteLine ($"{turn}: Normal");
    }
    else if (turn % 3 == 0 && turn % 5 != 0)
    {
        Console.WriteLine ($"{turn}: Fire");
    }
    else if (turn % 3 != 0 && turn % 5 == 0)
    {
        Console.WriteLine ($"{turn}: Electric");
    }
    else
    {
        Console.WriteLine ($"{turn}: Fire and Electric");
    }
}