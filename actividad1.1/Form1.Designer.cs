﻿namespace actividad1._1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textRes2 = new System.Windows.Forms.TextBox();
            this.totalFiles = new System.Windows.Forms.Label();
            this.textTotalFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTotalTiempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRes2
            // 
            this.textRes2.Location = new System.Drawing.Point(235, 28);
            this.textRes2.Multiline = true;
            this.textRes2.Name = "textRes2";
            this.textRes2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRes2.Size = new System.Drawing.Size(498, 388);
            this.textRes2.TabIndex = 1;
            this.textRes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRes2.TextChanged += new System.EventHandler(this.textRes2_TextChanged);
            // 
            // totalFiles
            // 
            this.totalFiles.AutoSize = true;
            this.totalFiles.Location = new System.Drawing.Point(12, 74);
            this.totalFiles.Name = "totalFiles";
            this.totalFiles.Size = new System.Drawing.Size(132, 15);
            this.totalFiles.TabIndex = 2;
            this.totalFiles.Text = "Total de archivos leidos:";
            // 
            // textTotalFiles
            // 
            this.textTotalFiles.Location = new System.Drawing.Point(153, 74);
            this.textTotalFiles.Name = "textTotalFiles";
            this.textTotalFiles.Size = new System.Drawing.Size(76, 23);
            this.textTotalFiles.TabIndex = 3;
            this.textTotalFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total de tiempo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTotalTiempo
            // 
            this.textTotalTiempo.Location = new System.Drawing.Point(153, 105);
            this.textTotalTiempo.Name = "textTotalTiempo";
            this.textTotalTiempo.Size = new System.Drawing.Size(76, 23);
            this.textTotalTiempo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Archivos sin html:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(756, 30);
            this.textTime.Multiline = true;
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(474, 386);
            this.textTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiempos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTotalTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTotalFiles);
            this.Controls.Add(this.totalFiles);
            this.Controls.Add(this.textRes2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Actividad 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textRes2;
        private Label totalFiles;
        private TextBox textTotalFiles;
        private Label label1;
        private TextBox textTotalTiempo;
        private Label label2;
        private TextBox textTime;
        private Label label3;
    }
}