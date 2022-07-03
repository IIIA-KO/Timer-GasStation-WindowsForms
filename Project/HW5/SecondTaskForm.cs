using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{
    public partial class SecondTaskForm : Form
    {
        double OneClientCafePay { get; set; }
        double OneClientGasPay { get; set; }
        double OneClientTotal { get; set; }
        double DayTotal = 0;


        public SecondTaskForm()
        {
            InitializeComponent();
            PetrolsComboBox.Items.Add("A-92");
            PetrolsComboBox.Items.Add("A-95");
            PetrolsComboBox.Items.Add("Дизель");
            PetrolsComboBox.SelectedIndex = 0;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            OneClientCafePay = 0;
            OneClientGasPay = 0;
            OneClientTotal = 0;

            double HotDogPrice = double.Parse(HotDogPriceTextBox.Text);
            double HamburgerPrice = double.Parse(HamburgerPriceTextBox.Text);
            double FriesPrice = double.Parse(FriesPriceTextBox.Text);
            double ColaPrice = double.Parse(ColaPriceTextBox.Text);
            double pricePerLiter = double.Parse(PriceTextBox.Text);

            if (int.TryParse(HotDogQuantityTextBox.Text, out int HotDogQuantity) && HotDogQuantity > 0 && HotDogCheckBox.Checked)
                OneClientCafePay += HotDogQuantity * HotDogPrice;

            if (int.TryParse(HamburgerQuantityTextBox.Text, out int HamburgerQuantity) && HamburgerQuantity > 0 && HamburgerCheckBox.Checked)
                OneClientCafePay += HamburgerQuantity * HamburgerPrice;

            if (int.TryParse(FriesQuantityTextBox.Text, out int FriesQuantity) && FriesQuantity > 0 && FriesCheckBox.Checked)
                OneClientCafePay += FriesQuantity * FriesPrice;

            if (int.TryParse(ColaQuantityTextBox.Text, out int ColaQuantity) && ColaQuantity > 0 && ColaCheckBox.Checked)
                OneClientCafePay += ColaQuantity * ColaPrice;


            if (QuantityRadioButton.Checked)
            {
                StationTotalPayLabel.Text = "";
                if (int.TryParse(LitersTextBox.Text, out int quantity))
                    StationTotalPayLabel.Text = (pricePerLiter * quantity).ToString() + " грн.";
                OneClientGasPay = pricePerLiter * quantity;
            }
            if (SumRadioButton.Checked)
            {
                StationTotalPayLabel.Text = "";
                if (double.TryParse(SumTextBox.Text, out double sum))
                    StationTotalPayLabel.Text = (Math.Round((sum / pricePerLiter), 3).ToString() + " л.");
                OneClientGasPay = sum;
            }


            OneClientTotal += OneClientCafePay + OneClientGasPay;

            CafeTotalPayLabel.Text = OneClientCafePay.ToString() + " грн.";
            OneClientTotalPayLabel.Text = OneClientTotal.ToString() + " грн.";

            DayTotal += OneClientTotal;
            TotalDayLabel.Text = DayTotal.ToString() + " грн.";

            CalculateButton.Enabled = false;
            timer1.Start();
        }



        private void RadioButtonsChanged(object sender, EventArgs e)
        {
            if (QuantityRadioButton.Checked)
            {
                StationTotalPayGroupBox.Text = "До оплати:";
                LitersTextBox.Enabled = true;
                SumTextBox.Enabled = false;
                SumTextBox.Text = "";
            }
            if (SumRadioButton.Checked)
            {
                StationTotalPayGroupBox.Text = "До видачі:";
                SumTextBox.Enabled = true;
                LitersTextBox.Enabled = false;
                LitersTextBox.Text = "";
            }
        }



        private void HotDogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDogCheckBox.Checked)
            {
                HotDogQuantityTextBox.Enabled = true;
            }
            else
            {
                HotDogQuantityTextBox.Text = "";
                HotDogQuantityTextBox.Enabled = false;
            }
        }
        private void HamburgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburgerCheckBox.Checked)
            {
                HamburgerQuantityTextBox.Enabled = true;
            }
            else
            {
                HamburgerQuantityTextBox.Text = "";
                HamburgerQuantityTextBox.Enabled = false;
            }
        }
        private void FriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCheckBox.Checked)
            {
                FriesQuantityTextBox.Enabled = true;
            }
            else
            {
                FriesQuantityTextBox.Text = "";
                FriesQuantityTextBox.Enabled = false;
            }
        }
        private void ColaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCheckBox.Checked)
            {
                ColaQuantityTextBox.Enabled = true;
            }
            else
            {
                ColaQuantityTextBox.Text = "";
                ColaQuantityTextBox.Enabled = false;
            }
        }



        private void PetrolsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PetrolsComboBox.SelectedIndex)
            {
                case 0:
                    PriceTextBox.Text = "35,93";
                    break;

                case 1:
                    PriceTextBox.Text = "37,7";
                    break;

                case 2:
                    PriceTextBox.Text = "42,63";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (DialogResult.Yes == MessageBox.Show("Очистити форму?", "Запит", MessageBoxButtons.YesNo))
            {
                PetrolsComboBox.SelectedIndex = 0;

                QuantityRadioButton.Checked = false;
                SumRadioButton.Checked = false;

                StationTotalPayLabel.Text = "";
                
                //--------------------------------------------------

                HotDogCheckBox.Checked = false;
                HamburgerCheckBox.Checked = false;
                FriesCheckBox.Checked = false;
                ColaCheckBox.Checked = false;

                CafeTotalPayLabel.Text = "";

                //--------------------------------------------------

                OneClientTotalPayLabel.Text = "";
            }
            else
            {
                timer1.Start();
            }
            CalculateButton.Enabled = true;
        }
    }
}
