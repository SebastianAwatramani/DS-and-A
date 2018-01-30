namespace DS_And_A
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(374, 32);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(159, 259);
            this.output.TabIndex = 1;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(33, 32);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 2;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(33, 84);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 20);
            this.input3.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(33, 58);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 4;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(33, 110);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(100, 20);
            this.input4.TabIndex = 5;
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(33, 136);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(100, 20);
            this.input5.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 472);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.TextBox input5;
    }
}

