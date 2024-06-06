namespace CoffeeMachine
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
            label1 = new Label();
            EmptyButton = new Button();
            EmptyProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 55F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 198);
            label1.TabIndex = 0;
            label1.Text = "Pojemnik na skropliny \r\n      ZAPEŁNIONY!!!";
            // 
            // EmptyButton
            // 
            EmptyButton.Font = new Font("Segoe UI", 30F);
            EmptyButton.Location = new Point(263, 210);
            EmptyButton.Name = "EmptyButton";
            EmptyButton.Size = new Size(253, 90);
            EmptyButton.TabIndex = 1;
            EmptyButton.Text = "OPRÓŻNIJ";
            EmptyButton.UseVisualStyleBackColor = true;
            EmptyButton.Click += EmptyButton_Click;
            // 
            // EmptyProgressBar
            // 
            EmptyProgressBar.Location = new Point(12, 329);
            EmptyProgressBar.Name = "EmptyProgressBar";
            EmptyProgressBar.Size = new Size(776, 86);
            EmptyProgressBar.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmptyProgressBar);
            Controls.Add(EmptyButton);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button EmptyButton;
        private ProgressBar EmptyProgressBar;
    }
}