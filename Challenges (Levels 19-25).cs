// See https://aka.ms/new-console-template for more information



//C# Players Guide - Challenge "Vin's Trouble" pg. 162


Arrow product = new Arrow(HeadType.Steel, 1, FletchingType.Turkey);

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
                product.SetHeadType(HeadType.Steel);
                head_selected = true;
                break;
            case 2:
                product.SetHeadType(HeadType.Wood);
                head_selected = true;
                break;
            case 3:
                product.SetHeadType(HeadType.Obsidian);
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
            product.SetShaftLength(shaft_num);
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
                product.SetFletchingType(FletchingType.Plastic);
                fletch_selected = true;
                break;
            case 2:
                product.SetFletchingType(FletchingType.Turkey);
                fletch_selected = true;
                break;
            case 3:
                product.SetFletchingType(FletchingType.Goose);
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
    if (product.GetHeadType() == HeadType.Steel)
        arrow_cost += 10;
    else if (product.GetHeadType() == HeadType.Wood)
        arrow_cost += 3;
    else
        arrow_cost += 5;

    //Add shaft length cost
    arrow_cost += product.GetShaftLength() * 0.5;

    //Add fletching material cost
    if (product.GetFletchMaterial() == FletchingType.Plastic)
        arrow_cost += 10;
    else if (product.GetFletchMaterial() == FletchingType.Turkey)
        arrow_cost += 5;
    else
        arrow_cost += 3;

    return arrow_cost;
}
//Display total cost
get_product();
Console.WriteLine($"The total cost for an arrow with an " +
    $"arrowhead made of {product.GetHeadType()}, " +
    $"a shaft that's {product.GetShaftLength()}cm long, " +
    $"and fletching made of {product.GetFletchMaterial()} " +
    $"is {get_cost()} gold.");



//Classes and Enumerations for Vin Fletcher's Arrows
//Make fields private and add getters and setters
class Arrow
{
    private HeadType head_material;
    private double shaft_length;
    private FletchingType fletch_material;

    public Arrow (HeadType head_material, double shaft_length, FletchingType fletch_material)
    {
        this.head_material = head_material;
        this.shaft_length = shaft_length;
        this.fletch_material = fletch_material;
    }

    public HeadType GetHeadType() => this.head_material;
    public double GetShaftLength() => this.shaft_length;
    public FletchingType GetFletchMaterial() => this.fletch_material;

    public void SetHeadType(HeadType value) => this.head_material = value;
    public void SetShaftLength(double value) => this.shaft_length = value;
    public void SetFletchingType(FletchingType value) => this.fletch_material = value;
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







//C# Players Guide - Challenge "The Properties of Arrows" Level 20, pg. 168

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
                product.headtype = HeadType.Steel;
                head_selected = true;
                break;
            case 2:
                product.headtype = HeadType.Wood;
                head_selected = true;
                break;
            case 3:
                product.headtype = HeadType.Obsidian;
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
            product.shaftlength = shaft_num;
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
                product.fletchtype = FletchingType.Plastic;
                fletch_selected = true;
                break;
            case 2:
                product.fletchtype = FletchingType.Turkey;
                fletch_selected = true;
                break;
            case 3:
                product.fletchtype = FletchingType.Goose;
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
    if (product.headtype == HeadType.Steel)
        arrow_cost += 10;
    else if (product.headtype == HeadType.Wood)
        arrow_cost += 3;
    else
        arrow_cost += 5;

    //Add shaft length cost
    arrow_cost += product.shaftlength * 0.5;

    //Add fletching material cost
    if (product.fletchtype == FletchingType.Plastic)
        arrow_cost += 10;
    else if (product.fletchtype == FletchingType.Turkey)
        arrow_cost += 5;
    else
        arrow_cost += 3;

    return arrow_cost;
}

//Display total cost
get_product();
Console.WriteLine($"The total cost for an arrow with an " +
    $"arrowhead made of {product.headtype}, " +
    $"a shaft that's {product.shaftlength}cm long, " +
    $"and fletching made of {product.fletchtype} " +
    $"is {get_cost()} gold.");



