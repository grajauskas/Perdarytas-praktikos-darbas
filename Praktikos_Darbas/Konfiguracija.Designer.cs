namespace Praktikos_Darbas
{
    partial class Konfiguracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGerai = new System.Windows.Forms.Button();
            this.buttonAtsaukt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aut. teisiu mok.";
            // 
            // buttonGerai
            // 
            this.buttonGerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGerai.Location = new System.Drawing.Point(24, 113);
            this.buttonGerai.Name = "buttonGerai";
            this.buttonGerai.Size = new System.Drawing.Size(75, 23);
            this.buttonGerai.TabIndex = 1;
            this.buttonGerai.Text = "Gerai";
            this.buttonGerai.UseVisualStyleBackColor = true;
            this.buttonGerai.Click += new System.EventHandler(this.buttonGerai_Click);
            // 
            // buttonAtsaukt
            // 
            this.buttonAtsaukt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAtsaukt.Location = new System.Drawing.Point(129, 113);
            this.buttonAtsaukt.Name = "buttonAtsaukt";
            this.buttonAtsaukt.Size = new System.Drawing.Size(75, 23);
            this.buttonAtsaukt.TabIndex = 2;
            this.buttonAtsaukt.Text = "Atšaukt";
            this.buttonAtsaukt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Konfiguracija
            // 
            this.AcceptButton = this.buttonGerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAtsaukt;
            this.ClientSize = new System.Drawing.Size(233, 182);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAtsaukt);
            this.Controls.Add(this.buttonGerai);
            this.Controls.Add(this.label1);
            this.Name = "Konfiguracija";
            this.Text = "Konfiguracija";
            this.Load += new System.EventHandler(this.Konfiguracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGerai;
        private System.Windows.Forms.Button buttonAtsaukt;
        private System.Windows.Forms.TextBox textBox1;
    }
}