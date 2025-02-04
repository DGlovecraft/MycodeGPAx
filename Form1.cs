namespace GPAx
{
    public partial class Form1 : Form
    {
        GPAcal gpacalculater;
        public Form1()
        {
            InitializeComponent();
            gpacalculater = new GPAcal();
        }

        private void CalGPA_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(this.score.Text);
                gpacalculater.setGPA(input);
                this.GPAx.Text = gpacalculater.getGPAX().ToString();
                this.Max.Text = gpacalculater.getMax().ToString();
                this.Low.Text = gpacalculater.getMin().ToString();
            }     
            catch (Exception ex)
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");
                this.score.Text = string.Empty;
            }
        }
    }
}
