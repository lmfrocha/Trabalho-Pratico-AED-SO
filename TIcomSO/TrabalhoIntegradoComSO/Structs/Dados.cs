using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoIntegradoComSO.Structs
{
    public interface Dados : IEquatable<Dados>    
    {
        new bool Equals(Dados o);
        int CompareTo(Dados o);
    }
}
