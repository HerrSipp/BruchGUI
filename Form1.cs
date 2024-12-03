namespace BruchGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                // Bruch 1
                int numerator1 = int.Parse(TxtBox1.Text);
                int denominator1 = int.Parse(TxtBox2.Text);

                // Bruch 2
                int numerator2 = int.Parse(TxtBox3.Text);
                int denominator2 = int.Parse(TxtBox4.Text);

                // Nenner darf nicht null sein
                if (denominator1 == 0 || denominator2 == 0)
                {
                    MessageBox.Show("Nenner darf nicht 0 sein!");
                    return;
                }

                int resultNumerator;
                int resultDenominator;

                if (denominator1 == denominator2)
                {
                    // Wenn die Nenner gleich sind
                    resultNumerator = numerator1 + numerator2;
                    resultDenominator = denominator1 + denominator2;
                }
                else
                {
                    resultNumerator = numerator1 * denominator2 + denominator1 * numerator2;
                    resultDenominator = denominator1 * denominator2;
                }
                // Ergebnis anzeigen
                LblErgebnisZ.Text = $"{resultNumerator}";
                LblErgebnisN.Text = $"{resultDenominator}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte nur ganze Zahlen eingeben.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                // Bruch 1
                int numerator1 = int.Parse(TxtBox1.Text);
                int denominator1 = int.Parse(TxtBox2.Text);

                // Bruch 2
                int numerator2 = int.Parse(TxtBox3.Text);
                int denominator2 = int.Parse(TxtBox4.Text);

                // Nenner darf nicht null sein
                if (denominator1 == 0 || denominator2 == 0)
                {
                    MessageBox.Show("Nenner darf nicht 0 sein!");
                    return;
                }

                int resultNumerator;
                int resultDenominator;

                if (denominator1 == denominator2)
                {
                    // Wenn die Nenner gleich sind
                    resultNumerator = numerator1 - numerator2;
                    resultDenominator = denominator1 - denominator2;
                }
                else
                {
                    resultNumerator = numerator1 * denominator2 - denominator1 * numerator2;
                    resultDenominator = denominator1 * denominator2;
                }
                // Ergebnis anzeigen
                LblErgebnisZ.Text = $"{resultNumerator}";
                LblErgebnisN.Text = $"{resultDenominator}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte nur ganze Zahlen eingeben.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }

        private void BtnMultiplikation_Click(object sender, EventArgs e)
        {
            try
            {
                // Bruch 1
                int numerator1 = int.Parse(TxtBox1.Text);
                int denominator1 = int.Parse(TxtBox2.Text);

                // Bruch 2
                int numerator2 = int.Parse(TxtBox3.Text);
                int denominator2 = int.Parse(TxtBox4.Text);

                // Nenner darf nicht null sein
                if (denominator1 == 0 || denominator2 == 0)
                {
                    MessageBox.Show("Nenner darf nicht 0 sein!");
                    return;
                }

                int resultNumerator;
                int resultDenominator;

                resultNumerator = numerator1 * numerator2;
                resultDenominator = denominator1 * denominator2;
                // Ergebnis anzeigen
                LblErgebnisZ.Text = $"{resultNumerator}";
                LblErgebnisN.Text = $"{resultDenominator}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte nur ganze Zahlen eingeben.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}
