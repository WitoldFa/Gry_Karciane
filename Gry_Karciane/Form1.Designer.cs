namespace Gry_Karciane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Wojna = new Button();
            Memory = new Button();
            Blackjack = new Button();
            Historia = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Wojna
            // 
            Wojna.Location = new Point(166, 61);
            Wojna.Name = "Wojna";
            Wojna.Size = new Size(94, 29);
            Wojna.TabIndex = 0;
            Wojna.Text = "Wojna";
            Wojna.UseVisualStyleBackColor = true;
            Wojna.Click += Wojna_Click;
            // 
            // Memory
            // 
            Memory.Location = new Point(166, 96);
            Memory.Name = "Memory";
            Memory.Size = new Size(94, 29);
            Memory.TabIndex = 1;
            Memory.Text = "Memory";
            Memory.UseVisualStyleBackColor = true;
            Memory.Click += Memory_Click;
            // 
            // Blackjack
            // 
            Blackjack.Location = new Point(166, 131);
            Blackjack.Name = "Blackjack";
            Blackjack.Size = new Size(94, 29);
            Blackjack.TabIndex = 2;
            Blackjack.Text = "Blackjack";
            Blackjack.UseVisualStyleBackColor = true;
            Blackjack.Click += Blackjack_Click;
            // 
            // Historia
            // 
            Historia.Location = new Point(166, 166);
            Historia.Name = "Historia";
            Historia.Size = new Size(94, 29);
            Historia.TabIndex = 3;
            Historia.Text = "Historia";
            Historia.UseVisualStyleBackColor = true;
            Historia.Click += Historia_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(166, 201);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Historia);
            Controls.Add(Blackjack);
            Controls.Add(Memory);
            Controls.Add(Wojna);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Wojna;
        private Button Memory;
        private Button Blackjack;
        private Button Historia;
        private Button Exit;
    }
}
