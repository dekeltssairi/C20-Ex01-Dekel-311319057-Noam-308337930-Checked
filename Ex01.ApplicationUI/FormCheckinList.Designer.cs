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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.f_ListBoxCheckins = new System.Windows.Forms.ListBox();
            this.checkinProxyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinProxyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(102, 108);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(102, 135);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(102, 157);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.f_ListBoxCheckins);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(createdTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.createdTimeDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nameLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(909, 534);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 0;
            // 
            // f_ListBoxCheckins
            // 
            this.f_ListBoxCheckins.DataSource = this.checkinProxyBindingSource;
            this.f_ListBoxCheckins.FormattingEnabled = true;
            this.f_ListBoxCheckins.ItemHeight = 16;
            this.f_ListBoxCheckins.Location = new System.Drawing.Point(3, 68);
            this.f_ListBoxCheckins.Name = "f_ListBoxCheckins";
            this.f_ListBoxCheckins.Size = new System.Drawing.Size(297, 468);
            this.f_ListBoxCheckins.TabIndex = 0;
            // 
            // checkinProxyBindingSource
            // 
            this.checkinProxyBindingSource.DataSource = typeof(Ex01.ApplicationUI.CheckinProxy);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkinProxyBindingSource, "Checkin.CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(205, 104);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinProxyBindingSource, "Checkin.Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(205, 132);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinProxyBindingSource, "Checkin.Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(205, 157);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(200, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label1";
            // 
            // FormCheckinList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 534);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCheckinList";
            this.Text = "CheckIn List";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkinProxyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox f_ListBoxCheckins;
        private System.Windows.Forms.BindingSource checkinProxyBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label nameLabel1;
    }
}