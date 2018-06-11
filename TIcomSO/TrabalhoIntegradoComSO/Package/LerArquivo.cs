using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TrabalhoIntegradoComSO.Structs;
using TrabalhoIntegradoComSO.Package;

namespace TrabalhoIntegradoComSO.Package
{
    static class LerArquivo
    {
        public static void Ler(Fila fila_p1, Fila fila_p2, Fila fila_p3, Fila fila_p4, Fila fila_p5) // objeto é passado sempre como referencia
        {
              
            string arq = "TI.txt";
            StreamReader sr = new StreamReader(arq, Encoding.Default); // abre o arquivo para leitura
            string aux;
            string[] atributos = new string[5];
            Processo p;

            while (!sr.EndOfStream) // enquanto não chegar ao final do arquivo
            {
                aux = sr.ReadLine(); // aux recebe a próxima linha do arquivo
                atributos = aux.Split(';'); // vetor atributos é construido com strings separadas pelo ";" de aux

                p = new Processo(int.Parse(atributos[0]), atributos[1], int.Parse(atributos[2]), float.Parse(atributos[3]), int.Parse(atributos[4]));

                switch (p.Prioridade)
                {
                    case 1:
                        fila_p1.enfileirar(p);
                        break;
                    case 2:
                        fila_p2.enfileirar(p);
                        break;
                    case 3:
                        fila_p3.enfileirar(p);
                        break;
                    case 4:
                        fila_p4.enfileirar(p);
                        break;
                    case 5:
                        fila_p5.enfileirar(p);
                        break;
                    default:
                        break;
                }
            }           
        }
    }
}
    

