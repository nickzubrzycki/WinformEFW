
namespace WinformEFW
{
    partial class FormEditBadges
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
            this.clbBadges = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbBadges
            // 
            this.clbBadges.CheckOnClick = true;
            this.clbBadges.FormattingEnabled = true;
            this.clbBadges.Location = new System.Drawing.Point(92, 65);
            this.clbBadges.Name = "clbBadges";
            this.clbBadges.Size = new System.Drawing.Size(149, 79);
            this.clbBadges.TabIndex = 0;
            this.clbBadges.SelectedIndexChanged += new System.EventHandler(this.clbBadges_SelectedIndexChanged);
            // 
            // FormEditBadges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 242);
            this.Controls.Add(this.clbBadges);
            this.Name = "FormEditBadges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditBadges";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbBadges;
    }
}