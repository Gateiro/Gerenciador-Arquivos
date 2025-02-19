using System;
using System.IO;

namespace Gerenciador_Arquivos
{
    class Menu
    {
        static void Main(string[] args)
        {
            Arquivos arquivos = new Arquivos();
            Pastas pastas = new Pastas();

            do
            {
                Console.WriteLine("\n---- Gerenciador de Arquivos e Pastas ----");
                Console.WriteLine("\n1 - Arquivos");
                Console.WriteLine("2 - Pastas");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        int opc1;
                        do
                        {
                            Console.WriteLine("\n---- Gerenciador de Arquivos ----");
                            Console.WriteLine("\n1 - Listar arquivos");
                            Console.WriteLine("2 - Criar arquivo");
                            Console.WriteLine("3 - Renomear arquivo");
                            Console.WriteLine("4 - Alterar conteúdo do arquivo");
                            Console.WriteLine("5 - Deletar arquivo");
                            Console.WriteLine("0 - Voltar");
                            Console.Write("Digite a opção desejada: ");
                            opc1 = int.Parse(Console.ReadLine());
                            
                            switch (opc1)
                            {
                                case 1:
                                    Console.WriteLine("Opc1");
                                    break;
                                case 2:
                                    Console.WriteLine("Opc2");
                                    break;
                                case 3:
                                    Console.WriteLine("Opc3");
                                    break;
                                case 4:
                                    Console.WriteLine("Opc4");
                                    break;
                                case 5:
                                    Console.WriteLine("Opc5");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }

                        } while (opc1 != 0);
                        break;

                    case 2:
                        int opc2;
                        do
                        {
                            Console.WriteLine("\n---- Gerenciador de Pastas ----");
                            Console.WriteLine("\n1 - Listar pastas");
                            Console.WriteLine("2 - Criar pasta");
                            Console.WriteLine("3 - Renomear pasta");
                            Console.WriteLine("4 - Deletar pasta");
                            Console.WriteLine("0 - Voltar");
                            Console.Write("Digite a opção desejada: ");
                            opc2 = int.Parse(Console.ReadLine());

                            switch (opc2)
                            {
                                case 1:
                                    Console.WriteLine("Opc1");
                                    break;
                                case 2:
                                    string caminhoAtual = Directory.GetCurrentDirectory(); // Pega o diretório atual
                                    Pastas.CriarPasta(caminhoAtual);
                                    break;
                                case 3:
                                    Console.WriteLine("Opc3");
                                    break;
                                case 4:
                                    Console.WriteLine("Opc4");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }

                        } while (opc2 != 0);
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (true);
        }
    }
}