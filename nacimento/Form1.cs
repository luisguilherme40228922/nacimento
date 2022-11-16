using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nacimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbllabel_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.Date.ToShortDateString(); //Aqui envia para a textbox a data de nascimento

            int ano_nasc = Calendar1.SelectedDate.Year; //Ano de nascimento
            int ano_actual = DateTime.Now.Year; //Ano actual

            int anos = ano_actual - ano_nasc; //Calcula os anos 
        }
    }
}
