
namespace _5th_Grade_Game
{
    partial class Leaderboard
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
            this.dgvLeaderBoard = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaderBoard
            // 
            this.dgvLeaderBoard.AllowUserToAddRows = false;
            this.dgvLeaderBoard.AllowUserToDeleteRows = false;
            this.dgvLeaderBoard.AllowUserToResizeColumns = false;
            this.dgvLeaderBoard.AllowUserToResizeRows = false;
            this.dgvLeaderBoard.Location = new System.Drawing.Point(26, 12);
            this.dgvLeaderBoard.Name = "dgvLeaderBoard";
            this.dgvLeaderBoard.Size = new System.Drawing.Size(345, 407);
            this.dgvLeaderBoard.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(396, 50);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 54);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return back to Main Menu";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 502);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvLeaderBoard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Leaderboard";
            this.ShowIcon = false;
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaderBoard;
        private System.Windows.Forms.Button btnReturn;
    }
}