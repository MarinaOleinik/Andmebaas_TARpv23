namespace Andmebaas_TARpv23
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nimetus_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.uuenda_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otsipilt_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Ladu_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimetus";
            // 
            // Nimetus_txt
            // 
            this.Nimetus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Nimetus_txt.Location = new System.Drawing.Point(148, 12);
            this.Nimetus_txt.Name = "Nimetus_txt";
            this.Nimetus_txt.Size = new System.Drawing.Size(121, 32);
            this.Nimetus_txt.TabIndex = 1;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kogus_txt.Location = new System.Drawing.Point(148, 61);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(121, 32);
            this.Kogus_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kogus";
            // 
            // Hind_txt
            // 
            this.Hind_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Hind_txt.Location = new System.Drawing.Point(148, 114);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(121, 32);
            this.Hind_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hind";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lisa_btn
            // 
            this.lisa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lisa_btn.Location = new System.Drawing.Point(36, 222);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(151, 38);
            this.lisa_btn.TabIndex = 7;
            this.lisa_btn.Text = "Lisa andmed";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // uuenda_btn
            // 
            this.uuenda_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.uuenda_btn.Location = new System.Drawing.Point(193, 222);
            this.uuenda_btn.Name = "uuenda_btn";
            this.uuenda_btn.Size = new System.Drawing.Size(151, 38);
            this.uuenda_btn.TabIndex = 8;
            this.uuenda_btn.Text = "Uuenda andmed";
            this.uuenda_btn.UseVisualStyleBackColor = true;
            this.uuenda_btn.Click += new System.EventHandler(this.uuenda_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(290, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 139);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // otsipilt_btn
            // 
            this.otsipilt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.otsipilt_btn.Location = new System.Drawing.Point(507, 222);
            this.otsipilt_btn.Name = "otsipilt_btn";
            this.otsipilt_btn.Size = new System.Drawing.Size(151, 38);
            this.otsipilt_btn.TabIndex = 10;
            this.otsipilt_btn.Text = "Pildi otsing";
            this.otsipilt_btn.UseVisualStyleBackColor = true;
            this.otsipilt_btn.Click += new System.EventHandler(this.otsipilt_btn_Click);
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kustuta_btn.Location = new System.Drawing.Point(350, 222);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(151, 38);
            this.kustuta_btn.TabIndex = 11;
            this.kustuta_btn.Text = "Kustuta andmed";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            this.kustuta_btn.Click += new System.EventHandler(this.kustuta_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(40, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ladu";
            // 
            // Ladu_cb
            // 
            this.Ladu_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Ladu_cb.FormattingEnabled = true;
            this.Ladu_cb.Location = new System.Drawing.Point(148, 160);
            this.Ladu_cb.Name = "Ladu_cb";
            this.Ladu_cb.Size = new System.Drawing.Size(121, 33);
            this.Ladu_cb.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ladu_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.otsipilt_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uuenda_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nimetus_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ladu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nimetus_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.Button uuenda_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button otsipilt_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Ladu_cb;
    }
}

