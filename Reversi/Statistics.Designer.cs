namespace Reversi
{
    partial class Statistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblComputerWins = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerAS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblComputerAS = new System.Windows.Forms.Label();
            this.lstUserStatistics = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer Wins:";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(205, 9);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(18, 20);
            this.lblPlayerWins.TabIndex = 2;
            this.lblPlayerWins.Text = "0";
            // 
            // lblComputerWins
            // 
            this.lblComputerWins.AutoSize = true;
            this.lblComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWins.Location = new System.Drawing.Point(494, 9);
            this.lblComputerWins.Name = "lblComputerWins";
            this.lblComputerWins.Size = new System.Drawing.Size(18, 20);
            this.lblComputerWins.TabIndex = 3;
            this.lblComputerWins.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Average Score:";
            // 
            // lblPlayerAS
            // 
            this.lblPlayerAS.AutoSize = true;
            this.lblPlayerAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAS.Location = new System.Drawing.Point(205, 47);
            this.lblPlayerAS.Name = "lblPlayerAS";
            this.lblPlayerAS.Size = new System.Drawing.Size(18, 20);
            this.lblPlayerAS.TabIndex = 5;
            this.lblPlayerAS.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Computer Average Score:";
            // 
            // lblComputerAS
            // 
            this.lblComputerAS.AutoSize = true;
            this.lblComputerAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerAS.Location = new System.Drawing.Point(494, 47);
            this.lblComputerAS.Name = "lblComputerAS";
            this.lblComputerAS.Size = new System.Drawing.Size(18, 20);
            this.lblComputerAS.TabIndex = 7;
            this.lblComputerAS.Text = "0";
            // 
            // lstUserStatistics
            // 
            this.lstUserStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUserStatistics.FormattingEnabled = true;
            this.lstUserStatistics.ItemHeight = 16;
            this.lstUserStatistics.Location = new System.Drawing.Point(16, 111);
            this.lstUserStatistics.Name = "lstUserStatistics";
            this.lstUserStatistics.Size = new System.Drawing.Size(472, 132);
            this.lstUserStatistics.TabIndex = 8;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 283);
            this.Controls.Add(this.lstUserStatistics);
            this.Controls.Add(this.lblComputerAS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayerAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblComputerWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblComputerWins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerAS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblComputerAS;
        private System.Windows.Forms.ListBox lstUserStatistics;
    }
}