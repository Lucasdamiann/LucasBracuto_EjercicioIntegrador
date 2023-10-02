using Entidades;
namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            cmbOperacion = new ComboBox();
            txtSegundoOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(72, 48);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(246, 65);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += lblResultado_Click;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(258, 162);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(270, 100);
            grpSistema.TabIndex = 3;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(161, 49);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 25);
            rdbBinario.TabIndex = 7;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(36, 49);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(84, 25);
            rdbDecimal.TabIndex = 6;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(66, 277);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(212, 32);
            lblPrimerOperador.TabIndex = 4;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(331, 277);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(139, 32);
            lblOperacion.TabIndex = 5;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(515, 277);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(236, 32);
            lblSegundoOperador.TabIndex = 6;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(77, 328);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(187, 36);
            txtPrimerOperador.TabIndex = 0;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(338, 326);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 38);
            cmbOperacion.TabIndex = 1;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(530, 326);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(187, 36);
            txtSegundoOperador.TabIndex = 2;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(77, 386);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(187, 46);
            btnOperar.TabIndex = 3;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(338, 386);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 46);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(530, 386);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(187, 46);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtSegundoOperador);
            Controls.Add(cmbOperacion);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de [Lucas Bracuto]";
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperador;
        private ComboBox cmbOperacion;
        private TextBox txtSegundoOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;

    }
}