namespace Gry_Karciane
{
    partial class Form3
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
            OK = new Button();
            ANULUJ = new Button();
            label1 = new Label();
            label2 = new Label();
            LiczbaGraczy = new TextBox();
            LiczbaTur = new TextBox();
            SuspendLayout();
            // 
            // OK
            // 
            OK.Location = new Point(12, 88);
            OK.Name = "OK";
            OK.Size = new Size(75, 23);
            OK.TabIndex = 0;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click_1;
            // 
            // ANULUJ
            // 
            ANULUJ.Location = new Point(117, 88);
            ANULUJ.Name = "ANULUJ";
            ANULUJ.Size = new Size(75, 23);
            ANULUJ.TabIndex = 1;
            ANULUJ.Text = "ANULUJ";
            ANULUJ.UseVisualStyleBackColor = true;
            ANULUJ.Click += ANULUJ_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Liczbagraczy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Liczbatur";
            // 
            // LiczbaGraczy
            // 
            LiczbaGraczy.Location = new Point(92, 12);
            LiczbaGraczy.Name = "LiczbaGraczy";
            LiczbaGraczy.Size = new Size(100, 23);
            LiczbaGraczy.TabIndex = 4;
            LiczbaGraczy.TextChanged += LiczbaGraczy_TextChanged;
            // 
            // LiczbaTur
            // 
            LiczbaTur.Location = new Point(92, 45);
            LiczbaTur.Name = "LiczbaTur";
            LiczbaTur.Size = new Size(100, 23);
            LiczbaTur.TabIndex = 5;
            LiczbaTur.TextChanged += LiczbaTur_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 133);
            Controls.Add(LiczbaTur);
            Controls.Add(LiczbaGraczy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ANULUJ);
            Controls.Add(OK);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OK;
        private Button ANULUJ;
        private Label label1;
        private Label label2;
        private TextBox LiczbaGraczy;
        private TextBox LiczbaTur;
    }
}