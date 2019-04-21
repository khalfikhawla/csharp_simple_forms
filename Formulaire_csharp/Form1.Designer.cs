namespace Formulaire_csharp
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
            this.nomber1 = new System.Windows.Forms.Label();
            this.nomber2 = new System.Windows.Forms.Label();
            this.somme = new System.Windows.Forms.Label();
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox_num2 = new System.Windows.Forms.TextBox();
            this.textBox_somme = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.effacer = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.radio_multiplication = new System.Windows.Forms.RadioButton();
            this.radio_soustractions = new System.Windows.Forms.RadioButton();
            this.radio_division = new System.Windows.Forms.RadioButton();
            this.radio_sommation = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nomber1
            // 
            this.nomber1.AutoSize = true;
            this.nomber1.Location = new System.Drawing.Point(59, 41);
            this.nomber1.Name = "nomber1";
            this.nomber1.Size = new System.Drawing.Size(50, 13);
            this.nomber1.TabIndex = 0;
            this.nomber1.Text = "Nomber1";
            this.nomber1.Click += new System.EventHandler(this.nomber1_Click);
            // 
            // nomber2
            // 
            this.nomber2.AutoSize = true;
            this.nomber2.Location = new System.Drawing.Point(59, 81);
            this.nomber2.Name = "nomber2";
            this.nomber2.Size = new System.Drawing.Size(50, 13);
            this.nomber2.TabIndex = 1;
            this.nomber2.Text = "Nomber2";
            this.nomber2.Click += new System.EventHandler(this.label2_Click);
            // 
            // somme
            // 
            this.somme.AutoSize = true;
            this.somme.Location = new System.Drawing.Point(59, 189);
            this.somme.Name = "somme";
            this.somme.Size = new System.Drawing.Size(42, 13);
            this.somme.TabIndex = 2;
            this.somme.Text = "Somme";
            this.somme.Click += new System.EventHandler(this.somme_Click);
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(134, 41);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(100, 20);
            this.textBox_num1.TabIndex = 3;
            this.textBox_num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_num2
            // 
            this.textBox_num2.Location = new System.Drawing.Point(134, 81);
            this.textBox_num2.Name = "textBox_num2";
            this.textBox_num2.Size = new System.Drawing.Size(100, 20);
            this.textBox_num2.TabIndex = 4;
            this.textBox_num2.TextChanged += new System.EventHandler(this.textBox_num2_TextChanged);
            // 
            // textBox_somme
            // 
            this.textBox_somme.Location = new System.Drawing.Point(134, 189);
            this.textBox_somme.Name = "textBox_somme";
            this.textBox_somme.Size = new System.Drawing.Size(100, 20);
            this.textBox_somme.TabIndex = 5;
            this.textBox_somme.TextChanged += new System.EventHandler(this.textBox_somme_TextChanged);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(12, 226);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // effacer
            // 
            this.effacer.Location = new System.Drawing.Point(100, 226);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(75, 23);
            this.effacer.TabIndex = 7;
            this.effacer.Text = "Effacer";
            this.effacer.UseVisualStyleBackColor = true;
            this.effacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(197, 226);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 8;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // radio_multiplication
            // 
            this.radio_multiplication.AutoSize = true;
            this.radio_multiplication.Location = new System.Drawing.Point(8, 124);
            this.radio_multiplication.Name = "radio_multiplication";
            this.radio_multiplication.Size = new System.Drawing.Size(86, 17);
            this.radio_multiplication.TabIndex = 11;
            this.radio_multiplication.TabStop = true;
            this.radio_multiplication.Text = "Multiplication";
            this.radio_multiplication.UseVisualStyleBackColor = true;
            this.radio_multiplication.CheckedChanged += new System.EventHandler(this.radio_multiplication_CheckedChanged);
            // 
            // radio_soustractions
            // 
            this.radio_soustractions.AutoSize = true;
            this.radio_soustractions.Location = new System.Drawing.Point(100, 124);
            this.radio_soustractions.Name = "radio_soustractions";
            this.radio_soustractions.Size = new System.Drawing.Size(89, 17);
            this.radio_soustractions.TabIndex = 12;
            this.radio_soustractions.TabStop = true;
            this.radio_soustractions.Text = "Soustractions";
            this.radio_soustractions.UseVisualStyleBackColor = true;
            this.radio_soustractions.CheckedChanged += new System.EventHandler(this.radio_soustractions_CheckedChanged);
            // 
            // radio_division
            // 
            this.radio_division.AutoSize = true;
            this.radio_division.Location = new System.Drawing.Point(210, 124);
            this.radio_division.Name = "radio_division";
            this.radio_division.Size = new System.Drawing.Size(62, 17);
            this.radio_division.TabIndex = 13;
            this.radio_division.TabStop = true;
            this.radio_division.Text = "Division";
            this.radio_division.UseVisualStyleBackColor = true;
            this.radio_division.CheckedChanged += new System.EventHandler(this.radio_division_CheckedChanged);
            // 
            // radio_sommation
            // 
            this.radio_sommation.AutoSize = true;
            this.radio_sommation.Location = new System.Drawing.Point(100, 166);
            this.radio_sommation.Name = "radio_sommation";
            this.radio_sommation.Size = new System.Drawing.Size(77, 17);
            this.radio_sommation.TabIndex = 14;
            this.radio_sommation.TabStop = true;
            this.radio_sommation.Text = "Sommation";
            this.radio_sommation.UseVisualStyleBackColor = true;
            this.radio_sommation.CheckedChanged += new System.EventHandler(this.radio_sommation_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radio_sommation);
            this.Controls.Add(this.radio_division);
            this.Controls.Add(this.radio_soustractions);
            this.Controls.Add(this.radio_multiplication);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.effacer);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.textBox_somme);
            this.Controls.Add(this.textBox_num2);
            this.Controls.Add(this.textBox_num1);
            this.Controls.Add(this.somme);
            this.Controls.Add(this.nomber2);
            this.Controls.Add(this.nomber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomber1;
        private System.Windows.Forms.Label nomber2;
        private System.Windows.Forms.Label somme;
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox_num2;
        private System.Windows.Forms.TextBox textBox_somme;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button effacer;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.RadioButton radio_multiplication;
        private System.Windows.Forms.RadioButton radio_soustractions;
        private System.Windows.Forms.RadioButton radio_division;
        private System.Windows.Forms.RadioButton radio_sommation;
    }
}

