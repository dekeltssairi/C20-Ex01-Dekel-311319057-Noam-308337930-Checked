namespace Ex01.ApplicationUI
{
    partial class FormCheckinList
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
            this.f_ListBoxCheckins = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // f_ListBoxCheckins
            // 
            this.f_ListBoxCheckins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f_ListBoxCheckins.FormattingEnabled = true;
            this.f_ListBoxCheckins.HorizontalScrollbar = true;
            this.f_ListBoxCheckins.ItemHeight = 16;
            this.f_ListBoxCheckins.Location = new System.Drawing.Point(205, 101);
            this.f_ListBoxCheckins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_ListBoxCheckins.Name = "f_ListBoxCheckins";
            this.f_ListBoxCheckins.Size = new System.Drawing.Size(373, 228);
            this.f_ListBoxCheckins.TabIndex = 0;
            // 
            // FormCheckinList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f_ListBoxCheckins);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCheckinList";
            this.Text = "CheckIn List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox f_ListBoxCheckins;
    }
}