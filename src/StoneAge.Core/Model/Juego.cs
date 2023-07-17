using System.Collections.Generic;
using System.Linq;

namespace StoneAge.Core.Model
{
    public class Juego
    {
        public List<Jugador> Jugadores { get; set; }
        public int Turno { get; set; }

        public Juego(string[] names)
        {
            foreach (string name in names)
                Jugadores.Add(new Jugador(name));
            Reset();
        }

        public void Reset()
        {
            foreach (var item in Jugadores)
                item.Reset();
            Turno = 0;
        }

        public Jugador ElTurno() => Jugadores[Turno];

        public void AccionesAutomaticas()
        {
            foreach (Jugador jug in Jugadores)
            {
                foreach (var accion in jug.TribuJugador.Acciones.Where(x=> !x.RequiereDados))
                    accion.RealizacionAccion(this);
            }
        }
    }
}
