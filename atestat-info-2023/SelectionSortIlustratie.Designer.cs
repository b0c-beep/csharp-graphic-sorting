
namespace atestat_info_2023
{
    partial class SelectionSortIlustratie
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
            this.components = new System.ComponentModel.Container();
            this.timerSelectionSort = new System.Windows.Forms.Timer(this.components);
            this.buttonMeniu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelInterschimbari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerSelectionSort
            // 
            this.timerSelectionSort.Tick += new System.EventHandler(this.timerSelectionSort_Tick);
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.Location = new System.Drawing.Point(12, 303);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMeniu.Size = new System.Drawing.Size(100, 23);
            this.buttonMeniu.TabIndex = 0;
            this.buttonMeniu.Text = "Inapoi la meniu";
            this.buttonMeniu.UseVisualStyleBackColor = true;
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(128, 303);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Iesire";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelInterschimbari
            // 
            this.labelInterschimbari.AutoSize = true;
            this.labelInterschimbari.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInterschimbari.Location = new System.Drawing.Point(242, 311);
            this.labelInterschimbari.Name = "labelInterschimbari";
            this.labelInterschimbari.Size = new System.Drawing.Size(99, 13);
            this.labelInterschimbari.TabIndex = 2;
            this.labelInterschimbari.Text = "Interschimbari: ";
            // 
            // SelectionSortIlustratie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.labelInterschimbari);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMeniu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectionSortIlustratie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atestat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionSortIlustratie_FormClosing);
            this.Load += new System.EventHandler(this.SelectionSortIlustratie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSelectionSort;
        private System.Windows.Forms.Button buttonMeniu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelInterschimbari;
    }
}