namespace StoneAge.Core.Model.Acciones
{
    public class CartaCivilizacion : IAccion
    {
        private int ocupados;

        public CartaCivilizacion(TipoCarta carta)
        {
            Carta = carta;
            Reset();
        }
        public void Reset() => ocupados = 0;
        public TipoCarta Carta { get; private set; }
        public int Disponibles { get => Maximo - ocupados; }
        public int Maximo => 1;
        public int Requeridos => 1;
        public bool RequiereDados => Carta.RequiereDados();

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
