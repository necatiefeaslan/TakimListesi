using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakimListesi
{
    public partial class Form1 : Form
    {
        string[,] takımlar = new string[4, 3]
        {
            {"samet","sadettin","selim"},
            {"muzaffer","eyüp","özlem" },
            {"erdem","mahmut","bedirhan"},
            {"mehmet","burak","ayşe" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(takımlar[3, 0]+" "+ takımlar[3, 1]+" "+ takımlar[3,2]);
            

        }
    }
}
