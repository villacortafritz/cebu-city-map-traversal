namespace Graphify
{
    partial class Form2
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
            this.GraphMatrix = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GraphMatrix
            // 
            this.GraphMatrix.AutoScroll = true;
            this.GraphMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphMatrix.Location = new System.Drawing.Point(0, 0);
            this.GraphMatrix.Name = "GraphMatrix";
            this.GraphMatrix.Size = new System.Drawing.Size(600, 400);
            this.GraphMatrix.TabIndex = 2;
            this.GraphMatrix.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphMatrix_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.GraphMatrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GraphMatrix;
    }
}