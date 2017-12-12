using System;
namespace StrategySample.Delivery
{
    public class CalculaFrete
    {
        private string corrier;
        public CalculaFrete(string corrier)
        {
            this.corrier = corrier;
        }

        public int Calcular(int preco)
        {
            if("correios".Equals(this.corrier))
            {
                return preco * 10;
            }
            if ("ctt".Equals(this.corrier))
            {
                return preco * 20;
            }
            if ("fedex".Equals(this.corrier))
            {
                return preco * 25;
            }
            return 0;
        }
    }
}
