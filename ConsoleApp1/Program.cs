// See https://aka.ms/new-console-template for more information
/*
*/
using ConsoleApp1;

//Juego game = new Juego.Instance;
Console.WriteLine("Esta es la misma instancia" + (Juego.Instance == Juego.Instance));
Juego.Instance.OnPlay();

