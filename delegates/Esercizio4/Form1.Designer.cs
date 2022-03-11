
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(263, 153);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(135, 64);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMessaggio
            // 
            this.btnMessaggio.Location = new System.Drawing.Point(67, 153);
            this.btnMessaggio.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessaggio.Name = "btnMessaggio";
            this.btnMessaggio.Size = new System.Drawing.Size(145, 64);
            this.btnMessaggio.TabIndex = 1;
            this.btnMessaggio.Text = "Messaggio";
            this.btnMessaggio.UseVisualStyleBackColor = true;
            // 
            // btnEverything
            // 
            this.btnEverything.Location = new System.Drawing.Point(136, 330);
            this.btnEverything.Margin = new System.Windows.Forms.Padding(4);
            this.btnEverything.Name = "btnEverything";
            this.btnEverything.Size = new System.Drawing.Size(227, 66);
            this.btnEverything.TabIndex = 2;
            this.btnEverything.Text = "Media, Max, Ipotenusa";
            this.btnEverything.UseVisualStyleBackColor = true;
            this.btnEverything.Click += new System.EventHandler(this.btnEverything_Click);
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(548, 174);
            this.txtOne.Margin = new System.Windows.Forms.Padding(4);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(132, 22);
            this.txtOne.TabIndex = 3;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(783, 174);
            this.txtTwo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(132, 22);
            this.txtTwo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Num2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnEverything);
            this.Controls.Add(this.btnMessaggio);
            this.Controls.Add(this.btnMedia);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

