namespace Height_multi_form
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            h.f1 = this;
        }
        Height h = new Height();

        int[] height = new int[20];
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int i=int.Parse(textBox1.Text);

            if (count < height.Length)
            {
                height[count] = i;
                count++;
            }
            int sum = 0;

            for(int j =0;j<count;j++)
            {
                sum += height[j];
            }

            if (count > 19)
            {
                MessageBox.Show("limit reached.please clear");
                return;
            }
            else
            {
                float avg=sum/count;
                h.label2.Text = avg.ToString();
                label3.Text = h.label2.Text;
                h.listBox1.Items.Add(i);
            }
            textBox1.Clear();
            h.Show();
            
        }
    }
}