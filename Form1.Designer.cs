﻿namespace mvchat_generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.SoundsText_check = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastOffset_lbl = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.SelectFiles_btn = new System.Windows.Forms.Button();
            this.TotalAdded_lbl = new System.Windows.Forms.Label();
            this.Offset_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate from pk3 and zip files";
            // 
            // Generate_btn
            // 
            this.Generate_btn.Enabled = false;
            this.Generate_btn.Location = new System.Drawing.Point(559, 45);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(97, 47);
            this.Generate_btn.TabIndex = 2;
            this.Generate_btn.Text = "Generate";
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // SoundsText_check
            // 
            this.SoundsText_check.AutoSize = true;
            this.SoundsText_check.Location = new System.Drawing.Point(662, 59);
            this.SoundsText_check.Name = "SoundsText_check";
            this.SoundsText_check.Size = new System.Drawing.Size(238, 21);
            this.SoundsText_check.TabIndex = 4;
            this.SoundsText_check.Text = "Use sounds filename for their text";
            this.SoundsText_check.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SoundsText_check.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Offset";
            // 
            // LastOffset_lbl
            // 
            this.LastOffset_lbl.AutoSize = true;
            this.LastOffset_lbl.Location = new System.Drawing.Point(588, 132);
            this.LastOffset_lbl.Name = "LastOffset_lbl";
            this.LastOffset_lbl.Size = new System.Drawing.Size(151, 17);
            this.LastOffset_lbl.TabIndex = 7;
            this.LastOffset_lbl.Text = "Last used offset: None";
            // 
            // Save_btn
            // 
            this.Save_btn.Enabled = false;
            this.Save_btn.Location = new System.Drawing.Point(432, 181);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(97, 47);
            this.Save_btn.TabIndex = 8;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(559, 181);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(97, 47);
            this.Reset_btn.TabIndex = 9;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // SelectFiles_btn
            // 
            this.SelectFiles_btn.Location = new System.Drawing.Point(432, 46);
            this.SelectFiles_btn.Name = "SelectFiles_btn";
            this.SelectFiles_btn.Size = new System.Drawing.Size(107, 46);
            this.SelectFiles_btn.TabIndex = 1;
            this.SelectFiles_btn.Text = "Select files";
            this.SelectFiles_btn.UseVisualStyleBackColor = true;
            this.SelectFiles_btn.Click += new System.EventHandler(this.SelectFiles_btn_Click);
            // 
            // TotalAdded_lbl
            // 
            this.TotalAdded_lbl.AutoSize = true;
            this.TotalAdded_lbl.Location = new System.Drawing.Point(464, 245);
            this.TotalAdded_lbl.Name = "TotalAdded_lbl";
            this.TotalAdded_lbl.Size = new System.Drawing.Size(150, 17);
            this.TotalAdded_lbl.TabIndex = 10;
            this.TotalAdded_lbl.Text = "Total added sounds: 0";
            // 
            // Offset_input
            // 
            this.Offset_input.Location = new System.Drawing.Point(482, 129);
            this.Offset_input.Name = "Offset_input";
            this.Offset_input.Size = new System.Drawing.Size(100, 23);
            this.Offset_input.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 566);
            this.Controls.Add(this.Offset_input);
            this.Controls.Add(this.TotalAdded_lbl);
            this.Controls.Add(this.SelectFiles_btn);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.LastOffset_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SoundsText_check);
            this.Controls.Add(this.Generate_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mvchat generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.CheckBox SoundsText_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LastOffset_lbl;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button SelectFiles_btn;
        private System.Windows.Forms.Label TotalAdded_lbl;
        private System.Windows.Forms.TextBox Offset_input;
    }
}

