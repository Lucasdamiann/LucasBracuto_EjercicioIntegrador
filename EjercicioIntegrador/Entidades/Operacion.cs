using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {

        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
            }
            set
            {
                this.primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }
        public Numeracion Operar(char operador)
        {

            double auxiliar1 = double.Parse(this.primerOperando.Valor);
            double auxiliar2 = double.Parse(this.segundoOperando.Valor);
            double calculo = 0;

            switch (operador)
            {
                case '-':
                    calculo = auxiliar1 - auxiliar2;
                    break;
                case '*':
                    calculo = auxiliar1 * auxiliar2;
                    break;
                case '/':
                    if (double.Parse(this.segundoOperando.Valor) != 0)
                    {
                        calculo = auxiliar1 / auxiliar2;
                    }
                    break;
                default:
                    calculo = auxiliar1 + auxiliar2;
                    break;

            }
            Numeracion resultado = new Numeracion(calculo, ESistema.Decimal);
            return resultado;
        }

    }
}
