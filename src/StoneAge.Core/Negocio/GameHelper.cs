using StoneAge.Core.Enums;
using StoneAge.Core.Model;
using StoneAge.Core.Model.Construcciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoneAge.Core.Negocio
{
    public static class GameHelper
    {
        public static IEnumerable<ICarta> GetCartas()
        {
            yield return new CartaObjeto(TipoAmbito.Arte, TipoBeneficio.Ninguno, null, 0, 0, new Recurso(Resource.Oro));
            yield return new CartaMultiplicador(TipoPremio.Personas, 2, TipoBeneficio.Ninguno, null, 0, 0, new Recurso(Resource.Madera));
            yield return new CartaMultiplicador(TipoPremio.Personas, 1, TipoBeneficio.Ninguno, null, 0, 0, new Recurso(Resource.Piedra));
            yield return new CartaMultiplicador(TipoPremio.Herramientas, 2, TipoBeneficio.Ninguno, null, 2, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Herramientas, 1, TipoBeneficio.Ninguno, null, 3, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Personas, 2, TipoBeneficio.Ninguno, new List<Recurso>() { new Recurso(Resource.Madera) }, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Personas, 1, TipoBeneficio.Ninguno, new List<Recurso>() { new Recurso(Resource.Oro) }, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Personas, 1, TipoBeneficio.Ninguno, new List<Recurso>() { new Recurso(Resource.Piedra) }, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Transporte, TipoBeneficio.Ninguno, new List<Recurso>() { new Recurso(Resource.Piedra), new Recurso(Resource.Piedra) }, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Agricultura, 1, TipoBeneficio.Ninguno, new List<Recurso>() { new Recurso(Resource.Piedra) }, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Tejeduria, TipoBeneficio.Ninguno, null, 0, 1, null);
            yield return new CartaObjeto(TipoAmbito.Ceramica, TipoBeneficio.Ninguno, null, 0, 7, null);
            yield return new CartaObjeto(TipoAmbito.PlantasMedicinales, TipoBeneficio.Ninguno, null, 0, 5, null);
            yield return new CartaObjeto(TipoAmbito.Tejeduria, TipoBeneficio.Ninguno, null, 0, 3, null);
            yield return new CartaMultiplicador(TipoPremio.Construcciones, 2, TipoBeneficio.Ninguno, null, 0, 2, null);
            yield return new CartaMultiplicador(TipoPremio.Construcciones, 1, TipoBeneficio.Ninguno, null, 0, 4, null);
            yield return new CartaMultiplicador(TipoPremio.Agricultura, 2, TipoBeneficio.Ninguno, null, 0, 3, null);
            yield return new CartaMultiplicador(TipoPremio.Agricultura, 1, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Agricultura, 2, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Construcciones, 1, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Construcciones, 2, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Herramientas, 2, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Herramientas, 2, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Tiempo, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Escritura, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Ceramica, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Transporte, TipoBeneficio.JuegoDados, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Musica, TipoBeneficio.TresPuntosVictoria, null, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Construcciones, 3, TipoBeneficio.TresPuntosVictoria, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Arte, TipoBeneficio.AumentaHerramienta, null, 0, 0, null);
            yield return new CartaMultiplicador(TipoPremio.Agricultura, 1, TipoBeneficio.AumentaAgricultura, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Tiempo, TipoBeneficio.AumentaAgricultura, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.Escritura, TipoBeneficio.CartaExtra, null, 0, 0, null);
            yield return new CartaObjeto(TipoAmbito.PlantasMedicinales, TipoBeneficio.DosRecursos, null, 0, 0, null);
        }

        public static IEnumerable<IConstruccion> GetConstrucciones()
        {
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Arcilla), new Recurso(Resource.Arcilla), new Recurso(Resource.Piedra) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Arcilla), new Recurso(Resource.Piedra) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Piedra), new Recurso(Resource.Piedra), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Piedra), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Arcilla), new Recurso(Resource.Piedra), new Recurso(Resource.Piedra) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Arcilla), new Recurso(Resource.Arcilla), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Arcilla), new Recurso(Resource.Piedra), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Piedra), new Recurso(Resource.Piedra) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Arcilla), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Arcilla), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Arcilla), new Recurso(Resource.Piedra) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Arcilla), new Recurso(Resource.Arcilla) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Madera), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Piedra), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Arcilla), new Recurso(Resource.Piedra), new Recurso(Resource.Oro) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Madera), new Recurso(Resource.Piedra) });
            yield return new ConstruccionFija(new List<Recurso>() { new Recurso(Resource.Madera), new Recurso(Resource.Madera), new Recurso(Resource.Arcilla) });

            yield return new ConstruccionVariable(1, 7);
            yield return new ConstruccionVariable(1, 7);
            yield return new ConstruccionVariable(1, 7);
            yield return new ConstruccionVariable(5, 5, true, 1);
            yield return new ConstruccionVariable(4, 4, true, 1);
            yield return new ConstruccionVariable(5, 5, true, 2);
            yield return new ConstruccionVariable(4, 4, true, 2);
            yield return new ConstruccionVariable(5, 5, true, 3);
            yield return new ConstruccionVariable(4, 4, true, 3);
            yield return new ConstruccionVariable(5, 5, true, 4);
            yield return new ConstruccionVariable(4, 4, true, 4);
        }
    }
}
