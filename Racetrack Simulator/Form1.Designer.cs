using System.Windows.Forms;


namespace Racetrack_Simulator
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;




        //{ MyPictureBox = Dog1PictureBox,
        //            StartingPosition = TrackPictureBox.Left, RacetrackLength =
        //            TrackPictureBox.Width - TrackPictureBox.Width, Randomizer
        //            = MyRandomizer
        //        new Greyhound() {MyPictureBox = Dog2PictureBox,
        //            StartingPosition = Dog2PictureBox.Left, RacetrackLength =
        //            racetrackPictureBox.Width - Dog1PictureBox.Width, Randomizer
        //            = MyRandomizer},
        //        new Greyhound() {MyPictureBox = Dog3PictureBox,
        //            StartingPosition = Dog2PictureBox.Left, RacetrackLength =
        //            racetrackPictureBox.Width - Dog3PictureBox.Width, Randomizer
        //            = MyRandomizer},
        //        new Greyhound() {MyPictureBox = Dog4PictureBox,
        //            StartingPosition = Dog3PictureBox.Left, RacetrackLength =
        //            racetrackPictureBox.Width - Dog4PictureBox.Width, Randomizer
        //            = MyRandomizer}
        //    };

        //Guy[] GuyArray =
        //{
        //        new Guy("Joe", 50, joeRadioButton, joeBetLabel);
        ////{Name = "Joe", Cash = 50, MyRadioButton = , MyLabel = },
        //        //new Guy(){Name = "Bob", Cash = 75, MyRadioButton = , MyLabel = },
        //        //new Guy(){Name = "Al", Cash = 45, MyRadioButton = , MyLabel = }
        //    };








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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TrackPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RaceButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DogNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BetAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.Dog1PictureBox = new System.Windows.Forms.PictureBox();
            this.Dog2PictureBox = new System.Windows.Forms.PictureBox();
            this.Dog3PictureBox = new System.Windows.Forms.PictureBox();
            this.Dog4PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrackPictureBox
            // 
            this.TrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TrackPictureBox.Image")));
            this.TrackPictureBox.Location = new System.Drawing.Point(12, 13);
            this.TrackPictureBox.Name = "TrackPictureBox";
            this.TrackPictureBox.Size = new System.Drawing.Size(1188, 402);
            this.TrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TrackPictureBox.TabIndex = 0;
            this.TrackPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RaceButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DogNumberNumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BetAmountNumericUpDown);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting parlor";
            // 
            // RaceButton
            // 
            this.RaceButton.Location = new System.Drawing.Point(802, 60);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(332, 101);
            this.RaceButton.TabIndex = 14;
            this.RaceButton.Text = "Race";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = ".";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DogNumberNumericUpDown
            // 
            this.DogNumberNumericUpDown.Location = new System.Drawing.Point(534, 171);
            this.DogNumberNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumberNumericUpDown.Name = "DogNumberNumericUpDown";
            this.DogNumberNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.DogNumberNumericUpDown.TabIndex = 12;
            this.DogNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "bucks on hound number";
            // 
            // BetAmountNumericUpDown
            // 
            this.BetAmountNumericUpDown.Location = new System.Drawing.Point(160, 171);
            this.BetAmountNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.BetAmountNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmountNumericUpDown.Name = "BetAmountNumericUpDown";
            this.BetAmountNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.BetAmountNumericUpDown.TabIndex = 10;
            this.BetAmountNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(78, 168);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 45);
            this.betsButton.TabIndex = 9;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 177);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 25);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "name";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(338, 132);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(400, 30);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(338, 96);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(400, 30);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(338, 60);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(400, 30);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bets";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(12, 132);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(178, 29);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(12, 96);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(197, 29);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(12, 60);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(190, 29);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 31);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(182, 25);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // Dog1PictureBox
            // 
            this.Dog1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog1PictureBox.Image")));
            this.Dog1PictureBox.Location = new System.Drawing.Point(25, 27);
            this.Dog1PictureBox.Name = "Dog1PictureBox";
            this.Dog1PictureBox.Size = new System.Drawing.Size(120, 36);
            this.Dog1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog1PictureBox.TabIndex = 2;
            this.Dog1PictureBox.TabStop = false;
            // 
            // Dog2PictureBox
            // 
            this.Dog2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog2PictureBox.Image")));
            this.Dog2PictureBox.Location = new System.Drawing.Point(25, 125);
            this.Dog2PictureBox.Name = "Dog2PictureBox";
            this.Dog2PictureBox.Size = new System.Drawing.Size(120, 36);
            this.Dog2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog2PictureBox.TabIndex = 3;
            this.Dog2PictureBox.TabStop = false;
            // 
            // Dog3PictureBox
            // 
            this.Dog3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog3PictureBox.Image")));
            this.Dog3PictureBox.Location = new System.Drawing.Point(25, 242);
            this.Dog3PictureBox.Name = "Dog3PictureBox";
            this.Dog3PictureBox.Size = new System.Drawing.Size(120, 36);
            this.Dog3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog3PictureBox.TabIndex = 4;
            this.Dog3PictureBox.TabStop = false;
            // 
            // Dog4PictureBox
            // 
            this.Dog4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog4PictureBox.Image")));
            this.Dog4PictureBox.Location = new System.Drawing.Point(25, 342);
            this.Dog4PictureBox.Name = "Dog4PictureBox";
            this.Dog4PictureBox.Size = new System.Drawing.Size(120, 36);
            this.Dog4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog4PictureBox.TabIndex = 5;
            this.Dog4PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 657);
            this.Controls.Add(this.Dog4PictureBox);
            this.Controls.Add(this.Dog3PictureBox);
            this.Controls.Add(this.Dog2PictureBox);
            this.Controls.Add(this.Dog1PictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A day at the races";
            ((System.ComponentModel.ISupportInitialize)(this.TrackPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Timer timer1;
        private PictureBox TrackPictureBox;
        private GroupBox groupBox1;
        private RadioButton joeRadioButton;
        private Label minimumBetLabel;
        private Label alBetLabel;
        private Label bobBetLabel;
        private Label joeBetLabel;
        private Label label1;
        private RadioButton alRadioButton;
        private RadioButton bobRadioButton;
        private Label label3;
        private NumericUpDown DogNumberNumericUpDown;
        private Label label2;
        private NumericUpDown BetAmountNumericUpDown;
        private Button betsButton;
        private Label nameLabel;
        private Button RaceButton;
        private PictureBox Dog1PictureBox;
        private PictureBox Dog2PictureBox;
        private PictureBox Dog3PictureBox;
        private PictureBox Dog4PictureBox;
    }
}

