namespace Pedra_Papel_Tesoura_2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 25);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 3;
            label1.Text = "Escolha da máquina:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(287, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 118);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 5;
            label2.Text = "Ganhador:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(204, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(494, 31);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(47, 59);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Pedra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(47, 109);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Papel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(47, 158);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Tesoura";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 25);
            label3.Name = "label3";
            label3.Size = new Size(211, 25);
            label3.TabIndex = 10;
            label3.Text = "Escolha uma das opções:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}