namespace uber
{
    public class Passageiro : Usario
    {
        public string SolicitarMotorista(){
            return "Procurando motorista...";
        }

        public bool Pagar(string statusCorrida){
            if(statusCorrida == "Finalizada"){
                return true;
            }
            return false;
        }
    }
}