﻿namespace Hello_World
{
    partial class FrmHelloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHelloWorld.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWorld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHelloWorld.Location = new System.Drawing.Point(176, 94);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(238, 59);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello World";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(198, 272);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(162, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Hello World";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 318);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "FrmHelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnShow;
    }
}

