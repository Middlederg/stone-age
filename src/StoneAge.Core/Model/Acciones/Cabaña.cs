
namespace StoneAge.Core.Model.Acciones
{
    public class Cabaña : IAccion
    {
        private int ocupados;

        public Cabaña() { Reset(); }
        public void Reset() => ocupados = 0;

        public int Disponibles { get => Maximo - ocupados; }
        public int Maximo => 2;
        public int Requeridos => 2;
        public bool RequiereDados => false;

        public bool PuedeColocarPersona(Juego game, int numPersonas)
        {
            throw new System.NotImplementedException();
        }

        public void RealizacionAccion(Juego game) => game.ElTurno().TribuJugador.NuevoMiembro();
        
    }
}
