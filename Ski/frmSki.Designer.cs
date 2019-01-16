namespace Ski
{
    partial class frmSki
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLengthPath = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDropPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(178, 30);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 33);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length of Calculated Path";
            // 
            // txtLengthPath
            // 
            this.txtLengthPath.Location = new System.Drawing.Point(178, 102);
            this.txtLengthPath.Name = "txtLengthPath";
            this.txtLengthPath.Size = new System.Drawing.Size(57, 20);
            this.txtLengthPath.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(178, 149);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(372, 20);
            this.txtPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calculated Path";
            // 
            // txtDropPath
            // 
            this.txtDropPath.Location = new System.Drawing.Point(178, 126);
            this.txtDropPath.Name = "txtDropPath";
            this.txtDropPath.Size = new System.Drawing.Size(57, 20);
            this.txtDropPath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drop of Calculated Path";
            // 
            // frmSki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 196);
            this.Controls.Add(this.txtDropPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLengthPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmSki";
            this.Text = "Ski";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLengthPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDropPath;
        private System.Windows.Forms.Label label3;
    }
}

