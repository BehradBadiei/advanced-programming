namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                int x;
                if (n <= 0)
                {
                    MessageBox.Show("please dont write a number below 1");
                    return;
                }
                n = n - 1;
                x = fib(n);
                MessageBox.Show("the " + (n+1) + "th sequence of the fibonacci sequence is: " + x.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int fib(int n)
        {
            if (n <= 0)
                return n;
            if (n == 1)
                return n;
            else
                return fib(n - 1) + fib(n - 2);
        }
    }
}