namespace OkulEFAppProject
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            table = new DataGridView();
            lblAd = new Label();
            lblSoyad = new Label();
            lblNo = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "AD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 27);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "SOYAD:";
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.BackgroundColor = Color.Linen;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.GridColor = Color.DarkSlateGray;
            table.Location = new Point(12, 62);
            table.Name = "table";
            table.ReadOnly = true;
            table.Size = new Size(764, 360);
            table.TabIndex = 4;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblAd.ForeColor = Color.White;
            lblAd.Location = new Point(44, 12);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(21, 15);
            lblAd.TabIndex = 5;
            lblAd.Text = "ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblSoyad.ForeColor = Color.White;
            lblSoyad.Location = new Point(65, 27);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(41, 15);
            lblSoyad.TabIndex = 6;
            lblSoyad.Text = "soyad";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblNo.ForeColor = Color.White;
            lblNo.Location = new Point(99, 42);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(21, 15);
            lblNo.TabIndex = 7;
            lblNo.Text = "no";
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(269, 428);
            button1.Name = "button1";
            button1.Size = new Size(257, 28);
            button1.TabIndex = 8;
            button1.Text = "Seçili Dersleri Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += dersleriKaydet;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(796, 468);
            Controls.Add(button1);
            Controls.Add(lblNo);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(table);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView table;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblNo;
        private Button button1;
    }
}