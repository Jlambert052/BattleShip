// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Game.Battleship Ship = new();

int[,] ints = new int[8,5] { {1, 2, 3, 4, 5}, {2, 3, 4, 5, 6}, {3, 4, 5, 6, 7}, {4, 5, 6, 7, 8}, {5, 6, 7, 8, 9}, {6, 7, 8, 9, 10}, {7, 8, 9, 10, 11}, {8, 9, 10, 11, 12} };
char[,] board = new char[8,8];

//Ship.DisplayInts(ints);

Ship.AssignBoard(board);

