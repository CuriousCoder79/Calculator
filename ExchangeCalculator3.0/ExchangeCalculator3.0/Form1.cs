using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeCalculator3._0
{
    public partial class Form1 : Form
    {
        NairaExchangeProgram _naira;
        public Form1()
        {
            InitializeComponent();
            _naira = new NairaExchangeProgram();
        }

        private void btnDivideAvg_Click(object sender, EventArgs e)
        {
            try
            {
                _naira.abokiAvgRateOne= decimal.Parse(txtAbokiFXAvg1.Text);
                _naira.abokiAvgRateTwo = decimal.Parse(txtAbokiFXAvg2.Text);
                txtAbokiFXAvgResult.Text = _naira.AbokiFXAvgResult().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, have you left a field blank or, entered a non numeric character?");
            }
        }

        private void btnDivideAbokiTrackMas_Click(object sender, EventArgs e)
        {
            try
            {
                _naira.TrackMasRate = decimal.Parse(txtTrackMasRate.Text);
                txtAbokiTrackMasResult.Text = _naira.AbokiTrackMasResult().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, have you left a field blank or, entered a non numeric character?");
            }
        }

        private void btnDivideResipAbokiTrackMasResult_Click(object sender, EventArgs e)
        {
            try
            {
                _naira.Reciprocal = decimal.Parse(txtRecpirocal.Text);
                txtResipAbokiTrackMasResult.Text = _naira.ResipAbokiTrackMasResult().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, have you left a field blank or, entered a non numeric character?");
            }
        }
    }
}
