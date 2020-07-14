namespace uber
{
    public class Usario
    {
        public string Nome { get; set; }

        private int idade = 0;
        public int Idade
        {
            get{ return idade;}
            set{
                if(idade>0){
                    idade = value;
                }
            }
        }

        public string Foto {get;set;}
        private string login = "henrique@gmail.com";
        private string senha = "defre334";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }
        public string TipoAcesso { get; set; }

        ///<sumary>
        /// Faz login no sistema
        /// </sumary>
        /// <param name="login">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns> Salva o token e retorna se o login foi aprovado ou nao</returns>

        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha)
            {
                TokenLogin =
                "iewhyfwhfjsdhsdlkfj";
                return true;
            }
            return false;
        }
        public void Logout(){
            TokenLogin = "";
        }


    }
}