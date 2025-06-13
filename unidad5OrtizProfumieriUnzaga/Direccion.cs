using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad5OrtizProfumieriUnzaga
{
    public class Direccion
    {
        //2.Crear una clase Direccion que contenga(Calle, Numero, Piso, Departamento).
        //4.Para ambas clases, crear un constructor usando todas de las propiedades y sobreescribir
        //el método ToString() para mostrar todas las propiedades.
        private string calle, numero, piso, departamento;

        public Direccion(string calle,string numero,string piso,string departamento)
        {
            this.calle = calle;
            this.numero = numero;
            this.piso = piso;
            this.departamento = departamento;
        }

        public override string ToString()
        {
            return $" calle:{calle} numero:{numero} piso:{piso} departamento:{departamento}";
        }
    }
}
