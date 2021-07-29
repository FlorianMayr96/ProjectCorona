namespace Projekt
{
    partial class MainView
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
            this.Chart = new LiveCharts.WinForms.CartesianChart();
            this.btn_CovidCases = new System.Windows.Forms.Button();
            this.btn_Deaths = new System.Windows.Forms.Button();
            this.btn_Tests = new System.Windows.Forms.Button();
            this.btn_IntensiveStation = new System.Windows.Forms.Button();
            this.btn_Recovered = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(42, 74);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(545, 336);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "Chart";
            // 
            // btn_CovidCases
            // 
            this.btn_CovidCases.Location = new System.Drawing.Point(625, 52);
            this.btn_CovidCases.Name = "btn_CovidCases";
            this.btn_CovidCases.Size = new System.Drawing.Size(131, 39);
            this.btn_CovidCases.TabIndex = 2;
            this.btn_CovidCases.Text = "CovidCases";
            this.btn_CovidCases.UseVisualStyleBackColor = true;
            this.btn_CovidCases.Click += new System.EventHandler(this.btn_CovidCases_Click);
            // 
            // btn_Deaths
            // 
            this.btn_Deaths.Location = new System.Drawing.Point(625, 120);
            this.btn_Deaths.Name = "btn_Deaths";
            this.btn_Deaths.Size = new System.Drawing.Size(131, 39);
            this.btn_Deaths.TabIndex = 3;
            this.btn_Deaths.Text = "Deaths";
            this.btn_Deaths.UseVisualStyleBackColor = true;
            this.btn_Deaths.Click += new System.EventHandler(this.btn_Deaths_Click);
            // 
            // btn_Tests
            // 
            this.btn_Tests.Location = new System.Drawing.Point(625, 183);
            this.btn_Tests.Name = "btn_Tests";
            this.btn_Tests.Size = new System.Drawing.Size(131, 39);
            this.btn_Tests.TabIndex = 4;
            this.btn_Tests.Text = "Tests";
            this.btn_Tests.UseVisualStyleBackColor = true;
            this.btn_Tests.Click += new System.EventHandler(this.btn_Tests_Click);
            // 
            // btn_IntensiveStation
            // 
            this.btn_IntensiveStation.Location = new System.Drawing.Point(625, 245);
            this.btn_IntensiveStation.Name = "btn_IntensiveStation";
            this.btn_IntensiveStation.Size = new System.Drawing.Size(131, 39);
            this.btn_IntensiveStation.TabIndex = 5;
            this.btn_IntensiveStation.Text = "IntensiveStation";
            this.btn_IntensiveStation.UseVisualStyleBackColor = true;
            this.btn_IntensiveStation.Click += new System.EventHandler(this.btn_IntensiveStation_Click);
            // 
            // btn_Recovered
            // 
            this.btn_Recovered.Location = new System.Drawing.Point(625, 300);
            this.btn_Recovered.Name = "btn_Recovered";
            this.btn_Recovered.Size = new System.Drawing.Size(131, 39);
            this.btn_Recovered.TabIndex = 6;
            this.btn_Recovered.Text = "Recovered";
            this.btn_Recovered.UseVisualStyleBackColor = true;
            this.btn_Recovered.Click += new System.EventHandler(this.btn_Recovered_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.Location = new System.Drawing.Point(625, 399);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(131, 39);
            this.btn_Config.TabIndex = 7;
            this.btn_Config.Text = "Config";
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_Recovered);
            this.Controls.Add(this.btn_IntensiveStation);
            this.Controls.Add(this.btn_Tests);
            this.Controls.Add(this.btn_Deaths);
            this.Controls.Add(this.btn_CovidCases);
            this.Controls.Add(this.Chart);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart Chart;
        private System.Windows.Forms.Button btn_CovidCases;
        private System.Windows.Forms.Button btn_Deaths;
        private System.Windows.Forms.Button btn_Tests;
        private System.Windows.Forms.Button btn_IntensiveStation;
        private System.Windows.Forms.Button btn_Recovered;
        private System.Windows.Forms.Button btn_Config;
    }
}

