namespace LabWork_1_OOP
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
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_Corporation = new System.Windows.Forms.TextBox();
            this.textBox_Product_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Country = new System.Windows.Forms.Button();
            this.btn_Corporation = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.numericUpDown_Count = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(70, 11);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(100, 20);
            this.textBox_Country.TabIndex = 0;
            // 
            // textBox_Corporation
            // 
            this.textBox_Corporation.Location = new System.Drawing.Point(70, 38);
            this.textBox_Corporation.Name = "textBox_Corporation";
            this.textBox_Corporation.Size = new System.Drawing.Size(100, 20);
            this.textBox_Corporation.TabIndex = 1;
            // 
            // textBox_Product_Name
            // 
            this.textBox_Product_Name.Location = new System.Drawing.Point(70, 64);
            this.textBox_Product_Name.Name = "textBox_Product_Name";
            this.textBox_Product_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Product_Name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Название:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кол-во:";
            // 
            // btn_Country
            // 
            this.btn_Country.Location = new System.Drawing.Point(185, 9);
            this.btn_Country.Name = "btn_Country";
            this.btn_Country.Size = new System.Drawing.Size(131, 23);
            this.btn_Country.TabIndex = 10;
            this.btn_Country.Text = "Создать страну";
            this.btn_Country.UseVisualStyleBackColor = true;
            this.btn_Country.Click += new System.EventHandler(this.btn_Country_Click);
            // 
            // btn_Corporation
            // 
            this.btn_Corporation.Location = new System.Drawing.Point(186, 34);
            this.btn_Corporation.Name = "btn_Corporation";
            this.btn_Corporation.Size = new System.Drawing.Size(130, 23);
            this.btn_Corporation.TabIndex = 11;
            this.btn_Corporation.Text = "Создать корпорацию";
            this.btn_Corporation.UseVisualStyleBackColor = true;
            this.btn_Corporation.Click += new System.EventHandler(this.btn_Corporation_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.Location = new System.Drawing.Point(185, 61);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(130, 23);
            this.btn_Product.TabIndex = 12;
            this.btn_Product.Text = "Создать продукт";
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // numericUpDown_Count
            // 
            this.numericUpDown_Count.Location = new System.Drawing.Point(89, 116);
            this.numericUpDown_Count.Name = "numericUpDown_Count";
            this.numericUpDown_Count.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Count.TabIndex = 14;
            this.numericUpDown_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.Location = new System.Drawing.Point(89, 91);
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Price.TabIndex = 15;
            this.numericUpDown_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 161);
            this.Controls.Add(this.numericUpDown_Price);
            this.Controls.Add(this.numericUpDown_Count);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Corporation);
            this.Controls.Add(this.btn_Country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Product_Name);
            this.Controls.Add(this.textBox_Corporation);
            this.Controls.Add(this.textBox_Country);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.TextBox textBox_Corporation;
        private System.Windows.Forms.TextBox textBox_Product_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Country;
        private System.Windows.Forms.Button btn_Corporation;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.NumericUpDown numericUpDown_Count;
        private System.Windows.Forms.NumericUpDown numericUpDown_Price;
    }
}

