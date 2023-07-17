namespace StoneAge.Core.Model.Acciones
{
    public class FuenteRecurso : IAccion
    {
        private int ocupados;

        public FuenteRecurso(Recurso recurso)
        {
            TipoRecurso = recurso;
            Reset();
        }
        public void Reset() => ocupados = 0;
        public Recurso TipoRecurso { get; private set; }
        public int Disponibles { get => Maximo - ocupados; }
        public int Maximo => 7;
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
