using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NomesDosMeses
{
    public partial class NomesDosMeses : Form
    {
        string[] mesesArray = {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"
        };

        public NomesDosMeses()
        {
            InitializeComponent();
        }
        private void NamesOfMonths_Load(object sender, EventArgs e)
        {
            lblMonth.Text = mesesArray[0].ToString();
        }

        private void label1_Click(object senderEventArgs , EventArgs e)
        {
        }

        private void reset_Click(object sender, EventArgs e)
        {
            lblMonth.Text = mesesArray[0].ToString();
        }

        private void proximo_Click(object sender, EventArgs e)
        {
          int  index = Array.FindIndex(mesesArray, row => row.Contains(lblMonth.Text.Trim()) );
                  if (index < mesesArray.Length - 1) { 
                     lblMonth.Text = mesesArray[++index].ToString();
                 }
        }

        private int IndexOf(string text)
        {
            throw new NotImplementedException();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            int index = Array.FindIndex(mesesArray, row => row.Contains(lblMonth.Text.ToString())); 
            if (index > 0)
            {
                lblMonth.Text = mesesArray[--index].ToString();
            }

        }

        private void lblDays_Click(object sender, EventArgs e)
        {
        }

    }
}