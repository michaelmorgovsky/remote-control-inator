using System;
using System.Runtime.InteropServices;

namespace Program
{
    public class Mouse
    {
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        public void SetPosition(int a, int b)
        {
            SetCursorPos(a, b);
        }

        
    }

    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Inside Program");

            var Mouse = new Mouse();
            int x = 0;
            int y = 0;
            int k = 0;
            while (k < 400)
            {
                if (k < 100)
                {
                    x++;
                }
                else if (k < 200)
                {
                    y++;
                }
                else if (k < 300)
                {
                    x--;
                }
                else
                {
                    y--;
                }
                k++;
                Thread.Sleep(1);
                Mouse.SetPosition(x, y);
            }
        }
    }

}