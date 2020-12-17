namespace Abstração.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;

        public string numero;

        public string titular;

        public string cvv;

        public override string Desconto(int valor)
        {
            return "";
        }

        public override string Juros(int parcelas)
        {
            return "";
        }

        public string SalvarCartao(){

            return "";
        }

        
    }
}