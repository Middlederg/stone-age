using System.Collections.Generic;
using System.Linq;

namespace StoneAge.Core.Model.Construcciones
{
    public class ConstruccionVariable : IConstruccion
    {
        public TipoConstruccion Tipo => TipoConstruccion.Variable;
        public List<Recurso> Recursos { get; set; }
        int numRecursosMin;
        int numRecurosMax;
        bool requiereNumTipoExacto;
        int numTipoExacto;

        public ConstruccionVariable(int numRecursosMin, int numRecurosMax, bool requiereNumTipoExacto = false, int numTipoExacto = 0)
        {
            Recursos = new List<Recurso>();
            this.numRecursosMin = numRecursosMin;
            this.numRecurosMax = numRecurosMax;
            this.requiereNumTipoExacto = requiereNumTipoExacto;
            this.numTipoExacto = numTipoExacto;
        }

        public int PuntosVictoria() => Recursos.Select(x => (int)x.Material).Sum();

        public bool RecurosSirven(List<Recurso> recursos)
        {
            Recursos = new List<Recurso>();
            if (recursos.Count > numRecurosMax || recursos.Count < numRecursosMin) return false;
            if (requiereNumTipoExacto)
            {
                int numTipos = recursos.Distinct().Count();
                if (numTipos != numTipoExacto) return false;
            }
            Recursos.AddRange(recursos);
            return true;
        }
    }
}