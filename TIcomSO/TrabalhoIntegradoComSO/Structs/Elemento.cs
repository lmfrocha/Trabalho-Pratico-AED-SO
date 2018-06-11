using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoIntegradoComSO.Structs
{
    class Elemento
    {
        public Dados d;
        public Elemento prox;

        public Elemento(Dados dado)
        {
            this.d = dado;
            this.prox = null;
        }
    }
}

