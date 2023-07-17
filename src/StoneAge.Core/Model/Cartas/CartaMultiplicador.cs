using StoneAge.Core.Enums;
using System.Collections.Generic;

namespace StoneAge.Core.Model
{
    public class CartaMultiplicador : CartaBase
    {
        public TipoPremio TipoDePremio { get; private set; }
        public int Multiplicador { get; private set; }

        public CartaMultiplicador(TipoPremio premio, int multiplicador, TipoBeneficio beneficio, List<Recurso> recursos = null, int herramientaExtra = 0, 
            int comida = 0, Recurso dosDados = null) : base(beneficio, recursos, herramientaExtra, comida, dosDados)
        {
            TipoDePremio = premio;
            Multiplicador = multiplicador;
        }

        public override int PuntosFinalPartida(Jugador jugador)
        {
            switch (TipoDePremio)
            {
                case TipoPremio.Personas: return jugador.TribuJugador.Maximo * Multiplicador;
                case TipoPremio.Agricultura: return jugador.Agricultura * Multiplicador;
                case TipoPremio.Construcciones: return jugador.Construcciones.Count * Multiplicador;
                case TipoPremio.Herramientas: return jugador.Herramientas.Total() * Multiplicador;
            }
            return 0;
        }
        public override TipoAmbito? GetAmbito() => null;
    }
}
