using System;

namespace Live_Currency_Exchange
{
    partial class excForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.currExc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.convBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Location = new System.Drawing.Point(240, 58);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(250, 23);
            this.fromBox.TabIndex = 0;
            // 
            // toBox
            // 
            this.toBox.FormattingEnabled = true;
            this.toBox.Location = new System.Drawing.Point(496, 58);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(244, 23);
            this.toBox.TabIndex = 1;
            // 
            // currExc
            // 
            this.currExc.Location = new System.Drawing.Point(12, 58);
            this.currExc.Name = "currExc";
            this.currExc.Size = new System.Drawing.Size(222, 23);
            this.currExc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currency";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // convBtn
            // 
            this.convBtn.Location = new System.Drawing.Point(648, 169);
            this.convBtn.Name = "convBtn";
            this.convBtn.Size = new System.Drawing.Size(92, 26);
            this.convBtn.TabIndex = 7;
            this.convBtn.Text = "Convert";
            this.convBtn.UseVisualStyleBackColor = true;
            this.convBtn.Click += new System.EventHandler(this.conv_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Converted Amount : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // excForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(762, 207);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.convBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currExc);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Name = "excForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Exchange";
            this.Load += new System.EventHandler(this.excForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.TextBox currExc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

