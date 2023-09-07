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
            this.dgvWeatherValues = new System.Windows.Forms.DataGridView();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Light = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnAutoGenerate = new System.Windows.Forms.Button();
            this.nudNumberOfData = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemparature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWeatherValues
            // 
            this.dgvWeatherValues.AllowUserToAddRows = false;
            this.dgvWeatherValues.AllowUserToDeleteRows = false;
            this.dgvWeatherValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeatherValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Temperature,
            this.Humidity,
            this.Pressure,
            this.Light});
            this.dgvWeatherValues.Location = new System.Drawing.Point(43, 216);
            this.dgvWeatherValues.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvWeatherValues.Name = "dgvWeatherValues";
            this.dgvWeatherValues.ReadOnly = true;
            this.dgvWeatherValues.RowHeadersWidth = 62;
            this.dgvWeatherValues.RowTemplate.Height = 28;
            this.dgvWeatherValues.Size = new System.Drawing.Size(656, 473);
            this.dgvWeatherValues.TabIndex = 31;
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
            // Humidity
            // 
            this.Humidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Humidity.DataPropertyName = "Humidity";
            this.Humidity.HeaderText = "Humidity";
            this.Humidity.MinimumWidth = 8;
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
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
            // Light
            // 
            this.Light.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Light.DataPropertyName = "Light";
            this.Light.HeaderText = "Light";
            this.Light.MinimumWidth = 8;
            this.Light.Name = "Light";
            this.Light.ReadOnly = true;
            // 
            // nudLight
            // 
            this.nudLight.Location = new System.Drawing.Point(557, 59);
            this.nudLight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.nudLight.Size = new System.Drawing.Size(143, 22);
            this.nudLight.TabIndex = 30;
            this.nudLight.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // nudPressure
            // 
            this.nudPressure.Location = new System.Drawing.Point(385, 59);
            this.nudPressure.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.nudPressure.Size = new System.Drawing.Size(143, 22);
            this.nudPressure.TabIndex = 29;
            this.nudPressure.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudHumidity
            // 
            this.nudHumidity.Location = new System.Drawing.Point(211, 59);
            this.nudHumidity.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudHumidity.Name = "nudHumidity";
            this.nudHumidity.Size = new System.Drawing.Size(143, 22);
            this.nudHumidity.TabIndex = 28;
            this.nudHumidity.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudTemparature
            // 
            this.nudTemparature.Location = new System.Drawing.Point(44, 59);
            this.nudTemparature.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.nudTemparature.Size = new System.Drawing.Size(143, 22);
            this.nudTemparature.TabIndex = 27;
            this.nudTemparature.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(915, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 7);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClearValues
            // 
            this.btnClearValues.Location = new System.Drawing.Point(150, 114);
            this.btnClearValues.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClearValues.Name = "btnClearValues";
            this.btnClearValues.Size = new System.Drawing.Size(98, 65);
            this.btnClearValues.TabIndex = 25;
            this.btnClearValues.Text = "Clear";
            this.btnClearValues.UseVisualStyleBackColor = true;
            this.btnClearValues.Click += new System.EventHandler(this.btnClearValues_Click);
            // 
            // btnSetValues
            // 
            this.btnSetValues.Location = new System.Drawing.Point(43, 114);
            this.btnSetValues.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSetValues.Name = "btnSetValues";
            this.btnSetValues.Size = new System.Drawing.Size(99, 65);
            this.btnSetValues.TabIndex = 24;
            this.btnSetValues.Text = "Save";
            this.btnSetValues.UseVisualStyleBackColor = true;
            this.btnSetValues.Click += new System.EventHandler(this.btnSetValues_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Light";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Temperature";
            // 
            // btnAutoGenerate
            // 
            this.btnAutoGenerate.Location = new System.Drawing.Point(604, 114);
            this.btnAutoGenerate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAutoGenerate.Name = "btnAutoGenerate";
            this.btnAutoGenerate.Size = new System.Drawing.Size(96, 65);
            this.btnAutoGenerate.TabIndex = 32;
            this.btnAutoGenerate.Text = "Auto Generate";
            this.btnAutoGenerate.UseVisualStyleBackColor = true;
            this.btnAutoGenerate.Click += new System.EventHandler(this.btnAutoGenerate_Click);
            // 
            // nudNumberOfData
            // 
            this.nudNumberOfData.Location = new System.Drawing.Point(445, 148);
            this.nudNumberOfData.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudNumberOfData.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNumberOfData.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudNumberOfData.Name = "nudNumberOfData";
            this.nudNumberOfData.Size = new System.Drawing.Size(143, 22);
            this.nudNumberOfData.TabIndex = 33;
            this.nudNumberOfData.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "# of Data records";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(744, 700);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudNumberOfData);
            this.Controls.Add(this.btnAutoGenerate);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NodeMCU Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemparature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Light;
        private System.Windows.Forms.Button btnAutoGenerate;
        private System.Windows.Forms.NumericUpDown nudNumberOfData;
        private System.Windows.Forms.Label label5;
    }
}

