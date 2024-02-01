﻿using System.Runtime.InteropServices;
using Mission4Assignment;

TicTacTools ttt = new TicTacTools();

string player1 = "";
string player2 = "";
int playerTurn = 0;
string playerName = "";
string token = "";
bool isContinuing = true;
string[] game = new string[9];
int position = 0;

for (int i = 0; i < game.Length; i++)
{
    game[i] = " ";
}

Console.WriteLine("Welcome to our tic tac toe game!");
Console.WriteLine("Loading the playing field");
Thread.Sleep(300);
Console.WriteLine(".");
Thread.Sleep(300);
Console.WriteLine(".");
Thread.Sleep(300);
Console.WriteLine(".");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("This is the tic tac toe position layout for reference");
Console.WriteLine();
string completeBoard = $" 1 | 2 | 3\n" +
               $" ---------\n" +
               $" 4 | 5 | 6\n" +
               $" ---------\n" +
               $" 7 | 8 | 9\n";

Console.WriteLine(completeBoard);
Console.WriteLine();


Console.WriteLine("Please enter player 1's name: ");
player1 = Console.ReadLine();
Console.WriteLine("Please enter player 2's name: ");
player2 = Console.ReadLine();  

for (int i = 0; i < game.Length; i++)
{
    if (playerTurn == 0)
    {
        playerName = player1;
        token = "X";
    }
    if (playerTurn == 1)
    {
        playerName = player2;
        token = "O";
    }

    while (isContinuing)
    {
        Console.WriteLine($"{playerName}, please enter the position number you would like: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out position))
        {
            isContinuing = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    isContinuing = true;
    game[position - 1] = token;
    Console.WriteLine(ttt.UpdatePrintBoard(game));
    
    if (playerTurn == 0)
    {
        playerTurn = 1;
    }
    else
    {
        playerTurn = 0;
    }
}
