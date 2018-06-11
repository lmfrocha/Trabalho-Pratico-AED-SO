using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoIntegradoComSO.Structs
{
    class Pilha
    {
        public Elemento topo, fundo;

        /// <summary>
        /// Construtor. Cria uma pilha vazia com sentinela.
        /// </summary>
        public Pilha()
        {
            this.topo = new Elemento(null);
            this.fundo = this.topo;
        }

        /// <summary>
        /// Empilha um elemento.
        /// </summary>
        /// <param name="novo">O objeto a ser empilhado</param>
        public void push(Dados novo)
        {
            Elemento elemento = new Elemento(novo);
            elemento.prox = this.topo.prox;
            this.topo.prox = elemento;
            if (this.topo == this.fundo) this.fundo = elemento;
        }

        /// <summary>
        /// Desempilha um elemento.
        /// </summary>
        /// <returns>O objeto que estava no topo da pilha, ou null, se a pilha estiver vazia</returns>
        public Dados pop()
        {
            Elemento aux = this.topo.prox;

            if (aux != null)
            {
                this.topo.prox = aux.prox;
                aux.prox = null;
                if (aux == this.fundo)
                    this.fundo = this.topo;
                return aux.d;
            }
            else return null;
        }

        /// <summary>
        /// Mostra o objeto no topo da pilha, sem desempilhar
        /// </summary>
        /// <returns>O objeto do topo da pilha, ou null, se a pilha estiver vazia</returns>
        public Dados peek()
        {
            if (topo.prox != null)
                return this.topo.prox.d;
            else
                return null;
        }

        /// <summary>
        /// Indica se a pilha está vazia
        /// </summary>
        /// <returns>Verdadeiro, para pilha vazia; falso, caso contrário</returns>
        public bool pilhaVazia()
        {
            return (this.topo == this.fundo);
        }
    }
}
