using System;


//string choice = "";
//int a = 16;
//int b = 8;
//int c= 10;


Console.WriteLine("You have 100 dollars and you would like to buy a) Pepsi bottle (16kr), b) Choaklad bar (8kr) and c) gummy bears (10kr)");

string vara = GetAnswer();

static string GetAnswer()
{
    int cost = 0;
    string choice = "";
    string pay_or_shop = "";
    string how_many = "";
    int money = 100;
    string pay;



    while (money > 0)
    {
        choice = Console.ReadLine();
        choice = choice.ToLower();
        Console.WriteLine("How many would you like to buy?");
        how_many = Console.ReadLine();


        int howManyNum = 0;
        // int choiceNum = 0;
        int.TryParse(how_many, out howManyNum);
        // int.TryParse(choice, out choiceNum);


        if (choice == "a")
        {
            cost = 16 * howManyNum;
            money -= cost;

            if (cost < money)
            {
                Console.WriteLine($"You have {money} dollars would you like to pay or contineu shopping ");
                Console.ReadLine();
                pay = Console.ReadLine();

                if (pay_or_shop == pay)
                {
                    Console.WriteLine($"The total cost were {cost} and you are left with {money} dollars");
                    money = 0;
                    Console.ReadLine();

                }
                else
                {

                }
            }

            else
            {
                Console.WriteLine("You dont have enough money, would you like change how many you will buy?");
            }
        }

        else if (choice == "b")
        {
            cost = 8 * howManyNum;
            money -= cost;
            if (cost < money)
            {
                 Console.WriteLine($"You have {money} dollars would you like to pay or contineu shopping ");
                Console.ReadLine();
                pay = Console.ReadLine();

                if (pay_or_shop == pay)
                {
                    Console.WriteLine($"The total cost were {cost} and you are left with {money} dollars");
                    money = 0;
                    Console.ReadLine();

                }

            }

            else
            {
                Console.WriteLine("You dont have enough money, would you like change how many you will buy?");
            }
        }


        else if (choice == "c")
        {
            cost = 10 * howManyNum;
            money -= cost;
            if (cost < money)
            {
                Console.WriteLine($"You have {money} dollars would you like to pay or contineu shopping ");
            }







            else
            {
                Console.WriteLine("You dont have enough money, would you like change how many you will buy?");
            }
        }






    }
    return choice;
}
