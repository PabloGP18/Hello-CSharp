// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, who are you?");
string? userName = Console.ReadLine();

Console.WriteLine($"Hello {userName}!");

while (true)
{
    Console.WriteLine("Do you want to play a game? (y/n)");
    string? response = Console.ReadLine();

    if (response == "y")
    {
        Console.WriteLine("yeaaahhhh!!!");
        int millisecondss = 1000;
        Thread.Sleep(millisecondss);

        Console.WriteLine("Let's play a game against monsters!");
        int millisecondsss = 1000;
        Thread.Sleep(millisecondsss);
        Console.WriteLine("Choose a character between the numbers: 1. Prohpet, 2. Warrior, 3. Priest");
        string? choose = Console.ReadLine();
        
        switch (choose)
        {
            case "1":
                int healtProphet = 10;
                int attackProphet = 7;
                int magicProphet = 8;
                Console.WriteLine($"Prohpet it is! You will have this stats: {healtProphet} healt, {attackProphet} attack and {magicProphet} of magic");
                break;
            
            case "2":
                int healtWarrior = 8;
                int attackWarrior = 10;
                int magicWarrior = 3;
                Console.WriteLine($"Yihaa you warrior!! You will have this stats: {healtWarrior} healt, {attackWarrior} attack and {magicWarrior} of magic");
                break;
            
            case "3":
                int healtPriest = 6;
                int attackPriest = 6;
                int magicPriest = 10;
                Console.WriteLine($"You will baptise everybode as a priest!!! You will have this stats: {healtPriest} healt, {attackPriest} attack and {magicPriest} of magic");
                break;
        }
        
        int playerWins = 0;
        

        int beastWins = 0;
        bool hasLost = false;
        
        do
        {
            Console.WriteLine("Choose a number between 0 and 1, you have 3 opportunities!");
            string? player = Console.ReadLine();
            
            Random rnd = new Random();
            int beast = rnd.Next(0, 2);
            string monster = beast.ToString();
            
            if (player == monster)
            {
                Console.WriteLine($"beast had number {beast}, you wone!");
                playerWins++;
                Console.WriteLine($"Player has: {playerWins} points.");

            }
            else if(player != monster)
            {
                Console.WriteLine($"beast had number {beast}, too bad!");
                beastWins++;
                Console.WriteLine($"Beast has: {beastWins} points.");
                
            }

            if ((playerWins == 3)||(beastWins == 3 ))
            {
                hasLost = true;
            }
            
        }
        while (!hasLost);
        
        break;
    }
    else if (response == "n")
    {
        Console.WriteLine("boeeeeeee");
        break;
    }
    else
    {
        Console.WriteLine("Please choose between yes (y) or no (n)!!!!");
        int milliseconds = 1000;
        Thread.Sleep(milliseconds);
    }
}





// string date = DateTime.Now.ToString("MM/dd/yyyy");
// int milliseconds = 2000;
// Thread.Sleep(milliseconds);
// Console.WriteLine(date);
