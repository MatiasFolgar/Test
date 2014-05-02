using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ClaseTest.sayHI());
            Abajo();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA MUNDO");
        }

        private void Abajo() { MessageBox.Show("Un mensaje"); }
    }
}
