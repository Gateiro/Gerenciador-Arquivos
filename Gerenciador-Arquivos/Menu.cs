using System;
using System.IO;

namespace Gerenciador_Arquivos
{
    class Menu
    {
        public static void Main(string[] args)
        {
            
            Arquivos Arquivos = new Arquivos();
            Pastas Pastas = new Pastas();
            
            try
            {
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
                                        Arquivos.ListarArquivos(Directory.GetCurrentDirectory());
                                        break;
                                    case 2:
                                        Arquivos.CriarArquivo(Directory.GetCurrentDirectory());
                                        break;
                                    case 3:
                                        Arquivos.RenomearArquivos();
                                        break;
                                    case 4:
                                        Arquivos.AlterarConteudoArquivo();
                                        break;
                                    case 5:
                                        Arquivos.DeletarArquivo();
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
                                        Pastas.ListarPastas(Directory.GetCurrentDirectory());
                                        break;
                                    case 2:
                                        string caminhoAtual = Directory.GetCurrentDirectory();
                                        Pastas.CriarPasta(caminhoAtual);
                                        break;
                                    case 3:
                                        Pastas.RenomearPastas();
                                        break;
                                    case 4:
                                        Pastas.DeletarPasta();
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
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro de formato: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }
}