
namespace atestat_info_2023
{
    partial class SelectionSortInfo
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
            this.picturebox_info = new System.Windows.Forms.PictureBox();
            this.button_ilustratie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_info)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_info
            // 
            this.picturebox_info.Image = global::atestat_info_2023.Properties.Resources.SelectSortInfo;
            this.picturebox_info.Location = new System.Drawing.Point(10, 28);
            this.picturebox_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebox_info.Name = "picturebox_info";
            this.picturebox_info.Size = new System.Drawing.Size(751, 309);
            this.picturebox_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_info.TabIndex = 0;
            this.picturebox_info.TabStop = false;
            // 
            // button_ilustratie
            // 
            this.button_ilustratie.Location = new System.Drawing.Point(350, 364);
            this.button_ilustratie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ilustratie.Name = "button_ilustratie";
            this.button_ilustratie.Size = new System.Drawing.Size(82, 22);
            this.button_ilustratie.TabIndex = 1;
            this.button_ilustratie.Text = "Ilustratie";
            this.button_ilustratie.UseVisualStyleBackColor = true;
            this.button_ilustratie.Click += new System.EventHandler(this.button_ilustratie_Click);
            // 
            // SelectionSortInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 415);
            this.Controls.Add(this.button_ilustratie);
            this.Controls.Add(this.picturebox_info);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectionSortInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atestat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionSortInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_info;
        private System.Windows.Forms.Button button_ilustratie;
    }
}