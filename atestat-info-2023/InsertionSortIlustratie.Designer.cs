
namespace atestat_info_2023
{
    partial class InsertionSortIlustratie
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
            this.labelInterschimbari = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMeniu = new System.Windows.Forms.Button();
            this.timerQuickSort = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelInterschimbari
            // 
            this.labelInterschimbari.AutoSize = true;
            this.labelInterschimbari.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInterschimbari.Location = new System.Drawing.Point(267, 12);
            this.labelInterschimbari.Name = "labelInterschimbari";
            this.labelInterschimbari.Size = new System.Drawing.Size(99, 13);
            this.labelInterschimbari.TabIndex = 5;
            this.labelInterschimbari.Text = "Interschimbari: ";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(139, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Iesire";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.Location = new System.Drawing.Point(23, 12);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.Size = new System.Drawing.Size(110, 23);
            this.buttonMeniu.TabIndex = 3;
            this.buttonMeniu.Text = "Inapoi la meniu";
            this.buttonMeniu.UseVisualStyleBackColor = true;
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // timerQuickSort
            // 
            this.timerQuickSort.Tick += new System.EventHandler(this.timerQuickSort_Tick);
            // 
            // QuickSortIlustratie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInterschimbari);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMeniu);
            this.Name = "QuickSortIlustratie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atestat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickSortIlustratie_FormClosing);
            this.Load += new System.EventHandler(this.QuickSortIlustratie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInterschimbari;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMeniu;
        private System.Windows.Forms.Timer timerQuickSort;
    }
}