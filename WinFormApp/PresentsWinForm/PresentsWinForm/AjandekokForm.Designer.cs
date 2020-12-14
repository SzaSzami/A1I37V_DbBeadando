namespace PresentsWinForm
{
    partial class AjandekokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjandekokForm));
            this.dgv_Presents = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_addpresent = new System.Windows.Forms.Button();
            this.btn_updatepresent = new System.Windows.Forms.Button();
            this.btn_deletepresent = new System.Windows.Forms.Button();
            this.txt_presentid = new System.Windows.Forms.TextBox();
            this.txt_presentname = new System.Windows.Forms.TextBox();
            this.txt_manuid = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Presents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Presents
            // 
            this.dgv_Presents.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_Presents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Presents.Location = new System.Drawing.Point(99, 95);
            this.dgv_Presents.Name = "dgv_Presents";
            this.dgv_Presents.Size = new System.Drawing.Size(1085, 367);
            this.dgv_Presents.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(564, 671);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1096, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 145);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btn_addpresent
            // 
            this.btn_addpresent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addpresent.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_addpresent.Location = new System.Drawing.Point(333, 624);
            this.btn_addpresent.Name = "btn_addpresent";
            this.btn_addpresent.Size = new System.Drawing.Size(165, 42);
            this.btn_addpresent.TabIndex = 5;
            this.btn_addpresent.Text = "Add present";
            this.btn_addpresent.UseVisualStyleBackColor = true;
            this.btn_addpresent.Click += new System.EventHandler(this.btn_addpresent_Click);
            // 
            // btn_updatepresent
            // 
            this.btn_updatepresent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updatepresent.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_updatepresent.Location = new System.Drawing.Point(556, 624);
            this.btn_updatepresent.Name = "btn_updatepresent";
            this.btn_updatepresent.Size = new System.Drawing.Size(165, 42);
            this.btn_updatepresent.TabIndex = 6;
            this.btn_updatepresent.Text = "Update present";
            this.btn_updatepresent.UseVisualStyleBackColor = true;
            this.btn_updatepresent.Click += new System.EventHandler(this.btn_updatepresent_Click);
            // 
            // btn_deletepresent
            // 
            this.btn_deletepresent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deletepresent.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_deletepresent.Location = new System.Drawing.Point(773, 624);
            this.btn_deletepresent.Name = "btn_deletepresent";
            this.btn_deletepresent.Size = new System.Drawing.Size(165, 42);
            this.btn_deletepresent.TabIndex = 7;
            this.btn_deletepresent.Text = "Delete present";
            this.btn_deletepresent.UseVisualStyleBackColor = true;
            this.btn_deletepresent.Click += new System.EventHandler(this.btn_deletepresent_Click);
            // 
            // txt_presentid
            // 
            this.txt_presentid.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_presentid.Location = new System.Drawing.Point(244, 468);
            this.txt_presentid.Name = "txt_presentid";
            this.txt_presentid.Size = new System.Drawing.Size(324, 31);
            this.txt_presentid.TabIndex = 8;
            // 
            // txt_presentname
            // 
            this.txt_presentname.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_presentname.Location = new System.Drawing.Point(244, 505);
            this.txt_presentname.Name = "txt_presentname";
            this.txt_presentname.Size = new System.Drawing.Size(324, 31);
            this.txt_presentname.TabIndex = 9;
            // 
            // txt_manuid
            // 
            this.txt_manuid.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manuid.Location = new System.Drawing.Point(244, 542);
            this.txt_manuid.Name = "txt_manuid";
            this.txt_manuid.Size = new System.Drawing.Size(324, 31);
            this.txt_manuid.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(747, 505);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(324, 31);
            this.txt_price.TabIndex = 11;
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(244, 579);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(324, 31);
            this.txt_color.TabIndex = 12;
            // 
            // txt_weight
            // 
            this.txt_weight.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.Location = new System.Drawing.Point(747, 542);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(324, 31);
            this.txt_weight.TabIndex = 13;
            // 
            // cmb_size
            // 
            this.cmb_size.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(747, 470);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(324, 30);
            this.cmb_size.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "PRESENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Present ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Manufacturer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(696, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(696, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(680, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Weight";
            // 
            // AjandekokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1279, 726);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Presents);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_manuid);
            this.Controls.Add(this.txt_presentname);
            this.Controls.Add(this.txt_presentid);
            this.Controls.Add(this.btn_deletepresent);
            this.Controls.Add(this.btn_updatepresent);
            this.Controls.Add(this.btn_addpresent);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AjandekokForm";
            this.Text = "AjandekokForm";
            this.Load += new System.EventHandler(this.AjandekokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Presents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Presents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_addpresent;
        private System.Windows.Forms.Button btn_updatepresent;
        private System.Windows.Forms.Button btn_deletepresent;
        private System.Windows.Forms.TextBox txt_presentid;
        private System.Windows.Forms.TextBox txt_presentname;
        private System.Windows.Forms.TextBox txt_manuid;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}