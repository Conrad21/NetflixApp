namespace NetflixApp
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
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.txtMovieID = new System.Windows.Forms.ListBox();
            this.movieRating = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.occupation = new System.Windows.Forms.ListBox();
            this.MovieButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.secondBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.namebox = new System.Windows.Forms.ComboBox();
            this.movieBox = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.eachRating = new System.Windows.Forms.Button();
            this.topN = new System.Windows.Forms.TextBox();
            this.topNAvg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(31, 43);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(185, 26);
            this.txtDatabase.TabIndex = 0;
            this.txtDatabase.Text = "netflix-200k.mdf";
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.ItemHeight = 20;
            this.lstMovies.Location = new System.Drawing.Point(69, 194);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(305, 444);
            this.lstMovies.TabIndex = 1;
            this.lstMovies.SelectedIndexChanged += new System.EventHandler(this.lstMovies_SelectedIndexChanged);
            // 
            // txtMovieID
            // 
            this.txtMovieID.FormattingEnabled = true;
            this.txtMovieID.ItemHeight = 20;
            this.txtMovieID.Location = new System.Drawing.Point(534, 29);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(162, 24);
            this.txtMovieID.TabIndex = 2;
            // 
            // movieRating
            // 
            this.movieRating.FormattingEnabled = true;
            this.movieRating.ItemHeight = 20;
            this.movieRating.Location = new System.Drawing.Point(534, 59);
            this.movieRating.Name = "movieRating";
            this.movieRating.Size = new System.Drawing.Size(162, 24);
            this.movieRating.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movie ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Avg Rating: ";
            // 
            // userID
            // 
            this.userID.FormattingEnabled = true;
            this.userID.ItemHeight = 20;
            this.userID.Location = new System.Drawing.Point(532, 96);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(164, 24);
            this.userID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Occupation";
            // 
            // occupation
            // 
            this.occupation.FormattingEnabled = true;
            this.occupation.ItemHeight = 20;
            this.occupation.Location = new System.Drawing.Point(532, 132);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(164, 24);
            this.occupation.TabIndex = 9;
            // 
            // MovieButton
            // 
            this.MovieButton.Location = new System.Drawing.Point(217, 119);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(113, 61);
            this.MovieButton.TabIndex = 10;
            this.MovieButton.Text = "Movie";
            this.MovieButton.UseVisualStyleBackColor = true;
            this.MovieButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(69, 117);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(118, 61);
            this.userButton.TabIndex = 11;
            this.userButton.Text = "Users";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // secondBox
            // 
            this.secondBox.FormattingEnabled = true;
            this.secondBox.ItemHeight = 20;
            this.secondBox.Location = new System.Drawing.Point(424, 198);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(314, 444);
            this.secondBox.TabIndex = 12;
            this.secondBox.SelectedIndexChanged += new System.EventHandler(this.secondBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 137);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 783);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 735);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Movie Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 783);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // namebox
            // 
            this.namebox.FormattingEnabled = true;
            this.namebox.Location = new System.Drawing.Point(148, 666);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(226, 28);
            this.namebox.TabIndex = 21;
            this.namebox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // movieBox
            // 
            this.movieBox.FormattingEnabled = true;
            this.movieBox.Location = new System.Drawing.Point(148, 727);
            this.movieBox.Name = "movieBox";
            this.movieBox.Size = new System.Drawing.Size(225, 28);
            this.movieBox.TabIndex = 22;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(222, 35);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(99, 63);
            this.Connect.TabIndex = 23;
            this.Connect.Text = "Connect to data";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // eachRating
            // 
            this.eachRating.Location = new System.Drawing.Point(805, 204);
            this.eachRating.Name = "eachRating";
            this.eachRating.Size = new System.Drawing.Size(131, 55);
            this.eachRating.TabIndex = 24;
            this.eachRating.Text = "Each Rating";
            this.eachRating.UseVisualStyleBackColor = true;
            this.eachRating.Click += new System.EventHandler(this.eachRating_Click);
            // 
            // topN
            // 
            this.topN.Location = new System.Drawing.Point(805, 384);
            this.topN.Name = "topN";
            this.topN.Size = new System.Drawing.Size(100, 26);
            this.topN.TabIndex = 25;
            this.topN.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // topNAvg
            // 
            this.topNAvg.Location = new System.Drawing.Point(805, 416);
            this.topNAvg.Name = "topNAvg";
            this.topNAvg.Size = new System.Drawing.Size(100, 70);
            this.topNAvg.TabIndex = 26;
            this.topNAvg.Text = "Top-N Movies";
            this.topNAvg.UseVisualStyleBackColor = true;
            this.topNAvg.Click += new System.EventHandler(this.topNAvg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(801, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Get the number of ratings ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(801, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Get the Nth Top movie ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 783);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Stars ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Put dataBase name here and Press Connect ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 901);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.topNAvg);
            this.Controls.Add(this.topN);
            this.Controls.Add(this.eachRating);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.movieBox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.MovieButton);
            this.Controls.Add(this.occupation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieRating);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.txtDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.ListBox txtMovieID;
        private System.Windows.Forms.ListBox movieRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox userID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox occupation;
        private System.Windows.Forms.Button MovieButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.ListBox secondBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox namebox;
        private System.Windows.Forms.ComboBox movieBox;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button eachRating;
        private System.Windows.Forms.TextBox topN;
        private System.Windows.Forms.Button topNAvg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

