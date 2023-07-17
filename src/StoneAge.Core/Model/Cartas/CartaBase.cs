using StoneAge.Core.Enums;
using System.Collections.Generic;

namespace StoneAge.Core.Model
{
    public class CartaBase : ICarta
    {
        public TipoBeneficio Beneficio { get; }
        public List<Recurso> Recursos { get; }
        public int HerramientaExtra { get; }
        public int Comida  { get; }
        public Recurso DosDados  { get; }

        public CartaBase(TipoBeneficio beneficio, List<Recurso> recursos = null, int herramientaExtra = 0,
            int comida = 0, Recurso dosDados = null)
        {
            Beneficio = beneficio;
            recursos = recursos == null ? new List<Recurso>() : recursos;
            HerramientaExtra = herramientaExtra;
            Comida = comida;
            DosDados = dosDados;
        }

        public void CobrarEfectoInmediato(Jugador jugador)
        {
            jugador.Comida += Comida;
            jugador.Recursos.AddRange(Recursos);
            jugador.HerramientasExtras.Add(HerramientaExtra);

           
            switch (Beneficio)
            {
                case TipoBeneficio.AumentaHerramienta:
                    jugador.Herramientas.AddTool();
                    break;
                case TipoBeneficio.AumentaAgricultura:
                    jugador.Agricultura++;
                    break;
                case TipoBeneficio.TresPuntosVictoria:
                    jugador.Puntos += 3;
                    break;
                case TipoBeneficio.Ninguno:
                case TipoBeneficio.CartaExtra: //requiere coger una carta
                case TipoBeneficio.DosRecursos: //Requiere elegir dos recursos cualesquiera
                case TipoBeneficio.JuegoDados: //Requiere realizar juego de dados
                default:
                    break;
            }
        }

        public bool RequiereGestionExtra()
        {
            return  Beneficio.Equals(TipoBeneficio.DosRecursos) ||
                    Beneficio.Equals(TipoBeneficio.JuegoDados)  ||
                    Beneficio.Equals(TipoBeneficio.DosRecursos) ||
                    Beneficio.Equals(TipoBeneficio.CartaExtra)  ||
                    DosDados != null;
        }

        public virtual int PuntosFinalPartida(Jugador jugador) => throw new System.NotImplementedException();

        public virtual TipoAmbito? GetAmbito() => throw new System.NotImplementedException();
    }
}
