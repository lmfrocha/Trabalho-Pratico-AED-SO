using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoIntegradoComSO.Structs
{
    class ListaCircular
    {
        public Elemento atual, prox;

        public ListaCircular()
        {
            this.atual = new Elemento(null);
            this.prox = this.atual;
        }

    }
}
