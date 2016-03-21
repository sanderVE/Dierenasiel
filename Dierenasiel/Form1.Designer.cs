namespace Dierenasiel
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
            this.btnVoegHondToe = new System.Windows.Forms.Button();
            this.tbHondNaam = new System.Windows.Forms.TextBox();
            this.lblHondNaam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKatNaam = new System.Windows.Forms.TextBox();
            this.btnVoegKatToe = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoegHondToe
            // 
            this.btnVoegHondToe.Location = new System.Drawing.Point(16, 42);
            this.btnVoegHondToe.Name = "btnVoegHondToe";
            this.btnVoegHondToe.Size = new System.Drawing.Size(138, 23);
            this.btnVoegHondToe.TabIndex = 0;
            this.btnVoegHondToe.Text = "Voeg hond toe";
            this.btnVoegHondToe.UseVisualStyleBackColor = true;
            this.btnVoegHondToe.Click += new System.EventHandler(this.btnVoegHondToe_Click);
            // 
            // tbHondNaam
            // 
            this.tbHondNaam.Location = new System.Drawing.Point(54, 16);
            this.tbHondNaam.Name = "tbHondNaam";
            this.tbHondNaam.Size = new System.Drawing.Size(100, 20);
            this.tbHondNaam.TabIndex = 1;
            // 
            // lblHondNaam
            // 
            this.lblHondNaam.AutoSize = true;
            this.lblHondNaam.Location = new System.Drawing.Point(13, 19);
            this.lblHondNaam.Name = "lblHondNaam";
            this.lblHondNaam.Size = new System.Drawing.Size(35, 13);
            this.lblHondNaam.TabIndex = 2;
            this.lblHondNaam.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam";
            // 
            // tbKatNaam
            // 
            this.tbKatNaam.Location = new System.Drawing.Point(222, 16);
            this.tbKatNaam.Name = "tbKatNaam";
            this.tbKatNaam.Size = new System.Drawing.Size(100, 20);
            this.tbKatNaam.TabIndex = 4;
            // 
            // btnVoegKatToe
            // 
            this.btnVoegKatToe.Location = new System.Drawing.Point(184, 42);
            this.btnVoegKatToe.Name = "btnVoegKatToe";
            this.btnVoegKatToe.Size = new System.Drawing.Size(138, 23);
            this.btnVoegKatToe.TabIndex = 3;
            this.btnVoegKatToe.Text = "Voeg kat toe";
            this.btnVoegKatToe.UseVisualStyleBackColor = true;
            this.btnVoegKatToe.Click += new System.EventHandler(this.btnVoegKatToe_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 134);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKatNaam);
            this.Controls.Add(this.btnVoegKatToe);
            this.Controls.Add(this.lblHondNaam);
            this.Controls.Add(this.tbHondNaam);
            this.Controls.Add(this.btnVoegHondToe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoegHondToe;
        private System.Windows.Forms.TextBox tbHondNaam;
        private System.Windows.Forms.Label lblHondNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKatNaam;
        private System.Windows.Forms.Button btnVoegKatToe;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

