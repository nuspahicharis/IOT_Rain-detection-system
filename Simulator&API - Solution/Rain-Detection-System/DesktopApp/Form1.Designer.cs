namespace DesktopApp
{
    partial class Form1
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
            this.Light = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWeatherValues = new System.Windows.Forms.DataGridView();
            this.nudLight = new System.Windows.Forms.NumericUpDown();
            this.nudPressure = new System.Windows.Forms.NumericUpDown();
            this.nudHumidity = new System.Windows.Forms.NumericUpDown();
            this.nudTemparature = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClearValues = new System.Windows.Forms.Button();
            this.btnSetValues = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemparature)).BeginInit();
            this.SuspendLayout();
            // 
            // Light
            // 
            this.Light.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Light.DataPropertyName = "Light";
            this.Light.HeaderText = "Light";
            this.Light.MinimumWidth = 8;
            this.Light.Name = "Light";
            this.Light.ReadOnly = true;
            // 
            // Humidity
            // 
            this.Humidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Humidity.DataPropertyName = "Humidity";
            this.Humidity.HeaderText = "Humidity";
            this.Humidity.MinimumWidth = 8;
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
            // 
            // Temperature
            // 
            this.Temperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Temperature.DataPropertyName = "Temperature";
            this.Temperature.HeaderText = "Temperature";
            this.Temperature.MinimumWidth = 8;
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Pressure
            // 
            this.Pressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pressure.DataPropertyName = "Pressure";
            this.Pressure.HeaderText = "Pressure";
            this.Pressure.MinimumWidth = 8;
            this.Pressure.Name = "Pressure";
            this.Pressure.ReadOnly = true;
            // 
            // dgvWeatherValues
            // 
            this.dgvWeatherValues.AllowUserToAddRows = false;
            this.dgvWeatherValues.AllowUserToDeleteRows = false;
            this.dgvWeatherValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeatherValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Temperature,
            this.Humidity,
            this.Pressure,
            this.Light});
            this.dgvWeatherValues.Location = new System.Drawing.Point(33, 162);
            this.dgvWeatherValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWeatherValues.Name = "dgvWeatherValues";
            this.dgvWeatherValues.ReadOnly = true;
            this.dgvWeatherValues.RowHeadersWidth = 62;
            this.dgvWeatherValues.RowTemplate.Height = 28;
            this.dgvWeatherValues.Size = new System.Drawing.Size(636, 384);
            this.dgvWeatherValues.TabIndex = 31;
            // 
            // nudLight
            // 
            this.nudLight.Location = new System.Drawing.Point(418, 48);
            this.nudLight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudLight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLight.Name = "nudLight";
            this.nudLight.Size = new System.Drawing.Size(107, 20);
            this.nudLight.TabIndex = 30;
            this.nudLight.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // nudPressure
            // 
            this.nudPressure.Location = new System.Drawing.Point(289, 48);
            this.nudPressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPressure.Maximum = new decimal(new int[] {
            1050,
            0,
            0,
            0});
            this.nudPressure.Minimum = new decimal(new int[] {
            950,
            0,
            0,
            0});
            this.nudPressure.Name = "nudPressure";
            this.nudPressure.Size = new System.Drawing.Size(107, 20);
            this.nudPressure.TabIndex = 29;
            this.nudPressure.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudHumidity
            // 
            this.nudHumidity.Location = new System.Drawing.Point(158, 48);
            this.nudHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudHumidity.Name = "nudHumidity";
            this.nudHumidity.Size = new System.Drawing.Size(107, 20);
            this.nudHumidity.TabIndex = 28;
            // 
            // nudTemparature
            // 
            this.nudTemparature.Location = new System.Drawing.Point(33, 48);
            this.nudTemparature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTemparature.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTemparature.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudTemparature.Name = "nudTemparature";
            this.nudTemparature.Size = new System.Drawing.Size(107, 20);
            this.nudTemparature.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(7, 6);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClearValues
            // 
            this.btnClearValues.Location = new System.Drawing.Point(169, 93);
            this.btnClearValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearValues.Name = "btnClearValues";
            this.btnClearValues.Size = new System.Drawing.Size(131, 53);
            this.btnClearValues.TabIndex = 25;
            this.btnClearValues.Text = "Clear";
            this.btnClearValues.UseVisualStyleBackColor = true;
            this.btnClearValues.Click += new System.EventHandler(this.btnClearValues_Click);
            // 
            // btnSetValues
            // 
            this.btnSetValues.Location = new System.Drawing.Point(33, 93);
            this.btnSetValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetValues.Name = "btnSetValues";
            this.btnSetValues.Size = new System.Drawing.Size(131, 53);
            this.btnSetValues.TabIndex = 24;
            this.btnSetValues.Text = "Save";
            this.btnSetValues.UseVisualStyleBackColor = true;
            this.btnSetValues.Click += new System.EventHandler(this.btnSetValues_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Light";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(702, 569);
            this.Controls.Add(this.dgvWeatherValues);
            this.Controls.Add(this.nudLight);
            this.Controls.Add(this.nudPressure);
            this.Controls.Add(this.nudHumidity);
            this.Controls.Add(this.nudTemparature);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearValues);
            this.Controls.Add(this.btnSetValues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NodeMCU Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemparature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Light;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridView dgvWeatherValues;
        private System.Windows.Forms.NumericUpDown nudLight;
        private System.Windows.Forms.NumericUpDown nudPressure;
        private System.Windows.Forms.NumericUpDown nudHumidity;
        private System.Windows.Forms.NumericUpDown nudTemparature;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearValues;
        private System.Windows.Forms.Button btnSetValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

