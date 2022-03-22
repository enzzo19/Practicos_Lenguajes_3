
namespace TP2_Juarez_Enzo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_bonificacion = new System.Windows.Forms.CheckBox();
            this.num_hijos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pago_extra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_horas_extras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pago_normal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_horas_normales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_bonificacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sueldo_neto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sueldo_bruto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_hijos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_calcular);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_pago_extra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_horas_extras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_pago_normal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_horas_normales);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jornada Laboral";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(370, 199);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(212, 199);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Nuevo";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(59, 199);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 9;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_bonificacion);
            this.groupBox3.Controls.Add(this.num_hijos);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 42);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonificacion";
            // 
            // chk_bonificacion
            // 
            this.chk_bonificacion.AutoSize = true;
            this.chk_bonificacion.Location = new System.Drawing.Point(320, 16);
            this.chk_bonificacion.Name = "chk_bonificacion";
            this.chk_bonificacion.Size = new System.Drawing.Size(84, 17);
            this.chk_bonificacion.TabIndex = 11;
            this.chk_bonificacion.Text = "Bonificacion";
            this.chk_bonificacion.UseVisualStyleBackColor = true;
            // 
            // num_hijos
            // 
            this.num_hijos.Location = new System.Drawing.Point(162, 14);
            this.num_hijos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_hijos.Name = "num_hijos";
            this.num_hijos.Size = new System.Drawing.Size(78, 20);
            this.num_hijos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de Hijos";
            // 
            // txt_pago_extra
            // 
            this.txt_pago_extra.Location = new System.Drawing.Point(345, 115);
            this.txt_pago_extra.Name = "txt_pago_extra";
            this.txt_pago_extra.Size = new System.Drawing.Size(100, 20);
            this.txt_pago_extra.TabIndex = 7;
            this.txt_pago_extra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pago por Hora Extra";
            // 
            // txt_horas_extras
            // 
            this.txt_horas_extras.Location = new System.Drawing.Point(59, 115);
            this.txt_horas_extras.Name = "txt_horas_extras";
            this.txt_horas_extras.Size = new System.Drawing.Size(100, 20);
            this.txt_horas_extras.TabIndex = 5;
            this.txt_horas_extras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas Extras Trabajadas";
            // 
            // txt_pago_normal
            // 
            this.txt_pago_normal.Location = new System.Drawing.Point(345, 57);
            this.txt_pago_normal.Name = "txt_pago_normal";
            this.txt_pago_normal.Size = new System.Drawing.Size(100, 20);
            this.txt_pago_normal.TabIndex = 3;
            this.txt_pago_normal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pago por Hora Normal";
            // 
            // txt_horas_normales
            // 
            this.txt_horas_normales.Location = new System.Drawing.Point(59, 57);
            this.txt_horas_normales.Name = "txt_horas_normales";
            this.txt_horas_normales.Size = new System.Drawing.Size(100, 20);
            this.txt_horas_normales.TabIndex = 1;
            this.txt_horas_normales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas Normales Trabajadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_bonificacion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_sueldo_neto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_sueldo_bruto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(23, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo";
            // 
            // txt_bonificacion
            // 
            this.txt_bonificacion.Location = new System.Drawing.Point(440, 25);
            this.txt_bonificacion.Name = "txt_bonificacion";
            this.txt_bonificacion.Size = new System.Drawing.Size(100, 20);
            this.txt_bonificacion.TabIndex = 17;
            this.txt_bonificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bonificacion: ";
            // 
            // txt_sueldo_neto
            // 
            this.txt_sueldo_neto.Location = new System.Drawing.Point(260, 25);
            this.txt_sueldo_neto.Name = "txt_sueldo_neto";
            this.txt_sueldo_neto.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldo_neto.TabIndex = 15;
            this.txt_sueldo_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sueldo Neto: ";
            // 
            // txt_sueldo_bruto
            // 
            this.txt_sueldo_bruto.Location = new System.Drawing.Point(80, 25);
            this.txt_sueldo_bruto.Name = "txt_sueldo_bruto";
            this.txt_sueldo_bruto.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldo_bruto.TabIndex = 13;
            this.txt_sueldo_bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sueldo Bruto: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TP2_Juarez Enzo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_hijos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_bonificacion;
        private System.Windows.Forms.NumericUpDown num_hijos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pago_extra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_horas_extras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pago_normal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_horas_normales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_sueldo_bruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bonificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sueldo_neto;
        private System.Windows.Forms.Label label7;
    }
}

