
namespace atestat_info_2023
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
            this.label_titlu = new System.Windows.Forms.Label();
            this.button_alegeMetoda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titlu
            // 
            this.label_titlu.AutoSize = true;
            this.label_titlu.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_titlu.Location = new System.Drawing.Point(304, 97);
            this.label_titlu.Name = "label_titlu";
            this.label_titlu.Size = new System.Drawing.Size(300, 34);
            this.label_titlu.TabIndex = 0;
            this.label_titlu.Text = "Algoritmi de sortare";
            // 
            // button_alegeMetoda
            // 
            this.button_alegeMetoda.Location = new System.Drawing.Point(382, 425);
            this.button_alegeMetoda.Name = "button_alegeMetoda";
            this.button_alegeMetoda.Size = new System.Drawing.Size(124, 53);
            this.button_alegeMetoda.TabIndex = 1;
            this.button_alegeMetoda.Text = "Alege metoda de sortare";
            this.button_alegeMetoda.UseVisualStyleBackColor = true;
            this.button_alegeMetoda.Click += new System.EventHandler(this.button_alegeMetoda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button_alegeMetoda);
            this.Controls.Add(this.label_titlu);
            this.Name = "Form1";
            this.Text = "Atestat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titlu;
        private System.Windows.Forms.Button button_alegeMetoda;
    }
}

