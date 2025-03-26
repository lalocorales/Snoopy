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
            dgvPersonajes.Location = new Point(46, 38);
            dgvPersonajes.Margin = new Padding(4, 5, 4, 5);
            dgvPersonajes.Name = "dgvPersonajes";
            dgvPersonajes.RowHeadersWidth = 62;
            dgvPersonajes.Size = new Size(1284, 463);
            dgvPersonajes.TabIndex = 0;
            // 
            // cmbSnoopy
            // 
            cmbSnoopy.FormattingEnabled = true;
            cmbSnoopy.Location = new Point(1089, 598);
            cmbSnoopy.Margin = new Padding(4, 5, 4, 5);
            cmbSnoopy.Name = "cmbSnoopy";
            cmbSnoopy.Size = new Size(240, 33);
            cmbSnoopy.TabIndex = 1;
            cmbSnoopy.SelectedIndexChanged += cmbSnoopy_SelectedIndexChanged;
            // 
            // pictoreSnoopy
            // 
            pictoreSnoopy.Location = new Point(704, 533);
            pictoreSnoopy.Margin = new Padding(4, 5, 4, 5);
            pictoreSnoopy.Name = "pictoreSnoopy";
            pictoreSnoopy.Size = new Size(340, 375);
            pictoreSnoopy.SizeMode = PictureBoxSizeMode.StretchImage;
            pictoreSnoopy.TabIndex = 2;
            pictoreSnoopy.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1127, 568);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 3;
            label1.Text = "Selecciona Personaje:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 945);
            Controls.Add(label1);
            Controls.Add(pictoreSnoopy);
            Controls.Add(cmbSnoopy);
            Controls.Add(dgvPersonajes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Snoopy";
            Load += Form1_Load;
            Click += Form1_Click;
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
