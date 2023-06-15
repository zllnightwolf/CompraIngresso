using CompraIngresso.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraIngresso.View
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Ingresso ingresso = new Ingresso();
            int q = Convert.ToInt32(txtQuantidade.Text);
            int v = Convert.ToInt32(txtValor.Text);
            string r = ingresso.Calculo(q, v).ToString();
            lblResul.Text = r; 
        }
    }
}
