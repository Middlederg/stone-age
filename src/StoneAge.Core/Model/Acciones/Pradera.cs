namespace StoneAge.Core.Model.Acciones
{
    public class Pradera : IAccion
    {
        private int ocupados;

        public Pradera(Recurso recurso)
        {
            Reset();
        }
        public void Reset() => ocupados = 0;
        public int Disponibles { get => Maximo - ocupados; }
        public int Maximo => 40;
        public int Requeridos => 1;
        public bool RequiereDados => true;

        public bool PuedeColocarPersona(Juego game, int numPersonas)
        {
            throw new System.NotImplementedException();
        }

        public void RealizacionAccion(Juego game)
        {
            throw new System.NotImplementedException();
        }
    }
}
