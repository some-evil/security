namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encodeBt = new System.Windows.Forms.Button();
            this.decodeBt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encodeTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBt = new System.Windows.Forms.Button();
            this.loadTextBt = new System.Windows.Forms.Button();
            this.statusLb = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loadEncodeText = new System.Windows.Forms.Button();
            this.setKeyBt = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encodeBt
            // 
            this.encodeBt.Location = new System.Drawing.Point(13, 12);
            this.encodeBt.Name = "encodeBt";
            this.encodeBt.Size = new System.Drawing.Size(75, 23);
            this.encodeBt.TabIndex = 0;
            this.encodeBt.Text = "Encode";
            this.encodeBt.UseVisualStyleBackColor = true;
            this.encodeBt.Click += new System.EventHandler(this.encode_Click);
            // 
            // decodeBt
            // 
            this.decodeBt.Location = new System.Drawing.Point(175, 12);
            this.decodeBt.Name = "decodeBt";
            this.decodeBt.Size = new System.Drawing.Size(75, 23);
            this.decodeBt.TabIndex = 1;
            this.decodeBt.Text = "Decode";
            this.decodeBt.UseVisualStyleBackColor = true;
            this.decodeBt.Click += new System.EventHandler(this.decode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 111);
            this.textBox1.TabIndex = 2;
            // 
            // encodeTextBox2
            // 
            this.encodeTextBox2.Location = new System.Drawing.Point(221, 64);
            this.encodeTextBox2.Multiline = true;
            this.encodeTextBox2.Name = "encodeTextBox2";
            this.encodeTextBox2.Size = new System.Drawing.Size(202, 111);
            this.encodeTextBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encode text";
            // 
            // clearBt
            // 
            this.clearBt.Location = new System.Drawing.Point(94, 12);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(75, 23);
            this.clearBt.TabIndex = 6;
            this.clearBt.Text = "Clear";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clear_click);
            // 
            // loadTextBt
            // 
            this.loadTextBt.Location = new System.Drawing.Point(12, 181);
            this.loadTextBt.Name = "loadTextBt";
            this.loadTextBt.Size = new System.Drawing.Size(76, 23);
            this.loadTextBt.TabIndex = 7;
            this.loadTextBt.Text = "Load text";
            this.loadTextBt.UseVisualStyleBackColor = true;
            this.loadTextBt.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Location = new System.Drawing.Point(347, 226);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(16, 13);
            this.statusLb.TabIndex = 8;
            this.statusLb.Text = " 1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 225);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "ShowKey";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loadEncodeText
            // 
            this.loadEncodeText.Location = new System.Drawing.Point(221, 181);
            this.loadEncodeText.Name = "loadEncodeText";
            this.loadEncodeText.Size = new System.Drawing.Size(103, 23);
            this.loadEncodeText.TabIndex = 10;
            this.loadEncodeText.Text = "Load encode text";
            this.loadEncodeText.UseVisualStyleBackColor = true;
            this.loadEncodeText.Click += new System.EventHandler(this.loadEncodeFile_Click);
            // 
            // setKeyBt
            // 
            this.setKeyBt.Location = new System.Drawing.Point(293, 221);
            this.setKeyBt.Name = "setKeyBt";
            this.setKeyBt.Size = new System.Drawing.Size(48, 23);
            this.setKeyBt.TabIndex = 12;
            this.setKeyBt.Text = "Set";
            this.setKeyBt.UseVisualStyleBackColor = true;
            this.setKeyBt.Visible = false;
            this.setKeyBt.Click += new System.EventHandler(this.setKeyBt_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(84, 223);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(202, 20);
            this.keyBox.TabIndex = 13;
            this.keyBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 260);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.setKeyBt);
            this.Controls.Add(this.loadEncodeText);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.loadTextBt);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encodeTextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.decodeBt);
            this.Controls.Add(this.encodeBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enigma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encodeBt;
        private System.Windows.Forms.Button decodeBt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox encodeTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Button loadTextBt;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loadEncodeText;
        private System.Windows.Forms.Button setKeyBt;
        private System.Windows.Forms.TextBox keyBox;
    }
}

