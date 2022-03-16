using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            gb_creacion.Visible = true;
            txt_name.Clear();
            txt_password.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            // Get the count of the child tree nodes contained in the SelectedNode.
            int my_node_count = treeView1.SelectedNode.GetNodeCount(true);
            // name to add in treeView
            string name = txt_name.Text;
            // password to add in treeView
            string password = txt_password.Text;

            treeView1.BeginUpdate();
            treeView1.Nodes[0].Nodes.Add(name);
            treeView1.Nodes[0].Nodes[my_node_count / 2].Nodes.Add(password);
            treeView1.EndUpdate();

            MessageBox.Show("Usuario Creado con Exito!!",
                            "Atencion", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

            gb_creacion.Visible = false;
            
        }
    }
}
