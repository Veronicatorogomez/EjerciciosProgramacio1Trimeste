using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;

namespace El_Ahorcao
{
    class Program
    {

        static void Main()
        {
            string[] words = new string[] { "friend", "love", "hard stuck", "flower", "kiss" };
            Random random = new Random();
            int randomNumber = random.Next(words.Length);
            string firstWord = words[randomNumber];
            int tries = 8;
            Start(firstWord, tries);
        }

        static string GenerateHiddenWord(string firstWord)
        {
            string hiddenWord = string.Empty;
            for (int i = 0; i < firstWord.Length; i++)
            {
                // hiddenWord += firstWord[i] == ' ' ? ' ' : '-';
                if (firstWord[i] == ' ')
                {
                    hiddenWord += ' ';
                }
                else
                {
                    hiddenWord += '-';
                }
            }
            return hiddenWord;
        }

        static string DiscoverLetter(string firstWord, char letter, string lastHiddenWord)
        {
            string hiddenWord = string.Empty;
            for (int i = 0; i < firstWord.Length; i++)
            {
                if (firstWord[i] == letter)
                {
                    hiddenWord += letter;
                }
                else
                {
                    hiddenWord += lastHiddenWord[i];
                }
                //lasthiddenWord me mantienes lo del ultimo caracter [(que seria un guion) o  si encuentra la letra la letra.]En este caso.

            }
            return hiddenWord;
        }
        static char GiveMeALetter()
        {
            Console.WriteLine("Enter a letter");
            string input = Console.ReadLine();
            char letter;
            try
            {
                letter = Convert.ToChar(input);
            }
            catch
            {
                letter = input[0];
            }
            return letter;
        }


        enum GameState { Win, Lose, Playing }
        static void Start(string firstWord, int tries)
        {
            GameState gameState = GameState.Playing;
            gameState = Play(firstWord, tries);
            if (gameState == GameState.Win)
            {
                Console.WriteLine("You Win");
            }
            else
            {

                Console.WriteLine("You Lose the correct word was = " + firstWord);
            }
        }
        static GameState Play(string firstWord, int tries)
        {
            char[] usedLetters = new char[tries];
            string hiddenWord = GenerateHiddenWord(firstWord);//guiones
            int errors = tries;
            for (int i = 0; i < tries;)
            {
                PrintResult(errors, usedLetters, hiddenWord);
                PrintHuman(errors);
                char letter = GiveMeALetter();
                if (firstWord.Contains(letter) == false) // bucle!!!! intenta tmbn se puede (!firstWord.Contains(letter)
                {
                    usedLetters[errors - 1] = letter;
                    // ponemos errors para que diga la posicion donde lo guardo y el -1 es xk array empieza de 0-7 y errors es 8; 
                    errors--;
                    i++;
                }
                usedLetters = SortAlphabetically(usedLetters);
                hiddenWord = DiscoverLetter(firstWord, letter, hiddenWord);
                if (hiddenWord == firstWord)
                {
                    return GameState.Win;
                }
            }
            Console.Clear();
            PrintResult(errors, usedLetters, hiddenWord);
            PrintHuman(errors);
            return GameState.Lose;
        }

        static char[] SortAlphabetically(char[] usedLetters)
        {
            char tidy;
            for (int i = 0; i < usedLetters.Length - 1; i++)
            {
                for (int j = 0; j < usedLetters.Length - 1; j++)
                {
                    if (usedLetters[j] > usedLetters[j + 1])// int es el numero ascii para el char usedletters[j]
                    {
                        tidy = usedLetters[j + 1];// tidy es ordenado
                        usedLetters[j + 1] = usedLetters[j];
                        usedLetters[j] = tidy;
                    }
                }
            }
            return usedLetters;
        }

        static void PrintHuman(int errors)
        {
            switch (errors)
            {
                case 8:
                    Console.WriteLine("-\n|\n|\n|\n|\n|\n---");
                    break;
                case 7:
                    Console.WriteLine("------\n|\n|\n|\n|\n|\n—--");
                    break;
                case 6:
                    Console.WriteLine("------\n|    |\n|\n|\n|\n|\n---");
                    break;
                case 5:
                    Console.WriteLine("------\n|    |\n|    O\n|\n|\n|\n---");
                    break;
                case 4:
                    Console.WriteLine("------\n|    |\n|    O\n|    |\n|\n|\n---");
                    break;
                case 3:
                    Console.WriteLine("------\n|    |\n|    O\n| *-/|\n|\n|\n---");
                    break;
                case 2:
                    Console.WriteLine("------\n|    |\n|    O\n| *-/|\\\n|\n|\n---");
                    break;
                case 1:
                    Console.WriteLine("------\n|    |\n|    O\n| *-/|\\\n|   /\n|\n---");
                    break;
                case 0:
                    Console.WriteLine("------\n|    |\n|    O\n| *-/|\\\n|   / \\\n|\n---");
                    break;

            }

        }
        static void PrintResult(int errors, char[] usedLetters, string hiddenWord)
        {
            //Array.Sort(usedLetters);
Console.Clear();
            Console.WriteLine("The word to guess: " + hiddenWord);
            Console.WriteLine("You have " + errors + " tries");
            Console.WriteLine("You have used: " + string.Join(", ", usedLetters));

        }
    }
}


