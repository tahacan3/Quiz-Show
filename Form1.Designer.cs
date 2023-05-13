namespace Quiz_Show
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            ButtonA = new Button();
            ButtonB = new Button();
            ButtonC = new Button();
            ButtonD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            WrongNum = new Label();
            QNum = new Label();
            CorrectNum = new Label();
            Next = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(518, 202);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ButtonA
            // 
            ButtonA.Enabled = false;
            ButtonA.Location = new Point(12, 225);
            ButtonA.Name = "ButtonA";
            ButtonA.Size = new Size(256, 48);
            ButtonA.TabIndex = 1;
            ButtonA.Text = "A";
            ButtonA.UseVisualStyleBackColor = true;
            ButtonA.Click += ButtonA_Click;
            // 
            // ButtonB
            // 
            ButtonB.Enabled = false;
            ButtonB.Location = new Point(274, 225);
            ButtonB.Name = "ButtonB";
            ButtonB.Size = new Size(256, 48);
            ButtonB.TabIndex = 5;
            ButtonB.Text = "B";
            ButtonB.UseVisualStyleBackColor = true;
            ButtonB.Click += ButtonB_Click;
            // 
            // ButtonC
            // 
            ButtonC.Enabled = false;
            ButtonC.Location = new Point(12, 279);
            ButtonC.Name = "ButtonC";
            ButtonC.Size = new Size(256, 48);
            ButtonC.TabIndex = 6;
            ButtonC.Text = "C";
            ButtonC.UseVisualStyleBackColor = true;
            ButtonC.Click += ButtonC_Click;
            // 
            // ButtonD
            // 
            ButtonD.Enabled = false;
            ButtonD.Location = new Point(274, 279);
            ButtonD.Name = "ButtonD";
            ButtonD.Size = new Size(256, 48);
            ButtonD.TabIndex = 7;
            ButtonD.Text = "D";
            ButtonD.UseVisualStyleBackColor = true;
            ButtonD.Click += ButtonD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 8;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 9;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 109);
            label3.Name = "label3";
            label3.Size = new Size(83, 27);
            label3.TabIndex = 10;
            label3.Text = "Yanlış:";
            // 
            // WrongNum
            // 
            WrongNum.AutoSize = true;
            WrongNum.Location = new Point(659, 109);
            WrongNum.Name = "WrongNum";
            WrongNum.Size = new Size(21, 27);
            WrongNum.TabIndex = 11;
            WrongNum.Text = "-";
            // 
            // QNum
            // 
            QNum.AutoSize = true;
            QNum.Location = new Point(659, 29);
            QNum.Name = "QNum";
            QNum.Size = new Size(21, 27);
            QNum.TabIndex = 12;
            QNum.Text = "-";
            // 
            // CorrectNum
            // 
            CorrectNum.AutoSize = true;
            CorrectNum.Location = new Point(659, 69);
            CorrectNum.Name = "CorrectNum";
            CorrectNum.Size = new Size(21, 27);
            CorrectNum.TabIndex = 13;
            CorrectNum.Text = "-";
            // 
            // Next
            // 
            Next.Location = new Point(551, 290);
            Next.Name = "Next";
            Next.Size = new Size(212, 37);
            Next.TabIndex = 14;
            Next.Text = "Başla";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Correct;
            pictureBox1.Location = new Point(551, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Wrong;
            pictureBox2.Location = new Point(663, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 69);
            label4.Name = "label4";
            label4.Size = new Size(75, 27);
            label4.TabIndex = 17;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 69);
            label5.Name = "label5";
            label5.Size = new Size(74, 27);
            label5.TabIndex = 18;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(775, 339);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Next);
            Controls.Add(CorrectNum);
            Controls.Add(QNum);
            Controls.Add(WrongNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonD);
            Controls.Add(ButtonC);
            Controls.Add(ButtonB);
            Controls.Add(ButtonA);
            Controls.Add(richTextBox1);
            Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Quiz Show";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button ButtonA;
        private Button ButtonB;
        private Button ButtonC;
        private Button ButtonD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label WrongNum;
        private Label QNum;
        private Label CorrectNum;
        private Button Next;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}