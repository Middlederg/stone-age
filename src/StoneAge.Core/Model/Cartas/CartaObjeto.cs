using StoneAge.Core.Enums;
using System.Collections.Generic;
using System.Linq;

namespace StoneAge.Core.Model
{
    public class CartaObjeto : CartaBase
    {
        private TipoAmbito Ambito;
        public int Multiplicador { get; private set; }

        public CartaObjeto(TipoAmbito ambito, TipoBeneficio beneficio, List<Recurso> recursos = null, int herramientaExtra = 0,
            int comida = 0, Recurso dosDados = null) : base(beneficio, recursos, herramientaExtra, comida, dosDados)
        {
            Ambito = ambito;
        }

        public override int PuntosFinalPartida(Jugador jugador) => 0;
        public override TipoAmbito? GetAmbito() => Ambito;
    }

    public static class CartaObjetoHelper
    {
        public static int Puntos(List<ICarta> listaCartas) 
            => (int)System.Math.Pow(listaCartas.Select(x => x.GetAmbito().HasValue).Distinct().Count(), 2);
    }
}
