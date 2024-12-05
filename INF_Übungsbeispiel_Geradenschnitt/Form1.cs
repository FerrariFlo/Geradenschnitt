namespace INF_Übungsbeispiel_Geradenschnitt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                // Eingabewerte der ersten Gerade einlesen
                double x1 = Convert.ToDouble(txtX1.Text);
                double y1 = Convert.ToDouble(txtY1.Text);
                double x2 = Convert.ToDouble(txtX2.Text);
                double y2 = Convert.ToDouble(txtY2.Text);

                // Eingabewerte der zweiten Gerade einlesen
                double x3 = Convert.ToDouble(txtX3.Text);
                double y3 = Convert.ToDouble(txtY3.Text);
                double x4 = Convert.ToDouble(txtX4.Text);
                double y4 = Convert.ToDouble(txtY4.Text);

                // Steigungen und Achsenabschnitte berechnen
                double m1 = (y2 - y1) / (x2 - x1);
                double b1 = y1 - m1 * x1;

                double m2 = (y4 - y3) / (x4 - x3);
                double b2 = y3 - m2 * x3;

                // Prüfung auf Parallelität
                if (m1 == m2)
                {
                    if (b1 == b2)
                    {
                        lblSchnittpunkt.Text = "Die Geraden sind identisch.";
                    }
                    else
                    {
                        lblSchnittpunkt.Text = "Die Geraden sind parallel und schneiden sich nicht.";
                    }
                }
                else
                {
                    // Schnittpunkt berechnen
                    double x = (b2 - b1) / (m1 - m2);
                    double y = m1 * x + b1;

                    lblSchnittpunkt.Text = $"Schnittpunkt: {x:F2} / {y:F2}";
                }
            }
            catch (Exception ex)
            {
                lblSchnittpunkt.Text = $"Fehler: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Alle TextBoxen leeren
            txtX1.Clear();
            txtY1.Clear();
            txtX2.Clear();
            txtY2.Clear();
            txtX3.Clear();
            txtY3.Clear();
            txtX4.Clear();
            txtY4.Clear();

            // Ergebnis-Label leeren
            lblSchnittpunkt.Text = $"X / Y";
        }
    }
}
