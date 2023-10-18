using System.Globalization;

namespace height
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            int[] height = new int[20];
            int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int i =int.Parse(textBox1.Text);

            if (count < height.Length)
            {
                height[count] = i;
                count++;
            }
            int sum = 0;

            for(int j = 0; j < count; j++)
            {
                sum += height[j];
            }

            if (count > 19)
            {
                MessageBox.Show("you have reached the height limit to enter,please clear the list and try again");
                return;
            }
            else
            {
                float avg = sum / count;
                label3.Text = avg.ToString();
                listBox1.Items.Add(i);
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            count = 0;
            label3.Text = "";
        }
    }
}