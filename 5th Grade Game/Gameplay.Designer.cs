
namespace _5th_Grade_Game
{
    partial class Gameplay
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
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.btnQ4 = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.hiddenlbl = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.labelAgeTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQ1
            // 
            this.btnQ1.BackColor = System.Drawing.Color.White;
            this.btnQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1.Location = new System.Drawing.Point(13, 363);
            this.btnQ1.Margin = new System.Windows.Forms.Padding(2);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(255, 46);
            this.btnQ1.TabIndex = 0;
            this.btnQ1.Text = "button1";
            this.btnQ1.UseVisualStyleBackColor = false;
            this.btnQ1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.BackColor = System.Drawing.Color.White;
            this.btnQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ2.Location = new System.Drawing.Point(334, 363);
            this.btnQ2.Margin = new System.Windows.Forms.Padding(2);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(255, 46);
            this.btnQ2.TabIndex = 1;
            this.btnQ2.Text = "button2";
            this.btnQ2.UseVisualStyleBackColor = false;
            this.btnQ2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQ3
            // 
            this.btnQ3.BackColor = System.Drawing.Color.White;
            this.btnQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ3.Location = new System.Drawing.Point(13, 427);
            this.btnQ3.Margin = new System.Windows.Forms.Padding(2);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(255, 46);
            this.btnQ3.TabIndex = 2;
            this.btnQ3.Text = "button3";
            this.btnQ3.UseVisualStyleBackColor = false;
            this.btnQ3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQ4
            // 
            this.btnQ4.BackColor = System.Drawing.Color.White;
            this.btnQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ4.Location = new System.Drawing.Point(334, 426);
            this.btnQ4.Margin = new System.Windows.Forms.Padding(2);
            this.btnQ4.Name = "btnQ4";
            this.btnQ4.Size = new System.Drawing.Size(255, 46);
            this.btnQ4.TabIndex = 3;
            this.btnQ4.Text = "button4";
            this.btnQ4.UseVisualStyleBackColor = false;
            this.btnQ4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(9, 10);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(582, 268);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(240, 508);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Skip Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(9, 295);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(582, 57);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // hiddenlbl
            // 
            this.hiddenlbl.AutoSize = true;
            this.hiddenlbl.Location = new System.Drawing.Point(35, 475);
            this.hiddenlbl.Name = "hiddenlbl";
            this.hiddenlbl.Size = new System.Drawing.Size(0, 13);
            this.hiddenlbl.TabIndex = 8;
            this.hiddenlbl.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(475, 474);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 9;
            this.lblScore.Visible = false;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(37, 525);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 13);
            this.labelTest.TabIndex = 10;
            this.labelTest.Visible = false;
            // 
            // labelAgeTest
            // 
            this.labelAgeTest.AutoSize = true;
            this.labelAgeTest.Location = new System.Drawing.Point(489, 535);
            this.labelAgeTest.Name = "labelAgeTest";
            this.labelAgeTest.Size = new System.Drawing.Size(0, 13);
            this.labelAgeTest.TabIndex = 11;
            this.labelAgeTest.Visible = false;
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 565);
            this.Controls.Add(this.labelAgeTest);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.hiddenlbl);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnQ4);
            this.Controls.Add(this.btnQ3);
            this.Controls.Add(this.btnQ2);
            this.Controls.Add(this.btnQ1);
            this.Name = "Gameplay";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.Gameplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbImage;
        public System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Button btnQ1;
        public System.Windows.Forms.Button btnQ2;
        public System.Windows.Forms.Button btnQ3;
        public System.Windows.Forms.Button btnQ4;
        public System.Windows.Forms.Label lblQuestion;
        public System.Windows.Forms.Label hiddenlbl;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelAgeTest;
    }
}