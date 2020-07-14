using System;

namespace uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro passageiro = new Passageiro();

            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();
            passageiro.Login(login, senha);

            if( passageiro.TokenLogin !="" && passageiro.TokenLogin != null){

                System.Console.WriteLine("Login autorizado!");

                // Instaciamos um motorista para teste
                Motorista motorista = new Motorista();
                motorista.Nome = "Claudio";
                motorista.Placa = "XLSK-2235";
                motorista.Carro = "Rand Louver";

                // Cadastramos uma conta para o motorista
                Conta contaMotorista = new Conta();
                contaMotorista.Cadastrar();

                // Atribuímos dados do passageiro
                passageiro.Nome = "Jefersson da Silva";
                passageiro.Idade = 30;
                passageiro.LocalizacaoAtual = "Rua 32 de ipiranga, 345";

                // salvamos um cartão para o usuário
                Cartao cartao = new Cartao();
                cartao.Cadastrar();

                passageiro.SolicitarMotorista();
                motorista.AceitarPassageiro(passageiro.Nome);

                //Começamos uma corrida
                Corrida corrida = new Corrida();
                corrida.LocalInicio = passageiro.LocalizacaoAtual;
                corrida.LocalChegada = "Eldorado, 342";
                corrida.motorista = motorista.Nome;
                corrida.passageiro = passageiro.Nome;

                string resposta = "Não chegamos";

                while(resposta != "Sim"){
                    System.Console.WriteLine("Você chegou ao seu destino? Digite: Sim ou Nao");
                    resposta = Console.ReadLine();
                }
                // finalizamos a corrida
                corrida.StatusCorrida = "Finalizada";
                passageiro.Pagar(corrida.StatusCorrida);
                motorista.ReceberPagamento(corrida.StatusCorrida);

                // Realizamos o Pagamento
                Pagamento pgto = new Pagamento();
                pgto.Data = DateTime.Now;
                pgto.StatusPagamento = "Pago";

                System.Console.WriteLine("Corrida Finalizada");
                System.Console.WriteLine("Status Corrida: " + corrida.StatusCorrida);
                System.Console.WriteLine("Status pagamento:" + pgto.StatusPagamento);
                System.Console.WriteLine("Data e hora:" + pgto.Data);
                System.Console.WriteLine("Motorista:" + motorista.Nome);

            }else{
                System.Console.WriteLine("Não é possível utilizar o app");
            }
        }
    }
}
