using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoIntegradoComSO.Structs
{
    class Fila
    {
        public Elemento prim, ult;
        public int quantidade;
        /// <summary>
        /// Construtor. Cria uma fila vazia com sentinela.
        /// </summary>
        public Fila()
        {
            this.quantidade = 0;
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        /// <summary>
        /// Busca dados. Precisa receber um objeto com valor igual ao que se deseja buscar.
        /// O objeto precisa ter um método sobrescrito Equals para indicar se é igual a outro objeto da mesma classe
        /// </summary>
        /// <param name="v">O objeto com o valor a ser buscado</param>
        /// <returns>O objeto procurado ou null, caso não exista</returns>
        public Dados buscar(Dados v)
        {
            Elemento aux = this.prim.prox;
            while (aux != null)
            {
                if (aux.d.Equals(v))
                    return aux.d;
                else aux = aux.prox;
            }
            return null;
        }

        /// <summary>
        /// Enfileira um objeto ao final da fila.
        /// </summary>
        /// <param name="novo">O novo objeto a ser enfileirado</param>
        public void enfileirar(Dados novo)
        {
            Elemento aux = new Elemento(novo);
            this.ult.prox = aux;
            this.ult = aux;
            this.quantidade += 1;
        }

        /// <summary>
        /// Desenfileira o primeiro objeto da fila.
        /// </summary>
        /// <returns>Retorna um objeto ou null, caso a fila esteja vazia</returns>
        public Dados desenfileirar()
        {
            Elemento aux = this.prim.prox;
            if (aux != null)
            {
                this.prim.prox = aux.prox;
                if (aux == this.ult) this.ult = this.prim;
                else aux.prox = null;
                this.quantidade -= 1;
                return aux.d;
            }
            else
                return null;
        }

        public bool estaVazia()
        {
            return (this.prim == this.ult);
        }

        //public bool estaVazia()
        //{
        //    Elemento aux = this.prim.prox;

        //    if (this.quantidade == 0)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}

        public int totalLista()
        {
            return this.quantidade;
        }
    }
}
