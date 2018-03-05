namespace Praktikos_Darbas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKonf = new System.Windows.Forms.Button();
            this.buttonSkaiciavimas = new System.Windows.Forms.Button();
            this.textBoxIRank = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAntPop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(313, 202);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonKonf);
            this.tabPage1.Controls.Add(this.buttonSkaiciavimas);
            this.tabPage1.Controls.Add(this.textBoxIRank);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(305, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Atlyginimas į rankas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxAntPop);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(305, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Atlyginimas ant popieriaus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Atlyginimas į rankas";
            // 
            // buttonKonf
            // 
            this.buttonKonf.Location = new System.Drawing.Point(170, 113);
            this.buttonKonf.Name = "buttonKonf";
            this.buttonKonf.Size = new System.Drawing.Size(83, 23);
            this.buttonKonf.TabIndex = 6;
            this.buttonKonf.Text = "Konfiguracija";
            this.buttonKonf.UseVisualStyleBackColor = true;
            this.buttonKonf.Click += new System.EventHandler(this.buttonKonf_Click);
            // 
            // buttonSkaiciavimas
            // 
            this.buttonSkaiciavimas.Location = new System.Drawing.Point(38, 113);
            this.buttonSkaiciavimas.Name = "buttonSkaiciavimas";
            this.buttonSkaiciavimas.Size = new System.Drawing.Size(75, 23);
            this.buttonSkaiciavimas.TabIndex = 5;
            this.buttonSkaiciavimas.Text = "Skaičiuoti";
            this.buttonSkaiciavimas.UseVisualStyleBackColor = true;
            this.buttonSkaiciavimas.Click += new System.EventHandler(this.buttonSkaiciavimas_Click);
            // 
            // textBoxIRank
            // 
            this.textBoxIRank.Location = new System.Drawing.Point(170, 41);
            this.textBoxIRank.Name = "textBoxIRank";
            this.textBoxIRank.Size = new System.Drawing.Size(100, 20);
            this.textBoxIRank.TabIndex = 4;
            this.textBoxIRank.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Skaičiuoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAntPop
            // 
            this.textBoxAntPop.Location = new System.Drawing.Point(162, 41);
            this.textBoxAntPop.Name = "textBoxAntPop";
            this.textBoxAntPop.Size = new System.Drawing.Size(100, 20);
            this.textBoxAntPop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Atlyginimas ant popieriaus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 202);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Atlyginimo skaičiuoklė";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKonf;
        private System.Windows.Forms.Button buttonSkaiciavimas;
        private System.Windows.Forms.TextBox textBoxIRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAntPop;
        private System.Windows.Forms.Button button1;
    }
}

