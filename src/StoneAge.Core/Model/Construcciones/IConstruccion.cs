using System.Collections.Generic;

namespace StoneAge.Core.Model.Construcciones
{
    public interface IConstruccion
    {
        TipoConstruccion Tipo { get; }
        int PuntosVictoria();
        bool RecurosSirven(List<Recurso> recursos);
    }
}