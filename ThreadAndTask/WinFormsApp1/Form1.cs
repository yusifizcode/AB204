namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(FPB1);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(FPB2);
            thread.Start();
        }

        public void FPB1()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar1.Value = i / 10000000;
            }
        }

        public void FPB2()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar2.Value = i / 10000000;
            }
        }
    }
}