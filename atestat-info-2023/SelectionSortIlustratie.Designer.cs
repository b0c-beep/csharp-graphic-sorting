﻿
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
            this.SuspendLayout();
            // 
            // timerSelectionSort
            // 
            this.timerSelectionSort.Tick += new System.EventHandler(this.timerSelectionSort_Tick);
            // 
            // SelectionSortIlustratie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectionSortIlustratie";
            this.Text = "Atestat";
            this.Load += new System.EventHandler(this.SelectionSortIlustratie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSelectionSort;
    }
}