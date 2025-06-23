namespace Activity2
{
    partial class FrmSeconds
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
            btnRun = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResults = new Label();
            txtUserEntry = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(411, 141);
            btnRun.Margin = new Padding(4, 4, 4, 4);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(131, 31);
            btnRun.TabIndex = 0;
            btnRun.Text = "Apply Seconds";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += this.ManageSecondsEventHandler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.Location = new Point(22, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 26);
            label1.TabIndex = 1;
            label1.Text = "Enter the number of seconds:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Microsoft Sans Serif", 16F);
            lblResults.Location = new Point(411, 280);
            lblResults.Margin = new Padding(4, 0, 4, 0);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(70, 26);
            lblResults.TabIndex = 3;
            lblResults.Text = "label3";
            // 
            // txtUserEntry
            // 
            txtUserEntry.Font = new Font("Microsoft Sans Serif", 16F);
            txtUserEntry.Location = new Point(411, 81);
            txtUserEntry.Margin = new Padding(4, 4, 4, 4);
            txtUserEntry.Name = "txtUserEntry";
            txtUserEntry.Size = new Size(206, 32);
            txtUserEntry.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F);
            label4.Location = new Point(626, 85);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 26);
            label4.TabIndex = 5;
            label4.Text = "seconds";
            // 
            // FrmSeconds
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(label4);
            Controls.Add(txtUserEntry);
            Controls.Add(lblResults);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmSeconds";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Label label1;
        private Label label2;
        private Label lblResults;
        private TextBox txtUserEntry;
        private Label label4;
    }
}
