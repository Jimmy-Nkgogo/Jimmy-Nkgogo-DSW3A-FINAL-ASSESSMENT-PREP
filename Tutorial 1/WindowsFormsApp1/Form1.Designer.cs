namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.textBoxAssignment = new System.Windows.Forms.TextBox();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.textBoxExam = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.uj;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "University Of Johannesburg Exam Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Exam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Final";
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Location = new System.Drawing.Point(154, 147);
            this.textBoxStudentNumber.Multiline = true;
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(185, 28);
            this.textBoxStudentNumber.TabIndex = 7;
            this.textBoxStudentNumber.TextChanged += new System.EventHandler(this.textBoxStudentNumber_TextChanged);
            this.textBoxStudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudentNumber_KeyPress);
            // 
            // textBoxAssignment
            // 
            this.textBoxAssignment.Location = new System.Drawing.Point(154, 199);
            this.textBoxAssignment.Multiline = true;
            this.textBoxAssignment.Name = "textBoxAssignment";
            this.textBoxAssignment.Size = new System.Drawing.Size(185, 28);
            this.textBoxAssignment.TabIndex = 8;
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(154, 243);
            this.textBoxTest.Multiline = true;
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(185, 28);
            this.textBoxTest.TabIndex = 9;
            // 
            // textBoxExam
            // 
            this.textBoxExam.Location = new System.Drawing.Point(154, 287);
            this.textBoxExam.Multiline = true;
            this.textBoxExam.Name = "textBoxExam";
            this.textBoxExam.Size = new System.Drawing.Size(185, 28);
            this.textBoxExam.TabIndex = 10;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Enabled = false;
            this.textBoxFinal.Location = new System.Drawing.Point(154, 333);
            this.textBoxFinal.Multiline = true;
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(185, 28);
            this.textBoxFinal.TabIndex = 11;
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Enabled = false;
            this.textBoxDisplay.Location = new System.Drawing.Point(467, 190);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(456, 171);
            this.textBoxDisplay.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Student Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Final Mark";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(820, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Result Code";
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(15, 391);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(100, 31);
            this.buttonCompute.TabIndex = 16;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(154, 391);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 31);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(299, 391);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(100, 31);
            this.buttonDisplay.TabIndex = 18;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(442, 391);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(100, 31);
            this.buttonWrite.TabIndex = 19;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(583, 391);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 31);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(734, 391);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 31);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxExam);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.textBoxAssignment);
            this.Controls.Add(this.textBoxStudentNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.TextBox textBoxAssignment;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.TextBox textBoxExam;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

