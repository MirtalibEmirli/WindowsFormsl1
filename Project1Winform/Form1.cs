namespace Project1Winform
{
    public partial class pr1 : Form
    {
        public pr1()
        {
            InitializeComponent();
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label1.Text = DateTime.Now.ToString();
            BackgroundImage = Image.FromFile("C:\\Users\\mirta\\source\\repos\\WindowsForms\\Project1Winform\\Resources\\baku44.jpg");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            var dt = DateTime.Now.AddHours(-3);
            label2.Text = (dt).ToString();
            BackgroundImage = Image.FromFile("C:\\Users\\mirta\\source\\repos\\WindowsForms\\Project1Winform\\Resources\\london3.jpg");
        }


    }
}
