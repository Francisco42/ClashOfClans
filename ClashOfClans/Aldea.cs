using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Aldea
    {
        public string nombre;
        public int cant_oro;
        public int cant_ElixirR;
        public int cant_ElixirO;
        public List<IAlmacenamiento> almacenes;
        public List<Campamento> campamentos;
        public Castillo castillo;
        public Altar_Rey altarRey;
        public Altar_Reina altarReina;
        public Altar_Warden altarWarden;
        

        public Aldea(string nombre, int oro, int rojo, int oscuro)
        {
            this.nombre = nombre;
            this.cant_oro = oro;
            this.cant_ElixirR = rojo;
            this.cant_ElixirO = oscuro;

        }
        /// <summary>
        /// agrega una entidad a la aldea
        /// </summary>
        /// <param name="e"> la entidad a agregar </param>
        public void AgregarEntidad (Entidad e)
        {
            if(e is IEdificio)
            {
                if(e is )
            }

        }

        // TEST

        
        

    }
}
