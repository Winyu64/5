namespace GPACalculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPACal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput, name);

            double gpax = oGPACal.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            textBoxMaxGPA.Text = oGPACal.getMax().ToString();
            textBoxMaxName.Text = oGPACal.getMaxName().ToString();

            textBoxMinGPA.Text = oGPACal.getMin().ToString();
            textBoxMinName.Text = oGPACal.getMinName().ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = string.Empty;
            textBoxAllData.Text = oGPACal.getAlldata();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxName_input.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
        }
    }
}