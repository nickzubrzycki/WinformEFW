
namespace WinformEFW
{
    partial class FormMain
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnAddBadge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.AccessibleName = "";
            this.btnToevoegen.Location = new System.Drawing.Point(81, 83);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(199, 31);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "Persoon toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnBewerken
            // 
            this.btnBewerken.AccessibleName = "";
            this.btnBewerken.Location = new System.Drawing.Point(81, 172);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(199, 31);
            this.btnBewerken.TabIndex = 1;
            this.btnBewerken.Text = "Personen bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // btnAddBadge
            // 
            this.btnAddBadge.AccessibleName = "";
            this.btnAddBadge.Location = new System.Drawing.Point(81, 129);
            this.btnAddBadge.Name = "btnAddBadge";
            this.btnAddBadge.Size = new System.Drawing.Size(199, 31);
            this.btnAddBadge.TabIndex = 2;
            this.btnAddBadge.Text = "Badge toevoegen";
            this.btnAddBadge.UseVisualStyleBackColor = true;
            this.btnAddBadge.Click += new System.EventHandler(this.btnAddBadge_Click);
            // 
            // FormMain
            // 
            this.AccessibleName = "form1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 288);
            this.Controls.Add(this.btnAddBadge);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnToevoegen);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnAddBadge;
    }
}

