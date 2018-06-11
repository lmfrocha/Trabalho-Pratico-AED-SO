##TI com Sistemas Operacionais

O Propósito deste trabalho é colocar em pratica o aprendizado sobre as estruturas de dados Filas, Listas, Pilhas e Arvore.

##Processo

Este projeto tem como foco principal o input de um arquivo com "processos" similares aos processos do windows.

- PID do processo (piD, int)
- Nome do processo (string, Nome)
- Prioridade (int, Prioridade)
- Tempo de execução de uso da cpu (float, timeExec)
- Número de ciclos de cpu para terminar (int, ciclos).

##Exemplo:

- 35;/usr/lib/evolution/evolution-addressbook-factory;4;0,65;7
- Pid = 35, nome = "/usr/lib/evolution/evolution-addressbook-factory"
- Prioridade = 4
- TimeExec = 0,65 segundos
- Ciclos = 7

##Problema

- O desafio é, criar estruturas que distribuam os processos por prioridades em filas de execução, enquanto existir um processo existir em qualquer fila, o mesmo deverá ser executado, respeitando a ordem de prioridade de cada processo.

##Instalação

- A pasta contem o fonte, basta clonar a pasta e executar o projeto.
- Recomendação utilizar o Visual Studio no minimo versão 2010
- Está sendo feito no Visual Studio Comunity 2017
