namespace Projekt
{
    partial class ConfigView
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
            this.tbCountryInput = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listViewCountries = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbCountryInput
            // 
            this.tbCountryInput.Location = new System.Drawing.Point(48, 50);
            this.tbCountryInput.Name = "tbCountryInput";
            this.tbCountryInput.Size = new System.Drawing.Size(758, 31);
            this.tbCountryInput.TabIndex = 0;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(505, 132);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(319, 67);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Hinzufügen";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(319, 67);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Entfernen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(505, 355);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(319, 67);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importieren";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(505, 737);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(319, 67);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listViewCountries
            // 
            this.listViewCountries.HideSelection = false;
            this.listViewCountries.Location = new System.Drawing.Point(48, 132);
            this.listViewCountries.Name = "listViewCountries";
            this.listViewCountries.Size = new System.Drawing.Size(413, 672);
            this.listViewCountries.TabIndex = 6;
            this.listViewCountries.UseCompatibleStateImageBehavior = false;
            // 
            // ConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 849);
            this.Controls.Add(this.listViewCountries);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.tbCountryInput);
            this.Name = "ConfigView";
            this.Text = "ConfigView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCountryInput;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView listViewCountries;
    }
}