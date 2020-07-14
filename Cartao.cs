using System;

namespace uber
{
    public class Cartao
    {
        public string Numero { get; set;}
        public string Titular { get; set;}
        public string Bandeira { get; set;}
        public string Cvv { get; set;}


        /// <sumary>
        /// Salva os dados do cartão
        /// </suamruy>
        /// <returns></returns>
        
        
        public string Cadastrar(){
            Console.WriteLine("Digite o nome do titular do cartão:");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o número do cartãoo:");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite a bandeira do cartão:");
            Console.ReadLine();
            Console.WriteLine("Digite o código de segurança do cartão:");
            Cvv = Console.ReadLine();

            return "Cartão cadastrado com sucesso!";
        }
        /// <sumary>
        /// apaga os dados instaciados do cartão
        /// </suamry>
        public void Excluir(){
            Titular = "";
            Numero = "";
            Bandeira = "";
            Cvv = "";
        }
        }       
    }
