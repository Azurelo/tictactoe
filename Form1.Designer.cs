namespace TicTacToe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            lblStatus = new Label();
            btnReset = new Button();
            xLabel = new Label();
            oLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.Location = new Point(192, 116);
            button1.Name = "button1";
            button1.Size = new Size(125, 125);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.Location = new Point(323, 116);
            button2.Name = "button2";
            button2.Size = new Size(125, 125);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowFrame;
            button3.Location = new Point(454, 116);
            button3.Name = "button3";
            button3.Size = new Size(125, 125);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.WindowFrame;
            button4.Location = new Point(192, 247);
            button4.Name = "button4";
            button4.Size = new Size(125, 125);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.WindowFrame;
            button5.Location = new Point(323, 247);
            button5.Name = "button5";
            button5.Size = new Size(125, 125);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.WindowFrame;
            button6.Location = new Point(454, 247);
            button6.Name = "button6";
            button6.Size = new Size(125, 125);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.WindowFrame;
            button7.Location = new Point(192, 378);
            button7.Name = "button7";
            button7.Size = new Size(125, 125);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.WindowFrame;
            button8.Location = new Point(323, 378);
            button8.Name = "button8";
            button8.Size = new Size(125, 125);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.WindowFrame;
            button9.Location = new Point(454, 378);
            button9.Name = "button9";
            button9.Size = new Size(125, 125);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 20F);
            lblStatus.Location = new Point(192, 62);
            lblStatus.Margin = new Padding(0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(155, 37);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Player Turn:";
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.AppWorkspace;
            btnReset.Font = new Font("Segoe UI", 16F);
            btnReset.Location = new Point(192, 509);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(387, 61);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Font = new Font("Segoe UI", 16F);
            xLabel.Location = new Point(454, 53);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(102, 30);
            xLabel.TabIndex = 11;
            xLabel.Text = "X Wins: 0";
            // 
            // oLabel
            // 
            oLabel.AutoSize = true;
            oLabel.Font = new Font("Segoe UI", 16F);
            oLabel.Location = new Point(454, 83);
            oLabel.Name = "oLabel";
            oLabel.Size = new Size(106, 30);
            oLabel.TabIndex = 12;
            oLabel.Text = "O Wins: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 652);
            Controls.Add(oLabel);
            Controls.Add(xLabel);
            Controls.Add(btnReset);
            Controls.Add(lblStatus);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label lblStatus;
        private Button btnReset;
        private Label xLabel;
        private Label oLabel;
    }
}
