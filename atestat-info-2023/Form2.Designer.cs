
namespace atestat_info_2023
{
    partial class Form2
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
            this.label_titlu = new System.Windows.Forms.Label();
            this.button_selectionSort = new System.Windows.Forms.Button();
            this.button_bubbleSort = new System.Windows.Forms.Button();
            this.button_quickSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titlu
            // 
            this.label_titlu.AutoSize = true;
            this.label_titlu.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_titlu.Location = new System.Drawing.Point(296, 64);
            this.label_titlu.Name = "label_titlu";
            this.label_titlu.Size = new System.Drawing.Size(313, 28);
            this.label_titlu.TabIndex = 0;
            this.label_titlu.Text = "Alegeti metoda de sortare";
            // 
            // button_selectionSort
            // 
            this.button_selectionSort.Location = new System.Drawing.Point(380, 215);
            this.button_selectionSort.Name = "button_selectionSort";
            this.button_selectionSort.Size = new System.Drawing.Size(140, 29);
            this.button_selectionSort.TabIndex = 1;
            this.button_selectionSort.Text = "Selection Sort";
            this.button_selectionSort.UseVisualStyleBackColor = true;
            this.button_selectionSort.Click += new System.EventHandler(this.button_selectionSort_Click);
            // 
            // button_bubbleSort
            // 
            this.button_bubbleSort.Location = new System.Drawing.Point(380, 300);
            this.button_bubbleSort.Name = "button_bubbleSort";
            this.button_bubbleSort.Size = new System.Drawing.Size(137, 29);
            this.button_bubbleSort.TabIndex = 2;
            this.button_bubbleSort.Text = "Bubble Sort";
            this.button_bubbleSort.UseVisualStyleBackColor = true;
            this.button_bubbleSort.Click += new System.EventHandler(this.button_bubbleSort_Click);
            // 
            // button_quickSort
            // 
            this.button_quickSort.Location = new System.Drawing.Point(380, 393);
            this.button_quickSort.Name = "button_quickSort";
            this.button_quickSort.Size = new System.Drawing.Size(137, 29);
            this.button_quickSort.TabIndex = 3;
            this.button_quickSort.Text = "Quick Sort";
            this.button_quickSort.UseVisualStyleBackColor = true;
            this.button_quickSort.Click += new System.EventHandler(this.button_quickSort_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button_quickSort);
            this.Controls.Add(this.button_bubbleSort);
            this.Controls.Add(this.button_selectionSort);
            this.Controls.Add(this.label_titlu);
            this.Name = "Form2";
            this.Text = "Atestat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titlu;
        private System.Windows.Forms.Button button_selectionSort;
        private System.Windows.Forms.Button button_bubbleSort;
        private System.Windows.Forms.Button button_quickSort;
    }
}