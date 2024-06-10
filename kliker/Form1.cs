namespace kliker
{
    public partial class Form1 : Form
    {
        Delay delay = new Delay();
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resource1.cookie2;
            delay.Start(timer1, 3, ShowCookie);
        }
        private void ShowCookie()
        {
            pictureBox1.Image = Resource1.cookie1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            delay.Tick();
        }
    }
}
