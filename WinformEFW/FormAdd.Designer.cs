
namespace WinformEFW
{
    partial class FormAdd
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
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.numLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.AccessibleName = "";
            this.txtVoornaam.Location = new System.Drawing.Point(37, 34);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(213, 20);
            this.txtVoornaam.TabIndex = 0;
            this.txtVoornaam.TextChanged += new System.EventHandler(this.txtVoornaam_TextChanged);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.AccessibleName = "";
            this.txtAchternaam.Location = new System.Drawing.Point(37, 84);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(213, 20);
            this.txtAchternaam.TabIndex = 1;
            this.txtAchternaam.TextChanged += new System.EventHandler(this.txtAchternaam_TextChanged);
            // 
            // numLeeftijd
            // 
            this.numLeeftijd.AccessibleName = "";
            this.numLeeftijd.Location = new System.Drawing.Point(37, 133);
            this.numLeeftijd.Name = "numLeeftijd";
            this.numLeeftijd.Size = new System.Drawing.Size(213, 20);
            this.numLeeftijd.TabIndex = 2;
            this.numLeeftijd.ValueChanged += new System.EventHandler(this.numLeeftijd_ValueChanged);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.AccessibleName = "";
            this.btnVoegToe.Location = new System.Drawing.Point(37, 169);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(213, 25);
            this.btnVoegToe.TabIndex = 3;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AccessibleName = "";
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(34, 18);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(55, 13);
            this.lblVoornaam.TabIndex = 4;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AccessibleName = "";
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(34, 68);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(64, 13);
            this.lblAchternaam.TabIndex = 5;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AccessibleName = "";
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(34, 117);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(41, 13);
            this.lblLeeftijd.TabIndex = 6;
            this.lblLeeftijd.Text = "Leeftijd";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 208);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.numLeeftijd);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Persoon toevoegen";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.NumericUpDown numLeeftijd;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblLeeftijd;
    }
}