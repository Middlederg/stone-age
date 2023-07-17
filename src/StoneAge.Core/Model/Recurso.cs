using System.Text;
using StoneAge.Core.Enums;

namespace StoneAge.Core.Model
{
    public class Recurso
    {
        private Resource resource;
        public Resource Material { get { return resource; } }

        public Recurso(Resource res)
        {
            resource = res;
        }

        /// <summary>
        /// Devuelve el número de recursos que se obtendrían de ese material con esa tirada
        /// </summary>
        /// <param name="resultado"></param>
        /// <returns></returns>
        public int NumeroObtenido(int resultado) => resultado / (int)resource;

        public override string ToString() => resource.ToString();

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Recurso)obj).Material.Equals(resource);
        }

        public override int GetHashCode() => resource.GetHashCode();
    }
}
