using System;
using System.IO;
using System.Collections.Generic;

namespace ProgramForCourseWithMenu
{
    class Program
    {
        static void Main()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            //printa ut en meny
            Console.Clear();
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1.  Hello World!");
            Console.WriteLine("2.  Namn och ålder.");
            Console.WriteLine("3.  Byt färg.");
            Console.WriteLine("4.  Dagens datum.");
            Console.WriteLine("5.  Vilket tal är störst ?");
            Console.WriteLine("6.  Gissa Nummret!");
            Console.WriteLine("7.  Skriv text till en fil.");
            Console.WriteLine("8.  Läs text från en fil.");
            Console.WriteLine("9.  Roten ur, upphöjt till 2 och upphöjt till 10.");
            Console.WriteLine("10. Multiplikationstabell.");
            Console.WriteLine("11. 2 Arrays");
            Console.WriteLine("12. Palindrom");
            Console.WriteLine("13. Från x till y.");
            Console.WriteLine("14. Udda och jämna tal.");
            Console.WriteLine("15. Addera tal");
            Console.WriteLine("16. BarFight v0.1");
            Console.WriteLine("0. Avsluta");
            Console.Write("\r\nDitt val: ");

            // få input och utför motsvarande instruktioner
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Hello World!");
                    Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    return true;
                case "2":
                    NameAndAge();
                    return true;
                case "3":
                    //om färgen är grå(default), byt till grön. Om inte grå sätt färgen till grå
                    if (Console.ForegroundColor == ConsoleColor.Gray)
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    else
                        Console.ForegroundColor = ConsoleColor.Gray;
                    return true;
                case "4":
                    Console.Clear();
                    DateTime today = DateTime.Now;
                    Console.WriteLine(today);
                    Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    return true;
                case "5":
                    LargestNumber();
                    return true;
                case "6":
                    GuessTheNumber();
                    return true;
                case "7":
                    WriteToFile();
                    return true;
                case "8":
                    ReadFromFile();
                    return true;
                case "9":
                    SquareRoot();
                    return true;
                case "10":
                    Multiplication();
                    return true;
                case "11":
                    SortedRandom();
                    return true;
                case "12":
                    IsPalindrome();
                    return true;
                case "13":
                    FromXToY();
                    return true;
                case "14":
                    OddEvenSort();
                    return true;
                case "15":
                    Addition();
                    return true;
                case "16":
                    BarFight();
                    return true;
                case "0":
                    //Avsluta program
                    return false;
                default:
                    return true;
            }
        }
        private static void NameAndAge()
        {
            string fName, lName, age;
            Console.Clear();
            Console.WriteLine("Förnamn: ");
            fName = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            lName = Console.ReadLine();
            Console.WriteLine("Ålder: ");
            age = Console.ReadLine();
            Console.WriteLine(fName + " " + lName + ", " + age);
            Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        private static void LargestNumber()
        {
            string input;
            int number1, number2;
            bool isParsable, run = true;
            bool inputCorrect = false;

            Console.Clear();
            do
            {
                do
                {

                    Console.WriteLine("Skriv in ett heltal");
                    input = Console.ReadLine();

                    //konvertera till integer samt kolla att det är en siffra som matats in, om det inte är en siffra visa felmeddelande och vänta på ny input
                    isParsable = Int32.TryParse(input, out number1);
                    if (isParsable)
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Måste vara ett nummer, heltal.");
                        inputCorrect = false;
                    }
                }
                while (inputCorrect == false);

                inputCorrect = false;
                do
                {

                    Console.WriteLine("Skriv in ett till heltal");
                    input = Console.ReadLine();

                    isParsable = Int32.TryParse(input, out number2);
                    if (isParsable)
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Måste vara ett nummer, heltal.");
                        inputCorrect = false;
                    }
                }
                while (inputCorrect == false);

                if (number1 > number2)
                {
                    Console.WriteLine("Första nummret är störst.");
                    Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    run = false;
                }
                else if (number1 == number2)
                {
                    Console.WriteLine("Båda nummer är lika stora.");
                    Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    run = false;
                }
                else
                {
                    Console.WriteLine("Andra nummret är störst.");
                    Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    run = false;
                }

            }
            while (run == true);
        }
        private static void GuessTheNumber()
        {
            int randomNumber, guess, numberOfGuesses = 1;
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 101);
            bool guessedRight = false, isParsable, inputCorrect;
            string input;

            Console.Clear();
            Console.WriteLine("Gissa nummret!");
            do
            {

                do
                {
                    Console.WriteLine("Skriv in ett heltal från 1 till 100 " /*+ randomNumber.ToString()*/);
                    input = Console.ReadLine();

                    isParsable = Int32.TryParse(input, out guess);
                    if (isParsable)
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Måste vara ett nummer, heltal.");
                        inputCorrect = false;
                    }
                }
                while (inputCorrect == false);

                if (guess == randomNumber)
                {
                    Console.WriteLine("Du gissade rätt!");
                    Console.WriteLine("Antal gissningar:" + numberOfGuesses.ToString());
                    Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    guessedRight = true;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Du gissade för högt! Försök igen...");
                    numberOfGuesses++;
                }
                else
                {
                    Console.WriteLine("Du gissade för lågt! Försök igen...");
                    numberOfGuesses++;
                }

            }
            while (guessedRight == false);
        }
        private static void WriteToFile()
        {
            string text, filename, path;


            //funkar inte att skriva egen sökväg
            Console.Clear();
            Console.WriteLine("Skriv in namnet på textfilen du vill skapa, utan filtyp. det kommer sparas som .txt på skrivbordet");
            filename = Console.ReadLine();
            filename = filename + ".txt";
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename);
            Console.WriteLine(filename);
            /*Console.WriteLine("välj 1 för att specificera sökväg till filen, tryck enter för att spara på skrivbordet."); 
            switch (Console.ReadLine())
            {
                case "1":
                    path = Console.ReadLine();
                    break;
                default:
                    path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename);
                    break;
            }*/


            Console.WriteLine("Skriv en rad som kommer sparas till en fil...");
            text = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine(text);
            }

            Console.WriteLine("Sparat i filen " + filename);
            Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        private static void ReadFromFile()
        {
            string filename, path;


            Console.Clear();
            Console.WriteLine("Skriv in namnet på textfilen du vill öppna, inklusive filtyp (.txt)");
            filename = Console.ReadLine();
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename);
            //funkar inte att skriva egen sökväg 
            Console.WriteLine(filename);
            /*Console.WriteLine("välj 1 för att specificera sökväg till filen, tryck enter för att öppna från skrivbordet.");
            switch (Console.ReadLine())
            {
                case "1":
                    path = Console.ReadLine();
                    break;
                default:
                    path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename);
                    break;
            }*/
            Console.WriteLine(path);

            //försök öppna en fil, om det går skriv ut innehållet
            try
            {

                using (StreamReader inputFile = new StreamReader(path))
                {
                    Console.WriteLine(inputFile.ReadToEnd());
                }
                Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                Console.ReadLine();

            }
            //om det blir något fel visa felmeddelande
            catch (FileNotFoundException)
            {
                Console.WriteLine("Det finns ingen fil, gå tillbaka för att skapa en...");
                Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                Console.ReadLine();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Mappen går inte att hitta...");
                Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                Console.ReadLine();
            }
            catch (IOException)
            {
                Console.WriteLine("Filen går inte att öppna...");
                Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
                Console.ReadLine();
            }

        }
        private static void SquareRoot()
        {
            double x;
            string input;
            bool isParsable, inputCorrect;
            Console.Clear();

            do
            {
                Console.WriteLine("Skriv in ett decimaltal ");
                input = Console.ReadLine();
                isParsable = double.TryParse(input, out x);
                if (isParsable)
                {
                    inputCorrect = true;
                }
                else
                {
                    Console.WriteLine("Måste vara ett nummer");
                    inputCorrect = false;
                }
            }
            while (inputCorrect == false);

            Console.WriteLine("input:\t\t\t" + x);
            Console.WriteLine("Roten ur:\t\t" + Math.Sqrt(x).ToString());
            Console.WriteLine("Upphöjt till 2:\t\t" + Math.Pow(x, 2).ToString());
            Console.WriteLine("Upphöjt till 10:\t" + Math.Pow(x, 10).ToString());
            Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        private static void Multiplication()
        {
            Console.Clear();
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                    Console.Write(i * j + "\t");
                Console.WriteLine("\r");
            }

            Console.WriteLine("Tryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();

        }
        private static void SortedRandom()
        {
            int[] randomNumbers = new int[25];
            int[] sortedNumbers = new int[25];
            int temp;
            Random rnd = new Random();

            for (int i = 0; i < 25; i++)
            {
                randomNumbers[i] = rnd.Next(1, 100);
            }
            /*for (int i = 0; i < 25; i++)
            {
                sortedNumbers[i] = randomNumbers[i];
            }*/
            randomNumbers.CopyTo(sortedNumbers, 0);


            for (int j = 0; j <= 23; j++)
            {
                for (int i = 0; i <= 23; i++)
                {
                    if (sortedNumbers[i] > sortedNumbers[i + 1])
                    {
                        temp = sortedNumbers[i + 1];
                        sortedNumbers[i + 1] = sortedNumbers[i];
                        sortedNumbers[i] = temp;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Randomiserade tal:");

            foreach (int number in randomNumbers)
            {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Sorterade Tal:");
            foreach (int number in sortedNumbers)
            {
                Console.Write(number.ToString() + " ");
            }

            Console.WriteLine("\nTryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        private static void IsPalindrome()
        {

            string inputString, reverseString;

            Console.Clear();
            Console.WriteLine("Skriv ett ord för att testa om det är ett palindrom");
            inputString = Console.ReadLine();

            char[] r = inputString.ToCharArray();
            Array.Reverse(r);
            reverseString = new string(r);

            bool isPalindrome = inputString.Equals(reverseString, StringComparison.OrdinalIgnoreCase);

            if (isPalindrome == true)
            {
                Console.WriteLine(inputString + " är ett palindrom!");
            }
            else
            {
                Console.WriteLine(inputString + " är inte ett palindrom");
            }

            Console.WriteLine("\nTryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();

        }
        private static void FromXToY()
        {
            int x, y, i;
            string input;
            bool inputCorrect, isParsable;

            Console.Clear();
            Console.WriteLine("Mata in två tal och få utskrivet alla tal mellan dem.");

            do
            {
                Console.WriteLine("Tal 1: ");
                input = Console.ReadLine();
                isParsable = Int32.TryParse(input, out x);
                if (isParsable)
                {
                    inputCorrect = true;
                }
                else
                {
                    Console.WriteLine("Måste vara ett nummer");
                    inputCorrect = false;
                }
            }
            while (inputCorrect == false);
            do
            {
                Console.WriteLine("Tal 2: ");
                input = Console.ReadLine();

                //isParsable = double.TryParse(input, out guess);
                isParsable = Int32.TryParse(input, out y);
                if (isParsable)
                {
                    inputCorrect = true;
                }
                else
                {
                    Console.WriteLine("Måste vara ett nummer");
                    inputCorrect = false;
                }
            }
            while (inputCorrect == false);

            for (i = x; i <= y; i++)
                Console.Write(i.ToString() + " ");

            Console.WriteLine("\nTryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        private static void OddEvenSort()
        {
            string input;
            int temp;
            bool isParsable;

            List<int> listOfNumbers = new List<int>();
            List<int> listOfOddNumbers = new List<int>();
            List<int> listOfEvenNumbers = new List<int>();

            Console.Clear();
            Console.WriteLine("Mata in heltal separerade med kommatecken:");
            input = Console.ReadLine();
            string[] values = input.Split(',');
            foreach (string numberString in values)
            {
                isParsable = false;
                isParsable = Int32.TryParse(numberString, out temp);
                if (isParsable == true)
                {
                    listOfNumbers.Add(temp);
                }
            }

            listOfNumbers.Sort();
            foreach (int number in listOfNumbers)
            {
                temp = number % 2;
                if (temp == 0)
                    listOfEvenNumbers.Add(number);
                else
                    listOfOddNumbers.Add(number);
            }
            Console.WriteLine("Jämna nummer:");
            foreach (int number in listOfEvenNumbers)
                Console.WriteLine(number);

            Console.WriteLine("Ojämna nummer:");
            foreach (int number in listOfOddNumbers)
                Console.WriteLine(number);

            Console.WriteLine("\nTryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        private static void Addition()
        {
            string input;
            int total = 0, temp;
            bool isParsable;

            List<int> listOfNumbers = new List<int>();

            Console.Clear();
            Console.WriteLine("Mata in heltal separerade med kommatecken:");
            input = Console.ReadLine();
            string[] values = input.Split(',');
            foreach (string numberString in values)
            {
                isParsable = false;
                isParsable = Int32.TryParse(numberString, out temp);
                if (isParsable == true)
                {
                    listOfNumbers.Add(temp);
                }
            }

            foreach (int number in listOfNumbers)
                total += number;


            Console.WriteLine("Summan av talen är: " + total.ToString());

            Console.WriteLine("\nTryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        private static void BarFight()
        {
            string name;
            Console.Clear();

            Console.WriteLine("Hjältens namn:");
            name = Console.ReadLine();
            var player = new Fighter(name);
            Console.WriteLine($"Namn{ player.name} HP{player.health} Luck{player.luck} Styrka{player.strength}");

            Console.WriteLine("Fiendens namn:");
            name = Console.ReadLine();
            var enemy = new Fighter(name);
            Console.WriteLine($"Namn{ enemy.name} HP{enemy.health} Luck{enemy.luck} Styrka{enemy.strength}");
            bool battle = true;

            do
            {
                Console.WriteLine("Fienden attackerar!");
                player.health = player.health - (enemy.strength + enemy.luck);

                enemy.health = enemy.health - (player.strength + player.luck);

                if (player.health <= 0)
                {
                    battle = false;
                    Console.WriteLine("Vinnaren är " + enemy.name);
                }
                else if (enemy.health <= 0)
                {
                    battle = false;
                    Console.WriteLine("Vinnaren är " + player.name);
                }
                else
                    battle = true;

            }
            while (battle == true);
            Console.WriteLine("\nTryck enter för att gå tillbaka till menyn.");
            Console.ReadLine();
        }
        public class Fighter
        {
            public string name { get; set; }
            public int health { get; set; }
            public int luck { get; }
            public int strength { get; }

            Random rnd = new Random();

            public Fighter(string n)
            {
                Random rnd = new Random();
                this.name = n;
                this.health = rnd.Next(50, 75);
                this.luck = rnd.Next(1, 5);
                this.strength = rnd.Next(1, 20);
            }

        }

    }
}