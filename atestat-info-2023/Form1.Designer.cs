
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
            this.textbox_marimeVector = new System.Windows.Forms.TextBox();
            this.textbox_valoriVector = new System.Windows.Forms.TextBox();
            this.label_marimeVector = new System.Windows.Forms.Label();
            this.label_valoriVector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_titlu
            // 
            this.label_titlu.AutoSize = true;
            this.label_titlu.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_titlu.Location = new System.Drawing.Point(266, 73);
            this.label_titlu.Name = "label_titlu";
            this.label_titlu.Size = new System.Drawing.Size(231, 26);
            this.label_titlu.TabIndex = 0;
            this.label_titlu.Text = "Algoritmi de sortare";
            // 
            // button_alegeMetoda
            // 
            this.button_alegeMetoda.Location = new System.Drawing.Point(334, 319);
            this.button_alegeMetoda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_alegeMetoda.Name = "button_alegeMetoda";
            this.button_alegeMetoda.Size = new System.Drawing.Size(108, 40);
            this.button_alegeMetoda.TabIndex = 1;
            this.button_alegeMetoda.Text = "Alege metoda de sortare";
            this.button_alegeMetoda.UseVisualStyleBackColor = true;
            this.button_alegeMetoda.Click += new System.EventHandler(this.button_alegeMetoda_Click);
            // 
            // textbox_marimeVector
            // 
            this.textbox_marimeVector.Location = new System.Drawing.Point(116, 170);
            this.textbox_marimeVector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_marimeVector.MaxLength = 2;
            this.textbox_marimeVector.Name = "textbox_marimeVector";
            this.textbox_marimeVector.Size = new System.Drawing.Size(50, 23);
            this.textbox_marimeVector.TabIndex = 2;
            this.textbox_marimeVector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_marimeVector_KeyPress);
            // 
            // textbox_valoriVector
            // 
            this.textbox_valoriVector.Location = new System.Drawing.Point(116, 247);
            this.textbox_valoriVector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_valoriVector.Name = "textbox_valoriVector";
            this.textbox_valoriVector.Size = new System.Drawing.Size(378, 23);
            this.textbox_valoriVector.TabIndex = 3;
            this.textbox_valoriVector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_valoriVector_KeyPress);
            // 
            // label_marimeVector
            // 
            this.label_marimeVector.AutoSize = true;
            this.label_marimeVector.Location = new System.Drawing.Point(563, 176);
            this.label_marimeVector.Name = "label_marimeVector";
            this.label_marimeVector.Size = new System.Drawing.Size(84, 15);
            this.label_marimeVector.TabIndex = 4;
            this.label_marimeVector.Text = "Marime Vector";
            // 
            // label_valoriVector
            // 
            this.label_valoriVector.AutoSize = true;
            this.label_valoriVector.Location = new System.Drawing.Point(563, 247);
            this.label_valoriVector.Name = "label_valoriVector";
            this.label_valoriVector.Size = new System.Drawing.Size(72, 15);
            this.label_valoriVector.TabIndex = 5;
            this.label_valoriVector.Text = "Valori Vector";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 415);
            this.Controls.Add(this.label_valoriVector);
            this.Controls.Add(this.label_marimeVector);
            this.Controls.Add(this.textbox_valoriVector);
            this.Controls.Add(this.textbox_marimeVector);
            this.Controls.Add(this.button_alegeMetoda);
            this.Controls.Add(this.label_titlu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atestat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titlu;
        private System.Windows.Forms.Button button_alegeMetoda;
        private System.Windows.Forms.TextBox textbox_marimeVector;
        private System.Windows.Forms.TextBox textbox_valoriVector;
        private System.Windows.Forms.Label label_marimeVector;
        private System.Windows.Forms.Label label_valoriVector;
    }
}

