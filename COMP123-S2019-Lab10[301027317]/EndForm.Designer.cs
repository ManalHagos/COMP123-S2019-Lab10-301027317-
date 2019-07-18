namespace COMP123_S2019_Lab10_301027317_
{
    partial class EndForm
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
            this.TheBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TheBackButton
            // 
            this.TheBackButton.Location = new System.Drawing.Point(244, 301);
            this.TheBackButton.Name = "TheBackButton";
            this.TheBackButton.Size = new System.Drawing.Size(234, 60);
            this.TheBackButton.TabIndex = 0;
            this.TheBackButton.Text = "BackButton";
            this.TheBackButton.UseVisualStyleBackColor = true;
            this.TheBackButton.Click += new System.EventHandler(this.TheBackButton_Click);
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.TheBackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "EndForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TheBackButton;
    }
}