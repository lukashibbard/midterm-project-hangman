// See https://aka.ms/new-console-template for more information
while (true)
{
    bool wordguessed = false;
    Random random = new Random();
    int lettersguessed = 0;
    int ig = 5;
    int rannum = random.Next(1, 10);
    Console.WriteLine("welcome to hangman if you would like to play please pick a catagory");
    Console.WriteLine("1) people");
    Console.WriteLine("2) places");
    Console.WriteLine("3) things");
    Console.Write("type here:");
    string word = "";
    string choice = Console.ReadLine() + "";
    string[] people = new string[] { "dale", "venom", "tom", "raien", "tim", "jon", "jerad", "aron", "cris", "tom", };
    string[] places = new string[] { "starbuck", "mcdonalds", "gamestop", "OTC", "arbys", "lostvagus", "cali", "mo", "truck", "whitevan", };
    string[] things = new string[] { "cup", "bag", "rock", "lamp", "sign", "card", "log", "computer", "moniter", "table", };
    List<string> inguess = new List<string>() { };
//line 4-18 made a random for the line picker it made the three arrays and a list for the incorrect guesses and gets what catagory th user wants
    switch (choice)
    {
        case "1":
            word = people[rannum];
            break;
        case "2":
            word = places[rannum];
            break;
        case "3":
            word = things[rannum];
            break;
    }
//line 20-31 picks the random depending on what the users selects 
    string wordlgdash = "";
    int wordlg = (word.Length);
    switch (wordlg)
    {
        case 3:
            wordlgdash = "---";
            break;
        case 4:
            wordlgdash = "----";
            break;
        case 5:
            wordlgdash = "-----";
            break;
        case 6:
            wordlgdash = "------";
            break;
        case 7:
            wordlgdash = "-------";
            break;
        case 8:
            wordlgdash = "--------";
            break;
        case 9:
            wordlgdash = "---------";
            break;
    }
//line 34-68 will make the dashes in the words by checking the length of the word
    string wordlgdash2 = wordlgdash;
    Console.WriteLine("i have made a choice from your selected catogory");
    do
    {
        if (ig == 0)
            {
                break;
            }
//line 61-68 tell the user that it has been selected and and if they run out of guesses it will break the loop at the start of it
        Console.WriteLine(wordlgdash2);
        bool ol = true;
        while (ol == true)
        {
            Console.Write("incorrect guesses:");
            foreach (string ingues in inguess)
            {
                Console.Write($"{ingues},");
            }
            Console.WriteLine($"you have {ig} incorrect guesses left");
            Console.Write("enter your guess here: ");
            string lg = Console.ReadLine() + "";
            int lgint = lg.Length;
//line 70-82 shows the user the incorrect guesses and takes the new guess
            switch (lgint)
            {
                case 1:
                    int index = word.IndexOf(lg);
                    if (index >= 0)
                    {
                        wordlgdash2 = wordlgdash.Remove(index, 1);
                        wordlgdash = wordlgdash2;
                        wordlgdash2 = wordlgdash.Insert(index, lg);
                        wordlgdash = wordlgdash2;
                        Console.WriteLine($"{lg} is a letter");
                        lettersguessed++;
                        if (lettersguessed == wordlg)
                        {
                            wordguessed = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{lg} is not a letter");
                        inguess.Insert(0, lg);
                        ig--;
                    }
                    ol = false;
                    break;

                case > 1:
                    Console.WriteLine("please type 1 letter");
                    break;
            }
        }
//line 84-14 check the letter in the word if its right it replaces the dash with it while if its false it will tell them its not a letter and subtract one from their incorrect guesses
    } while (wordguessed == false);
    if (lettersguessed == wordlg)
    {
        Console.WriteLine("you won yay!");
    }
    else
    {
        Console.WriteLine("you ran out of guesses oh noooo!");
    }
    Console.WriteLine("would you like to play again? y/n");
    string playagain = Console.ReadLine() + "";
    if (playagain == "n")
    {
        break;
    }
}
// the rest of the lines are used for the play again and end mechanic