//Classes and Enumerations for Vin Fletcher's Arrows
//Make fields private and add getters and setters
class Arrow
{
    public HeadType headtype { get; set; }
    public double shaftlength { get; set; }
    public FletchingType fletchtype { get; set; }
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







//C# Players Guide - Challenge "Arrow Factories" Level 21, pg. 173

using System.Linq.Expressions;

Arrow product = new Arrow();

bool arrow_cust_selected = false;




//Pre-determined or custom arrow
while (arrow_cust_selected == false)
{
    Console.WriteLine("Would you like a pre-defined arrow or a custom arrow?");
    Console.WriteLine("1) Pre-Defined");
    Console.WriteLine("2) Custom");
    Console.Write("Please make your selection using the corresponding number: ");
    try
    {
        int custom_or_nah = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");

        switch (custom_or_nah)
        {
            //Pre-Determined Arrow
            case 1:
                get_product_pre();
                arrow_cust_selected = true;
                break;
            //Custom Arrow
            case 2:
                get_product();
                Console.WriteLine($"The total cost for an arrow with an " +
                    $"arrowhead made of {product.headtype}, " +
                    $"a shaft that's {product.shaftlength}cm long, " +
                    $"and fletching made of {product.fletchtype} " +
                    $"is {get_cost()} gold.");
                arrow_cust_selected = true;
                break;
            //Invalid Selection
            default:
                Console.WriteLine("That is an invalid selection. Please choose a correct number.");
                Console.WriteLine(" ");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("   ");
        Console.WriteLine("That is not a valid input. Please only use numbers with no decimal places.");
        Console.WriteLine("   ");
    }

}



//Getting users input on pre-determined arrows
void get_product_pre()
{
    bool pre_arrow_selected = false;

    //Get pre-determined arrow type
    while (pre_arrow_selected == false)
    {
        Console.WriteLine("Which type of arrow would you like?");
        Console.WriteLine("1) Elite Arrow");
        Console.WriteLine("2) Beginner Arrow");
        Console.WriteLine("3) Marksman Arrow");
        Console.Write("Please make your selectin using the corresponding number: ");
        try
        {
            int how_good_it_be = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            switch (how_good_it_be)
            {
                //Elite Arrow
                case 1:
                    Console.WriteLine($"The Elite Arrow will cost " +
                        $"{get_cost_pre(Arrow.CreateEliteArrow())} gold.");
                    pre_arrow_selected = true;
                    break;
                //Beginner Arrow
                case 2:
                    Console.WriteLine($"The Beginner Arrow will cost " +
                        $"{get_cost_pre(Arrow.CreateBeginnerArrow())} gold.");
                    pre_arrow_selected = true;
                    break;
                //Marksman Arrow
                case 3:
                    Console.WriteLine($"The Marksman Arrow will cost " +
                        $"{get_cost_pre(Arrow.CreateMarksmanArrow())} gold.");
                    pre_arrow_selected = true;
                    break;
                //Invalid selection
                default:
                    Console.WriteLine("That is an invalid selection. Please choose a correct number.");
                    Console.WriteLine(" ");
                    break;
            }
        }
        catch ( Exception ex ) 
        {
            Console.WriteLine("   ");
            Console.WriteLine("That is not a valid input. Please only use numbers with no decimal places.");
            Console.WriteLine("   ");
        }
    }
}



//Getting users input on custom arrows
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

        //In case some dick tries to enter anything but a number
        try
        {
            int head_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            switch (head_num)
            {
                //Steel Arrowhead
                case 1:
                    product.headtype = HeadType.Steel;
                    head_selected = true;
                    break;
                //Wood Arrowhead
                case 2:
                    product.headtype = HeadType.Wood;
                    head_selected = true;
                    break;
                //Obsidian Arrowhead
                case 3:
                    product.headtype = HeadType.Obsidian;
                    head_selected = true;
                    break;
                //Invalid Selection
                default:
                    Console.WriteLine("That is an invalid entry. Please select a correct one.");
                    Console.WriteLine(" ");
                    break;
            }
        }
        catch ( Exception ex )
        {
            Console.WriteLine("   ");
            Console.WriteLine("That is not a valid input. Please only use numbers with no decimal places.");
            Console.WriteLine("   ");
        }
    }

