﻿
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listViewCountries = new System.Windows.Forms.ListView();
            this.ColCountries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbCountryInput
            // 
            this.tbCountryInput.Location = new System.Drawing.Point(32, 32);
            this.tbCountryInput.Margin = new System.Windows.Forms.Padding(2);
            this.tbCountryInput.Name = "tbCountryInput";
            this.tbCountryInput.Size = new System.Drawing.Size(507, 22);
            this.tbCountryInput.TabIndex = 0;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(337, 84);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(213, 43);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Hinzufügen";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 156);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Entfernen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(337, 227);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(213, 43);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importieren";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(337, 472);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(213, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(337, 294);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(213, 43);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Aktualisieren";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listViewCountries
            // 
            this.listViewCountries.AllowColumnReorder = true;
            this.listViewCountries.AllowDrop = true;
            this.listViewCountries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColCountries});
            this.listViewCountries.FullRowSelect = true;
            this.listViewCountries.GridLines = true;
            this.listViewCountries.HideSelection = false;
            this.listViewCountries.Location = new System.Drawing.Point(32, 68);
            this.listViewCountries.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCountries.MultiSelect = false;
            this.listViewCountries.Name = "listViewCountries";
            this.listViewCountries.Size = new System.Drawing.Size(273, 469);
            this.listViewCountries.TabIndex = 8;
            this.listViewCountries.UseCompatibleStateImageBehavior = false;
            this.listViewCountries.View = System.Windows.Forms.View.Details;
            // 
            // ColCountries
            // 
            this.ColCountries.Text = "Österreichische Bundesländer";
            this.ColCountries.Width = 360;
            // 
            // ConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 543);
            this.Controls.Add(this.listViewCountries);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.tbCountryInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfigView";
            this.Text = "ConfigView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCountryInput;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listViewCountries;
        private System.Windows.Forms.ColumnHeader ColCountries;
    }
}