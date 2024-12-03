namespace BruchGUI
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
            LblBruch1 = new Label();
            LblBruch2 = new Label();
            LblErgebnis = new Label();
            TxtBox1 = new TextBox();
            TxtBox2 = new TextBox();
            TxtBox3 = new TextBox();
            TxtBox4 = new TextBox();
            BtnPlus = new Button();
            BtnGeteilt = new Button();
            BtnMultiplikation = new Button();
            BtnMinus = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            LblErgebnisN = new Label();
            LblErgebnisZ = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // LblBruch1
            // 
            LblBruch1.AutoSize = true;
            LblBruch1.Location = new Point(44, 76);
            LblBruch1.Name = "LblBruch1";
            LblBruch1.Size = new Size(58, 20);
            LblBruch1.TabIndex = 0;
            LblBruch1.Text = "Bruch 1";
            // 
            // LblBruch2
            // 
            LblBruch2.AutoSize = true;
            LblBruch2.Location = new Point(202, 76);
            LblBruch2.Name = "LblBruch2";
            LblBruch2.Size = new Size(58, 20);
            LblBruch2.TabIndex = 1;
            LblBruch2.Text = "Bruch 2";
            // 
            // LblErgebnis
            // 
            LblErgebnis.AutoSize = true;
            LblErgebnis.Location = new Point(375, 76);
            LblErgebnis.Name = "LblErgebnis";
            LblErgebnis.Size = new Size(66, 20);
            LblErgebnis.TabIndex = 2;
            LblErgebnis.Text = "Ergebnis";
            // 
            // TxtBox1
            // 
            TxtBox1.Location = new Point(44, 124);
            TxtBox1.Name = "TxtBox1";
            TxtBox1.Size = new Size(71, 27);
            TxtBox1.TabIndex = 3;
            // 
            // TxtBox2
            // 
            TxtBox2.Location = new Point(44, 177);
            TxtBox2.Name = "TxtBox2";
            TxtBox2.Size = new Size(71, 27);
            TxtBox2.TabIndex = 4;
            // 
            // TxtBox3
            // 
            TxtBox3.Location = new Point(202, 124);
            TxtBox3.Name = "TxtBox3";
            TxtBox3.Size = new Size(71, 27);
            TxtBox3.TabIndex = 5;
            // 
            // TxtBox4
            // 
            TxtBox4.Location = new Point(202, 177);
            TxtBox4.Name = "TxtBox4";
            TxtBox4.Size = new Size(71, 27);
            TxtBox4.TabIndex = 6;
            // 
            // BtnPlus
            // 
            BtnPlus.Location = new Point(134, 101);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(39, 29);
            BtnPlus.TabIndex = 9;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += BtnPlus_Click;
            // 
            // BtnGeteilt
            // 
            BtnGeteilt.Location = new Point(134, 206);
            BtnGeteilt.Name = "BtnGeteilt";
            BtnGeteilt.Size = new Size(39, 29);
            BtnGeteilt.TabIndex = 10;
            BtnGeteilt.Text = ":";
            BtnGeteilt.UseVisualStyleBackColor = true;
            // 
            // BtnMultiplikation
            // 
            BtnMultiplikation.Location = new Point(134, 171);
            BtnMultiplikation.Name = "BtnMultiplikation";
            BtnMultiplikation.Size = new Size(39, 29);
            BtnMultiplikation.TabIndex = 11;
            BtnMultiplikation.Text = "*";
            BtnMultiplikation.UseVisualStyleBackColor = true;
            BtnMultiplikation.Click += BtnMultiplikation_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.Location = new Point(134, 136);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(39, 29);
            BtnMinus.TabIndex = 12;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            BtnMinus.Click += BtnMinus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 154);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 13;
            label1.Text = "——————";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 154);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 14;
            label2.Text = "——————";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 154);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 15;
            label3.Text = "——————";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(317, 145);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 16;
            label4.Text = "—";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(317, 165);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 17;
            label5.Text = "—";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(29, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(99, 186);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(189, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(99, 186);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(LblErgebnisN);
            panel3.Controls.Add(LblErgebnisZ);
            panel3.Location = new Point(364, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(99, 186);
            panel3.TabIndex = 20;
            // 
            // LblErgebnisN
            // 
            LblErgebnisN.AutoSize = true;
            LblErgebnisN.Location = new Point(27, 121);
            LblErgebnisN.Name = "LblErgebnisN";
            LblErgebnisN.Size = new Size(0, 20);
            LblErgebnisN.TabIndex = 1;
            // 
            // LblErgebnisZ
            // 
            LblErgebnisZ.AutoSize = true;
            LblErgebnisZ.Location = new Point(27, 68);
            LblErgebnisZ.Name = "LblErgebnisZ";
            LblErgebnisZ.Size = new Size(0, 20);
            LblErgebnisZ.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 319);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnMinus);
            Controls.Add(BtnMultiplikation);
            Controls.Add(BtnGeteilt);
            Controls.Add(BtnPlus);
            Controls.Add(TxtBox4);
            Controls.Add(TxtBox3);
            Controls.Add(TxtBox2);
            Controls.Add(TxtBox1);
            Controls.Add(LblErgebnis);
            Controls.Add(LblBruch2);
            Controls.Add(LblBruch1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblBruch1;
        private Label LblBruch2;
        private Label LblErgebnis;
        private TextBox TxtBox1;
        private TextBox TxtBox2;
        private TextBox TxtBox3;
        private TextBox TxtBox4;
        private Button BtnPlus;
        private Button BtnGeteilt;
        private Button BtnMultiplikation;
        private Button BtnMinus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label LblErgebnisZ;
        private Label LblErgebnisN;
    }
}
