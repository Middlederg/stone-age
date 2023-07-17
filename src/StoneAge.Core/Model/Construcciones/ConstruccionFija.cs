using System.Collections.Generic;
using System.Linq;

namespace StoneAge.Core.Model.Construcciones
{
    public class ConstruccionFija : IConstruccion
    {
        public TipoConstruccion Tipo => TipoConstruccion.Fija;
        public List<Recurso> Recursos { get; set; }

        public ConstruccionFija(List<Recurso> recursos)
        {
            Recursos = recursos;
        }
        public int PuntosVictoria() => Recursos.Select(x => (int)x.Material).Sum();

        public bool RecurosSirven(List<Recurso> recursos)
            => recursos.OrderBy(x => x.Material).SequenceEqual(Recursos.OrderBy(x => x.Material));
    }
}