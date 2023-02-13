using System.Windows.Forms;

namespace Market_App.exe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string parol = textBox2.Text;
            if (ad == "Mehdi" &&  parol== "Mehdi555") 
            {
                button2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                comboBox1.Visible = true;
                textBox3.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                maskedTextBox1.Visible = true;
                label6.Visible = true;
                button3.Visible = true;
                textBox4.Visible = true;
                listBox1.Visible = true;
                label9.Visible = true;
                numericUpDown1.Visible = true;
                textBox5.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                button6.Visible = true;
                button8.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Sehvdir parol ve yaxud ad");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            textBox3.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            maskedTextBox1.Visible = true;
            label6.Visible = true;
            button3.Visible = true;
            textBox4.Visible = true;
            listBox1.Visible = true;
            label9.Visible = true;
            numericUpDown1.Visible = true;
            textBox5.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = true;
            button8.Visible = true;
            button13.Visible = false;
            Parametr.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            Xett1.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button7.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yemek = listBox1.SelectedItem as string;
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          

            if (comboBox1.Text == " ")
            {
                MessageBox.Show("Xanalari doldur");
            }

            else if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Xanalari doldur");
            }

            else if (maskedTextBox1.Text == " ") 
            {
                MessageBox.Show("Xanalari doldur");
            }
            else
            {
              
                listView1.Visible = true;
                string kateqoriya, mehsul, sayi, bar;
                kateqoriya = comboBox1.Text;
                mehsul = textBox3.Text;
                sayi = numericUpDown1.Text;
                bar = maskedTextBox1.Text;

                string[] melumatlar = { kateqoriya, mehsul, sayi, bar };
                ListViewItem td = new ListViewItem(melumatlar);
                listView1.Items.Add(td);

                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label11.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Text = "Mehdi";

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label13.Text = "Mehdi555";
            

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            textBox3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            maskedTextBox1.Visible = false;
            label6.Visible = false;
            button3.Visible = false;
            textBox4.Visible = false;
            listBox1.Visible = false;
            label9.Visible = false;
            numericUpDown1.Visible = false;
            textBox5.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button7.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {   

            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            textBox3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            maskedTextBox1.Visible = false;
            label6.Visible = false;
            button3.Visible = false;
            textBox4.Visible = false;
            listBox1.Visible = false;
            label9.Visible = false;
            numericUpDown1.Visible = false;
            textBox5.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = false;
            Parametr.Visible = true;
            Xett1.Visible = true;
            button13.Visible = true;
            listView1.Visible = false;
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            var item = label16.Select;
            DialogResult result = MessageBox.Show("Form boyansinmi?", "Parametrler", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult  dd =  colorDialog1.ShowDialog();
            if (dd == DialogResult.OK)
            {
                this.BackColor = Color.Blue;
            }
             
        }

        private void label17_Click(object sender, EventArgs e)
        {
            var item = label16.Select;
            DialogResult result = MessageBox.Show("Form boyansinmi?", "Parametrler", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dd = colorDialog1.ShowDialog();
            if (dd == DialogResult.OK)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            var item = label16.Select;
            DialogResult result = MessageBox.Show("Form boyansinmi?", "Parametrler", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dd = colorDialog1.ShowDialog();
            if (dd == DialogResult.OK)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var item = label16.Select;
            DialogResult result = MessageBox.Show("Form boyansinmi?", "Parametrler", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            DialogResult dd = colorDialog1.ShowDialog();
            if (dd == DialogResult.OK)
            {
                this.BackColor = Color.Red;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}