namespace Accounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Customer cr= new Customer();
        Clist clist = new Clist();
        Product pt= new Product();
        Plist plist = new Plist();

        private void button1_Click(object sender, EventArgs e)
        {
            cr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clist.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pt.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            plist.Show();
        }
    }
}