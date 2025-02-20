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
        public static void CriarArquivo(string caminhoAtual)
        {
            Console.WriteLine($"Diretório atual: {caminhoAtual}");
            //Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
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
            // Combina o caminho base com o nome da nova pasta
            string caminhoCompleto = Path.Combine(caminhoAtual, nomeArquivo);

            try
            {
                // Cria a pasta
                File.Create(caminhoCompleto);
                Console.WriteLine($"Arquivo '{nomeArquivo}' criada com sucesso em: {caminhoCompleto}");
                // Verificação para adicionar conteúdo ao arquivo
                Console.WriteLine("Deseja adicionar conteúdo ao arquivo? (s/n)");
                string respostaConteudo = Console.ReadLine();
                if (respostaConteudo == "s")
                {
                    Console.Write("Digite o conteúdo do arquivo: ");
                    string conteudo = Console.ReadLine();
                    File.WriteAllText(Path.Combine(caminhoAtual, nomeArquivo), conteudo);
                    Console.WriteLine($"Arquivo '{nomeArquivo}' criado com sucesso em: {caminhoAtual}");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
            }
        }


        public static void ListarArquivos(string caminho)
        {
            try
            {
                Console.WriteLine($"Diretório atual: {caminho}");
                //Verificação para alterar ou não o caminho do atual, caso não seja alterado, o caminho atual será o diretório atual onde está executando o programa.
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
                    caminho = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Digite o caminho do arquivo que deseja renomear: ");
                    string caminho = Console.ReadLine();
                    Console.WriteLine("Digite o novo nome do arquivo: ");
                    string novoNome = Console.ReadLine();

                    string diretorio = Path.GetDirectoryName(caminho);
                    string novoCaminho = Path.Combine(diretorio, novoNome);

                    File.Move(caminho, novoCaminho);
                    Console.WriteLine($"Arquivo renomeado com sucesso para: {novoNome}");
                }

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
                    caminho = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Digite o caminho do arquivo que deseja deletar: ");
                    string caminho = Console.ReadLine();

                    File.Delete(caminho);
                    Console.WriteLine("Arquivo deletado com sucesso");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar a pasta: {ex.Message}");
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
                    caminho = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Digite o caminho do arquivo que deseja alterar o conteúdo: ");
                    string caminho = Console.ReadLine();
                    Console.WriteLine("Digite o novo conteúdo do arquivo: ");
                    string novoConteudo = Console.ReadLine();

                    File.WriteAllText(caminho, novoConteudo);
                    Console.WriteLine("Conteúdo do arquivo alterado com sucesso");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao alterar o conteúdo do arquivo: {ex.Message}");
            }

        }
    }

}
