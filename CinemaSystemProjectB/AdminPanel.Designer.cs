﻿namespace CinemaSystemProjectB
{
    partial class AdminPanel
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
            this.Linkerkolom = new System.Windows.Forms.Label();
            this.Rechterkolom = new System.Windows.Forms.Label();
            this.AdminFunctions = new System.Windows.Forms.FlowLayoutPanel();
            this.gradientLabel1 = new CinemaSystemProjectB.GradientLabel();
            this.Wittelijn = new System.Windows.Forms.Label();
            this.Bioscoopnaam = new System.Windows.Forms.Label();
            this.gradientLabel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Linkerkolom
            // 
            this.Linkerkolom.BackColor = System.Drawing.Color.Maroon;
            this.Linkerkolom.Location = new System.Drawing.Point(0, 146);
            this.Linkerkolom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Linkerkolom.Name = "Linkerkolom";
            this.Linkerkolom.Size = new System.Drawing.Size(40, 796);
            this.Linkerkolom.TabIndex = 54;
            // 
            // Rechterkolom
            // 
            this.Rechterkolom.BackColor = System.Drawing.Color.Maroon;
            this.Rechterkolom.Location = new System.Drawing.Point(1436, 146);
            this.Rechterkolom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rechterkolom.Name = "Rechterkolom";
            this.Rechterkolom.Size = new System.Drawing.Size(40, 770);
            this.Rechterkolom.TabIndex = 57;
            // 
            // AdminFunctions
            // 
            this.AdminFunctions.AutoScroll = true;
            this.AdminFunctions.Location = new System.Drawing.Point(75, 176);
            this.AdminFunctions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminFunctions.Name = "AdminFunctions";
            this.AdminFunctions.Size = new System.Drawing.Size(1327, 741);
            this.AdminFunctions.TabIndex = 58;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BeginColor = System.Drawing.Color.Black;
            this.gradientLabel1.Controls.Add(this.Wittelijn);
            this.gradientLabel1.Controls.Add(this.Bioscoopnaam);
            this.gradientLabel1.EndColor = System.Drawing.Color.Maroon;
            this.gradientLabel1.Location = new System.Drawing.Point(-4, -2);
            this.gradientLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(1484, 149);
            this.gradientLabel1.TabIndex = 56;
            // 
            // Wittelijn
            // 
            this.Wittelijn.BackColor = System.Drawing.Color.White;
            this.Wittelijn.Location = new System.Drawing.Point(-1, 143);
            this.Wittelijn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wittelijn.Name = "Wittelijn";
            this.Wittelijn.Size = new System.Drawing.Size(1483, 6);
            this.Wittelijn.TabIndex = 53;
            // 
            // Bioscoopnaam
            // 
            this.Bioscoopnaam.AutoSize = true;
            this.Bioscoopnaam.BackColor = System.Drawing.Color.Transparent;
            this.Bioscoopnaam.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.Bioscoopnaam.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bioscoopnaam.ForeColor = System.Drawing.Color.Yellow;
            this.Bioscoopnaam.Location = new System.Drawing.Point(69, 39);
            this.Bioscoopnaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bioscoopnaam.Name = "Bioscoopnaam";
            this.Bioscoopnaam.Size = new System.Drawing.Size(356, 73);
            this.Bioscoopnaam.TabIndex = 10;
            this.Bioscoopnaam.Text = "Darichwiwi";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1476, 919);
            this.Controls.Add(this.AdminFunctions);
            this.Controls.Add(this.Rechterkolom);
            this.Controls.Add(this.Linkerkolom);
            this.Controls.Add(this.gradientLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.gradientLabel1.ResumeLayout(false);
            this.gradientLabel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientLabel gradientLabel1;
        private System.Windows.Forms.Label Bioscoopnaam;
        private System.Windows.Forms.Label Wittelijn;
        private System.Windows.Forms.Label Linkerkolom;
        private System.Windows.Forms.Label Rechterkolom;
        private System.Windows.Forms.FlowLayoutPanel AdminFunctions;
    }
}