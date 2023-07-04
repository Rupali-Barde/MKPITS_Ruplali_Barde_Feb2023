namespace FendhalPreparation
{
    partial class FormRegister
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
            this.groupBox1UserDetails = new System.Windows.Forms.GroupBox();
            this.button1Save = new System.Windows.Forms.Button();
            this.button1Reset = new System.Windows.Forms.Button();
            this.label1Name = new System.Windows.Forms.Label();
            this.label2Age = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.textBox2Age = new System.Windows.Forms.TextBox();
            this.textBox3MobileNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1UserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1UserDetails
            // 
            this.groupBox1UserDetails.Controls.Add(this.label1);
            this.groupBox1UserDetails.Controls.Add(this.textBox3MobileNo);
            this.groupBox1UserDetails.Controls.Add(this.textBox2Age);
            this.groupBox1UserDetails.Controls.Add(this.textBox1Name);
            this.groupBox1UserDetails.Controls.Add(this.label3);
            this.groupBox1UserDetails.Controls.Add(this.label2Age);
            this.groupBox1UserDetails.Controls.Add(this.label1Name);
            this.groupBox1UserDetails.Controls.Add(this.button1Reset);
            this.groupBox1UserDetails.Controls.Add(this.button1Save);
            this.groupBox1UserDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1UserDetails.Location = new System.Drawing.Point(0, 12);
            this.groupBox1UserDetails.Name = "groupBox1UserDetails";
            this.groupBox1UserDetails.Size = new System.Drawing.Size(419, 211);
            this.groupBox1UserDetails.TabIndex = 0;
            this.groupBox1UserDetails.TabStop = false;
            this.groupBox1UserDetails.Text = "UserDetails";
            // 
            // button1Save
            // 
            this.button1Save.Location = new System.Drawing.Point(223, 170);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(79, 35);
            this.button1Save.TabIndex = 7;
            this.button1Save.Text = "Save";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // button1Reset
            // 
            this.button1Reset.Location = new System.Drawing.Point(320, 170);
            this.button1Reset.Name = "button1Reset";
            this.button1Reset.Size = new System.Drawing.Size(75, 35);
            this.button1Reset.TabIndex = 1;
            this.button1Reset.Text = "Reset";
            this.button1Reset.UseVisualStyleBackColor = true;
            this.button1Reset.Click += new System.EventHandler(this.button1Reset_Click);
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(137, 39);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(57, 21);
            this.label1Name.TabIndex = 8;
            this.label1Name.Text = "Name";
            // 
            // label2Age
            // 
            this.label2Age.AutoSize = true;
            this.label2Age.Location = new System.Drawing.Point(12, 85);
            this.label2Age.Name = "label2Age";
            this.label2Age.Size = new System.Drawing.Size(41, 21);
            this.label2Age.TabIndex = 9;
            this.label2Age.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mobile.No";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(137, 36);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(183, 28);
            this.textBox1Name.TabIndex = 1;
            // 
            // textBox2Age
            // 
            this.textBox2Age.Location = new System.Drawing.Point(137, 85);
            this.textBox2Age.MaxLength = 100;
            this.textBox2Age.Name = "textBox2Age";
            this.textBox2Age.Size = new System.Drawing.Size(183, 28);
            this.textBox2Age.TabIndex = 11;
            // 
            // textBox3MobileNo
            // 
            this.textBox3MobileNo.Location = new System.Drawing.Point(136, 129);
            this.textBox3MobileNo.MaxLength = 10;
            this.textBox3MobileNo.Name = "textBox3MobileNo";
            this.textBox3MobileNo.Size = new System.Drawing.Size(184, 28);
            this.textBox3MobileNo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.groupBox1UserDetails);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1UserDetails.ResumeLayout(false);
            this.groupBox1UserDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1UserDetails;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2Age;
        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.Button button1Reset;
        private System.Windows.Forms.TextBox textBox3MobileNo;
        private System.Windows.Forms.TextBox textBox2Age;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.Label label1;
    }
}

