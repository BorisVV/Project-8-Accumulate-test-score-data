namespace AccumulateTestScoreData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ScoreTotal = new System.Windows.Forms.Label();
            this.lbl_ScoreCount = new System.Windows.Forms.Label();
            this.lbl_Average = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.btn_SortedScores = new System.Windows.Forms.Button();
            this.btn_ClearScores = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_MinScore = new System.Windows.Forms.Label();
            this.lbl_MaxScore = new System.Windows.Forms.Label();
            this.btn_UnsortedList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boris Valle / Project 8 / Accumulated tests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter new score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Score count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Average:";
            // 
            // lbl_ScoreTotal
            // 
            this.lbl_ScoreTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ScoreTotal.Location = new System.Drawing.Point(30, 131);
            this.lbl_ScoreTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ScoreTotal.Name = "lbl_ScoreTotal";
            this.lbl_ScoreTotal.Size = new System.Drawing.Size(80, 32);
            this.lbl_ScoreTotal.TabIndex = 5;
            // 
            // lbl_ScoreCount
            // 
            this.lbl_ScoreCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ScoreCount.Location = new System.Drawing.Point(30, 191);
            this.lbl_ScoreCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ScoreCount.Name = "lbl_ScoreCount";
            this.lbl_ScoreCount.Size = new System.Drawing.Size(80, 32);
            this.lbl_ScoreCount.TabIndex = 6;
            // 
            // lbl_Average
            // 
            this.lbl_Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Average.Location = new System.Drawing.Point(30, 244);
            this.lbl_Average.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Average.Name = "lbl_Average";
            this.lbl_Average.Size = new System.Drawing.Size(80, 32);
            this.lbl_Average.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(242, 46);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 32);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "&Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(155, 46);
            this.txt_Score.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(79, 24);
            this.txt_Score.TabIndex = 1;
            // 
            // btn_SortedScores
            // 
            this.btn_SortedScores.Location = new System.Drawing.Point(207, 290);
            this.btn_SortedScores.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SortedScores.Name = "btn_SortedScores";
            this.btn_SortedScores.Size = new System.Drawing.Size(169, 32);
            this.btn_SortedScores.TabIndex = 10;
            this.btn_SortedScores.Text = "Display &Sorted Scores";
            this.btn_SortedScores.UseVisualStyleBackColor = true;
            this.btn_SortedScores.Click += new System.EventHandler(this.btn_SortedScores_Click);
            // 
            // btn_ClearScores
            // 
            this.btn_ClearScores.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ClearScores.Location = new System.Drawing.Point(242, 144);
            this.btn_ClearScores.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClearScores.Name = "btn_ClearScores";
            this.btn_ClearScores.Size = new System.Drawing.Size(111, 32);
            this.btn_ClearScores.TabIndex = 11;
            this.btn_ClearScores.Text = "&Clear scores";
            this.btn_ClearScores.UseVisualStyleBackColor = true;
            this.btn_ClearScores.Click += new System.EventHandler(this.btn_ClearScores_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(242, 184);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(111, 32);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Min score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max score:";
            // 
            // lbl_MinScore
            // 
            this.lbl_MinScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MinScore.Location = new System.Drawing.Point(146, 144);
            this.lbl_MinScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MinScore.Name = "lbl_MinScore";
            this.lbl_MinScore.Size = new System.Drawing.Size(64, 32);
            this.lbl_MinScore.TabIndex = 15;
            // 
            // lbl_MaxScore
            // 
            this.lbl_MaxScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaxScore.Location = new System.Drawing.Point(146, 197);
            this.lbl_MaxScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaxScore.Name = "lbl_MaxScore";
            this.lbl_MaxScore.Size = new System.Drawing.Size(64, 32);
            this.lbl_MaxScore.TabIndex = 16;
            // 
            // btn_UnsortedList
            // 
            this.btn_UnsortedList.Location = new System.Drawing.Point(17, 290);
            this.btn_UnsortedList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UnsortedList.Name = "btn_UnsortedList";
            this.btn_UnsortedList.Size = new System.Drawing.Size(182, 32);
            this.btn_UnsortedList.TabIndex = 17;
            this.btn_UnsortedList.Text = "Display &Unsorted Scores";
            this.btn_UnsortedList.UseVisualStyleBackColor = true;
            this.btn_UnsortedList.Click += new System.EventHandler(this.btn_UnsortedList_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(387, 358);
            this.Controls.Add(this.btn_UnsortedList);
            this.Controls.Add(this.lbl_MaxScore);
            this.Controls.Add(this.lbl_MinScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ClearScores);
            this.Controls.Add(this.btn_SortedScores);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Average);
            this.Controls.Add(this.lbl_ScoreCount);
            this.Controls.Add(this.lbl_ScoreTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Data App";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ScoreTotal;
        private System.Windows.Forms.Label lbl_ScoreCount;
        private System.Windows.Forms.Label lbl_Average;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.Button btn_SortedScores;
        private System.Windows.Forms.Button btn_ClearScores;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_MinScore;
        private System.Windows.Forms.Label lbl_MaxScore;
        private System.Windows.Forms.Button btn_UnsortedList;
    }
}

