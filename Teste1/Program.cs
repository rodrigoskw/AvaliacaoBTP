using System;
using System.Collections.Generic;

namespace Teste1
{
    class Program
    {
        //TODO
        /* 
         * Desenvolva um método que receba a string "abbcbbb". O retorno desse método deverá ser "abcb", 
         * logo o próximo caracter não deverá ser igual ao anterior, o método deve ser capaz de tratar qualquer string.
        */

        static void Main(string[] args)
        {

            String avaliacao = "abbcbbb";
            
            string processado = RemoverDuplicidades(avaliacao);

         }

        private static string RemoverDuplicidades(string mensagem)
        {

            List<string> letras = new List<string>();
            string ultimaPosicao = string.Empty;

            for (int posicao = 0; posicao < mensagem.Length; posicao++)
            {
                string analise = mensagem.Substring(posicao, 1);
                if (analise != ultimaPosicao)
                {
                    letras.Add(analise);
                    ultimaPosicao = analise;
                }
            }

            return string.Join("", letras);

        }

    }
}
