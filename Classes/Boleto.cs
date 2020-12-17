using System;

namespace Abstração.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public string CodigoDeBarras{
            get{return codigoDeBarras; }
        }

        public void Registrar(string valor){

            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();

            this.codigoDeBarras = valor;

            return "";
        }

        public override string Desconto(int valor)
        {
            return "";
        }

        public override string Juros(int parcelas)
        {
            return "";
        }

        public void GerarBoleto(){
            Console.WriteLine($"Valor do Boleto - R${this.valor}");
            Console.WriteLine($"Data - {this.Data}");
            Console.WriteLine($"Data de Vencimento - {this.Data.AddDays(10)}");
            Console.WriteLine($"Codigo de barras - {this.CodigoDeBarras}");
        }
    }
}