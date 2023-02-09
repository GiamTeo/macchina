namespace macchinaripassoverifica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpieno = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnfrena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStampa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpieno
            // 
            this.btnpieno.Location = new System.Drawing.Point(245, 46);
            this.btnpieno.Name = "btnpieno";
            this.btnpieno.Size = new System.Drawing.Size(89, 47);
            this.btnpieno.TabIndex = 0;
            this.btnpieno.Text = "Pieno";
            this.btnpieno.UseVisualStyleBackColor = true;
            this.btnpieno.Click += new System.EventHandler(this.btnpieno_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(245, 123);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(89, 47);
            this.btnAcc.TabIndex = 1;
            this.btnAcc.Text = "Accellera";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnfrena
            // 
            this.btnfrena.Location = new System.Drawing.Point(245, 199);
            this.btnfrena.Name = "btnfrena";
            this.btnfrena.Size = new System.Drawing.Size(89, 47);
            this.btnfrena.TabIndex = 2;
            this.btnfrena.Text = "Frena";
            this.btnfrena.UseVisualStyleBackColor = true;
            this.btnfrena.Click += new System.EventHandler(this.btnfrena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "targa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "velocita";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(386, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 276);
            this.listBox1.TabIndex = 9;
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(245, 275);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(89, 47);
            this.btnStampa.TabIndex = 10;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 123);
            this.button1.TabIndex = 11;
            this.button1.Text = "Crea la tua macchina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfrena);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.btnpieno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpieno;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnfrena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button button1;
    }
}

