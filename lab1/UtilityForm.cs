using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class UtilityForm : Form
    {
        public UtilityForm()
        {
            InitializeComponent();
        }

        private void UtilityForm_Load(object sender, EventArgs e)
        {

            tblRtng.Rows.Add("Very good", "10");
            tblRtng.Rows.Add("Good", "8");
            tblRtng.Rows.Add("Fair", "6");
            tblRtng.Rows.Add("Poor", "3");
            tblRtng.Rows.Add("Very poor", "1");
        }

        private void bttnCount_Click(object sender, EventArgs e)
        {
            double pRain;


            if (double.TryParse(txtBxPRn.Text, out double num))
            {
                pRain = num;
            }
            else
            {

                MessageBox.Show("Error! Enter right number");
                return;
            }


            if (pRain >= 1 || pRain <= 0) MessageBox.Show("Error! Enter right probabitity");

            double scoreHmRn = double.Parse(txtBxScrHmRn.Text);
            double scoreHmSn = double.Parse(txtBxScrHmSn.Text);
            double scoreFrRn = double.Parse(txtBxScrFrstRn.Text);
            double scoreFrSn = double.Parse(txtBxScrFrstSn.Text);

            double wHome;
            double wForest;

            wHome = pRain * scoreHmRn + (1 - pRain) * scoreHmSn;
            wForest = pRain * scoreFrRn + (1 - pRain) * scoreFrSn;

            if(wHome > wForest)
            {
                lblRes.Visible = true;
                lblRes.Text = "You better stay home";

            }
            else if(wHome < wForest)
            {
                lblRes.Visible = true;
                lblRes.Text = "You better go to forest";
            }
            else
            {
                lblRes.Visible = true;
                lblRes.Text = "You deside if stay home or go to forest";
            }
        }
    }
}
