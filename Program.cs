using System;

namespace cs_1._10_AvisoFesta3
{
    class Program
    {
        static void Main(string[] args)
        {
            int j; //declara variável inteira para controle do loop
            j = 1; //inicializa variável de controle do loop

            do //início do loop
            {
                //escreve a frase
                Console.WriteLine("Hoje vai ter festa na casa da Fabi");
                //incrementa variável de controle do loop (contador) 
                j++; // Mesmo que j = j + 1 
            } while (j <= 5); //fim do loop
        }
    }
}
