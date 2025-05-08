namespace Gry_Karciane
{
    partial class BlackJack
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
            stand = new Button();
            ustawienia = new Button();
            hit = new Button();
            start = new Button();
            graczKartyLabel = new Label();
            graczPunktyLabel = new Label();
            krupierPunktyLabel = new Label();
            krupierKartyLabel = new Label();
            SuspendLayout();
            // 
            // stand
            // 
            stand.Location = new Point(148, 270);
            stand.Name = "stand";
            stand.Size = new Size(94, 96);
            stand.TabIndex = 0;
            stand.Text = "Stand";
            stand.UseVisualStyleBackColor = true;
            stand.Click += this.Stand_Click;
            // 
            // ustawienia
            // 
            ustawienia.Location = new Point(148, 402);
            ustawienia.Name = "ustawienia";
            ustawienia.Size = new Size(94, 96);
            ustawienia.TabIndex = 1;
            ustawienia.Text = "Ustawienia";
            ustawienia.UseVisualStyleBackColor = true;
            ustawienia.Click += this.ustawienia_przycisk_Click;
            // 
            // hit
            // 
            hit.Location = new Point(396, 270);
            hit.Name = "hit";
            hit.Size = new Size(94, 96);
            hit.TabIndex = 2;
            hit.Text = "Hit!";
            hit.UseVisualStyleBackColor = true;
            hit.Click += this.Hit_Click;
            // 
            // start
            // 
            start.Location = new Point(396, 402);
            start.Name = "start";
            start.Size = new Size(94, 96);
            start.TabIndex = 3;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += this.start_Click;
            // 
            // graczKartyLabel
            // 
            graczKartyLabel.AutoSize = true;
            graczKartyLabel.Location = new Point(192, 195);
            graczKartyLabel.Name = "graczKartyLabel";
            graczKartyLabel.Size = new Size(0, 20);
            graczKartyLabel.TabIndex = 4;
            // 
            // graczPunktyLabel
            // 
            graczPunktyLabel.AutoSize = true;
            graczPunktyLabel.Location = new Point(192, 101);
            graczPunktyLabel.Name = "graczPunktyLabel";
            graczPunktyLabel.Size = new Size(0, 20);
            graczPunktyLabel.TabIndex = 5;
            // 
            // krupierPunktyLabel
            // 
            krupierPunktyLabel.AutoSize = true;
            krupierPunktyLabel.Location = new Point(396, 101);
            krupierPunktyLabel.Name = "krupierPunktyLabel";
            krupierPunktyLabel.Size = new Size(0, 20);
            krupierPunktyLabel.TabIndex = 6;
            // 
            // krupierKartyLabel
            // 
            krupierKartyLabel.AutoSize = true;
            krupierKartyLabel.Location = new Point(396, 217);
            krupierKartyLabel.Name = "krupierKartyLabel";
            krupierKartyLabel.Size = new Size(0, 20);
            krupierKartyLabel.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 536);
            Controls.Add(krupierKartyLabel);
            Controls.Add(krupierPunktyLabel);
            Controls.Add(graczPunktyLabel);
            Controls.Add(graczKartyLabel);
            Controls.Add(start);
            Controls.Add(hit);
            Controls.Add(ustawienia);
            Controls.Add(stand);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stand;
        private Button ustawienia;
        private Button hit;
        private Button start;
        private Label graczKartyLabel;
        private Label graczPunktyLabel;
        private Label krupierPunktyLabel;
        private Label krupierKartyLabel;
    }
}