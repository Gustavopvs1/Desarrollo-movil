using PingPong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablero : iGameObject
    {
        public int Ancho { get; set; } = 60;

        public int Alto { get; set; } = 20;

        public Pelota Pelota { get; set; }
        public Tablero(Pelota pelota) {
            Pelota = pelota;
        }

        public Tablero()
        {
        }

        public void OnDraw()
        {
            for (int i = 0; i < Ancho; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("_");
                Console.SetCursorPosition(i, Alto);
                Console.Write("_");
            }
            for (int i = 0; i < Alto; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(Ancho, i);
                Console.Write("|");
            }
        }
    }
}
