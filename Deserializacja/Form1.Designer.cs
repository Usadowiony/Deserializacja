namespace Deserializacja
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
            this.deserializujBnt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // deserializujBnt
            // 
            this.deserializujBnt.Location = new System.Drawing.Point(118, 245);
            this.deserializujBnt.Name = "deserializujBnt";
            this.deserializujBnt.Size = new System.Drawing.Size(75, 23);
            this.deserializujBnt.TabIndex = 0;
            this.deserializujBnt.Text = "Deserializuj";
            this.deserializujBnt.UseVisualStyleBackColor = true;
            this.deserializujBnt.Click += new System.EventHandler(this.deserializujBnt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.AutoSize = true;
            this.titleTextBox.Location = new System.Drawing.Point(40, 30);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(32, 13);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.Text = "Tytuł";
            // 
            // autorTextBox
            // 
            this.autorTextBox.AutoSize = true;
            this.autorTextBox.Location = new System.Drawing.Point(40, 80);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(32, 13);
            this.autorTextBox.TabIndex = 4;
            this.autorTextBox.Text = "Autor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 3;
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(34, 245);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(75, 23);
            this.addToListBtn.TabIndex = 5;
            this.addToListBtn.Text = "Add to list";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data wydania";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(225, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 121);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 280);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.addToListBtn);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deserializujBnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deserializujBnt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleTextBox;
        private System.Windows.Forms.Label autorTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addToListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

