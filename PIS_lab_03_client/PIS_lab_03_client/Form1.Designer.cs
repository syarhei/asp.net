namespace PIS_lab_03_client {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(12, 12);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 22);
            this.x.TabIndex = 0;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(12, 40);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(100, 22);
            this.y.TabIndex = 1;
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(12, 69);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(100, 23);
            this.SumButton.TabIndex = 2;
            this.SumButton.Text = "sum";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(13, 99);
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Size = new System.Drawing.Size(100, 22);
            this.sum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.TextBox sum;
    }
}

