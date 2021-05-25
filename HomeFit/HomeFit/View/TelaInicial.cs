using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeFit.View
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\ProjetoHomeFit\\HomeFit\\HomeFit\\Properties\\Resource\\TelaInicial.jpeg");
        }
    }
}
