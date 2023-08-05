using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Estoque
{
    public class Program
    {
        static void Main(string[] args) 
        { 
            //NOVO OBJETO DA CLASSE PRODUTO COM OS VALORES FORNECIDOS
            Produto produto = new Produto("TV", 900.00, 10);

            bool continuar = true;

            while (continuar)
            {
                //MENU DE OPÇOES
                Console.WriteLine("BEM VINDO!!, ESCOLHA UMA DAS OPÇÕES");
                Console.WriteLine($"(1) VER PRODUTO EM ESTOQUE");
                Console.WriteLine($"(2) ADICIONAR PRODUTO NO ESTOQUE");
                Console.WriteLine($"(3) REMOVER PRODUTO DO ESTOQUE");
                Console.WriteLine($"(4) SAIR");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //EXIBIR OS DADOS DO PRODUTO
                        Console.WriteLine("DADOS DO PRODUTO:");
                        Console.WriteLine($"ITEM: {produto.nomeP}");
                        Console.WriteLine($"PREÇO UNITÁRIO: R$ {produto.precoP.ToString("F2")}");
                        Console.WriteLine($"UNIDADES DISPONÍVEIS: {produto.quantP}");
                        Console.WriteLine($"TOTAL: R$ {produto.ValorTotalEmEstoque().ToString("F2")}");
                        Console.WriteLine();
                        break;

                    case 2:
                        //SOLICITAR USUARIO NUMERO DE PRODUTOS PARA SER ADICIONADO
                        Console.Write("DIGITE O NUMERO DE PRODUTOS PARA ADICIONAR AO ESTOQUE (ÚLTIMO NÚMERO DO SEU RU):");
                        int quantAdiciona = int.Parse(Console.ReadLine());

                        if (quantAdiciona == 0)
                        {
                            Console.WriteLine("NÚMERO ZERO DIGITADO, POR FAVOR DIGITE OUTRO NÚMERO.");
                            quantAdiciona = int.Parse(Console.ReadLine());
                        }

                        //ADICIONAR PRODUTOS NO ESTOQUE
                        produto.AdicionarProduto(quantAdiciona);
                        Console.WriteLine("PRODUTO ADICIONADO COM SUCESSO!!!");

                        //EXIBIR OS DADOS DO PRODUTO ATUALIZADO
                        Console.WriteLine("DADOS DO PRODUTO:");
                        Console.WriteLine($"ITEM: {produto.nomeP}");
                        Console.WriteLine($"PREÇO UNITÁRIO: R$ {produto.precoP.ToString("F2")}");
                        Console.WriteLine($"UNIDADES DISPONÍVEIS: {produto.quantP}");
                        Console.WriteLine($"TOTAL: R$ {produto.ValorTotalEmEstoque().ToString("F2")}");
                        Console.WriteLine();
                        break;

                    case 3:
                        //SOLICITAR USUARIO NUMERO DE PRODUTOS PARA SER REMOVIDO
                        Console.Write("DIGITE O NUMERO DE PRODUTOS PARA REMOVER DO ESTOQUE (PRIMEIRO NÚMERO DO SEU RU):");
                        int quantRemove = int.Parse(Console.ReadLine());

                        if (quantRemove == 0)
                        {
                            Console.WriteLine("NÚMERO ZERO DIGITADO, POR FAVOR DIGITE OUTRO NÚMERO.");
                            quantRemove = int.Parse(Console.ReadLine());
                        }
                        else if(quantRemove > produto.quantP)
                        {
                            Console.WriteLine("QUANTIDADE INSUFICIENTE EM ESTOQUE PARA REMOVER, DIGITE UMA QUANTIDADE VÁLIDA.");
                            quantRemove = int.Parse(Console.ReadLine());
                        }

                        //REMOVER PRODUTOS NO ESTOQUE
                        produto.RemoverProdutos(quantRemove);
                        Console.WriteLine("PRODUTO REMOVIDO COM SUCESSO!!!");

                        //EXIBIR OS DADOS DO PRODUTO ATUALIZADO
                        Console.WriteLine("DADOS DO PRODUTO:");
                        Console.WriteLine($"ITEM: {produto.nomeP}");
                        Console.WriteLine($"PREÇO UNITÁRIO: R$ {produto.precoP.ToString("F2")}");
                        Console.WriteLine($"UNIDADES DISPONÍVEIS: {produto.quantP}");
                        Console.WriteLine($"TOTAL: R$ {produto.ValorTotalEmEstoque().ToString("F2")}");
                        Console.WriteLine();
                        break;

                    case 4:
                        //OPÇÃO SAIR
                        continuar = false;
                        Console.WriteLine("VOLTE SEMPRE...ENCERRANDO PROGRAMA...");
                        break;

                    default:
                        //CASO SEJA DIGITADO UMA OPÇÃO QUE NÃO ESTÁ NO MENU
                        Console.WriteLine("OPÇÃO INVÁLIDA. POR FAVOR, ESCOLHA UMA OPÇÃO VÁLIDA.");
                        break;

                }
            }   
        }
    }
}