using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 1;
            numero = int.Parse(txtNumero.Text);
            while (i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, " * ", i, " = ", resultado));
                i = i + 1;
            }
            /* declaracao de variaveis do tipo interio
             * conversao para int
             * condicao, enquanto i for menor  ou igual a 10
             * variavel resultado multiplica o numero digitado
             listbox adiciona o item e concatena
            incremento */
        }

        private void lstTabuada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
