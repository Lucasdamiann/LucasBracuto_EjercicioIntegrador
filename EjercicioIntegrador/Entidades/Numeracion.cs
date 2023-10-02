namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public ESistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }

        public string Valor
        {
            get
            {
                return this.valorNumerico.ToString();
            }
        }

        public Numeracion(double valor, ESistema sistema)
        {
            this.sistema = sistema;
            this.valorNumerico = valor;
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        private double BinarioADecimal(string valor)
        {
            double resultado = 0;
            if (EsBinario(valor))
            {
                resultado = Convert.ToInt32(valor, 2);
            }
            return resultado;
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return BinarioADecimal(this.Valor).ToString();
            }
            else
            {
                return DecimalABinario(this.Valor);
            }
        }

        private string DecimalABinario(int valor)
        {
            if (valor < 0)
            {
                valor *= -1;
            }
            return Convert.ToString(valor, 2);
        }
        private string DecimalABinario(string valor)
        {
            string retorno = "Número Inválido";
            if (int.TryParse(valor, out int numero))
            {
                retorno = DecimalABinario(numero);
            }
            return retorno;
        }

        private bool EsBinario(string valor)
        {
            bool retorno = false;
            if (valor != null)
            {
                foreach (char caracter in valor)
                {
                    if (caracter != '0' && caracter != '1')
                    {
                        return false;
                    }
                }
                retorno = true;
            }
            return retorno;
        }

        private void InicializarValores(string valor, ESistema sistema)
        {
            //double.TryParse(valor, out double aux);
            //this.valorNumerico = aux;
            //this.sistema = sistema;
            this.valorNumerico = double.MinValue;
            if (sistema == ESistema.Binario && EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
                this.sistema = sistema;
            }
            else
            {
                double.TryParse(valor, out this.valorNumerico);
                this.sistema = sistema;
            }
        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion.sistema);
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1.sistema == n2.sistema);
        }

        public static Numeracion operator - (Numeracion n1, Numeracion n2)
        {
            Numeracion numeracion = new Numeracion(double.Parse(n1.Valor) - double.Parse(n2.Valor), ESistema.Decimal);
            return numeracion;
        }

        public static Numeracion operator * (Numeracion n1, Numeracion n2)
        {
            Numeracion numeracion = new Numeracion(double.Parse(n1.Valor) * double.Parse(n2.Valor), ESistema.Decimal);
            return numeracion;
        }

        public static Numeracion operator / (Numeracion n1, Numeracion n2)
        {
            Numeracion numeracion = n2;
            if ((double.Parse(n2.Valor)) != 0)
            {
                numeracion = new Numeracion(double.Parse(n1.Valor) / double.Parse(n2.Valor), ESistema.Decimal);
            }
            return numeracion;
        }

        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            Numeracion numeracion = new Numeracion(double.Parse(n1.Valor) + double.Parse(n2.Valor), ESistema.Decimal);
            return numeracion;
        }

        public static bool operator == (ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }
        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }
    }

    public enum ESistema
    {
        Decimal,
        Binario
    }
}