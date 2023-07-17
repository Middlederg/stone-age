using StoneAge.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoneAge.Core.Model.Acciones
{
    public interface IAccion
    {
        /// <summary>
        /// Número de huecos disponibles actualmente
        /// </summary>
        int Disponibles { get; }

        /// <summary>
        /// Número de huecos máximos que se puede llegar a llenar
        /// </summary>
        int Maximo { get; }

        /// <summary>
        /// Número de huecos que hay quellenar al poner personas
        /// </summary>
        int Requeridos { get; }

        /// <summary>
        /// Determina si requiere una tirada de dados, o es automático
        /// </summary>
        bool RequiereDados { get; }

        /// <summary>
        /// Reinicia la acción
        /// </summary>
        void Reset();

        /// <summary>
        /// Determina si el jugador activo podría colocar ese número de personas
        /// </summary>
        /// <param name="game"></param>
        /// <param name="numPersonas"></param>
        /// <returns></returns>
        bool PuedeColocarPersona(Juego game, int numPersonas);

        /// <summary>
        /// Realiza la acción
        /// </summary>
        /// <param name="game"></param>
        void RealizacionAccion(Juego game);
    }
}
