
namespace Ejercicio_Integrador
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("12345678");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Nancy", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("july_kpa");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Julieta", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("katty");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Candela", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode18,
            treeNode20});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_create = new System.Windows.Forms.Button();
            this.gb_creacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_creacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 12);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "Node2";
            treeNode15.Text = "12345678";
            treeNode16.Name = "Node1";
            treeNode16.Text = "Nancy";
            treeNode17.Name = "Node4";
            treeNode17.Text = "july_kpa";
            treeNode18.Name = "Node3";
            treeNode18.Text = "Julieta";
            treeNode19.Name = "Node6";
            treeNode19.Text = "katty";
            treeNode20.Name = "Node5";
            treeNode20.Text = "Candela";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Usuarios";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(137, 202);
            this.treeView1.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(43, 230);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(97, 27);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Crear Usuario";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // gb_creacion
            // 
            this.gb_creacion.Controls.Add(this.button2);
            this.gb_creacion.Controls.Add(this.txt_password);
            this.gb_creacion.Controls.Add(this.label2);
            this.gb_creacion.Controls.Add(this.txt_name);
            this.gb_creacion.Controls.Add(this.label1);
            this.gb_creacion.Location = new System.Drawing.Point(188, 12);
            this.gb_creacion.Name = "gb_creacion";
            this.gb_creacion.Size = new System.Drawing.Size(166, 245);
            this.gb_creacion.TabIndex = 2;
            this.gb_creacion.TabStop = false;
            this.gb_creacion.Text = "Creacion de Sección";
            this.gb_creacion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(60, 48);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(60, 112);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 269);
            this.Controls.Add(this.gb_creacion);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_creacion.ResumeLayout(false);
            this.gb_creacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.GroupBox gb_creacion;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

