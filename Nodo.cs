using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class Nodo
    {
        private int _dato;
        public int dato
        {
            set { _dato = value; }
            get { return _dato; }
        }

        private Nodo _hIzquierdo;
        public Nodo hIzquierdo
        {
            set { _hIzquierdo = value; }
            get { return _hIzquierdo; }
        }

        private Nodo _hDerecho;
        public Nodo hDerecho
        {
            set { _hDerecho = value; }
            get { return _hDerecho; }
        }

        public override string ToString()
        {
            return "[" + _dato.ToString()+"]";
        }
    }
}
