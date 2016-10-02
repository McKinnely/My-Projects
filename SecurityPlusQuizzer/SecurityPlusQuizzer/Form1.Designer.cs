namespace SecurityPlusQuizzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBtn1 = new System.Windows.Forms.Button();
            this.shwAnsrBtn = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdyModeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBtn1
            // 
            this.checkBtn1.Location = new System.Drawing.Point(12, 41);
            this.checkBtn1.Name = "checkBtn1";
            this.checkBtn1.Size = new System.Drawing.Size(84, 23);
            this.checkBtn1.TabIndex = 0;
            this.checkBtn1.Text = "Check";
            this.checkBtn1.UseVisualStyleBackColor = true;
            this.checkBtn1.Click += new System.EventHandler(this.CheckBtn1_Click);
            // 
            // shwAnsrBtn
            // 
            this.shwAnsrBtn.Location = new System.Drawing.Point(12, 121);
            this.shwAnsrBtn.Name = "shwAnsrBtn";
            this.shwAnsrBtn.Size = new System.Drawing.Size(84, 23);
            this.shwAnsrBtn.TabIndex = 1;
            this.shwAnsrBtn.Text = "Show Answer";
            this.shwAnsrBtn.UseVisualStyleBackColor = true;
            this.shwAnsrBtn.Click += new System.EventHandler(this.ShwAnsrBtn_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(104, 41);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(84, 20);
            this.answerTextBox.TabIndex = 2;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Location = new System.Drawing.Point(12, 81);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(30, 13);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "RDP";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(491, 39);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(55, 20);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coded By: McKinnely Bentley";
            // 
            // stdyModeBtn
            // 
            this.stdyModeBtn.Location = new System.Drawing.Point(12, 150);
            this.stdyModeBtn.Name = "stdyModeBtn";
            this.stdyModeBtn.Size = new System.Drawing.Size(84, 23);
            this.stdyModeBtn.TabIndex = 7;
            this.stdyModeBtn.Text = "Study Mode";
            this.stdyModeBtn.UseVisualStyleBackColor = true;
            this.stdyModeBtn.Click += new System.EventHandler(this.StdyModeBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecurityPlusQuizzer.Properties.Resources.SecPlusPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.stdyModeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.shwAnsrBtn);
            this.Controls.Add(this.checkBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Security Plus Ports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkBtn1;
        private System.Windows.Forms.Button shwAnsrBtn;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stdyModeBtn;
    }
}

