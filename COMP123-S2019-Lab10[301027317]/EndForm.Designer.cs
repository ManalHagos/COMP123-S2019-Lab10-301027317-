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
            this.BackButton_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton_Click
            // 
            this.BackButton_Click.Location = new System.Drawing.Point(262, 274);
            this.BackButton_Click.Name = "BackButton_Click";
            this.BackButton_Click.Size = new System.Drawing.Size(242, 57);
            this.BackButton_Click.TabIndex = 0;
            this.BackButton_Click.Text = "BackButton";
            this.BackButton_Click.UseVisualStyleBackColor = true;
            this.BackButton_Click.Click += new System.EventHandler(this.BackButton_Click_Click);
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.BackButton_Click);
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

        private System.Windows.Forms.Button BackButton_Click;
    }
}