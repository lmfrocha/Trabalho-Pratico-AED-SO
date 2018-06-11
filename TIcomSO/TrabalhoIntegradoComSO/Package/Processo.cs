using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabalhoIntegradoComSO.Package;
using TrabalhoIntegradoComSO.Structs;

#region Dados do Processo
/*
 * Prezados, 

boa tarde. Está no SGA o arquivo de dados para o trabalho interdisciplinar com SO.
É um arquivo texto, contendo em cada linha as informações de um processo, com a seguinte 
estrutura, separada por ponto e vírgula: 

*PID do processo (identificador, int) 
*nome do processo (string) 
*prioridade (int) 
*tempo de execução de uso da cpu (float, em segundos) 
*número de ciclos de cpu para terminar. 

Exemplificando, o processo abaixo: 

35;/usr/lib/evolution/evolution-addressbook-factory;4;0,65;7 

Tem um PID 35, se chama "/usr/lib/evolution/evolution-addressbook-factory", tem a prioridade 4, 
a cada vez que vai para a CPU executa por 0,65 segundos e precisa ir à CPU 7 vezes para terminar. 

Havendo dúvidas, me escrevam. 

Att, 
João
 */
#endregion

namespace TrabalhoIntegradoComSO.Package
{
    class Processo : Dados
    {
        private int piD;
        private string nome;
        private int prioridade;
        private float timeExec;
        private int ciclos;

        public int PiD
        {
            get
            {
                return piD;
            }

            set
            {
                piD = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Prioridade
        {
            get
            {
                return prioridade;
            }

            set
            {
                prioridade = value;
            }
        }

        public float TimeExec
        {
            get
            {
                return timeExec;
            }

            set
            {
                timeExec = value;
            }
        }

        public int Ciclos
        {
            get
            {
                return ciclos;
            }

            set
            {
                ciclos = value;
            }
        }

        //Construtor
        public Processo(int iD, string nome, int prioridade, float timeExec, int ciclos)
        {
            this.piD = iD;
            this.nome = nome;
            this.prioridade = prioridade;
            this.timeExec = timeExec;
            this.ciclos = ciclos;
        }       

        public override string ToString()
        {
            return PiD+";" + Nome +";"+ Prioridade +";"+ TimeExec +";"+ Ciclos ;
        }

        public Boolean Equals(Dados other)
        {
            Processo aux = (Processo)(other);
            if (this.piD == aux.piD) return true;
            else return false;
        }

        public int CompareTo(Dados other)
        {
            Processo aux = (Processo)(other);
            if (this.prioridade.Equals(aux.prioridade))
            {
                return 0;
            }
            else if (this.prioridade > aux.prioridade)
            {
                return 1;
            }
            else if (this.prioridade < aux.prioridade)
            {
                return -1;
            }
            return 3;
        }
    }
}
