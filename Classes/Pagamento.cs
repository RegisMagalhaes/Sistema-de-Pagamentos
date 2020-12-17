using System;

namespace Abstração.Classes
{
    public abstract class Pagamento
    {
        private DateTime Data;

        protected float valor;

        public string Cancelar(){

            return "";
        }

        public abstract string Desconto(int valor);

        public abstract string Juros(int parcelas);
        
        

    }    
}