﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Arquivos
{
    public class Pastas
    {
        public void CriarPasta(string caminho)
        {
            string caminhoAtual = Directory.GetCurrentDirectory(); // Pega o diretório atual
            Console.WriteLine($"Diretório atual: {caminhoAtual}");
            //Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
            Console.WriteLine("Deseja alterar o caminho? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                Console.Write("Digite o novo caminho: ");
                caminhoAtual = Console.ReadLine();
            }

            Console.Write("Digite o nome da nova pasta: ");
            string nomePasta = Console.ReadLine();

            if (Directory.Exists(nomePasta))
            {
                Console.WriteLine("Pasta já existe");
                return;
            }
            // Combina o caminho base com o nome da nova pasta
            string caminhoCompleto = Path.Combine(caminhoAtual, nomePasta);

            try
            {
                // Cria a pasta
                Directory.CreateDirectory(caminhoCompleto);
                Console.WriteLine($"Pasta '{nomePasta}' criada com sucesso em: {caminhoCompleto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar a pasta: {ex.Message}");
            }
        }


        public void ListarPastas(string caminho)
        {
            try
            {
                string caminhoAtual = Directory.GetCurrentDirectory(); // Pega o diretório atual
                Console.WriteLine($"Diretório atual: {caminhoAtual}");
                //Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
                Console.WriteLine("Deseja alterar o caminho? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.Write("Digite o novo caminho: ");
                    caminho = Console.ReadLine();
                }
                else
                {

                    string[] pastas = Directory.GetDirectories(caminho);
                    Console.WriteLine("\nPastas:");
                    foreach (string pasta in pastas)
                    {
                        Console.WriteLine(pasta);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar as pastas: {ex.Message}");
            }
        }

        public void RenomearPastas()
        {
            try
            {
                string caminhoAtual = Directory.GetCurrentDirectory(); // Pega o diretório atual
                Console.WriteLine($"Diretório atual: {caminhoAtual}");
                //Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
                Console.WriteLine("Deseja alterar o caminho? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.Write("Digite o novo caminho: ");
                    caminhoAtual = Console.ReadLine();
                    
                }

                Console.Write("Digite o novo nome para a pasta: ");
                string nomePasta = Console.ReadLine();
                string renomear = Path.Combine(caminhoAtual, nomePasta);

                if (Directory.Exists(caminhoAtual))
                {
                    Directory.Move(caminhoAtual, renomear);
                    Console.WriteLine($"Pasta renomeada com sucesso para: {nomePasta}");
                }

                else
                {
                    Console.WriteLine("Pasta não encontrada");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao renomear a pasta: {ex.Message}");
            }
        }

        public void DeletarPasta()
        {
            try
            {
                string caminhoAtual = Directory.GetCurrentDirectory(); // Pega o diretório atual
                Console.WriteLine($"Diretório atual: {caminhoAtual}");
                //Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
                Console.WriteLine("Deseja alterar o caminho? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.Write("Digite o novo caminho: ");
                    caminhoAtual = Console.ReadLine();
                }
                
                if (Directory.Exists(caminhoAtual))
                {
                    Directory.Delete(caminhoAtual, true);
                    Console.WriteLine("Pasta deletada com sucesso");
                }

                else
                {
                    Console.WriteLine("Pasta não encontrada");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar a pasta: {ex.Message}");
            }
        }
    }
}
