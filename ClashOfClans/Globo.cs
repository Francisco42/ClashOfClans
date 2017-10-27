using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Globo:Tropa_Normal
    {
        public Globo()
        {
            this.nombre = "Globo";
            this.daño = 25;
            this.velocidad = 10;
            this.tipo = "Aéreo";
            this.vida = 150;
            this.costo = 2000;
            this.nivel = 1;
            this.espacioOcupado = 15;

        }
    }
}
