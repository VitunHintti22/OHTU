﻿namespace Kirjautumissivu
{
    partial class Palautus
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
            this.chkListTuotteet = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkListTuotteet
            // 
            this.chkListTuotteet.CheckOnClick = true;
            this.chkListTuotteet.FormattingEnabled = true;
            this.chkListTuotteet.Location = new System.Drawing.Point(15, 38);
            this.chkListTuotteet.Name = "chkListTuotteet";
            this.chkListTuotteet.Size = new System.Drawing.Size(120, 94);
            this.chkListTuotteet.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Kirjautumissivu.Properties.Resources.lol;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::Kirjautumissivu.Properties.Resources.lol;
            this.button1.Location = new System.Drawing.Point(137, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Palauta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lainatut tuotteet";
            // 
            // Palautus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Kirjautumissivu.Properties.Resources.NIIIICEEE;
            this.ClientSize = new System.Drawing.Size(287, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkListTuotteet);
            this.Name = "Palautus";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListTuotteet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}