using System;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace LocalizaRato
{
    class Program
    {
        private static readonly string TextDivider = new String( '#',
            60 );

        private static readonly string Text1 =
            $"Resolution: {Screen.PrimaryScreen.Bounds.Width}x{Screen.PrimaryScreen.Bounds.Height}";

        private static readonly string Text2 =
            $"Scalling: {(float) (Screen.PrimaryScreen.Bounds.Width / SystemParameters.PrimaryScreenWidth) * 100}%";

        private static readonly string Text3 = "Press the Spacebar to end the program";
        private static readonly string Text4 = "Made by ltfavas";

        static void Main()
        {

            Info( 1 );

            Thread.Sleep(2000);

            do
            {
                while (!Console.KeyAvailable)
                {
                    ShowPosition();
                    Thread.Sleep(13);
                }
            } while (Console.ReadKey( true ).Key != ConsoleKey.Spacebar);

            Info( 2 );
            Thread.Sleep(1500);
        }

        public static void Info( int id )
        {
            if (id == 1)
            {
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (TextDivider.Length / 2)) + "}",
                    TextDivider );
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (Text1.Length / 2)) + "}",
                    Text1 );
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (Text2.Length / 2)) + "}",
                    Text2 );
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (TextDivider.Length / 2)) + "}",
                    TextDivider );
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (Text3.Length / 2)) + "}",
                    Text3 );
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (TextDivider.Length / 2)) + "}",
                    TextDivider );
            }
            else
            {
                Console.Clear();
                Thread.Sleep( 200 );
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (TextDivider.Length / 2)) + "}",
                    TextDivider );
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (Text4.Length / 2)) + "}",
                    Text4 );
                Console.WriteLine();
                Console.WriteLine( "{0," + ((Console.WindowWidth / 2) + (TextDivider.Length / 2)) + "}",
                    TextDivider );
            }
        }

        public static void ShowPosition()
        {
            var x = Cursor.Position;
            Console.WriteLine($" x: {x.X} | y : {x.Y}");
        }
    }
}
