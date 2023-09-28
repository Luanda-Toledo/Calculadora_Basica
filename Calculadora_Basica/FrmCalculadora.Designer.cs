namespace Calculadora_Basica
{
    // La parte estetica (ej propiedaddes: color, title, etc)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            resultado = new Label();
            tipoSistema = new GroupBox();
            binario_sist = new RadioButton();
            decimal_sist = new RadioButton();
            primerOperador = new TextBox();
            segundoOperador = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            operar = new Button();
            cerrar = new Button();
            limpiar = new Button();
            operacion = new ComboBox();
            tipoSistema.SuspendLayout();
            SuspendLayout();
            // 
            // resultado
            // 
            resources.ApplyResources(resultado, "resultado");
            resultado.ForeColor = Color.FromArgb(64, 64, 64);
            resultado.Name = "resultado";
            // 
            // tipoSistema
            // 
            tipoSistema.AccessibleRole = AccessibleRole.TitleBar;
            tipoSistema.BackColor = Color.PapayaWhip;
            resources.ApplyResources(tipoSistema, "tipoSistema");
            tipoSistema.Controls.Add(binario_sist);
            tipoSistema.Controls.Add(decimal_sist);
            tipoSistema.Cursor = Cursors.Hand;
            tipoSistema.FlatStyle = FlatStyle.Flat;
            tipoSistema.ForeColor = SystemColors.ControlText;
            tipoSistema.Name = "tipoSistema";
            tipoSistema.TabStop = false;
            tipoSistema.UseWaitCursor = true;
            // 
            // binario_sist
            // 
            resources.ApplyResources(binario_sist, "binario_sist");
            binario_sist.Name = "binario_sist";
            binario_sist.UseVisualStyleBackColor = true;
            binario_sist.UseWaitCursor = true;
            binario_sist.CheckedChanged += binario_sist_CheckedChanged;
            // 
            // decimal_sist
            // 
            resources.ApplyResources(decimal_sist, "decimal_sist");
            decimal_sist.Checked = true;
            decimal_sist.Name = "decimal_sist";
            decimal_sist.TabStop = true;
            decimal_sist.UseVisualStyleBackColor = true;
            decimal_sist.UseWaitCursor = true;
            decimal_sist.CheckedChanged += decimal_sist_CheckedChanged;
            // 
            // primerOperador
            // 
            primerOperador.BackColor = SystemColors.Info;
            resources.ApplyResources(primerOperador, "primerOperador");
            primerOperador.Name = "primerOperador";
            primerOperador.TextChanged += primerOperador_TextChanged;
            // 
            // segundoOperador
            // 
            segundoOperador.BackColor = SystemColors.Info;
            resources.ApplyResources(segundoOperador, "segundoOperador");
            segundoOperador.Name = "segundoOperador";
            segundoOperador.TextChanged += segundoOperador_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // operar
            // 
            operar.BackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(operar, "operar");
            operar.Name = "operar";
            operar.UseVisualStyleBackColor = false;
            operar.Click += operar_Click;
            // 
            // cerrar
            // 
            cerrar.BackColor = Color.MistyRose;
            resources.ApplyResources(cerrar, "cerrar");
            cerrar.Name = "cerrar";
            cerrar.UseVisualStyleBackColor = false;
            cerrar.Click += cerrar_Click;
            // 
            // limpiar
            // 
            limpiar.BackColor = SystemColors.GradientInactiveCaption;
            resources.ApplyResources(limpiar, "limpiar");
            limpiar.Name = "limpiar";
            limpiar.UseVisualStyleBackColor = false;
            limpiar.Click += limpiar_Click;
            // 
            // operacion
            // 
            operacion.BackColor = SystemColors.Info;
            operacion.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(operacion, "operacion");
            operacion.FormattingEnabled = true;
            operacion.Items.AddRange(new object[] { resources.GetString("operacion.Items"), resources.GetString("operacion.Items1"), resources.GetString("operacion.Items2"), resources.GetString("operacion.Items3") });
            operacion.Name = "operacion";
            operacion.SelectedIndexChanged += operacion_SelectedIndexChanged;
            // 
            // FrmCalculadora
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(operacion);
            Controls.Add(limpiar);
            Controls.Add(cerrar);
            Controls.Add(operar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(segundoOperador);
            Controls.Add(primerOperador);
            Controls.Add(tipoSistema);
            Controls.Add(resultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            FormClosing += FrmCalculadora_FormClosing;
            tipoSistema.ResumeLayout(false);
            tipoSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultado;
        private GroupBox tipoSistema;
        private RadioButton binario_sist;
        private RadioButton decimal_sist;
        private TextBox primerOperador;
        private TextBox segundoOperador;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button operar;
        private Button cerrar;
        private Button limpiar;
        private ComboBox operacion;
    }
}