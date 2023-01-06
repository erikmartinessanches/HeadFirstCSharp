namespace PartyEstimator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.costLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthyDinnerBox = new System.Windows.Forms.CheckBox();
            this.fancyDinnerBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberDinner = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDinner)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(232, 188);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.healthyDinnerBox);
            this.tabPage1.Controls.Add(this.fancyDinnerBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numberDinner);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(224, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(75, 116);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(115, 15);
            this.costLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // healthyDinnerBox
            // 
            this.healthyDinnerBox.AutoSize = true;
            this.healthyDinnerBox.Location = new System.Drawing.Point(12, 81);
            this.healthyDinnerBox.Margin = new System.Windows.Forms.Padding(2);
            this.healthyDinnerBox.Name = "healthyDinnerBox";
            this.healthyDinnerBox.Size = new System.Drawing.Size(105, 19);
            this.healthyDinnerBox.TabIndex = 9;
            this.healthyDinnerBox.Text = "Healthy option";
            this.healthyDinnerBox.UseVisualStyleBackColor = true;
            this.healthyDinnerBox.CheckedChanged += new System.EventHandler(this.healthyDinnerBox_CheckedChanged);
            // 
            // fancyDinnerBox
            // 
            this.fancyDinnerBox.AutoSize = true;
            this.fancyDinnerBox.Checked = true;
            this.fancyDinnerBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDinnerBox.Location = new System.Drawing.Point(12, 59);
            this.fancyDinnerBox.Margin = new System.Windows.Forms.Padding(2);
            this.fancyDinnerBox.Name = "fancyDinnerBox";
            this.fancyDinnerBox.Size = new System.Drawing.Size(122, 19);
            this.fancyDinnerBox.TabIndex = 8;
            this.fancyDinnerBox.Text = "Fancy decorations";
            this.fancyDinnerBox.UseVisualStyleBackColor = true;
            this.fancyDinnerBox.CheckedChanged += new System.EventHandler(this.fancyDinnerBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of people";
            // 
            // numberDinner
            // 
            this.numberDinner.Location = new System.Drawing.Point(12, 28);
            this.numberDinner.Margin = new System.Windows.Forms.Padding(2);
            this.numberDinner.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberDinner.Name = "numberDinner";
            this.numberDinner.Size = new System.Drawing.Size(70, 23);
            this.numberDinner.TabIndex = 6;
            this.numberDinner.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberDinner.ValueChanged += new System.EventHandler(this.numberDinner_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(224, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.IndianRed;
            this.tooLongLabel.Location = new System.Drawing.Point(136, 68);
            this.tooLongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(65, 15);
            this.tooLongLabel.TabIndex = 14;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(12, 85);
            this.cakeWriting.Margin = new System.Windows.Forms.Padding(2);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(197, 23);
            this.cakeWriting.TabIndex = 13;
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cake writing";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(46, 125);
            this.birthdayCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(115, 15);
            this.birthdayCost.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(12, 49);
            this.fancyBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(122, 19);
            this.fancyBirthday.TabIndex = 8;
            this.fancyBirthday.Text = "Fancy decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of people";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(12, 26);
            this.numberBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.numberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(70, 23);
            this.numberBirthday.TabIndex = 6;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 198);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDinner)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox healthyDinnerBox;
        private System.Windows.Forms.CheckBox fancyDinnerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberDinner;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numberBirthday;
    }
}

