using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class Estructura_Arbol
    {
        Nodo raiz;

        public void agregar(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                _agregar(nuevo, raiz);
        }

        private void _agregar(Nodo n, Nodo r)
        {
            if (n.dato < r.dato)
                if (r.hIzquierdo == null)
                    r.hIzquierdo = n;
                else
                    _agregar(n, r.hIzquierdo);
            else
            {
                if (r.hDerecho == null)
                    r.hDerecho = n;
                else
                    _agregar(n, r.hDerecho);
            }
        }

        public string InOrden()
        {
            if (raiz == null)
                return "";
            else
                return InOrden(raiz);
        }

        private string InOrden(Nodo r)
        {
            string res = "";
            if (r.hIzquierdo != null)
                res += InOrden(r.hIzquierdo);

            res += r.ToString();
            if (r.hDerecho != null)
                res += InOrden(r.hDerecho);
            return res;
        }

        public string PreOrden()
        {
            if (raiz == null)
                return "";
            else
                return PreOrden(raiz);
        }

        private string PreOrden(Nodo r)
        {
            string res = "";
            res += r.ToString();
            if (r.hIzquierdo != null)
                res += PreOrden(r.hIzquierdo);


            if (r.hDerecho != null)
                res += PreOrden(r.hDerecho);

            return res;
        }

        public string PosOrden()
        {
            if (raiz == null)
                return "";
            else
                return PosOrden(raiz);
        }

        private string PosOrden(Nodo r)
        {
            string res = "";

            if (r.hIzquierdo != null)
                res += PosOrden(r.hIzquierdo);


            if (r.hDerecho != null)
                res += PosOrden(r.hDerecho);

            res += r.ToString();
            return res;
        }

        ////////////////////////////////////////
        //NodoExpresion nodo;
        //public void agregarAExpre(NodoExpresion nuevoNodo)
        //{
        //    if (nodo == null)
        //        nodo = nuevoNodo;
        //    else
        //    {
        //        if (nuevoNodo.dato == '*' || nuevoNodo.dato = '-' || nuevoNodo.dato == '/' || nuevoNodo.dato == '+')
        //        {
        //            if (nodo.hIzquierdo != null)
        //                nodo.hIzquierdo = nodo;
        //            nodo = nuevoNodo;
        //        }
        //        else
        //        {

        //        }
        //    }
        //}
    }
}
