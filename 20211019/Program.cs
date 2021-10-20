using System;


//string choice = "";
//int a = 16;
//int b = 8;
//int c= 10;



Console.WriteLine("You have 100 dollars and you would like to buy a) Pepsi bottle (16kr), b) Choaklad bar (8kr) and c) gummy bears (10kr)");

string vara = GetAnswer();

static string GetAnswer()
{
    string choice = "";
    string how_many = "";
    int money = 100;
    while (choice != "a" && choice != "b" && choice != "c")
    {
        choice = Console.ReadLine();
        choice = choice.ToLower();
        Console.WriteLine("How many would you like to buy?");
        how_many = Console.ReadLine();
        int howManyNum = 0;
        int choiceNum = 0;
        int.TryParse(how_many, out howManyNum);
        int.TryParse(choice, out choiceNum); 

        money -= (choiceNum * howManyNum);

if (money > 0){
Console.WriteLine("Would you like to continue shopping or pay for what you have?");


}

else
{
    Console.WriteLine("You don´t have enough money");
}

    }
    return choice;
}
