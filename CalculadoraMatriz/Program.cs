using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatriz
{
    class Program
    {
        private static int sairPrograma;
        private static int saida;

        static void Main(string[] args)
        {
            void somaMatriz()
            {
                int sairPrograma = 0;
                int saida = 0;

                Console.WriteLine("SOMA DE MATRIZES");
                Console.WriteLine("Digite o tamanho da matriz:");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine("MATRIZ " + tamanho + " x " + tamanho);

                int[] matrizA = new int[tamanho * tamanho];
                int[] matrizB = new int[tamanho * tamanho];

                int contador = 0;

                Console.WriteLine("Digite os valores da matriz A");
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("matrizA[" + i + "][" + j + "]");
                        matrizA[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }

                contador = 0;
                Console.WriteLine("Digite os valores da matriz B");
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("matrizB[" + i + "][" + j + "]");
                        matrizB[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }

                int[] matrizResultado = new int[tamanho * tamanho];

                for (int i = 0; i < tamanho*tamanho; i++)
                {
                    matrizResultado[i] = matrizA[i] + matrizB[i];
                }

                int iContador = 0;
                int jContador = 0;
                for (int i = 0; i < tamanho * tamanho; i++)
                {
                    if (iContador == tamanho) iContador = 0;
                    if (jContador == tamanho) jContador = 0;
                    Console.WriteLine("matrizResultado[" + iContador + "][" + jContador + "] = " + matrizResultado[i]);
                    iContador++;
                    jContador++;
                }

                Console.Write("\n(1) Voltar ao Menu");
                Console.Write("\n(0) Sair do Programa\n");
                saida = int.Parse(Console.ReadLine());
                if (saida == 1) { sairPrograma = 0; }
                if (saida == 0) { sairPrograma = 1; }
            }

            void subMatriz()
            {
                Console.WriteLine("SUBTRAÇÃO DE MATRIZES");
                Console.WriteLine("Digite o tamanho da matriz:");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine("MATRIZ " + tamanho + " x " + tamanho);

                int[] matrizA = new int[tamanho * tamanho];
                int[] matrizB = new int[tamanho * tamanho];

                int contador = 0;

                Console.WriteLine("Digite os valores da matriz A");
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("matrizA[" + i + "][" + j + "]");
                        matrizA[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }

                contador = 0;
                Console.WriteLine("Digite os valores da matriz B");
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("matrizB[" + i + "][" + j + "]");
                        matrizB[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }

                int[] matrizResultado = new int[tamanho * tamanho];

                for (int i = 0; i < tamanho * tamanho; i++)
                {
                    matrizResultado[i] = matrizA[i] - matrizB[i];
                }

                int iContador = 0;
                int jContador = 0;
                for (int i = 0; i < tamanho * tamanho; i++)
                {
                    if (iContador == tamanho) iContador = 0;
                    if (jContador == tamanho) jContador = 0;
                    Console.WriteLine("matrizResultado[" + iContador + "][" + jContador + "] = " + matrizResultado[i]);
                    iContador++;
                    jContador++;
                }

                Console.Write("\n(1) Voltar ao Menu");
                Console.Write("\n(0) Sair do Programa\n");
                saida = int.Parse(Console.ReadLine());
                if (saida == 1) { sairPrograma = 0; }
                if (saida == 0) { sairPrograma = 1; }
            }

            void multConsMatriz()
            {
                Console.WriteLine("MULTIPLCAÇÃO DE UMA CONSTANTE COM UMA MATRIZES");
                Console.WriteLine("Digite o tamanho da matriz:");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine("MATRIZ " + tamanho + " x " + tamanho);

                int[] matrizA = new int[tamanho * tamanho];

                int contador = 0;

                Console.WriteLine("Digite os valores da matriz A");
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("matrizA[" + i + "][" + j + "]");
                        matrizA[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }

                Console.WriteLine("Digite o valor da constante: ");
                int constante = int.Parse(Console.ReadLine());

                int[] matrizResultado = new int[tamanho * tamanho];

                for (int i = 0; i < tamanho * tamanho; i++)
                {
                    matrizResultado[i] = matrizA[i] * constante;
                }

                int iContador = 0;
                int jContador = 0;
                for (int i = 0; i < tamanho * tamanho; i++)
                {
                    if (iContador == tamanho) iContador = 0;
                    if (jContador == tamanho) jContador = 0;
                    Console.WriteLine("matrizResultado[" + iContador + "][" + jContador + "] = " + matrizResultado[i]);
                    iContador++;
                    jContador++;
                }

                Console.Write("\n(1) Voltar ao Menu");
                Console.Write("\n(0) Sair do Programa\n");
                saida = int.Parse(Console.ReadLine());
                if (saida == 1) { sairPrograma = 0; }
                if (saida == 0) { sairPrograma = 1; }
            }

            void divMatriz()
            {
                Console.WriteLine("DIVISÃO DE MATRIZES");
                Console.WriteLine("Digite o tamanho da matriz:");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine("MATRIZ " + tamanho + " x " + tamanho);

                int[] matrizA = new int[tamanho * tamanho];
                int[] matrizB = new int[tamanho * tamanho];

                int contador = 0;

                Console.WriteLine("Digite os valores da matriz A");
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("matrizA[" + i + "][" + j + "]");
                        matrizA[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }

                contador = 0;
                Console.WriteLine("Digite os valores da matriz B");
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("matrizB[" + i + "][" + j + "]");
                        matrizB[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }

                int[] matrizResultado = new int[tamanho * tamanho];

                for (int i = 0; i < tamanho * tamanho; i++)
                {
                    matrizResultado[i] = matrizA[i] / matrizB[i];
                }

                int iContador = 0;
                int jContador = 0;
                for (int i = 0; i < tamanho * tamanho; i++)
                {
                    if (iContador == tamanho) iContador = 0;
                    if (jContador == tamanho) jContador = 0;
                    Console.WriteLine("matrizResultado[" + iContador + "][" + jContador + "] = " + matrizResultado[i]);
                    iContador++;
                    jContador++;
                }

                Console.Write("\n(1) Voltar ao Menu");
                Console.Write("\n(0) Sair do Programa\n");
                saida = int.Parse(Console.ReadLine());
                if (saida == 1) { sairPrograma = 0; }
                if (saida == 0) { sairPrograma = 1; }
            }

            void decisoes(int decisao)
            {
                switch (decisao)
                {
                    case 1:
                        somaMatriz();
                        break;
                    case 2:
                        subMatriz();
                        break;
                    case 3:
                        multConsMatriz();
                        break;
                    case 4:
                        divMatriz();
                        break;
                    case 0:
                        sairPrograma = 1;
                        break;
                }
            }

            int menu()
            {
                Console.WriteLine("\n\n===== CALCULADORA DE MATRIZES =====\n");
                Console.WriteLine("Escolha uma das operações abaixo:");
                Console.WriteLine("(1) SOMA");
                Console.WriteLine("(2) SUBTRAÇÃO");
                Console.WriteLine("(3) MULTIPLICAÇÃO COM CONSTANTE");
                Console.WriteLine("(4) DIVISAO");
                Console.WriteLine("(0) SAIR DO PROGRAMA");
                Console.WriteLine("\n===================================\n");
                return int.Parse(Console.ReadLine());
            }


            while (sairPrograma == 0)
            {
                int num = menu();
                decisoes(num);
            }
            

        }
    }
}
