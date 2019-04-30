namespace Chapter3_example1
{
    partial class Talker
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Say this:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of times: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(359, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Hello!";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(203, 60);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Talk to me";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Talker
            // 
            this.ClientSize = new System.Drawing.Size(616, 208);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Talker";
            this.Text = "Talker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
    }
}

