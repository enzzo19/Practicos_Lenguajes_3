
namespace TP2_Figuras_Geometricas_Juarez_Enzo
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
            this.pnl_rectangulo = new System.Windows.Forms.Panel();
            this.pnl_cuadrado = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_perimetro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_ladoB = new System.Windows.Forms.TextBox();
            this.txt_ladoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_rectangulo
            // 
            this.pnl_rectangulo.BackColor = System.Drawing.Color.Red;
            this.pnl_rectangulo.Location = new System.Drawing.Point(21, 211);
            this.pnl_rectangulo.Name = "pnl_rectangulo";
            this.pnl_rectangulo.Size = new System.Drawing.Size(150, 60);
            this.pnl_rectangulo.TabIndex = 7;
            this.pnl_rectangulo.Visible = false;
            // 
            // pnl_cuadrado
            // 
            this.pnl_cuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnl_cuadrado.Location = new System.Drawing.Point(49, 190);
            this.pnl_cuadrado.Name = "pnl_cuadrado";
            this.pnl_cuadrado.Size = new System.Drawing.Size(100, 100);
            this.pnl_cuadrado.TabIndex = 6;
            this.pnl_cuadrado.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_perimetro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_area);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(191, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // txt_perimetro
            // 
            this.txt_perimetro.Location = new System.Drawing.Point(66, 85);
            this.txt_perimetro.Name = "txt_perimetro";
            this.txt_perimetro.Size = new System.Drawing.Size(100, 20);
            this.txt_perimetro.TabIndex = 10;
            this.txt_perimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Area:";
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(66, 36);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(100, 20);
            this.txt_area.TabIndex = 9;
            this.txt_area.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Perimetro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.btn_calcular);
            this.groupBox1.Controls.Add(this.txt_ladoB);
            this.groupBox1.Controls.Add(this.txt_ladoA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Lados del Cuadrilatero";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(211, 117);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(211, 72);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(211, 29);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_ladoB
            // 
            this.txt_ladoB.Location = new System.Drawing.Point(28, 98);
            this.txt_ladoB.Name = "txt_ladoB";
            this.txt_ladoB.Size = new System.Drawing.Size(100, 20);
            this.txt_ladoB.TabIndex = 3;
            this.txt_ladoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ladoA
            // 
            this.txt_ladoA.Location = new System.Drawing.Point(28, 49);
            this.txt_ladoA.Name = "txt_ladoA";
            this.txt_ladoA.Size = new System.Drawing.Size(100, 20);
            this.txt_ladoA.TabIndex = 2;
            this.txt_ladoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 324);
            this.Controls.Add(this.pnl_rectangulo);
            this.Controls.Add(this.pnl_cuadrado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_rectangulo;
        private System.Windows.Forms.Panel pnl_cuadrado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_perimetro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_ladoB;
        private System.Windows.Forms.TextBox txt_ladoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

