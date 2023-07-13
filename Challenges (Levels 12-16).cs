// See https://aka.ms/new-console-template for more information

//C# Players Guide - Challenge "The Replicator of D'To" pg. 94

//int[] replic_array = new int[5];
//for (int i = 0; i < replic_array.Length; i++)
//{
//    Console.Write("Enter as number: ");
//    int replic_num = Convert.ToInt32(Console.ReadLine());
//    replic_array[i] = replic_num;
//}

//int[] replic_array_copy = new int[5];
//for (int j = 0; j < replic_array_copy.Length; j++)
//{
//    replic_array_copy[j] = replic_array[j];
//}

//for (int k = 0; k < replic_array.Length; k++)
//{
//    Console.WriteLine(replic_array[k].ToString());
//    Console.WriteLine(replic_array_copy[k].ToString());
//}







////C# Players Guide - Challenge "The Laws of Freach" pg. 95

//int[] freach = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

////Get smallest number in array
//int current_smallest = int.MaxValue;
//foreach (int num in freach)
//{
//    if (num < current_smallest)
//    {
//        current_smallest = num;
//    }
//}

//Console.WriteLine(current_smallest);

//int freach_total = 0;
//foreach (int num in freach)
//{
//    freach_total += num;
//}
//float freach_average = (float)freach_total / freach.Length;

//Console.WriteLine(freach_average);







////C# Players Guide - Challenge "Taking a Number" pg.106

//int ask_for_number(string text)
//{
//    Console.Write($"{text} ");
//    int result = Convert.ToInt32(Console.ReadLine());
//    return result;
//}

//ask_for_number("What is the airspeed velocity of an unladen swallow?");

//void ask_for_number_in_range(string text, int min, int max)
//{
//    while (true)
//    {
//        Console.Write($"{text} The range is from {min} to {max}. ");
//        int result = Convert.ToInt32(Console.ReadLine());
//        if (result >= min && result <= max)
//        {
//            return;
//        }
//        Console.WriteLine($"Hey, dumbass! Can you read? It needs to be between {min} and {max}!");
//    }
//}

//ask_for_number_in_range("How many hot pockets do you want?", 1, 4);







////C# Players Guide - Challenge "Countdown" pg. 107

//void countdown (int num)
//{  
//    if (num <= 0)
//    {
//        return;
//    }

//    Console.WriteLine(num);
//    countdown(num - 1);
//}

//countdown(10);







////C# Players Guide - Challenge "Simula's Test" pg. 135
//Chest current = Chest.Locked;

//while (true)
//{
//    string chest_state = "locked";

//    //Particular state used for chest status sentence
//    if (current == Chest.Locked)
//        chest_state = "locked";
//    else if (current == Chest.Closed)
//        chest_state = "closed";
//    else
//        chest_state = "open";

//    //State chest status and get user input on action
//    Console.Write($"The chest is {chest_state}. What do you want to do? Your options are lock, unlock, open and close. ");
//    string chest_action = Console.ReadLine();


//    //Different responses based on State and Action

//    //Unlock actions
//    if (current == Chest.Locked && chest_action == "unlock")
//        current = Chest.Closed;
//    else if (current != Chest.Locked && chest_action == "unlock")
//        Console.WriteLine("Chest is already unlocked");

//    //Lock actions
//    else if (current == Chest.Closed && chest_action == "lock")
//        current = Chest.Locked;
//    else if (current == Chest.Locked && chest_action == "lock")
//        Console.WriteLine("Chest is already locked.");
//    else if (current == Chest.Open && chest_action == "lock")
//        Console.WriteLine("Chest must be closed first.");

//    //Open actions
//    else if (current == Chest.Closed && chest_action == "open")
//        current = Chest.Open;
//    else if (current == Chest.Open && chest_action == "open")
//        Console.WriteLine("Chest is already opened.");
//    else if (current == Chest.Locked && chest_action == "open")
//        Console.WriteLine("Chest must be unlocked first");

//    //Close actions
//    else if (current != Chest.Open && chest_action == "close")
//        Console.WriteLine("Chest is already closed");
//    else if (current == Chest.Open && chest_action == "close")
//        current = Chest.Closed;
//}

////Enumerations for Challenge "Simula's Test"
//enum Chest { Open, Closed, Locked };







////C# Players Guide - Challenge "Simula's Soup" pg. 143

//FoodType food_type = 
//    FoodType.Soup;
//MainIngredient main_ingredient = 
//    MainIngredient.Mushroom;
//Seasoning seasoning_choice = 
//    Seasoning.Spicy;



////Food Type - input
//Console.WriteLine(
//    "What type of food should it be?"
//    );
//Console.Write(
//    "Soup, stew, or gumbo? "
//    );
//string type = 
//    Console.ReadLine();

////Main Ingredient - input
//Console.WriteLine(
//    "What should the main ingredient be?"
//    );
//Console.Write(
//    "Mushroom, chicken, carrot, or potato? "
//    );
//string ingredient = 
//    Console.ReadLine();

////Seasoning - input
//Console.WriteLine(
//    "What kind of seasoning should it have?"
//    );
//Console.Write(
//    "Spicy, salty, or sweet? "
//    );
//string seasoning = 
//    Console.ReadLine();




