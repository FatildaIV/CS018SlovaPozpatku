namespace CS018SlovaPozpatku
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.vstupTextBox = new System.Windows.Forms.TextBox();
            this.vystupTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vstupTextBox
            // 
            this.vstupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupTextBox.Location = new System.Drawing.Point(91, 46);
            this.vstupTextBox.Multiline = true;
            this.vstupTextBox.Name = "vstupTextBox";
            this.vstupTextBox.Size = new System.Drawing.Size(599, 142);
            this.vstupTextBox.TabIndex = 0;
            this.vstupTextBox.TextChanged += new System.EventHandler(this.vstupTextBox_TextChanged);
            // 
            // vystupTextBox
            // 
            this.vystupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vystupTextBox.Location = new System.Drawing.Point(91, 240);
            this.vystupTextBox.Multiline = true;
            this.vystupTextBox.Name = "vystupTextBox";
            this.vystupTextBox.Size = new System.Drawing.Size(599, 142);
            this.vystupTextBox.TabIndex = 1;
            this.vystupTextBox.TextChanged += new System.EventHandler(this.vystupTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vystupTextBox);
            this.Controls.Add(this.vstupTextBox);
            this.Name = "Form1";
            this.Text = "CS018 Slova pozpátku - Jaroslav Holaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vstupTextBox;
        private System.Windows.Forms.TextBox vystupTextBox;
    }
}

