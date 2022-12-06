using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp2
{
    public partial class frmHasil : Form
    {
        public frmHasil()
        {
            InitializeComponent();
        }

        private void proses(int nilaiA, int nilaiB, string operasi, string operasilabel, float hasil)
        {
            lstHasil.Items.Add(
                String.Format($"Hasil {operasilabel} dari {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
                );
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCal = new FrmCalculator();
            frmCal.prosesEvent += proses;
            frmCal.ShowDialog();
        }
    }
}
