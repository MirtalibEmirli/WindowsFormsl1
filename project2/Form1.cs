namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            var r1 = Random.Shared.Next(361);
            var r2 = Random.Shared.Next(300);
            label1.Location= new Point(r1,r2); 
            
        }
    }
}
