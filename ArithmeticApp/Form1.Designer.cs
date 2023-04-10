namespace ArithmeticApp
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
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.lbl_res = new System.Windows.Forms.Label();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.btn_5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(114, 123);
            this.lbl_num1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(119, 20);
            this.lbl_num1.TabIndex = 0;
            this.lbl_num1.Text = "Input Number 1";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(114, 180);
            this.lbl_num2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(119, 20);
            this.lbl_num2.TabIndex = 1;
            this.lbl_num2.Text = "Input Number 2";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(264, 120);
            this.txt_num1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(331, 26);
            this.txt_num1.TabIndex = 2;
            this.txt_num1.TextChanged += new System.EventHandler(this.txt_num1_TextChanged);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(264, 174);
            this.txt_num2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(331, 26);
            this.txt_num2.TabIndex = 3;
            this.txt_num2.TextChanged += new System.EventHandler(this.txt_num2_TextChanged);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(118, 217);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(112, 35);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "Add";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(240, 217);
            this.btn_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(112, 35);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "Subtract";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(362, 217);
            this.btn_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(112, 35);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "Multiply";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(483, 217);
            this.btn_4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(112, 35);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "Divide";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(114, 270);
            this.lbl_res.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(55, 20);
            this.lbl_res.TabIndex = 8;
            this.lbl_res.Text = "Result";
            this.lbl_res.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(264, 267);
            this.txt_res.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(331, 26);
            this.txt_res.TabIndex = 9;
            this.txt_res.TextChanged += new System.EventHandler(this.txt_res_TextChanged);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(483, 316);
            this.btn_5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(112, 35);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "Clear";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 509);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button btn_5;
    }
}

