namespace Malcolm_Verifica_2024_01_29
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxQuantita = new System.Windows.Forms.TextBox();
            this.textBoxPrezzo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodiceProduttore = new System.Windows.Forms.TextBox();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.textBoxProduttore = new System.Windows.Forms.TextBox();
            this.textBoxFarnell = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(277, 286);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(174, 286);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxQuantita
            // 
            this.textBoxQuantita.Location = new System.Drawing.Point(187, 205);
            this.textBoxQuantita.Name = "textBoxQuantita";
            this.textBoxQuantita.Size = new System.Drawing.Size(165, 23);
            this.textBoxQuantita.TabIndex = 26;
            // 
            // textBoxPrezzo
            // 
            this.textBoxPrezzo.Location = new System.Drawing.Point(187, 247);
            this.textBoxPrezzo.Name = "textBoxPrezzo";
            this.textBoxPrezzo.Size = new System.Drawing.Size(165, 23);
            this.textBoxPrezzo.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Codice Produttore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Produttore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descrizione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codice Farnell";
            // 
            // textBoxCodiceProduttore
            // 
            this.textBoxCodiceProduttore.Location = new System.Drawing.Point(187, 163);
            this.textBoxCodiceProduttore.Name = "textBoxCodiceProduttore";
            this.textBoxCodiceProduttore.Size = new System.Drawing.Size(165, 23);
            this.textBoxCodiceProduttore.TabIndex = 19;
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(187, 84);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(165, 23);
            this.textBoxDescrizione.TabIndex = 17;
            // 
            // textBoxProduttore
            // 
            this.textBoxProduttore.Location = new System.Drawing.Point(187, 127);
            this.textBoxProduttore.Name = "textBoxProduttore";
            this.textBoxProduttore.Size = new System.Drawing.Size(165, 23);
            this.textBoxProduttore.TabIndex = 16;
            // 
            // textBoxFarnell
            // 
            this.textBoxFarnell.Location = new System.Drawing.Point(187, 39);
            this.textBoxFarnell.Name = "textBoxFarnell";
            this.textBoxFarnell.Size = new System.Drawing.Size(165, 23);
            this.textBoxFarnell.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxFarnell);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxQuantita);
            this.Controls.Add(this.textBoxPrezzo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodiceProduttore);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.textBoxProduttore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxQuantita;
        private TextBox textBoxPrezzo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxCodiceProduttore;
        private TextBox textBoxDescrizione;
        private TextBox textBoxProduttore;
        private TextBox textBoxFarnell;
    }
}