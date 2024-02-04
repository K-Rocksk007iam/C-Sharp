namespace LogInForm
{
    partial class Delete
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
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deleteTheRecord = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(145, 71);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 13);
            this.name.TabIndex = 0;
            this.name.Text = "username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // deleteTheRecord
            // 
            this.deleteTheRecord.Location = new System.Drawing.Point(435, 119);
            this.deleteTheRecord.Name = "deleteTheRecord";
            this.deleteTheRecord.Size = new System.Drawing.Size(306, 23);
            this.deleteTheRecord.TabIndex = 1;
            this.deleteTheRecord.Text = "Delete ";
            this.deleteTheRecord.UseVisualStyleBackColor = true;
            this.deleteTheRecord.Click += new System.EventHandler(this.deleteTheRecord_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Go back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(145, 119);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteTheRecord);
            this.Controls.Add(this.name);
            this.Name = "Delete";
            this.Text = "DeleteTheRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button deleteTheRecord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label password;
    }
}