namespace StoneAge.Core.Model.Acciones
{
    public class FabricanteHerramientas : IAccion
    {
        private int ocupados;

        public FabricanteHerramientas(){ Reset(); }
        public void Reset() => ocupados = 0;

        public int Disponibles { get => Maximo - ocupados; }
        public int Maximo => 1;
        public int Requeridos => 1;
        public bool RequiereDados => false;

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
