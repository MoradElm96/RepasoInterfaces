using ControlUsuario.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuario.Controladores
{
    public  class ControladorCoches
    {
        //si es statica no se instancia

        public  List<Coche> recuperarCoches()
        {
            //crear variable y retornarla
            List<Coche> listaCoches = new List<Coche>();

            listaCoches.Add(new Coche("1234abc","seat","ibiza","rojo",2000));
            listaCoches.Add(new Coche("2244cac", "seat", "toledo", "azul", 1600));
            listaCoches.Add(new Coche("3534anc", "seat", "leon", "gris", 1800));

            return listaCoches;
        }

        //solo se guarda en  memoria
        public bool guardarCoche(Coche coche)
        {

            bool respuesta = true;
            
            List<Coche> lista = recuperarCoches();

            lista.Add(coche);

            return respuesta;

        }


    }
}
