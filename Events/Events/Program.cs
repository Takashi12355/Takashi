using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new KeyBoard();
            key.Run();
        }
        public class KeyBoard
        {
            public event EventHandler<char> OnKeyPressed;
            public void Run()
            {
                char input;
                do
                {
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    OnKeyPressed?.Invoke(this, input);
                }
                while (input != 'c');
            }
        }
    }
}
