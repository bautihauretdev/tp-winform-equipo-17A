using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_17A
{
    public class Categoria
    {
        // ATRIBUTOS
        public int id { get; set; } /// Que sea autoincrementable tomando de referencia el último que encuentre?
        public string descripcion { get; set; }

        // CONSTRUCTOR
        public Categoria(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
    }
}