    //Get shaft length
    while (shaft_selected == false)
    {
        Console.Write("Please enter how many centimeters long the shaft should be: ");
        try
        {
            double shaft_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (shaft_num > 0)
            {
                product.shaftlength = shaft_num;
                shaft_selected = true;
            }
            else
            {
                Console.WriteLine("The number must be greater than 0.");
                Console.WriteLine(" ");
            }
        }
        catch ( Exception ex )
        {
            Console.WriteLine("   ");
            Console.WriteLine("That is not a valid input. Please only use numbers with no decimal places.");
            Console.WriteLine("   ");
        }
    }

    //Get fletching type
    while (fletch_selected == false)
    {
        Console.WriteLine("What material would you like the fletching to be made of?");
        Console.WriteLine("1) Plastic");
        Console.WriteLine("2) Turkey Feathers");
        Console.WriteLine("3) Goose Feathers");
        Console.Write("Please enter the corresponding number: ");
        try
        {
            int fletch_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            switch (fletch_num)
            {
                //Plastic Fletching
                case 1:
                    product.fletchtype = FletchingType.Plastic;
                    fletch_selected = true;
                    break;
                //Turkey Feather Fletching
                case 2:
                    product.fletchtype = FletchingType.Turkey;
                    fletch_selected = true;
                    break;
                //Goose Feather Fletching
                case 3:
                    product.fletchtype = FletchingType.Goose;
                    fletch_selected = true;
                    break;
                //Invalid Selection
                default:
                    Console.WriteLine("That is an invalid entry. Please select a correct one.");
                    Console.WriteLine(" ");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("   ");
            Console.WriteLine("That is not a valid input. Please only use numbers with no decimal places.");
            Console.WriteLine("   ");   
        }
    }
}



//Determine cost of arrow
double get_cost()
{
    double arrow_cost = 0.0;

    //Add arrowhead material cost
    if (product.headtype == HeadType.Steel)
        arrow_cost += 10;
    else if (product.headtype == HeadType.Wood)
        arrow_cost += 3;
    else
        arrow_cost += 5;

    //Add shaft length cost
    arrow_cost += product.shaftlength * 0.5;

    //Add fletching material cost
    if (product.fletchtype == FletchingType.Plastic)
        arrow_cost += 10;
    else if (product.fletchtype == FletchingType.Turkey)
        arrow_cost += 5;
    else
        arrow_cost += 3;

    return arrow_cost;
}



//Cost for Pre-determined arrows
double get_cost_pre(Arrow type)
{
    double arrow_cost = 0.0;

    //Add arrowhead material cost
    if (type.headtype == HeadType.Steel)
        arrow_cost += 10;
    else if (type.headtype == HeadType.Wood)
        arrow_cost += 3;
    else
        arrow_cost += 5;

    //Add shaft length cost
    arrow_cost += type.shaftlength * 0.5;

    //Add fletching material cost
    if (type.fletchtype == FletchingType.Plastic)
        arrow_cost += 10;
    else if (type.fletchtype == FletchingType.Turkey)
        arrow_cost += 5;
    else
        arrow_cost += 3;

    return arrow_cost;
}




//Classes and Enumerations for Vin Fletcher's Arrows
//Make fields private and add getters and setters
class Arrow
{
    //Arrow Class Characteristics
    public HeadType headtype { get; set; }
    public double shaftlength { get; set; }
    public FletchingType fletchtype { get; set; }

    //Methods for Pre-Determined Arrows
    public static Arrow CreateEliteArrow()
    {
        Arrow EliteArrow = new Arrow();

        EliteArrow.headtype = HeadType.Steel;
        EliteArrow.shaftlength = 95;
        EliteArrow.fletchtype = FletchingType.Plastic;

        return EliteArrow;
    }

    public static Arrow CreateBeginnerArrow()
    {
        Arrow BeginnerArrow = new Arrow();

        BeginnerArrow.headtype = HeadType.Wood;
        BeginnerArrow.shaftlength = 75;
        BeginnerArrow.fletchtype = FletchingType.Goose;

        return BeginnerArrow;
    }

    public static Arrow CreateMarksmanArrow()
    {
        Arrow MarksmanArrow = new Arrow();

        MarksmanArrow.headtype = HeadType.Steel;
        MarksmanArrow.shaftlength = 65;
        MarksmanArrow.fletchtype = FletchingType.Goose;

        return MarksmanArrow;
    }


}



//Arrowhead Types
enum HeadType
{
    Steel,
    Wood,
    Obsidian
}

//Fletching Types
enum FletchingType
{
    Plastic,
    Turkey,
    Goose
}
