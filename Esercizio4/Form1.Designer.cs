
namespace Esercizio4
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
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMessaggio = new System.Windows.Forms.Button();
            this.btnEverything = new System.Windows.Forms.Button();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(197, 124);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(101, 52);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            // 
            // btnMessaggio
            // 
            this.btnMessaggio.Location = new System.Drawing.Point(50, 124);
            this.btnMessaggio.Name = "btnMessaggio";
            this.btnMessaggio.Size = new System.Drawing.Size(109, 52);
            this.btnMessaggio.TabIndex = 1;
            this.btnMessaggio.Text = "Messaggio";
            this.btnMessaggio.UseVisualStyleBackColor = true;
            // 
            // btnEverything
            // 
            this.btnEverything.Location = new System.Drawing.Point(102, 268);
            this.btnEverything.Name = "btnEverything";
            this.btnEverything.Size = new System.Drawing.Size(170, 54);
            this.btnEverything.TabIndex = 2;
            this.btnEverything.Text = "Media, Max, Ipotenusa";
            this.btnEverything.UseVisualStyleBackColor = true;
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(411, 141);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 3;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(587, 141);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnEverything);
            this.Controls.Add(this.btnMessaggio);
            this.Controls.Add(this.btnMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMessaggio;
        private System.Windows.Forms.Button btnEverything;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
    }
}

