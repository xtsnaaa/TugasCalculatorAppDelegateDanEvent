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
    public partial class FrmCalculator : Form
    {
        public delegate void Proses(int nilaiA, int nilaiB, string operasi, string operasilabel, float hasi);

        public event Proses prosesEvent;


        public FrmCalculator()
        {
            InitializeComponent();
            CalculatorInit();
        }

        private void CalculatorInit()
        {
            comCal.Items.Clear();
            comCal.Items.Add("Penjumlahan");
            comCal.Items.Add("Pengurangan");
            comCal.Items.Add("Perkalian");
            comCal.Items.Add("Pembagian");
            comCal.SelectedIndex = 0;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(txtNilaiA.Text);
            int nilaiB = int.Parse(txtNilaiB.Text);
            string operasi = "";
            string operasilabel = "";
            float hasil = 0;
            switch (comCal.SelectedIndex)
            {
                //Penjumlahan
                case 0:
                    hasil = CalculatorApp2.Calculator.Penjumlahan(nilaiA, nilaiB);
                    operasilabel = "Penjumlahan";
                    operasi = "+";
                    break;

                //Pengurangan
                case 1:
                    hasil = CalculatorApp2.Calculator.Pengurangan(nilaiA, nilaiB);
                    operasilabel = "Pengurangan";
                    operasi = "-";
                    break;

                //Perkalian
                case 2:
                    hasil = CalculatorApp2.Calculator.Perkalian(nilaiA, nilaiB);
                    operasilabel = "Perkalian";
                    operasi = "*";
                    break;

                //Pembagian
                case 3:
                    hasil = CalculatorApp2.Calculator.Pembagian(nilaiA, nilaiB);
                    operasilabel = "Pembagian";
                    operasi = "/";
                    break;
            }
            prosesEvent(nilaiA, nilaiB, operasi, operasilabel, hasil);
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
