namespace WindowsFormsApplication1
{
    partial class Form
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
            this.HW1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Given_Number_1 = new System.Windows.Forms.TextBox();
            this.bSolutionHW1_1 = new System.Windows.Forms.Button();
            this.listBoxHW1_1 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxHW1_2 = new System.Windows.Forms.ListBox();
            this.bSolutionHW1_2 = new System.Windows.Forms.Button();
            this.Given_Number_2 = new System.Windows.Forms.TextBox();
            this.listBoxHW1_3 = new System.Windows.Forms.ListBox();
            this.bSolutionHW1_3 = new System.Windows.Forms.Button();
            this.Given_Number_3 = new System.Windows.Forms.TextBox();
            this.HW1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HW1
            // 
            this.HW1.Controls.Add(this.tabPage1);
            this.HW1.Controls.Add(this.tabPage2);
            this.HW1.Controls.Add(this.tabPage3);
            this.HW1.Location = new System.Drawing.Point(12, 12);
            this.HW1.Name = "HW1";
            this.HW1.SelectedIndex = 0;
            this.HW1.Size = new System.Drawing.Size(545, 366);
            this.HW1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxHW1_1);
            this.tabPage1.Controls.Add(this.bSolutionHW1_1);
            this.tabPage1.Controls.Add(this.Given_Number_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HW1_108";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxHW1_2);
            this.tabPage2.Controls.Add(this.bSolutionHW1_2);
            this.tabPage2.Controls.Add(this.Given_Number_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HW1_331a";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Given_Number_1
            // 
            this.Given_Number_1.Location = new System.Drawing.Point(6, 23);
            this.Given_Number_1.Name = "Given_Number_1";
            this.Given_Number_1.Size = new System.Drawing.Size(238, 20);
            this.Given_Number_1.TabIndex = 3;
            this.Given_Number_1.Text = "0";
            // 
            // bSolutionHW1_1
            // 
            this.bSolutionHW1_1.Location = new System.Drawing.Point(272, 21);
            this.bSolutionHW1_1.Name = "bSolutionHW1_1";
            this.bSolutionHW1_1.Size = new System.Drawing.Size(248, 23);
            this.bSolutionHW1_1.TabIndex = 4;
            this.bSolutionHW1_1.Text = "Find solution";
            this.bSolutionHW1_1.UseVisualStyleBackColor = true;
            this.bSolutionHW1_1.Click += new System.EventHandler(this.bSolutionHW1_1_Click);
            // 
            // listBoxHW1_1
            // 
            this.listBoxHW1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxHW1_1.FormattingEnabled = true;
            this.listBoxHW1_1.ItemHeight = 24;
            this.listBoxHW1_1.Location = new System.Drawing.Point(6, 60);
            this.listBoxHW1_1.Name = "listBoxHW1_1";
            this.listBoxHW1_1.Size = new System.Drawing.Size(525, 268);
            this.listBoxHW1_1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxHW1_3);
            this.tabPage3.Controls.Add(this.bSolutionHW1_3);
            this.tabPage3.Controls.Add(this.Given_Number_3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(537, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HW1_554";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxHW1_2
            // 
            this.listBoxHW1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxHW1_2.FormattingEnabled = true;
            this.listBoxHW1_2.ItemHeight = 24;
            this.listBoxHW1_2.Location = new System.Drawing.Point(6, 60);
            this.listBoxHW1_2.Name = "listBoxHW1_2";
            this.listBoxHW1_2.Size = new System.Drawing.Size(525, 268);
            this.listBoxHW1_2.TabIndex = 8;
            // 
            // bSolutionHW1_2
            // 
            this.bSolutionHW1_2.Location = new System.Drawing.Point(272, 21);
            this.bSolutionHW1_2.Name = "bSolutionHW1_2";
            this.bSolutionHW1_2.Size = new System.Drawing.Size(248, 23);
            this.bSolutionHW1_2.TabIndex = 7;
            this.bSolutionHW1_2.Text = "Find solution";
            this.bSolutionHW1_2.UseVisualStyleBackColor = true;
            this.bSolutionHW1_2.Click += new System.EventHandler(this.bSolutionHW1_2_Click);
            // 
            // Given_Number_2
            // 
            this.Given_Number_2.Location = new System.Drawing.Point(6, 23);
            this.Given_Number_2.Name = "Given_Number_2";
            this.Given_Number_2.Size = new System.Drawing.Size(238, 20);
            this.Given_Number_2.TabIndex = 6;
            this.Given_Number_2.Text = "0";
            // 
            // listBoxHW1_3
            // 
            this.listBoxHW1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxHW1_3.FormattingEnabled = true;
            this.listBoxHW1_3.ItemHeight = 24;
            this.listBoxHW1_3.Location = new System.Drawing.Point(6, 60);
            this.listBoxHW1_3.Name = "listBoxHW1_3";
            this.listBoxHW1_3.Size = new System.Drawing.Size(525, 268);
            this.listBoxHW1_3.TabIndex = 11;
            // 
            // bSolutionHW1_3
            // 
            this.bSolutionHW1_3.Location = new System.Drawing.Point(272, 21);
            this.bSolutionHW1_3.Name = "bSolutionHW1_3";
            this.bSolutionHW1_3.Size = new System.Drawing.Size(248, 23);
            this.bSolutionHW1_3.TabIndex = 10;
            this.bSolutionHW1_3.Text = "Find solution";
            this.bSolutionHW1_3.UseVisualStyleBackColor = true;
            this.bSolutionHW1_3.Click += new System.EventHandler(this.bSolutionHW1_3_Click);
            // 
            // Given_Number_3
            // 
            this.Given_Number_3.Location = new System.Drawing.Point(7, 23);
            this.Given_Number_3.Name = "Given_Number_3";
            this.Given_Number_3.Size = new System.Drawing.Size(238, 20);
            this.Given_Number_3.TabIndex = 9;
            this.Given_Number_3.Text = "0";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 390);
            this.Controls.Add(this.HW1);
            this.Name = "Form";
            this.Text = "HW1_108_331а_554";
            this.HW1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HW1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxHW1_1;
        private System.Windows.Forms.Button bSolutionHW1_1;
        private System.Windows.Forms.TextBox Given_Number_1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBoxHW1_2;
        private System.Windows.Forms.Button bSolutionHW1_2;
        private System.Windows.Forms.TextBox Given_Number_2;
        private System.Windows.Forms.ListBox listBoxHW1_3;
        private System.Windows.Forms.Button bSolutionHW1_3;
        private System.Windows.Forms.TextBox Given_Number_3;
    }
}

