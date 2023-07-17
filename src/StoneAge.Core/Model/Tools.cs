using System;
using System.Linq;

namespace StoneAge.Core.Model
{
    public class Tools
    {
        private int[] huecos;
        public bool[] Utilizadas;

        public Tools()
        {
            huecos = new int[3];
            Utilizadas = new bool[3];
        }

        /// <summary>
        /// Utiliza una de las herramientas y la agota
        /// </summary>
        /// <param name="indx"></param>
        /// <returns>Devuelve el modificador a la tirada de dados</returns>
        public int Utilizar(int indx)
        {
            if (indx < 0 || indx > 2)
                throw new ArgumentOutOfRangeException("Solo dispones de 3 huecos para herramientas");

            Utilizadas[indx] = true;
            return huecos[indx];
        }

        /// <summary>
        /// Devuelve la suma total de las herramientas
        /// </summary>
        /// <returns></returns>
        public int Total() => huecos.Sum();

        /// <summary>
        /// Activa de nuevo todas as herramientas
        /// </summary>
        public void NuevoTurno() => Utilizadas = new bool[3];

        /// <summary>
        /// Añade o sube un nivel a una herramienta
        /// </summary>
        public void AddTool()
        {
            int herramientaMenor = huecos.Min();
            huecos[huecos.ToList().IndexOf(herramientaMenor)] = herramientaMenor++;
        }
        public override string ToString() => string.Join(", ", huecos.Where(x => x != 0).Select(x => $" + {x}"));
    }
}
