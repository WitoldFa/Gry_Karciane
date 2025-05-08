namespace Gry_Karciane
{
    partial class BlackJackUstawienia
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
            zatwierdzanie = new Button();
            anulowanie = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // zatwierdzanie
            // 
            zatwierdzanie.Location = new Point(79, 305);
            zatwierdzanie.Name = "zatwierdzanie";
            zatwierdzanie.Size = new Size(153, 99);
            zatwierdzanie.TabIndex = 0;
            zatwierdzanie.Text = "Zatwierdź";
            zatwierdzanie.UseVisualStyleBackColor = true;
            zatwierdzanie.Click += zatwierdzanie_Click;
            // 
            // anulowanie
            // 
            anulowanie.Location = new Point(331, 305);
            anulowanie.Name = "anulowanie";
            anulowanie.Size = new Size(153, 99);
            anulowanie.TabIndex = 1;
            anulowanie.Text = "Anuluj";
            anulowanie.UseVisualStyleBackColor = true;
            anulowanie.Click += anulowanie_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 113);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Pieniądze";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 194);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "Wielkość zakładu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // BlackJackUstawienia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(anulowanie);
            Controls.Add(zatwierdzanie);
            Name = "BlackJackUstawienia";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button zatwierdzanie;
        private Button anulowanie;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}