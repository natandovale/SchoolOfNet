using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArquivosCSharp
{
    class Program
    {
        [Serializable]
        class Pessoa
        {
            public int Idade;
            public string Nome;

            public override string ToString()
            {
                return Idade.ToString() + " " + Nome;
            }
        }
        [Serializable]
        class Carro
        {
            public string Modelo;
            public string Marca;

            public override string ToString()
            {
                return Modelo.ToString() + " " + Marca.ToString();
            }
        }

        static void Main(string[] args)
        {
            string caminhoDoArquivo = "./schoolofnet.son";
            string caminhoDoArquivoBinario = "./schoolofnet.natan";
            //Criação de um arquivo!
            if (!File.Exists(caminhoDoArquivo))
            {
                File.Create(caminhoDoArquivo);
            }

            //Escrever dados em um arquivo de texto
            //StreamWriter > Canal de escrita
            /*
            StreamWriter escritor = new StreamWriter(caminhoDoArquivo, append: true);
            escritor.WriteLine("Natan");
            escritor.WriteLine("Catarine");
            escritor.Close();
            */

            //ler dados em um arquivo de texto
            //StreamReader > Canal de escrita
            /*
            StreamReader leitor = new StreamReader(caminhoDoArquivo);
            string arquivoParaLer = leitor.ReadToEnd();
            leitor.Close();
            Console.WriteLine(arquivoParaLer);
            */
            StreamReader leitor = new StreamReader(caminhoDoArquivo);
            while (!leitor.EndOfStream)
            {
                Console.WriteLine(leitor.ReadLine());
            }
            leitor.Close();

            //ler dados em um arquivo de texto binario
            //FileStream - canal de comunicacao com o arquivo binario

            FileStream canalDeEscrita = new FileStream(caminhoDoArquivoBinario, FileMode.OpenOrCreate);
            BinaryFormatter serializador = new BinaryFormatter();
            List<Pessoa> usuarios = new List<Pessoa>();

            Pessoa natan = new Pessoa();
            natan.Nome = "Natan vale";
            natan.Idade = 20;

            Pessoa joana = new Pessoa();
            joana.Nome = "joana vale";
            joana.Idade = 25;
            usuarios.Add(natan);
            usuarios.Add(joana);

            //Carro jr = new Carro();
            //jr.Marca = "Jeep";
            //jr.Modelo = "Renegade";

            //Salvamento em arquivo binario
            serializador.Serialize(canalDeEscrita, usuarios);
            //serializador.Serialize(canalDeEscrita, jr);
            canalDeEscrita.Close();

            //Para abrir um arquivo binario , temos que saber o que esta la dentro, e saber a ordem do que foi colocado dentro do arquivo.
            //Lendo dados
            FileStream canalDeLeitura = new FileStream(caminhoDoArquivoBinario, FileMode.Open);
            //Responsavel por ler os dados do arquivo binario.
            BinaryFormatter deserializador = new BinaryFormatter();
            
            var pessoas = (List<Pessoa>) deserializador.Deserialize(canalDeLeitura);
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }
            //var carro = (Carro) deserializador.Deserialize(canalDeLeitura);
            //Console.WriteLine(pessoa.ToString());
            //Console.WriteLine(carro.ToString());
            canalDeLeitura.Close();
        }
    }
}
