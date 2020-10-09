namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.symbolLabel2 = new System.Windows.Forms.Label();
            this.symbolLabel3 = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.DimGray;
            this.cityOutput.Location = new System.Drawing.Point(31, 8);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(260, 40);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Leelawadee", 35F);
            this.maxOutput.ForeColor = System.Drawing.Color.LightSalmon;
            this.maxOutput.Location = new System.Drawing.Point(363, 156);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(78, 53);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "X";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Leelawadee", 35F);
            this.minOutput.ForeColor = System.Drawing.Color.Teal;
            this.minOutput.Location = new System.Drawing.Point(89, 156);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(78, 53);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "X";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Leelawadee", 16F);
            this.currentOutput.ForeColor = System.Drawing.Color.DimGray;
            this.currentOutput.Location = new System.Drawing.Point(358, 82);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(190, 32);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "and weather condition.";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Leelawadee", 16F);
            this.titleLabel.ForeColor = System.Drawing.Color.DimGray;
            this.titleLabel.Location = new System.Drawing.Point(32, 82);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(153, 26);
            this.titleLabel.TabIndex = 26;
            this.titleLabel.Text = "it is currently...";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Leelawadee", 16F);
            this.todayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.todayLabel.Location = new System.Drawing.Point(358, 14);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(83, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Leelawadee", 16F);
            this.forecastLabel.ForeColor = System.Drawing.Color.DimGray;
            this.forecastLabel.Location = new System.Drawing.Point(447, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(335, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Leelawadee", 50F);
            this.tempLabel.ForeColor = System.Drawing.Color.DimGray;
            this.tempLabel.Location = new System.Drawing.Point(214, 58);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(112, 76);
            this.tempLabel.TabIndex = 43;
            this.tempLabel.Text = "X";
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.BackColor = System.Drawing.Color.Transparent;
            this.symbolLabel.Font = new System.Drawing.Font("Leelawadee", 15F);
            this.symbolLabel.ForeColor = System.Drawing.Color.DimGray;
            this.symbolLabel.Location = new System.Drawing.Point(296, 58);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(30, 24);
            this.symbolLabel.TabIndex = 44;
            this.symbolLabel.Text = "°C";
            // 
            // symbolLabel2
            // 
            this.symbolLabel2.AutoSize = true;
            this.symbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.symbolLabel2.Font = new System.Drawing.Font("Leelawadee", 15F);
            this.symbolLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.symbolLabel2.Location = new System.Drawing.Point(423, 147);
            this.symbolLabel2.Name = "symbolLabel2";
            this.symbolLabel2.Size = new System.Drawing.Size(30, 24);
            this.symbolLabel2.TabIndex = 45;
            this.symbolLabel2.Text = "°C";
            // 
            // symbolLabel3
            // 
            this.symbolLabel3.AutoSize = true;
            this.symbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.symbolLabel3.Font = new System.Drawing.Font("Leelawadee", 15F);
            this.symbolLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.symbolLabel3.Location = new System.Drawing.Point(148, 147);
            this.symbolLabel3.Name = "symbolLabel3";
            this.symbolLabel3.Size = new System.Drawing.Size(30, 24);
            this.symbolLabel3.TabIndex = 46;
            this.symbolLabel3.Text = "°C";
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(228, 156);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(80, 80);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 47;
            this.iconBox.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.symbolLabel3);
            this.Controls.Add(this.symbolLabel2);
            this.Controls.Add(this.symbolLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(540, 300);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.Label symbolLabel2;
        private System.Windows.Forms.Label symbolLabel3;
        private System.Windows.Forms.PictureBox iconBox;
    }
}