////Convert choices to tuples
////Food Type - choice
//if (type == "soup")
//    food_type = FoodType.Soup;
//else if (type == "stew")
//    food_type = FoodType.Stew;
//else if (type == "gumbo")
//    food_type = FoodType.Gumbo;

////Main Ingredient - choice
//if (ingredient == "mushroom")
//    main_ingredient = MainIngredient.Mushroom;
//else if (ingredient == "chicken")
//    main_ingredient = MainIngredient.Chicken;
//else if (ingredient == "carrot")
//    main_ingredient = MainIngredient.Carrot;
//else if (ingredient == "potato")
//    main_ingredient = MainIngredient.Potato;

////Seasoning - choice
//if (seasoning == "spicy")
//    seasoning_choice = Seasoning.Spicy;
//else if (seasoning == "salty")
//    seasoning_choice = Seasoning.Salty;
//else if (seasoning == "sweet")
//    seasoning_choice = Seasoning.Sweet;

//(Seasoning special_stuff, MainIngredient the_stuff, FoodType foundation) parts = (
//    seasoning_choice, 
//    main_ingredient, 
//    food_type
//    );

////Print Food Name
//Console.WriteLine($"The food being made is the {parts.special_stuff} {parts.the_stuff} {parts.foundation}.");

////TODO: Get it to print out the correct stuff



////Enumerations for Challenge "Simula's Soup"
//enum FoodType { 
//    Soup, 
//    Stew, 
//    Gumbo 
//};
//enum MainIngredient { 
//    Mushroom, 
//    Chicken, 
//    Carrot, 
//    Potato 
//};
//enum Seasoning { 
//    Spicy, 
//    Salty, 
//    Sweet 
//};







//C# Players Guide - Challenge "Vin Fletcher's Arrows" pg. 153
Arrow product = new Arrow();

void get_product()
{
    bool head_selected = false;
    bool shaft_selected = false;
    bool fletch_selected = false;

    //Get arrowhead type
    while (head_selected == false)
    {
        Console.WriteLine("What material would you like the arrowhead to be made of?");
        Console.WriteLine("1) Steel");
        Console.WriteLine("2) Wood");
        Console.WriteLine("3) Obsidian");
        Console.Write("Please enter the corresponding number: ");
        int head_num = Convert.ToInt32(Console.ReadLine());

        switch (head_num)
        {
            case 1:
                product.head_material = HeadType.Steel;
                head_selected = true;
                break;
            case 2:
                product.head_material = HeadType.Wood;
                head_selected = true;
                break;
            case 3:
                product.head_material = HeadType.Obsidian;
                head_selected = true;
                break;
            default:
                Console.WriteLine("That is an invalid entry. Please select a correct one.");
                break;
        }
    }

    //Get shaft length
    while (shaft_selected == false)
    {
        Console.Write("Please enter how many centimeters long the shaft should be: ");
        double shaft_num = Convert.ToInt32(Console.ReadLine());

        if (shaft_num > 0)
        {
            product.shaft_length = shaft_num;
            shaft_selected = true;
        }
        else
            Console.WriteLine("The number must be greater than 0.");
    }

    //Get fletching type
    while (fletch_selected == false)
    {
        Console.WriteLine("What material would you like the fletching to be made of?");
        Console.WriteLine("1) Plastic");
        Console.WriteLine("2) Turkey Feathers");
        Console.WriteLine("3) Goose Feathers");
        Console.Write("Please enter the corresponding number: ");
        int fletch_num = Convert.ToInt32(Console.ReadLine());

        switch (fletch_num)
        {
            case 1:
                product.fletch_material = FletchingType.Plastic;
                fletch_selected = true;
                break;
            case 2:
                product.fletch_material = FletchingType.Turkey;
                fletch_selected = true;
                break;
            case 3:
                product.fletch_material= FletchingType.Goose;
                fletch_selected = true;
                break;
            default:
                Console.WriteLine("That is an invalid entry. Please select a correct one.");
                break;
        }
    }
}


//Determine cost of arrow
double get_cost()
{
    double arrow_cost = 0.0;

    //Add arrowhead material cost
    if (product.head_material == HeadType.Steel)
        arrow_cost += 10;
    else if (product.head_material == HeadType.Wood)
        arrow_cost += 3;
    else
        arrow_cost += 5;

    //Add shaft length cost
    arrow_cost += product.shaft_length * 0.5;

    //Add fletching material cost
    if (product.fletch_material == FletchingType.Plastic)
        arrow_cost += 10;
    else if (product.fletch_material == FletchingType.Turkey)
        arrow_cost += 5;
    else
        arrow_cost += 3;

    return arrow_cost;
}

//Display total cost
get_product();
Console.WriteLine($"The total cost for an arrow with an " +
    $"arrowhead made of {product.head_material}, " +
    $"a shaft that's {product.shaft_length}cm long, " +
    $"and fletching made of {product.fletch_material} " +
    $"is {get_cost()} gold.");



//Classes and Enumerations for Vin Fletcher's Arrows
class Arrow
{
    public HeadType head_material;
    public double shaft_length;
    public FletchingType fletch_material;
}

enum HeadType
{
    Steel,
    Wood,
    Obsidian
}

enum FletchingType
{
    Plastic,
    Turkey,
    Goose
}