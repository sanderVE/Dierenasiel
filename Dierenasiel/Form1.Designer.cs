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
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReserveer = new System.Windows.Forms.Button();
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
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(12, 240);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(151, 23);
            this.btnOverzicht.TabIndex = 7;
            this.btnOverzicht.Text = "Laat dieren zien";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(151, 146);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Eigenaar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dier";
            // 
            // btnReserveer
            // 
            this.btnReserveer.Location = new System.Drawing.Point(184, 162);
            this.btnReserveer.Name = "btnReserveer";
            this.btnReserveer.Size = new System.Drawing.Size(176, 23);
            this.btnReserveer.TabIndex = 13;
            this.btnReserveer.Text = "Reserveer";
            this.btnReserveer.UseVisualStyleBackColor = true;
            this.btnReserveer.Click += new System.EventHandler(this.btnReserveer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 274);
            this.Controls.Add(this.btnReserveer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOverzicht);
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
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReserveer;
    }
}

