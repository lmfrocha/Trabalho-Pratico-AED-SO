using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace TrabalhoIntegradoComSO.Package
{
    class GerenciaThread
    {
        public void ChamarThread()
        {
            ThreadStart ts = new ThreadStart(ExecutarThread);
            Thread t = new Thread(ts);
            t.IsBackground = true;
            t.Start();      }
        private void ExecutarThread()
        {
            // Código a ser executado pela thread
        }
    }
}
