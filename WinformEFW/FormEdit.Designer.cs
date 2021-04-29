
namespace WinformEFW
{
    partial class FormEdit
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
            this.cbPersonen = new System.Windows.Forms.ComboBox();
            this.lblPersonen = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.btnBewerk = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.numLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.lblBadge = new System.Windows.Forms.Label();
            this.btnBewerkBdg = new System.Windows.Forms.Button();
            this.txtBadges = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPersonen
            // 
            this.cbPersonen.AccessibleName = "";
            this.cbPersonen.FormattingEnabled = true;
            this.cbPersonen.Location = new System.Drawing.Point(6, 39);
            this.cbPersonen.Name = "cbPersonen";
            this.cbPersonen.Size = new System.Drawing.Size(128, 21);
            this.cbPersonen.TabIndex = 0;
            this.cbPersonen.SelectedIndexChanged += new System.EventHandler(this.cbPersonen_SelectedIndexChanged);
            
            // 
            // lblPersonen
            // 
            this.lblPersonen.AccessibleName = "";
            this.lblPersonen.AutoSize = true;
            this.lblPersonen.Location = new System.Drawing.Point(3, 23);
            this.lblPersonen.Name = "lblPersonen";
            this.lblPersonen.Size = new System.Drawing.Size(99, 13);
            this.lblPersonen.TabIndex = 1;
            this.lblPersonen.Text = "Persoon aanduiden";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(183, 40);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(125, 20);
            this.txtVoornaam.TabIndex = 2;
            this.txtVoornaam.TextChanged += new System.EventHandler(this.txtVoornaam_TextChanged);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(183, 83);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(125, 20);
            this.txtAchternaam.TabIndex = 3;
            this.txtAchternaam.TextChanged += new System.EventHandler(this.txtAchternaam_TextChanged);
            // 
            // btnBewerk
            // 
            this.btnBewerk.AccessibleName = "";
            this.btnBewerk.Location = new System.Drawing.Point(84, 79);
            this.btnBewerk.Name = "btnBewerk";
            this.btnBewerk.Size = new System.Drawing.Size(72, 26);
            this.btnBewerk.TabIndex = 5;
            this.btnBewerk.Text = "Bewerk";
            this.btnBewerk.UseVisualStyleBackColor = true;
            this.btnBewerk.Click += new System.EventHandler(this.btnBewerk_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.AccessibleName = "";
            this.btnVerwijder.Location = new System.Drawing.Point(6, 79);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(72, 26);
            this.btnVerwijder.TabIndex = 6;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // numLeeftijd
            // 
            this.numLeeftijd.Location = new System.Drawing.Point(183, 125);
            this.numLeeftijd.Name = "numLeeftijd";
            this.numLeeftijd.Size = new System.Drawing.Size(125, 20);
            this.numLeeftijd.TabIndex = 7;
            this.numLeeftijd.ValueChanged += new System.EventHandler(this.numLeeftijd_ValueChanged);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(180, 24);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(55, 13);
            this.lblVoornaam.TabIndex = 8;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(180, 67);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(64, 13);
            this.lblAchternaam.TabIndex = 9;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(180, 109);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(41, 13);
            this.lblLeeftijd.TabIndex = 10;
            this.lblLeeftijd.Text = "Leeftijd";
            // 
            // lblBadge
            // 
            this.lblBadge.AutoSize = true;
            this.lblBadge.Location = new System.Drawing.Point(180, 152);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Size = new System.Drawing.Size(43, 13);
            this.lblBadge.TabIndex = 12;
            this.lblBadge.Text = "Badges";
            // 
            // btnBewerkBdg
            // 
            this.btnBewerkBdg.AccessibleName = "";
            this.btnBewerkBdg.Location = new System.Drawing.Point(181, 269);
            this.btnBewerkBdg.Name = "btnBewerkBdg";
            this.btnBewerkBdg.Size = new System.Drawing.Size(127, 26);
            this.btnBewerkBdg.TabIndex = 15;
            this.btnBewerkBdg.Text = "Bewerk badges";
            this.btnBewerkBdg.UseVisualStyleBackColor = true;
            this.btnBewerkBdg.Click += new System.EventHandler(this.btnBewerkBdg_Click);
            // 
            // txtBadges
            // 
            this.txtBadges.Location = new System.Drawing.Point(181, 168);
            this.txtBadges.Multiline = true;
            this.txtBadges.Name = "txtBadges";
            this.txtBadges.Size = new System.Drawing.Size(127, 95);
            this.txtBadges.TabIndex = 16;
            this.txtBadges.TextChanged += new System.EventHandler(this.txtBadges_TextChanged);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 326);
            this.Controls.Add(this.txtBadges);
            this.Controls.Add(this.btnBewerkBdg);
            this.Controls.Add(this.lblBadge);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.numLeeftijd);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnBewerk);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lblPersonen);
            this.Controls.Add(this.cbPersonen);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Persoon bewerken";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPersonen;
        private System.Windows.Forms.Label lblPersonen;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Button btnBewerk;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.NumericUpDown numLeeftijd;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Button btnBewerkBdg;
        private System.Windows.Forms.TextBox txtBadges;
    }
}