namespace Presentation_Layer
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
            this.textBoxIdNumber = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.uj;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "UJ Staff Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identification Number";
            // 
            // textBoxIdNumber
            // 
            this.textBoxIdNumber.Location = new System.Drawing.Point(168, 153);
            this.textBoxIdNumber.MaxLength = 13;
            this.textBoxIdNumber.Multiline = true;
            this.textBoxIdNumber.Name = "textBoxIdNumber";
            this.textBoxIdNumber.Size = new System.Drawing.Size(181, 29);
            this.textBoxIdNumber.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(438, 153);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(106, 29);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(438, 198);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 29);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(168, 198);
            this.textBoxName.MaxLength = 13;
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(181, 29);
            this.textBoxName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(438, 242);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(106, 29);
            this.buttonRead.TabIndex = 10;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(168, 242);
            this.textBoxSurname.MaxLength = 13;
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(181, 29);
            this.textBoxSurname.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Surname";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(438, 289);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(106, 29);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(13, 389);
            this.textBoxDisplay.MaxLength = 13;
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(531, 157);
            this.textBoxDisplay.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(438, 340);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 29);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Age";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(165, 292);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 16);
            this.labelEmail.TabIndex = 17;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(165, 343);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(0, 16);
            this.labelAge.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 558);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxIdNumber);
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
        private System.Windows.Forms.TextBox textBoxIdNumber;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
    }
}

