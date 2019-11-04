namespace Donguler
{
    partial class Form3
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(13, 13);
            this.lst1.Name = "lst1";
            this.lst1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst1.Size = new System.Drawing.Size(120, 173);
            this.lst1.TabIndex = 0;
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(140, 13);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(115, 71);
            this.btnSag.TabIndex = 1;
            this.btnSag.Text = ">>>";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(140, 115);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(115, 71);
            this.btnSol.TabIndex = 1;
            this.btnSol.Text = "<<<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(261, 13);
            this.lst2.Name = "lst2";
            this.lst2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst2.Size = new System.Drawing.Size(120, 173);
            this.lst2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Label label1;
    }
}