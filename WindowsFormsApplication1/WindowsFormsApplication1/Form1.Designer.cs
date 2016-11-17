namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox11111 = new System.Windows.Forms.TextBox();
            this.textBox22222 = new System.Windows.Forms.TextBox();
            this.button1111 = new System.Windows.Forms.Button();
            this.label1122 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 249);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1122);
            this.tabPage1.Controls.Add(this.button1111);
            this.tabPage1.Controls.Add(this.textBox22222);
            this.tabPage1.Controls.Add(this.textBox11111);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox11111
            // 
            this.textBox11111.Location = new System.Drawing.Point(63, 83);
            this.textBox11111.Name = "textBox11111";
            this.textBox11111.Size = new System.Drawing.Size(100, 20);
            this.textBox11111.TabIndex = 0;
            // 
            // textBox22222
            // 
            this.textBox22222.Location = new System.Drawing.Point(316, 83);
            this.textBox22222.Name = "textBox22222";
            this.textBox22222.Size = new System.Drawing.Size(100, 20);
            this.textBox22222.TabIndex = 1;
            // 
            // button1111
            // 
            this.button1111.Location = new System.Drawing.Point(501, 194);
            this.button1111.Name = "button1111";
            this.button1111.Size = new System.Drawing.Size(203, 23);
            this.button1111.TabIndex = 2;
            this.button1111.Text = "Убрать КАПС";
            this.button1111.UseVisualStyleBackColor = true;
            this.button1111.Click += new System.EventHandler(this.button1111_Click);
            // 
            // label1122
            // 
            this.label1122.AutoSize = true;
            this.label1122.Location = new System.Drawing.Point(60, 52);
            this.label1122.Name = "label1122";
            this.label1122.Size = new System.Drawing.Size(98, 13);
            this.label1122.TabIndex = 3;
            this.label1122.Text = "Вводить КАПСОМ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 273);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1122;
        private System.Windows.Forms.Button button1111;
        private System.Windows.Forms.TextBox textBox22222;
        private System.Windows.Forms.TextBox textBox11111;
    }
}

