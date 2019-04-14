using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_FSI
{
    public class CArreglo
    {
        private Array arr_Vendedor = Array.CreateInstance(typeof(Cvendedor), 100);
        //se usa otra variable para controlar la posicion al ingresar obj
        private int indice = 0;
        public int Insertar(Cvendedor obj, int codigo)
        {
 
            int contador=0;
            if (arr_Vendedor.GetValue(0) == null)
            {
                arr_Vendedor.SetValue(obj, indice);
                indice++;
            }
            else
            {
                foreach (Cvendedor elemento in arr_Vendedor)
                    if (elemento != null)
                        if (elemento.Codigo == codigo)
                            contador = 1;
            }
            return contador;
        }





    }
}
