using System;
using System.Collections.Generic;

namespace CDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("---------------------BEM VINDO AO DICION�RIO-------------------------")
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("> Mentalidade de Crescimento: ", new string("Ter uma mentalidade de crescimento � acreditar que suas compet�ncias mais b�sicas podem ser desenvolvidas atrav�s de dedica��o e trabalho �rduo. O c�rebro e o talento s�o apenas o ponto de partida.\n"));
            dic.Add("> Mentalidade de Orienta��o ao Futuro: ", new string("Ter orienta��o ao futuro significa estabelecer metas para o seu futuro, compreender como as a��es de hoje impactam nessas metas e verificar seu progresso com frequ�ncia.\n"));
            dic.Add("> Mentalidade de Persist�ncia: ", new string("Ser persistente significa que voc� continuar� tentando vez ap�s vez. Em cada tentativa, voc� estar� mais pr�ximo do sucesso.\n"));
            dic.Add("> Mentalidade de Responsabilidade pessoal: ", new string("Responsabilidade pessoal significa assumir a responsabilidade por suas pr�prias a��es, trabalhando arduamente, mantendo seus compromissos e n�o dando desculpas.\n"));
            dic.Add("> Habilidade de Comunica��o", new string("Uma boa comunica��o significa capacidade de expressar ideias de forma clara e concisa, com linguagem apropriada ao p�blico, assim como ouvir com aten��om, manter contato visual com seus interlocutores e tomar notas ao receber novas informa��es.\n"));
            dic.Add("> Habilidade de Orienta��o ao detalhe", new string("Orienta��o ao detalhe consiste em estar constantemente atento aos detalhes ao executar tarefas, a fim de serem completadas com precis�o e cuidado.\n"));
            dic.Add("> Habilidade de Proatividade", new string("Proatividade significa assumir a lideran�a em seu emprego sem nenhum impulso de seu gerente, antecipando situa��es e tomando as a��es preventivas que forem necess�rias.\n"));
            dic.Add("> Habilidade de Trabalho em equipe", new string("Trabalho em equipe Consiste em um trupo de pessoas, ou apenas duas pessoas, trabalhando em conjunto visando um objetivo em comum.\n"));

            Console.WriteLine("- Mentalidades & Habilidades - \n");

            foreach (KeyValuePair<string, string> kvp in dic)
            {
                Console.WriteLine(" {0} Defini��o: {1}", kvp.Key, kvp.Value);
            }

            
        }
    }
}