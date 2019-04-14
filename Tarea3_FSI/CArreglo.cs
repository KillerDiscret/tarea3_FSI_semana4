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
                {
                    if (elemento != null)
                        if (elemento.Codigo == codigo)
                        {
                            contador = 1;
                        }
                }
                 if (contador==0)
                {
                    arr_Vendedor.SetValue(obj, indice);
                    indice++;
                }
            }
            return contador;
        }
      public string Mostrar_Mayor()
        {
            int auxmayor=0;
            string auxnombre="";

            foreach(Cvendedor mayor in arr_Vendedor)
            {
                if(mayor != null)
                {
                    if (mayor.Monto > auxmayor)
                    {
                        auxmayor = mayor.Monto;
                        auxnombre = mayor.Nombre;
                    }
                }
            }
            return auxnombre;
        }
        public string Mostrar_Menor()
        {
            int auxmenor = 999999;
            string auxn = "";

            foreach (Cvendedor menor in arr_Vendedor)
            {
                if (menor != null)
                {
                    if (menor.Monto < auxmenor)
                    {
                        auxmenor = menor.Monto;
                        auxn = menor.Nombre;
                    }
                }
            }
            return auxn;
        }





    }
}
