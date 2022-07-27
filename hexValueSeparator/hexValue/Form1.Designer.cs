namespace hexValue
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
            this.btn_separate = new System.Windows.Forms.Button();
            this.txtb_hexvalue = new System.Windows.Forms.TextBox();
            this.txtb_newhexvalue = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_separate
            // 
            this.btn_separate.Location = new System.Drawing.Point(365, 168);
            this.btn_separate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_separate.Name = "btn_separate";
            this.btn_separate.Size = new System.Drawing.Size(119, 62);
            this.btn_separate.TabIndex = 0;
            this.btn_separate.Text = "SEPARATE";
            this.btn_separate.UseVisualStyleBackColor = true;
            this.btn_separate.Click += new System.EventHandler(this.btn_separate_Click);
            // 
            // txtb_hexvalue
            // 
            this.txtb_hexvalue.Location = new System.Drawing.Point(140, 15);
            this.txtb_hexvalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_hexvalue.Multiline = true;
            this.txtb_hexvalue.Name = "txtb_hexvalue";
            this.txtb_hexvalue.Size = new System.Drawing.Size(549, 145);
            this.txtb_hexvalue.TabIndex = 1;
            // 
            // txtb_newhexvalue
            // 
            this.txtb_newhexvalue.Location = new System.Drawing.Point(140, 238);
            this.txtb_newhexvalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_newhexvalue.Name = "txtb_newhexvalue";
            this.txtb_newhexvalue.Size = new System.Drawing.Size(549, 145);
            this.txtb_newhexvalue.TabIndex = 2;
            this.txtb_newhexvalue.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "HEX VALUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NEW HEX VALUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_newhexvalue);
            this.Controls.Add(this.txtb_hexvalue);
            this.Controls.Add(this.btn_separate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HEX VALUE SEPARATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_separate;
        private System.Windows.Forms.TextBox txtb_hexvalue;
        private System.Windows.Forms.RichTextBox txtb_newhexvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

