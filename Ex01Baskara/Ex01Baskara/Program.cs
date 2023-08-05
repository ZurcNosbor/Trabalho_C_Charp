using System;

namespace Ex01Baskara
{
    class Program
    {
        static void Main(string[] args) {

            //DECLARANDO AS VARIAVEIS
            int letraA;
            int letraB;
            int letraC;
            double raiz;
            double delta;
            double x1;
            double x2;

            //INICIO DA INTERFACE DO USUARIO
            Console.Write("SEJA BEM VINDO AO CALCULO DA BASKARA");
            Console.WriteLine();

            //PEDINDO OS VALORES AO USUARIO
            Console.Write("Digite o valor para a letra A (PRIMEIRO NÚMERO DO SEU RU): ");
            letraA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor para a letra B (SEGUNDO NÚMERO DO SEU RU): ");
            letraB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor para a letra C (TERCEIRO NÚMERO DO SEU RU): ");
            letraC = int.Parse(Console.ReadLine());


            //CONDICIONAL PARA VERIFICAR A LETRA A (NÃO PODE SER ZERO)
            // E CASO O VALOR FINAL DE DELTA FOR UM NÚMERO NEGATIVO
            if(letraA == 0)
            {
                Console.Write("O VALOR DA LETRA A NÃO PODE SER ZERO...");
            }
            else
            {
                //CALCULA DELTA
                delta = (letraB * letraB) - (4 * letraA * letraC);

                //CASO DELTA FOR NEGATIVO
                if (delta < 0)
                {
                    Console.WriteLine($"IMPOSSIVEL DE SE CALCULAR O DELTA. VALOR NEGATIVO: {delta}");
                }
                else
                {
                    //CALCULAR AS RAIZES
                    raiz = Math.Sqrt(delta);
                    
                    x1 = (- letraB + raiz) / (2 * letraA);
                    Console.WriteLine();
                    //CONVERTENDO O RESULTADO FINAL PARA STRING
                    Console.WriteLine(String.Format($"O VALOR DE X1 É: {x1}"));

                    x2 = (- letraB - raiz) / (2 * letraA);
                    Console.WriteLine();
                    //CONVERTENDO O RESULTADO FINAL PARA STRING
                    Console.WriteLine(String.Format($"O VALOR DE X2 É: {x2}"));
                }
            }    
        }
    }
}