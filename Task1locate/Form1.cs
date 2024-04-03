namespace Task1locate
{

    public partial class Form1 : Form
    {
        int en { get; set; }
        int uzunluq { get; set; }
        int en_ { get; set; }
        int uzunluq_ { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void M_Down(object sender, MouseEventArgs e)
        {
            en = (int)e.X;
            uzunluq = (int)e.Y;
            button1.Location = e.Location;
        }

        private void M_Up(object sender, MouseEventArgs e)
        {
            en_= (int)e.X;
            uzunluq_ = (int)e.Y;

            button1.Width = Math.Abs(en_ - en);
            button1.Height = Math.Abs(uzunluq_ - uzunluq);
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What are u doing ","Warnung!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }
    }
}
