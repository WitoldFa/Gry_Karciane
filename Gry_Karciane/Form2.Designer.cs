namespace Gry_Karciane
{
    partial class WojnaGra
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
            panel1 = new Panel();
            Ustawienia = new Button();
            Anuluj = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 321);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Ustawienia
            // 
            Ustawienia.Location = new Point(558, 281);
            Ustawienia.Name = "Ustawienia";
            Ustawienia.Size = new Size(75, 23);
            Ustawienia.TabIndex = 1;
            Ustawienia.Text = "Ustawienia";
            Ustawienia.UseVisualStyleBackColor = true;
            Ustawienia.Click += Ustawienia_Click_1;
            // 
            // Anuluj
            // 
            Anuluj.Location = new Point(558, 310);
            Anuluj.Name = "Anuluj";
            Anuluj.Size = new Size(75, 23);
            Anuluj.TabIndex = 2;
            Anuluj.Text = "Anuluj";
            Anuluj.UseVisualStyleBackColor = true;
            Anuluj.Click += Anuluj_Click_1;
            // 
            // WojnaGra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 354);
            Controls.Add(Anuluj);
            Controls.Add(Ustawienia);
            Controls.Add(panel1);
            Name = "WojnaGra";
            Text = "WojnaGra";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Ustawienia;
        private Button Anuluj;
    }
}