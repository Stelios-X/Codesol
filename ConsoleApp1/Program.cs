﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleApp1;

/*var account = new BankAccount("Brandon", 556672);
Console.WriteLine($"Account Number {account.Number} was specifically created for the one and only {account.Owner} with a registered initial balance of {account.Balance}");
/*var account = new BankAccount("Brandon1", 556);
Console.WriteLine($"Account Number {account.Number} was specifically created for {account.Owner} with an initial balance of {account.Balance}");*/

/*var myaccount = new BankAccount("Sir Angote", 777444);
Console.WriteLine($"The Account Number {myaccount.Number} was exclusively created for {myaccount.Owner} with a registered initial balance of {myaccount.Balance}");*/

//Testing the in-biult binary search

//Array in question
//int[] mainArr = {9,8,7,6,5,4,3,2,1};

//Array.Sort(mainArr);

//Implemenatation of binary search, the method returns the index
//int number  = Array.BinarySearch(mainArr, 2);
//Console.Write("The index in question is "+number);


//Testing the Stock class

int[] prices = { 7, 1, 5, 3, 6, 4 };
Stock stock = new Stock();
stock.MaxProfit(prices);
int[] arr1 = {25,42,-31,12,55,-20,-18,-48,16,34 };

int[] arr3 = {1, 2, 3, 14, 7, 10};

int[] arr_a = { 1, 5, 3, 8 };
int[] arr_b = { 5, 4, 3, 7 };

int[] sb_arr = {7,1,5,3,6,4};
//int[] arr_a = { 6, 2, 3, 4 };
//int[] arr_b = { 4, 5, 4, 4 };

 


Delta mydel = new Delta();

mydel.StockBroke(sb_arr);

/*
Summation summation = new Summation();
summation.Two_sum_zero_solution(arr, 6);*/
