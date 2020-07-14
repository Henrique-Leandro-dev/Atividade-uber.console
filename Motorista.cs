namespace uber
{
    public class Motorista : Usario
    {
        public string Carro { get; set; }
        public string Placa { get; set; }

        public string AceitarPassageiro( string nome){
            return $"Passageiro {nome} aceito pelo motorista {this.Nome}";
        }

        public bool ReceberPagamento(string statusCorrida){
            if(statusCorrida == "Finalizada"){
                return true;
            }
            return false;
        }
        
    }
}