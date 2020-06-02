using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programa
{
    public class LerArquico
    {
        public string LerArquivo()
        {
                    string palavra = "";
            string arquivo = @"\Estados.csv";
            if (File.Exists(arquivo))
            {
                try
                {
                        StreamWriter X;
                        X = File.AppendText(arquivo);
                        string escrita = "teste,teste,teste";
                        escrita += ",1";
                        X.WriteLine(escrita);
                        X.Close();
                    using (StreamReader sr = new StreamReader(arquivo))
                    {

                            String linha;
                            int linhas = sr.Peek();
                        Console.WriteLine($"Tamanho da lista: {linhas}");
                        string[] coluna;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            int i;
                            coluna = linha.Split(',');
                            for (i = 0; i < coluna.Length; i++)
                            {

                                palavra += coluna[i];
                            }
                        }
                        Console.WriteLine($"Fim, palavra => {palavra}");
                        sr.Close();
                        return palavra;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");
            }
            Console.ReadKey();

            return palavra;
        }
    }

}
