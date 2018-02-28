namespace UltimateToolBox
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.boxSonderzeichen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(15, 141);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(181, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Sonderzeichen (z.B. !§$%&/)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Couture", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laenge des Passworts:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(211, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(15, 118);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Zahlen";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(15, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Großbuchstaben";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Kleinbuchstaben";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(272, 118);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(240, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Passwort in Zwischenablage kopieren";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Couture", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generiertes Passwort:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zurück zum Hauptmenü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "- Passwort generieren -";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxSonderzeichen
            // 
            this.boxSonderzeichen.Location = new System.Drawing.Point(15, 188);
            this.boxSonderzeichen.Name = "boxSonderzeichen";
            this.boxSonderzeichen.Size = new System.Drawing.Size(181, 20);
            this.boxSonderzeichen.TabIndex = 12;
            this.boxSonderzeichen.Text = "!§$%&/()=?+*#-:;{}_~<>|.[],\"";
            this.boxSonderzeichen.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Erlaubte Sonderzeichen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxSonderzeichen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(563, 274);
            this.MinimumSize = new System.Drawing.Size(563, 274);
            this.Name = "Form2";
            this.Text = "UltimateToolBox - Passwort Generator v1.0";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox boxSonderzeichen;
        private System.Windows.Forms.Label label2;
    }
}