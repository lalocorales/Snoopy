namespace Snoopy
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
            dgvPersonajes = new DataGridView();
            cmbSnoopy = new ComboBox();
            pictoreSnoopy = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictoreSnoopy).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonajes
            // 
            dgvPersonajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonajes.Location = new Point(32, 23);
            dgvPersonajes.Name = "dgvPersonajes";
            dgvPersonajes.Size = new Size(899, 278);
            dgvPersonajes.TabIndex = 0;
            // 
            // cmbSnoopy
            // 
            cmbSnoopy.FormattingEnabled = true;
            cmbSnoopy.Location = new Point(762, 359);
            cmbSnoopy.Name = "cmbSnoopy";
            cmbSnoopy.Size = new Size(169, 23);
            cmbSnoopy.TabIndex = 1;
            cmbSnoopy.SelectedIndexChanged += cmbSnoopy_SelectedIndexChanged;
            // 
            // pictoreSnoopy
            // 
            pictoreSnoopy.Location = new Point(493, 320);
            pictoreSnoopy.Name = "pictoreSnoopy";
            pictoreSnoopy.Size = new Size(238, 225);
            pictoreSnoopy.SizeMode = PictureBoxSizeMode.StretchImage;
            pictoreSnoopy.TabIndex = 2;
            pictoreSnoopy.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(789, 341);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Selecciona Personaje:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 567);
            Controls.Add(label1);
            Controls.Add(pictoreSnoopy);
            Controls.Add(cmbSnoopy);
            Controls.Add(dgvPersonajes);
            Name = "Form1";
            Text = "Snoopy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictoreSnoopy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonajes;
        private ComboBox cmbSnoopy;
        private PictureBox pictoreSnoopy;
        private Label label1;
    }
}
