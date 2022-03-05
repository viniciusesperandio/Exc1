//using System;
//using System.Text;
//using System.Linq;

//namespace Exc1
//{
//    internal class Collatz
//    {
//        public class Resultado
//        {
//            public int NumeroInicial { get; set; }
//            public int QtdeTermos { get; set; }
//        }
//        static void Main()
//        {
//            // Instância o objeto Resultado
//            List<Resultado> ListaResultados = new List<Resultado>();

//            //Percorre uma sequência de números entre 1 e 1M
//            //para achar aquele que retorna a maior sequência de termos
//            //de acordo com o problema Collatz.
//            for (int i = 2; i > 1 && i < 1000000; i++)
//            {
//                // Criação das variáveis de controle
//                int numInicial = i;
//                int numCalculado = i;
//                int qtdTermos = 1;

//                // Enquanto o número for maior que 1, continua calculando
//                while (numCalculado > 1)
//                {
//                    // Valida se o número é par
//                    if (numCalculado % 2 == 0)
//                    {
//                        // Caso o número seja par, atualizamos seu valor
//                        // de acordo com o cálculo abaixo
//                        // e adicionamos 1 ao contador de termos
//                        numCalculado = numCalculado / 2;
//                        qtdTermos++;
//                    }
//                    else
//                    {
//                        // Caso o número seja ímpar, atualizamos seu valor
//                        // de acordo com o cálculo abaixo
//                        // e adicionamos 1 ao contador de termos
//                        numCalculado = (numCalculado * 3) + 1;
//                        qtdTermos++;
//                    }
//                }

//                // Adiciona os resultados do número inicial e dos termos
//                // na lista de objetos
//                ListaResultados.Add(
//                    new Resultado
//                    {
//                        NumeroInicial = numInicial,
//                        QtdeTermos = qtdTermos
//                    }
//                );
//            }

//            //Filtra a lista de resultados,
//            //retornando o item com a maior quantidade de termos
//            Resultado result = ListaResultados
//                                .Select(x => x)
//                                .OrderByDescending(w => w.QtdeTermos)
//                                .First();

//            // Retorna no console o número inicial com a maior quantidade de termos
//            Console.WriteLine(
//                "Número inicial: " + result.NumeroInicial +
//                ", Termos:" + result.QtdeTermos
//            );
//        }
//    }
//}
