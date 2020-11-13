using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RVCS01.Class;

namespace RVCS01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            Curso curso = new Curso();
            var lista = curso.Listar();
            foreach (var item in lista)
            {
                lsbCursos.Items.Add(item.Id +"-"+item.Nome);
            }
        }
    }
}
