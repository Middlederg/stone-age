using StoneAge.Core.Enums;
using System.Collections.Generic;

namespace StoneAge.Core.Model
{
    public interface ICarta
    {
        TipoBeneficio Beneficio { get; }
        List<Recurso> Recursos { get; }
        int HerramientaExtra { get; }
        int Comida { get; }
        Recurso DosDados { get; }

        bool RequiereGestionExtra();

        void CobrarEfectoInmediato(Jugador jugador);

        int PuntosFinalPartida(Jugador jugador);
        TipoAmbito? GetAmbito();
    }
}
