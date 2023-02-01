
namespace _5th_Grade_Game
{
    partial class GameInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInfo));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLeader = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(98, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(394, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Are You Smarter Than A 5th Grader?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.White;
            this.lblRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(62, 57);
            this.lblRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(454, 92);
            this.lblRules.TabIndex = 1;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 211);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 211);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.nametxt_TextChanged_1);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(328, 210);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(46, 20);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age: ";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(378, 210);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(153, 20);
            this.txtAge.TabIndex = 5;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(26, 299);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(146, 57);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // btnLeader
            // 
            this.btnLeader.BackColor = System.Drawing.Color.White;
            this.btnLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeader.Location = new System.Drawing.Point(206, 299);
            this.btnLeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeader.Name = "btnLeader";
            this.btnLeader.Size = new System.Drawing.Size(146, 57);
            this.btnLeader.TabIndex = 7;
            this.btnLeader.Text = "Leaderboard";
            this.btnLeader.UseVisualStyleBackColor = false;
            this.btnLeader.Click += new System.EventHandler(this.leaderboardbtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(393, 299);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 57);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(95, 172);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(380, 18);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Please enter your Name and Age to begin playing!";
            // 
            // GameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLeader);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smarter than a 5th Grader";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.GameInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblRules;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblAge;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.Button btnPlay;
        public System.Windows.Forms.Button btnLeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblInstructions;
    }
}