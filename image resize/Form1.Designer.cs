namespace image_resize
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.property_inputdir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.property_outputdir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.property_check_filesizelimit = new System.Windows.Forms.CheckBox();
            this.property_check_aspect = new System.Windows.Forms.CheckBox();
            this.property_check_rotate = new System.Windows.Forms.CheckBox();
            this.property_height = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.property_filesizelimit = new System.Windows.Forms.NumericUpDown();
            this.property_width = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.colorcombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.property_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_filesizelimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_width)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "入力フォルダ";
            // 
            // property_inputdir
            // 
            this.property_inputdir.Location = new System.Drawing.Point(82, 6);
            this.property_inputdir.Name = "property_inputdir";
            this.property_inputdir.Size = new System.Drawing.Size(204, 19);
            this.property_inputdir.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(292, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(292, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "参照";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // property_outputdir
            // 
            this.property_outputdir.Location = new System.Drawing.Point(82, 31);
            this.property_outputdir.Name = "property_outputdir";
            this.property_outputdir.Size = new System.Drawing.Size(204, 19);
            this.property_outputdir.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "出力フォルダ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorcombo);
            this.groupBox1.Controls.Add(this.property_check_filesizelimit);
            this.groupBox1.Controls.Add(this.property_check_aspect);
            this.groupBox1.Controls.Add(this.property_check_rotate);
            this.groupBox1.Controls.Add(this.property_height);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.property_filesizelimit);
            this.groupBox1.Controls.Add(this.property_width);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "変換設定";
            // 
            // property_check_filesizelimit
            // 
            this.property_check_filesizelimit.AutoSize = true;
            this.property_check_filesizelimit.Location = new System.Drawing.Point(8, 42);
            this.property_check_filesizelimit.Name = "property_check_filesizelimit";
            this.property_check_filesizelimit.Size = new System.Drawing.Size(111, 16);
            this.property_check_filesizelimit.TabIndex = 7;
            this.property_check_filesizelimit.Text = "最大ファイルサイズ";
            this.property_check_filesizelimit.UseVisualStyleBackColor = true;
            // 
            // property_check_aspect
            // 
            this.property_check_aspect.AutoSize = true;
            this.property_check_aspect.Location = new System.Drawing.Point(8, 64);
            this.property_check_aspect.Name = "property_check_aspect";
            this.property_check_aspect.Size = new System.Drawing.Size(104, 16);
            this.property_check_aspect.TabIndex = 9;
            this.property_check_aspect.Text = "アスペクト比保持";
            this.property_check_aspect.UseVisualStyleBackColor = true;
            // 
            // property_check_rotate
            // 
            this.property_check_rotate.AutoSize = true;
            this.property_check_rotate.Location = new System.Drawing.Point(8, 86);
            this.property_check_rotate.Name = "property_check_rotate";
            this.property_check_rotate.Size = new System.Drawing.Size(72, 16);
            this.property_check_rotate.TabIndex = 10;
            this.property_check_rotate.Text = "自動回転";
            this.property_check_rotate.UseVisualStyleBackColor = true;
            // 
            // property_height
            // 
            this.property_height.Location = new System.Drawing.Point(243, 17);
            this.property_height.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.property_height.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.property_height.Name = "property_height";
            this.property_height.Size = new System.Drawing.Size(68, 19);
            this.property_height.TabIndex = 6;
            this.property_height.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.property_height.Enter += new System.EventHandler(this.property_height_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "高さ";
            // 
            // property_filesizelimit
            // 
            this.property_filesizelimit.Location = new System.Drawing.Point(217, 41);
            this.property_filesizelimit.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.property_filesizelimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.property_filesizelimit.Name = "property_filesizelimit";
            this.property_filesizelimit.Size = new System.Drawing.Size(68, 19);
            this.property_filesizelimit.TabIndex = 8;
            this.property_filesizelimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.property_filesizelimit.Enter += new System.EventHandler(this.property_filesizelimit_Enter);
            // 
            // property_width
            // 
            this.property_width.Location = new System.Drawing.Point(138, 17);
            this.property_width.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.property_width.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.property_width.Name = "property_width";
            this.property_width.Size = new System.Drawing.Size(68, 19);
            this.property_width.TabIndex = 5;
            this.property_width.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.property_width.Enter += new System.EventHandler(this.property_width_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "KB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "幅";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "サイズ指定";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 52);
            this.listBox1.TabIndex = 999;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "実行";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "背景色の指定";
            // 
            // colorcombo
            // 
            this.colorcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorcombo.FormattingEnabled = true;
            this.colorcombo.Location = new System.Drawing.Point(138, 107);
            this.colorcombo.Name = "colorcombo";
            this.colorcombo.Size = new System.Drawing.Size(173, 20);
            this.colorcombo.TabIndex = 11;
            this.colorcombo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.colorcombo_DrawItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 299);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.property_outputdir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.property_inputdir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "画像のリサイズ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.property_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_filesizelimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.property_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox property_inputdir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox property_outputdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox property_check_rotate;
        private System.Windows.Forms.NumericUpDown property_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown property_width;
        private System.Windows.Forms.CheckBox property_check_filesizelimit;
        private System.Windows.Forms.CheckBox property_check_aspect;
        private System.Windows.Forms.NumericUpDown property_filesizelimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox colorcombo;

    }
}

