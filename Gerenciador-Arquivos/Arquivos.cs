using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gerenciador_Arquivos
{
    public class Arquivos
    {
        public void CriarArquivo(string caminhoAtual)
        {
            Console.WriteLine($"Diretório atual: {caminhoAtual}");
            // Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
            Console.WriteLine("Deseja alterar o caminho? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                Console.Write("Digite o novo caminho: ");
                caminhoAtual = Console.ReadLine();
            }
            
            Console.Write("Digite o nome do novo arquivo: ");
            string nomeArquivo = Console.ReadLine();

            if (File.Exists(Path.Combine(caminhoAtual, nomeArquivo)))
            {
                Console.WriteLine("Arquivo já existe");
                return;
            }
            // Combina o caminho base com o nome do novo arquivo
            string caminhoCompleto = Path.Combine(caminhoAtual, nomeArquivo);

            try
            {
                // Cria o arquivo
                using (FileStream fs = File.Create(caminhoCompleto))
                {
                    Console.WriteLine($"Arquivo '{nomeArquivo}' criado com sucesso em: {caminhoCompleto}");
                }
                // Verificação para adicionar conteúdo ao arquivo
                Console.WriteLine("Deseja adicionar conteúdo ao arquivo? (s/n)");
                string respostaConteudo = Console.ReadLine();
                if (respostaConteudo == "s")
                {
                    Console.Write("Digite o conteúdo do arquivo: ");
                    string conteudo = Console.ReadLine();
                    File.WriteAllText(caminhoCompleto, conteudo);
                    Console.WriteLine($"Conteúdo adicionado ao arquivo '{nomeArquivo}' com sucesso.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
            }
        }

        public void ListarArquivos(string caminho)
        {
            try
            {
                Console.WriteLine($"Diretório atual: {caminho}");
                // Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
                Console.WriteLine("Deseja alterar o caminho? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.Write("Digite o novo caminho: ");
                    caminho = Console.ReadLine();
                }

                if (!Directory.Exists(caminho))
                {
                    Console.WriteLine("O caminho especificado não existe.");
                    return;
                }
                string[] arquivos = Directory.GetFiles(caminho);
                Console.WriteLine("\nArquivos:");
                foreach (string arquivo in arquivos)
                {
                    Console.WriteLine(arquivo);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar os arquivos: {ex.Message}");
            }
        }

        public void RenomearArquivos()
        {
            try
            {
                string caminhoAtual = Directory.GetCurrentDirectory();
                Console.WriteLine($"Diretório atual: {caminhoAtual}");
                Console.WriteLine("Deseja alterar o caminho? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.Write("Digite o novo caminho: ");
                    caminhoAtual = Console.ReadLine();
                }
                
                Console.WriteLine("Digite o nome do arquivo que deseja renomear: ");
                string nomeArquivo = Console.ReadLine();
                
                if (!File.Exists(Path.Combine(caminhoAtual, nomeArquivo)))
                {
                    Console.WriteLine("Arquivo não encontrado");
                    return;
                }
                
                Console.WriteLine("Digite o novo nome do arquivo: ");
                string novoNome = Console.ReadLine();
                string caminhoAntigo = Path.Combine(caminhoAtual, nomeArquivo);
                string novoCaminho = Path.Combine(caminhoAtual, novoNome);

                File.Move(caminhoAntigo, novoCaminho);
                Console.WriteLine($"Arquivo renomeado com sucesso para: {novoNome}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao renomear o arquivo: {ex.Message}");
            }
        }

        public void DeletarArquivo()
        {
            try
            {
                string caminhoAtual = Directory.GetCurrentDirectory();
                Console.WriteLine($"Diretório atual: {caminhoAtual}");
                Console.WriteLine("Deseja alterar o caminho? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.Write("Digite o novo caminho: ");
                    caminhoAtual = Console.ReadLine();
                }
                
                Console.WriteLine("Digite o nome do arquivo que deseja deletar: ");
                string nomeArquivo = Console.ReadLine();
                
                if (!File.Exists(Path.Combine(caminhoAtual, nomeArquivo)))
                {
                    Console.WriteLine("Arquivo não encontrado");
                    return;
                }
                
                File.Delete(Path.Combine(caminhoAtual, nomeArquivo));
                Console.WriteLine("Arquivo deletado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar o arquivo: {ex.Message}");
            }
        }

        public void AlterarConteudoArquivo()
        {
            try
            {
                string caminhoAtual = Directory.GetCurrentDirectory();
                Console.WriteLine($"Diretório atual: {caminhoAtual}");
                Console.WriteLine("Deseja alterar o caminho? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.Write("Digite o novo caminho: ");
                    caminhoAtual = Console.ReadLine();
                }
                
                Console.WriteLine("Digite o nome do arquivo que deseja alterar o conteúdo: ");
                string nomeArquivo = Console.ReadLine();

                if (!File.Exists(Path.Combine(caminhoAtual, nomeArquivo)))
                {
                    Console.WriteLine("Arquivo não encontrado");
                    return;
                }
                
                string novoCaminho = Path.Combine(caminhoAtual, nomeArquivo);
                Console.WriteLine("Digite o novo conteúdo do arquivo: ");
                string novoConteudo = Console.ReadLine();

                File.WriteAllText(novoCaminho, novoConteudo);
                Console.WriteLine("Conteúdo do arquivo alterado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao alterar o conteúdo do arquivo: {ex.Message}");
            }
        }
    }
}
