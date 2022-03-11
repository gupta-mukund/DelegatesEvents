
namespace Esercizio
{
    partial class Form1
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
            this.lsbFull = new System.Windows.Forms.ListBox();
            this.lsbAC = new System.Windows.Forms.ListBox();
            this.lsb14Char = new System.Windows.Forms.ListBox();
            this.lsb16Char = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbFull
            // 
            this.lsbFull.FormattingEnabled = true;
            this.lsbFull.ItemHeight = 16;
            this.lsbFull.Location = new System.Drawing.Point(42, 27);
            this.lsbFull.Name = "lsbFull";
            this.lsbFull.Size = new System.Drawing.Size(250, 180);
            this.lsbFull.TabIndex = 0;
            // 
            // lsbAC
            // 
            this.lsbAC.FormattingEnabled = true;
            this.lsbAC.ItemHeight = 16;
            this.lsbAC.Location = new System.Drawing.Point(333, 27);
            this.lsbAC.Name = "lsbAC";
            this.lsbAC.Size = new System.Drawing.Size(233, 180);
            this.lsbAC.TabIndex = 1;
            // 
            // lsb14Char
            // 
            this.lsb14Char.FormattingEnabled = true;
            this.lsb14Char.ItemHeight = 16;
            this.lsb14Char.Location = new System.Drawing.Point(42, 226);
            this.lsb14Char.Name = "lsb14Char";
            this.lsb14Char.Size = new System.Drawing.Size(238, 212);
            this.lsb14Char.TabIndex = 2;
            // 
            // lsb16Char
            // 
            this.lsb16Char.FormattingEnabled = true;
            this.lsb16Char.ItemHeight = 16;
            this.lsb16Char.Location = new System.Drawing.Point(333, 226);
            this.lsb16Char.Name = "lsb16Char";
            this.lsb16Char.Size = new System.Drawing.Size(233, 212);
            this.lsb16Char.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.lsb16Char);
            this.Controls.Add(this.lsb14Char);
            this.Controls.Add(this.lsbAC);
            this.Controls.Add(this.lsbFull);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFull;
        private System.Windows.Forms.ListBox lsbAC;
        private System.Windows.Forms.ListBox lsb14Char;
        private System.Windows.Forms.ListBox lsb16Char;
    }
}

