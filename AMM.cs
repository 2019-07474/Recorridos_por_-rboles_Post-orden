using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorridos_por_árboles_Post_orden
{
    class AMM
    {
        public class nodo
        {
            public nodo izq;
            public nodo der;
            public char letra;

            //constructor
            public nodo(char letra)
            {
                this.letra = letra;
                this.izq = null;
                this.der = null;

            }
        }
        // declaracion del primer nodo
        public nodo raiz;
        public AMM()
        {
            raiz = null;
        }
        // metodo de insertar
        public void insertar(char letra)
        {
            nodo nuevo = new nodo(letra);

            if (this.raiz == null)
            {
                this.raiz = nuevo;
            }
            else
            {
                this.raiz = this.insertarnodo(raiz, nuevo);
            }
        }
        public nodo insertarnodo(nodo actual, nodo nuevo)
        {
            if (nuevo.letra.CompareTo(actual.letra) < 0)
            {
                if (actual.izq == null)
                {
                    actual.izq = nuevo;
                    return actual;
                }
                else
                {
                    actual.izq = insertarnodo(actual.izq, nuevo);
                    return actual;
                }
            }
            else if (nuevo.letra.CompareTo(actual.letra) > 0)
            {
                if (actual.der == null)
                {
                    actual.der = nuevo;
                    return actual;
                }
                else
                {
                    actual.der = insertarnodo(actual.der, nuevo);
                    return actual;

                }
            }
            else
            {
                return null;
            }
        }
        public void preordenrecursivo()
        {
            Console.WriteLine("Recorridos por árboles en PRE-ORDEN");
            preorden(raiz);
        }

        public void preorden(nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine(raiz.letra.ToString());
                preorden(raiz.izq);
                preorden(raiz.der);
            }
        }
        public void inordenrecursivo()
        {
            Console.WriteLine("Recorrido por árboles en in-Orden");
            inorden(raiz);

        }

        public void inorden(nodo raiz)
        {
            if (raiz != null)
            {
                inorden(raiz.izq);
                Console.WriteLine(raiz.letra.ToString());
                inorden(raiz.der);
            }
        }
        public void postOrdenrecursivo()
        {
            Console.WriteLine("Recorrido por árboles en post-Orden");
            postOrden(raiz);

        }

        public void postOrden(nodo raiz)
        {
            if (raiz != null)
            {
                postOrden(raiz.izq);
                postOrden(raiz.der);
                Console.WriteLine(raiz.letra.ToString());
            }
        }
    }
}
