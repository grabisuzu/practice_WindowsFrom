namespace WindowsFormsAppTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StageNumberLabel = new System.Windows.Forms.Label();
            this.ObjectTypeBox = new System.Windows.Forms.ComboBox();
            this.ObjectTypeLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "変更";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StageNumberLabel
            // 
            this.StageNumberLabel.AutoSize = true;
            this.StageNumberLabel.Location = new System.Drawing.Point(33, 29);
            this.StageNumberLabel.Name = "StageNumberLabel";
            this.StageNumberLabel.Size = new System.Drawing.Size(77, 12);
            this.StageNumberLabel.TabIndex = 4;
            this.StageNumberLabel.Text = "Stage Number";
            this.StageNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ObjectTypeBox
            // 
            this.ObjectTypeBox.FormattingEnabled = true;
            this.ObjectTypeBox.Items.AddRange(new object[] {
            "Enemy",
            "Ground"});
            this.ObjectTypeBox.Location = new System.Drawing.Point(170, 46);
            this.ObjectTypeBox.Name = "ObjectTypeBox";
            this.ObjectTypeBox.Size = new System.Drawing.Size(121, 20);
            this.ObjectTypeBox.TabIndex = 5;
            this.ObjectTypeBox.Text = "ObjectType";
            // 
            // ObjectTypeLabel
            // 
            this.ObjectTypeLabel.AutoSize = true;
            this.ObjectTypeLabel.Location = new System.Drawing.Point(168, 29);
            this.ObjectTypeLabel.Name = "ObjectTypeLabel";
            this.ObjectTypeLabel.Size = new System.Drawing.Size(63, 12);
            this.ObjectTypeLabel.TabIndex = 6;
            this.ObjectTypeLabel.Text = "ObjectType";
            this.ObjectTypeLabel.Click += new System.EventHandler(this.ObjectTypeLabel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.Size = new System.Drawing.Size(713, 287);
            this.dataGridView.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "削除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ObjectTypeLabel);
            this.Controls.Add(this.ObjectTypeBox);
            this.Controls.Add(this.StageNumberLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label StageNumberLabel;
        private System.Windows.Forms.ComboBox ObjectTypeBox;
        private System.Windows.Forms.Label ObjectTypeLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button2;
    }
}

