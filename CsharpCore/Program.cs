// See https://aka.ms/new-console-template for more information
using CsharpCore.Linkq;

Console.WriteLine("Hello, World!");
LocalVersiouShareState localVersiouShareState = new LocalVersiouShareState();
//localVersiouShareState.Local();

new Thread(() =>
{
    Console.WriteLine("I'm running on another thread!");
    Console.WriteLine("This is so easy!");
}).Start();

AsynAwaitPrograming asynAwaitPrograming = new AsynAwaitPrograming();
Console.WriteLine(asynAwaitPrograming.GetPrimesCountAsync(5,50) + "");