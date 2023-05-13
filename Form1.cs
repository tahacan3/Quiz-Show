namespace Quiz_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void Next_Click(object sender, EventArgs e)
        {
            Next.Text = "Sonraki Soru";
            pictureBox2.Visible = true;
            pictureBox1.Visible = true;
            ButtonA.Enabled = true;
            ButtonB.Enabled = true;
            ButtonC.Enabled = true;
            ButtonD.Enabled = true;
            soruno++;
            QNum.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye Cumhuriyeti kaç yýlýnda kurulmuþtur?";
                ButtonA.Text = "1921";
                ButtonB.Text = "1922";
                ButtonC.Text = "1923";
                ButtonD.Text = "1924";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk ne zaman vefat etmiþtir?";
                ButtonA.Text = "1935";
                ButtonB.Text = "1936";
                ButtonC.Text = "1937";
                ButtonD.Text = "1938";
                label4.Text = "1938";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Türkiyenin baþkenti neresidir?";
                ButtonA.Text = "Ýstanbul";
                ButtonB.Text = "Ankara";
                ButtonC.Text = "Ýzmir";
                ButtonD.Text = "Sivas";
                label4.Text = "Ankara";
                Next.Enabled = false;
            }

        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            label5.Text = ButtonA.Text;
            ButtonA.Enabled = false;
            ButtonB.Enabled = false;
            ButtonC.Enabled = false;
            ButtonD.Enabled = false;

            if (ButtonA.Text == label4.Text)
            {
                dogru++;
                CorrectNum.Text = dogru.ToString();
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                WrongNum.Text = yanlis.ToString();
                pictureBox1.Visible = false;
            }
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            label5.Text = ButtonB.Text;
            ButtonA.Enabled = false;
            ButtonB.Enabled = false;
            ButtonC.Enabled = false;
            ButtonD.Enabled = false;

            if (ButtonB.Text == label4.Text)
            {
                dogru++;
                CorrectNum.Text = dogru.ToString();
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                WrongNum.Text = yanlis.ToString();
                pictureBox1.Visible = false;
            }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            label5.Text = ButtonC.Text;
            ButtonA.Enabled = false;
            ButtonB.Enabled = false;
            ButtonC.Enabled = false;
            ButtonD.Enabled = false;

            if (ButtonC.Text == label4.Text)
            {
                dogru++;
                CorrectNum.Text = dogru.ToString();
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                WrongNum.Text = yanlis.ToString();
                pictureBox1.Visible = false;
            }
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            label5.Text = ButtonD.Text;
            ButtonA.Enabled = false;
            ButtonB.Enabled = false;
            ButtonC.Enabled = false;
            ButtonD.Enabled = false;

            if (ButtonD.Text == label4.Text)
            {
                dogru++;
                CorrectNum.Text = dogru.ToString();
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                WrongNum.Text = yanlis.ToString();
                pictureBox1.Visible = false;
            }
        }
    }
}