namespace QuizApp
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.btnJawab = new System.Windows.Forms.Button();
            this.pilihanA = new System.Windows.Forms.RadioButton();
            this.pilihanB = new System.Windows.Forms.RadioButton();
            this.pilihanC = new System.Windows.Forms.RadioButton();
            this.pilihanD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelanjutnya = new System.Windows.Forms.Button();
            this.btnSebelumnya = new System.Windows.Forms.Button();
            this.soal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJawab
            // 
            this.btnJawab.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJawab.Image = ((System.Drawing.Image)(resources.GetObject("btnJawab.Image")));
            this.btnJawab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJawab.Location = new System.Drawing.Point(148, 277);
            this.btnJawab.Name = "btnJawab";
            this.btnJawab.Size = new System.Drawing.Size(119, 57);
            this.btnJawab.TabIndex = 4;
            this.btnJawab.Text = "Jawab";
            this.btnJawab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJawab.UseVisualStyleBackColor = true;
            this.btnJawab.Click += new System.EventHandler(this.btnJawab_Click);
            // 
            // pilihanA
            // 
            this.pilihanA.AutoSize = true;
            this.pilihanA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihanA.Location = new System.Drawing.Point(43, 157);
            this.pilihanA.Name = "pilihanA";
            this.pilihanA.Size = new System.Drawing.Size(32, 24);
            this.pilihanA.TabIndex = 6;
            this.pilihanA.TabStop = true;
            this.pilihanA.Text = "-";
            this.pilihanA.UseVisualStyleBackColor = true;
            this.pilihanA.CheckedChanged += new System.EventHandler(this.pilihanA_CheckedChanged);
            // 
            // pilihanB
            // 
            this.pilihanB.AutoSize = true;
            this.pilihanB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihanB.Location = new System.Drawing.Point(43, 183);
            this.pilihanB.Name = "pilihanB";
            this.pilihanB.Size = new System.Drawing.Size(32, 24);
            this.pilihanB.TabIndex = 7;
            this.pilihanB.TabStop = true;
            this.pilihanB.Text = "-";
            this.pilihanB.UseVisualStyleBackColor = true;
            // 
            // pilihanC
            // 
            this.pilihanC.AutoSize = true;
            this.pilihanC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihanC.Location = new System.Drawing.Point(43, 210);
            this.pilihanC.Name = "pilihanC";
            this.pilihanC.Size = new System.Drawing.Size(32, 24);
            this.pilihanC.TabIndex = 8;
            this.pilihanC.TabStop = true;
            this.pilihanC.Text = "-";
            this.pilihanC.UseVisualStyleBackColor = true;
            // 
            // pilihanD
            // 
            this.pilihanD.AutoSize = true;
            this.pilihanD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihanD.Location = new System.Drawing.Point(43, 236);
            this.pilihanD.Name = "pilihanD";
            this.pilihanD.Size = new System.Drawing.Size(32, 24);
            this.pilihanD.TabIndex = 9;
            this.pilihanD.TabStop = true;
            this.pilihanD.Text = "-";
            this.pilihanD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "A.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "B.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "C.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "D.";
            // 
            // btnSelanjutnya
            // 
            this.btnSelanjutnya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelanjutnya.Image = ((System.Drawing.Image)(resources.GetObject("btnSelanjutnya.Image")));
            this.btnSelanjutnya.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelanjutnya.Location = new System.Drawing.Point(294, 277);
            this.btnSelanjutnya.Name = "btnSelanjutnya";
            this.btnSelanjutnya.Size = new System.Drawing.Size(108, 57);
            this.btnSelanjutnya.TabIndex = 14;
            this.btnSelanjutnya.Text = "Selanjutnya";
            this.btnSelanjutnya.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelanjutnya.UseVisualStyleBackColor = true;
            this.btnSelanjutnya.Click += new System.EventHandler(this.btnSelanjutnya_Click);
            // 
            // btnSebelumnya
            // 
            this.btnSebelumnya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSebelumnya.Image = ((System.Drawing.Image)(resources.GetObject("btnSebelumnya.Image")));
            this.btnSebelumnya.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSebelumnya.Location = new System.Drawing.Point(12, 277);
            this.btnSebelumnya.Name = "btnSebelumnya";
            this.btnSebelumnya.Size = new System.Drawing.Size(108, 57);
            this.btnSebelumnya.TabIndex = 3;
            this.btnSebelumnya.Text = "Sebelumnya";
            this.btnSebelumnya.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSebelumnya.UseVisualStyleBackColor = true;
            this.btnSebelumnya.Click += new System.EventHandler(this.btnSebelumnya_Click);
            // 
            // soal
            // 
            this.soal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.soal.BackColor = System.Drawing.Color.White;
            this.soal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soal.Location = new System.Drawing.Point(12, 12);
            this.soal.Multiline = true;
            this.soal.Name = "soal";
            this.soal.ReadOnly = true;
            this.soal.Size = new System.Drawing.Size(390, 126);
            this.soal.TabIndex = 15;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(414, 346);
            this.Controls.Add(this.soal);
            this.Controls.Add(this.btnSelanjutnya);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pilihanD);
            this.Controls.Add(this.pilihanC);
            this.Controls.Add(this.pilihanB);
            this.Controls.Add(this.pilihanA);
            this.Controls.Add(this.btnJawab);
            this.Controls.Add(this.btnSebelumnya);
            this.Name = "Quiz";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJawab;
        private System.Windows.Forms.RadioButton pilihanA;
        private System.Windows.Forms.RadioButton pilihanB;
        private System.Windows.Forms.RadioButton pilihanC;
        private System.Windows.Forms.RadioButton pilihanD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelanjutnya;
        private System.Windows.Forms.Button btnSebelumnya;
        private System.Windows.Forms.TextBox soal;

    }
}

