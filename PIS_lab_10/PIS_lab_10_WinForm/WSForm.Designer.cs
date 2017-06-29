namespace PIS_lab_10_WinForm {
    partial class WSForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSessionValue = new System.Windows.Forms.TextBox();
            this.btnSessionGet = new System.Windows.Forms.Button();
            this.btnSessionSet = new System.Windows.Forms.Button();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.btnUpdateHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(54, 10);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(54, 36);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(54, 62);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(100, 20);
            this.textBoxRes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(97, 98);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(178, 98);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SessionValue";
            // 
            // textBoxSessionValue
            // 
            this.textBoxSessionValue.Location = new System.Drawing.Point(90, 150);
            this.textBoxSessionValue.Name = "textBoxSessionValue";
            this.textBoxSessionValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxSessionValue.TabIndex = 10;
            // 
            // btnSessionGet
            // 
            this.btnSessionGet.Location = new System.Drawing.Point(97, 176);
            this.btnSessionGet.Name = "btnSessionGet";
            this.btnSessionGet.Size = new System.Drawing.Size(75, 23);
            this.btnSessionGet.TabIndex = 12;
            this.btnSessionGet.Text = "Get";
            this.btnSessionGet.UseVisualStyleBackColor = true;
            this.btnSessionGet.Click += new System.EventHandler(this.btnSessionGet_Click);
            // 
            // btnSessionSet
            // 
            this.btnSessionSet.Location = new System.Drawing.Point(16, 176);
            this.btnSessionSet.Name = "btnSessionSet";
            this.btnSessionSet.Size = new System.Drawing.Size(75, 23);
            this.btnSessionSet.TabIndex = 11;
            this.btnSessionSet.Text = "Set";
            this.btnSessionSet.UseVisualStyleBackColor = true;
            this.btnSessionSet.Click += new System.EventHandler(this.btnSessionSet_Click);
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Location = new System.Drawing.Point(277, 10);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.Size = new System.Drawing.Size(239, 160);
            this.textBoxHistory.TabIndex = 13;
            // 
            // btnUpdateHistory
            // 
            this.btnUpdateHistory.Location = new System.Drawing.Point(277, 176);
            this.btnUpdateHistory.Name = "btnUpdateHistory";
            this.btnUpdateHistory.Size = new System.Drawing.Size(239, 23);
            this.btnUpdateHistory.TabIndex = 14;
            this.btnUpdateHistory.Text = "Update history";
            this.btnUpdateHistory.UseVisualStyleBackColor = true;
            this.btnUpdateHistory.Click += new System.EventHandler(this.btnUpdateHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 214);
            this.Controls.Add(this.btnUpdateHistory);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.btnSessionGet);
            this.Controls.Add(this.btnSessionSet);
            this.Controls.Add(this.textBoxSessionValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSessionValue;
        private System.Windows.Forms.Button btnSessionGet;
        private System.Windows.Forms.Button btnSessionSet;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Button btnUpdateHistory;
    }
}