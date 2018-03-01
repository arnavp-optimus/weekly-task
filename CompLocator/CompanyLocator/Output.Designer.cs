namespace FirstAssignment
{
    partial class OutputScreen
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
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCompanies
            // 
            this.lstCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.ItemHeight = 20;
            this.lstCompanies.Location = new System.Drawing.Point(0, 0);
            this.lstCompanies.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.Size = new System.Drawing.Size(959, 352);
            this.lstCompanies.TabIndex = 0;
            // 
            // OutputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 352);
            this.Controls.Add(this.lstCompanies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OutputScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutputScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCompanies;
    }
}