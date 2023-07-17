using StoneAge.Core.Model.Acciones;
using System.Collections.Generic;

namespace StoneAge.Core.Model
{
    public class Tribu
    {
        public int Maximo { get; private set; }
        public int Disponibles { get; private set; }
        public List<IAccion> Acciones { get; private set;}

        public Tribu()
        {
            Maximo = 5;
            Reset();
        }

        public void NuevoMiembro() => Maximo = Maximo < 10 ? Maximo + 1 : 10;

        public void Reset()
        {
            Disponibles = Maximo;
            Acciones = new List<IAccion>();
        }

        public void NuevaAccion(IAccion accion) => Acciones.Add(accion);

        public override string ToString() => $"{Disponibles}/{Maximo}";
    }
}
