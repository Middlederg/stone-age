using StoneAge.Core.Model.Construcciones;
using System.Collections.Generic;

namespace StoneAge.Core.Model
{
    public class Jugador
    {
        private string nombre;

        public int Agricultura { get; set; }
        public List<Recurso> Recursos { get; set; }
        public int Comida { get; set; }
        public Tribu TribuJugador { get; set; }
        public int Puntos { get; set; }
        public Tools Herramientas { get; set; }
        public List<int> HerramientasExtras { get; set; }
        public List<IConstruccion> Construcciones { get; set; }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            Reset();
        }

        public void Reset()
        {
            Agricultura = 0;
            Comida = 12;
            Recursos = new List<Recurso>();
            TribuJugador = new Tribu();
            Puntos = 0;
            Herramientas = new Tools();
            HerramientasExtras = new List<int>();
        }

        public void FinRonda()
        {
            TribuJugador.Reset();
        }

        public override string ToString() => nombre;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Jugador)obj).nombre.Equals(nombre);
        }

        public override int GetHashCode() => nombre.GetHashCode();
    }
}
