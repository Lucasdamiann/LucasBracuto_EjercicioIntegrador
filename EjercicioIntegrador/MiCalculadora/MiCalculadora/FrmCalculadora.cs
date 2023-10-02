using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private ESistema sistema;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.Items.Add('+');
            this.cmbOperacion.Items.Add('-');
            this.cmbOperacion.Items.Add('*');
            this.cmbOperacion.Items.Add('/');
            this.rdbDecimal.Checked = true;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(this.txtPrimerOperador.Text, ESistema.Decimal);
            this.segundoOperando = new Numeracion(this.txtSegundoOperador.Text, ESistema.Decimal);
            this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
            char operador = (char)this.cmbOperacion.SelectedItem;
            if (rdbBinario.Checked == true)
            {
                this.sistema = ESistema.Binario;
            }
            else
            {
                this.sistema = ESistema.Decimal;
            }
            this.resultado = new Numeracion(this.calculadora.Operar(operador).Valor, this.sistema);
            this.setResultado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                txtPrimerOperador.Text = "";
                txtSegundoOperador.Text = "";
                lblResultado.Text = "Resultado:";
                resultado = null;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setResultado()
        {
            this.lblResultado.Text = this.resultado.Valor;
        }
    }
}