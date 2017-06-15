using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class NodoExpresion
    {
        private string _dato;
        public string dato
        {
            set { _dato = value; }
            get { return _dato; }
        }

        private NodoExpresion _hIzquierdo;
        public NodoExpresion hIzquierdo
        {
            set { _hIzquierdo = value; }
            get { return _hIzquierdo; }
        }

        private NodoExpresion _hDerecho;
        public NodoExpresion hDerecho
        {
            set { _hDerecho = value; }
            get { return _hDerecho; }
        }

        private NodoExpresion _padre;
        public NodoExpresion padre
        {
            set { _padre = value; }
            get { return _padre; }
        }

        public override string ToString()
        {
            return "[" + _dato.ToString() + "]";
        }
    }
}
