using System;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Black;

            //Console.Clear();
            Console.Write("letra da musica: ");
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("Go The kid Laroi, ");
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Black;

            
            Console.WriteLine("precione enter para continuar...");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("------------------");

            string refletraA = "Go go go She always be \ntalking like she know know know \nI told her dont ever leave me lone lone lone \nI guess Im accident prone prone prone\nProne prone prone oh \nGo go go\nShe always be talking like she know know know\nI told her dont ever leave me lone lone lone\nI guess Im accident prone prone prone\nProne prone prone oh,";
            string letraB = "I don't know no better (I don't)\nI just wan' get into things, I just want mine better (nah)\nYou fuck up my brain, you don't know no better, yeah (okay)\nWish I knew you better, shit, but I don't know no better\nSo I keep doing what I know best, yeah\nYou're really good at fucking with me, girl, I'll give it to you (I will)\nBut I am out here doing this for me and not for you\nI done fucked around and got attached, damn, I'm so with you\nI don't know what to do, I don't know what to";
            string letraC = "And I should slide for youAnd that's my biggest problem, in denial 'bout you\nTonight, I'll go open up the night for you\nProbably die for you, fuck around and lie for you\nProbably cry for you";
            //string refletraA dnv
            string letraD = "Woah, woah, woah\nPerky with the lean, it got me slow, slow, slow\nAnd yeah, I know I made a few mistakes before\nBut you know I ain't fucking with these hoes no more\nWon't let go, I'm the type to show you that you're too special\nPlease don't be the type to hate the things I do\nAnd I'll ride for you, and I'll die for you\nHomicide for you";
            string letraE = "And I should slide for you\nAnd that's my biggest problem, in denial 'bout you\nTonight, I'll go open up the night for you\nProbably die for you, fuck around and lie for you\nProbably cry for you";
            string final = "Okay, go, go, go\nShe always be talking like she know, know, know\nI told her don't ever leave me 'lone, 'lone, 'lone\nI guess I'm accident-prone, prone, prone\nProne, prone, prone, oh\nGo, go, go";
            string final2 = "She always be talking like she know, know, know\nI told her don't ever leave me 'lone, 'lone, 'lone\nI guess I'm accident-prone, prone, prone\nProne, prone, prone, oh";

            string nmjuice = "[Juice WRLD]";
            string nmkid = "[The Kid LAROI]";

            Console.ResetColor();
            Console.WriteLine("(Refrão)");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($" {nmkid}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine($" {refletraA}");        
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;

            
            Console.WriteLine($" {letraB}");
            Console.WriteLine("");
            Console.WriteLine($" {letraC}");
            Console.WriteLine("");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.White;
            
            Console.WriteLine($" {refletraA}");


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(""); //espaço
            Console.WriteLine($" {nmjuice}");
            //Console.WriteLine(""); //espaço
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine($" {letraD}");
            
            Console.WriteLine(""); //espaço
            Console.WriteLine($" {nmkid}");
            //Console.WriteLine(""); //espaço

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine($" {letraE}");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($" {nmjuice} &");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" {nmkid}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" {final}");
            Console.WriteLine(""); //espaço
            Console.WriteLine($" {final2}");

            Console.WriteLine(" "); //espaço
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
            
            Console.Clear();
            Console.ResetColor();
        }
    }
}
//mdsss 112 linhas ja são 1:38 am =) 