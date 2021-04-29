
namespace WinformEFW
{
    partial class FormAddBadge
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
            this.txtNewBadge = new System.Windows.Forms.TextBox();
            this.btnAddNewBadge = new System.Windows.Forms.Button();
            this.lblNameBadge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewBadge
            // 
            this.txtNewBadge.Location = new System.Drawing.Point(59, 41);
            this.txtNewBadge.Name = "txtNewBadge";
            this.txtNewBadge.Size = new System.Drawing.Size(100, 20);
            this.txtNewBadge.TabIndex = 0;
            // 
            // btnAddNewBadge
            // 
            this.btnAddNewBadge.Location = new System.Drawing.Point(72, 81);
            this.btnAddNewBadge.Name = "btnAddNewBadge";
            this.btnAddNewBadge.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewBadge.TabIndex = 1;
            this.btnAddNewBadge.Text = "Voeg toe";
            this.btnAddNewBadge.UseVisualStyleBackColor = true;
            this.btnAddNewBadge.Click += new System.EventHandler(this.btnAddNewBadge_Click);
            // 
            // lblNameBadge
            // 
            this.lblNameBadge.AutoSize = true;
            this.lblNameBadge.Location = new System.Drawing.Point(56, 25);
            this.lblNameBadge.Name = "lblNameBadge";
            this.lblNameBadge.Size = new System.Drawing.Size(68, 13);
            this.lblNameBadge.TabIndex = 2;
            this.lblNameBadge.Text = "Naam badge";
            // 
            // FormAddBadge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 134);
            this.Controls.Add(this.lblNameBadge);
            this.Controls.Add(this.btnAddNewBadge);
            this.Controls.Add(this.txtNewBadge);
            this.Name = "FormAddBadge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddBadge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewBadge;
        private System.Windows.Forms.Button btnAddNewBadge;
        private System.Windows.Forms.Label lblNameBadge;
    }
}