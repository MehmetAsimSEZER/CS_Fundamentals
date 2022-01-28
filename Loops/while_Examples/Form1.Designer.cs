namespace while_Examples
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTarihleriGetir = new System.Windows.Forms.Button();
            this.btnExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sayıları Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(134, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 290);
            this.listBox1.TabIndex = 1;
            // 
            // btnTarihleriGetir
            // 
            this.btnTarihleriGetir.Location = new System.Drawing.Point(12, 65);
            this.btnTarihleriGetir.Name = "btnTarihleriGetir";
            this.btnTarihleriGetir.Size = new System.Drawing.Size(101, 23);
            this.btnTarihleriGetir.TabIndex = 2;
            this.btnTarihleriGetir.Text = "Tarihleri Getir";
            this.btnTarihleriGetir.UseVisualStyleBackColor = true;
            this.btnTarihleriGetir.Click += new System.EventHandler(this.btnTarihleriGetir_Click);
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(12, 105);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(101, 23);
            this.btnExample.TabIndex = 3;
            this.btnExample.Text = "Example";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.btnTarihleriGetir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTarihleriGetir;
        private System.Windows.Forms.Button btnExample;
    }
}

