namespace BarcodeApp
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
            picBarcode = new PictureBox();
            btnGenerate = new Button();
            lblBarcode = new Label();
            txtboxBarcode = new TextBox();
            btnSave = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)picBarcode).BeginInit();
            SuspendLayout();
            // 
            // picBarcode
            // 
            picBarcode.BackColor = SystemColors.Window;
            picBarcode.Location = new Point(12, 12);
            picBarcode.Name = "picBarcode";
            picBarcode.Size = new Size(776, 274);
            picBarcode.TabIndex = 0;
            picBarcode.TabStop = false;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(632, 321);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Oluştur";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(13, 300);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(104, 15);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "Barkod Numarası :";
            // 
            // txtboxBarcode
            // 
            txtboxBarcode.Location = new Point(122, 292);
            txtboxBarcode.Name = "txtboxBarcode";
            txtboxBarcode.Size = new Size(666, 23);
            txtboxBarcode.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(713, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(522, 321);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(104, 23);
            btnImport.TabIndex = 5;
            btnImport.Text = "Barkod Yükle";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(btnImport);
            Controls.Add(btnSave);
            Controls.Add(txtboxBarcode);
            Controls.Add(lblBarcode);
            Controls.Add(btnGenerate);
            Controls.Add(picBarcode);
            Name = "Form1";
            Text = "Barcode App";
            ((System.ComponentModel.ISupportInitialize)picBarcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBarcode;
        private Button btnGenerate;
        private Label lblBarcode;
        private TextBox txtboxBarcode;
        private Button btnSave;
        private Button btnImport;
    }
}
