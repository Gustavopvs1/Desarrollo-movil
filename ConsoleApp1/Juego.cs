using System;
using System.Threading;

namespace ConsoleApp1
{
    public class Juego
    {
        private Tablero tablero;
        private Pelota pelota;
        private Jugador jugadorA;
        private Jugador jugadorB;

        private static Juego? _instance;
        public static Juego Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance ??= new Juego();
                }
                return _instance;
            }
            private set { }
        }

        public Juego()
        {
            jugadorA = new Jugador();
            jugadorB = new Jugador();
            pelota = new Pelota();
            tablero = new Tablero();
            pelota.Source = "o";
            jugadorA.Source = "|";
            jugadorB.Source = "|";
            jugadorA.Positionx = 1;
            jugadorA.Positiony = tablero.Alto / 2;
            jugadorB.Positionx = tablero.Ancho - 1;
            jugadorB.Positiony = tablero.Alto / 2;
            Console.CursorVisible = false;
        }

        public void OnPlay()
        {
            int velocidadx = 1;
            int velocidady = 1;

            while (true)
            {
                tablero.OnDraw();
                Console.SetCursorPosition(jugadorA.Positionx, jugadorA.Positiony);
                Console.Write(jugadorA.Source);
                Console.SetCursorPosition(jugadorB.Positionx, jugadorB.Positiony);
                Console.Write(jugadorB.Source);
                Console.SetCursorPosition(pelota.PositionX, pelota.PositionY);
                Console.Write(pelota.Source);

                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.W:
                            if (jugadorA.Positiony > 0) 
                                jugadorA.Positiony--;
                            break;
                        case ConsoleKey.S:
                            if (jugadorA.Positiony < tablero.Alto - 1) 
                                jugadorA.Positiony++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (jugadorB.Positiony > 0) 
                                jugadorB.Positiony--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (jugadorB.Positiony < tablero.Alto - 1)
                                jugadorB.Positiony++;
                            break;
                    }
                }

                pelota.PositionX += velocidadx;
                pelota.PositionY += velocidady;

                
                if (pelota.PositionX >= tablero.Ancho - 1 || pelota.PositionX <= 0)
                    velocidadx *= -1;
                if (pelota.PositionY >= tablero.Alto - 1 || pelota.PositionY <= 0)
                    velocidady *= -1;

                Thread.Sleep(100);
                Console.Clear();
            }
        }

        public void OnPause()
        {
            // Lógica de pausa si es necesario
        }

        public void OnResume()
        {
            // Lógica de reanudación si es necesario
        }
    }
}
