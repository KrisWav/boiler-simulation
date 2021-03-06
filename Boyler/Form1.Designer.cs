namespace Boyler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showerTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showerTempTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sinkTempTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sinkTrackBar = new System.Windows.Forms.TrackBar();
            this.boilerTempLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boiler = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.waterFlowLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.waterConsumptionLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spiralStateLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.controlStateLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.simulationTimeLabel = new System.Windows.Forms.Label();
            this.startSimulationButton = new System.Windows.Forms.Button();
            this.stateControlCheckBox = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.heatControlCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.energyConsumptionLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timeMultiplierTrackBar = new System.Windows.Forms.TrackBar();
            this.timeMultiplierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showerTempTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinkTempTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinkTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMultiplierTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // showerTrackBar
            // 
            this.showerTrackBar.Location = new System.Drawing.Point(627, 62);
            this.showerTrackBar.Maximum = 30;
            this.showerTrackBar.Name = "showerTrackBar";
            this.showerTrackBar.Size = new System.Drawing.Size(104, 45);
            this.showerTrackBar.TabIndex = 0;
            this.showerTrackBar.ValueChanged += new System.EventHandler(this.showerTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(637, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprcha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(571, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Studena";
            // 
            // showerTempTrackBar
            // 
            this.showerTempTrackBar.Location = new System.Drawing.Point(627, 113);
            this.showerTempTrackBar.Maximum = 100;
            this.showerTempTrackBar.Name = "showerTempTrackBar";
            this.showerTempTrackBar.Size = new System.Drawing.Size(104, 45);
            this.showerTempTrackBar.TabIndex = 3;
            this.showerTempTrackBar.ValueChanged += new System.EventHandler(this.showerTempTrackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(737, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tepla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(737, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tepla";
            // 
            // sinkTempTrackBar
            // 
            this.sinkTempTrackBar.Location = new System.Drawing.Point(627, 288);
            this.sinkTempTrackBar.Maximum = 100;
            this.sinkTempTrackBar.Name = "sinkTempTrackBar";
            this.sinkTempTrackBar.Size = new System.Drawing.Size(104, 45);
            this.sinkTempTrackBar.TabIndex = 8;
            this.sinkTempTrackBar.ValueChanged += new System.EventHandler(this.sinkTempTrackBar_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(571, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Studena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(627, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Umyvadlo";
            // 
            // sinkTrackBar
            // 
            this.sinkTrackBar.Location = new System.Drawing.Point(627, 237);
            this.sinkTrackBar.Maximum = 15;
            this.sinkTrackBar.Name = "sinkTrackBar";
            this.sinkTrackBar.Size = new System.Drawing.Size(104, 45);
            this.sinkTrackBar.TabIndex = 5;
            this.sinkTrackBar.ValueChanged += new System.EventHandler(this.sinkTrackBar_ValueChanged);
            // 
            // boilerTempLabel
            // 
            this.boilerTempLabel.AutoSize = true;
            this.boilerTempLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boilerTempLabel.Location = new System.Drawing.Point(25, 34);
            this.boilerTempLabel.Name = "boilerTempLabel";
            this.boilerTempLabel.Size = new System.Drawing.Size(0, 30);
            this.boilerTempLabel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(28, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Teplota bojleru";
            // 
            // boiler
            // 
            this.boiler.Image = global::Boyler.Properties.Resources.Boiler;
            this.boiler.Location = new System.Drawing.Point(284, 78);
            this.boiler.Name = "boiler";
            this.boiler.Size = new System.Drawing.Size(200, 332);
            this.boiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boiler.TabIndex = 12;
            this.boiler.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(28, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prutok vody";
            // 
            // waterFlowLabel
            // 
            this.waterFlowLabel.AutoSize = true;
            this.waterFlowLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waterFlowLabel.Location = new System.Drawing.Point(25, 94);
            this.waterFlowLabel.Name = "waterFlowLabel";
            this.waterFlowLabel.Size = new System.Drawing.Size(81, 30);
            this.waterFlowLabel.TabIndex = 13;
            this.waterFlowLabel.Text = "0l/min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(28, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Spotrebovana voda";
            // 
            // waterConsumptionLabel
            // 
            this.waterConsumptionLabel.AutoSize = true;
            this.waterConsumptionLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waterConsumptionLabel.Location = new System.Drawing.Point(25, 159);
            this.waterConsumptionLabel.Name = "waterConsumptionLabel";
            this.waterConsumptionLabel.Size = new System.Drawing.Size(32, 30);
            this.waterConsumptionLabel.TabIndex = 15;
            this.waterConsumptionLabel.Text = "0l";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(28, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Stav spiraly";
            // 
            // spiralStateLabel
            // 
            this.spiralStateLabel.AutoSize = true;
            this.spiralStateLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spiralStateLabel.Location = new System.Drawing.Point(25, 273);
            this.spiralStateLabel.Name = "spiralStateLabel";
            this.spiralStateLabel.Size = new System.Drawing.Size(98, 30);
            this.spiralStateLabel.TabIndex = 17;
            this.spiralStateLabel.Text = "vypnuta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(28, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Typ řízení";
            // 
            // controlStateLabel
            // 
            this.controlStateLabel.AutoSize = true;
            this.controlStateLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.controlStateLabel.Location = new System.Drawing.Point(25, 338);
            this.controlStateLabel.Name = "controlStateLabel";
            this.controlStateLabel.Size = new System.Drawing.Size(142, 30);
            this.controlStateLabel.TabIndex = 19;
            this.controlStateLabel.Text = "automaticke";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(315, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Čas od počátku simulace";
            // 
            // simulationTimeLabel
            // 
            this.simulationTimeLabel.AutoSize = true;
            this.simulationTimeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulationTimeLabel.ForeColor = System.Drawing.Color.Red;
            this.simulationTimeLabel.Location = new System.Drawing.Point(346, 34);
            this.simulationTimeLabel.Name = "simulationTimeLabel";
            this.simulationTimeLabel.Size = new System.Drawing.Size(71, 30);
            this.simulationTimeLabel.TabIndex = 21;
            this.simulationTimeLabel.Text = "00:00";
            this.simulationTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.Location = new System.Drawing.Point(328, 436);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(126, 23);
            this.startSimulationButton.TabIndex = 23;
            this.startSimulationButton.Text = "Zapnout simulaci";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // stateControlCheckBox
            // 
            this.stateControlCheckBox.AutoSize = true;
            this.stateControlCheckBox.Location = new System.Drawing.Point(28, 382);
            this.stateControlCheckBox.Name = "stateControlCheckBox";
            this.stateControlCheckBox.Size = new System.Drawing.Size(107, 19);
            this.stateControlCheckBox.TabIndex = 25;
            this.stateControlCheckBox.Text = "Manualni řízení";
            this.stateControlCheckBox.UseVisualStyleBackColor = true;
            this.stateControlCheckBox.CheckedChanged += new System.EventHandler(this.stateControlCheckBox_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // heatControlCheckBox
            // 
            this.heatControlCheckBox.AutoSize = true;
            this.heatControlCheckBox.Location = new System.Drawing.Point(28, 407);
            this.heatControlCheckBox.Name = "heatControlCheckBox";
            this.heatControlCheckBox.Size = new System.Drawing.Size(104, 19);
            this.heatControlCheckBox.TabIndex = 26;
            this.heatControlCheckBox.Text = "Zapnout ohřev";
            this.heatControlCheckBox.UseVisualStyleBackColor = true;
            this.heatControlCheckBox.Visible = false;
            this.heatControlCheckBox.CheckedChanged += new System.EventHandler(this.heatControlCheckBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(30, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Spotrebovana energie";
            // 
            // energyConsumptionLabel
            // 
            this.energyConsumptionLabel.AutoSize = true;
            this.energyConsumptionLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.energyConsumptionLabel.Location = new System.Drawing.Point(27, 215);
            this.energyConsumptionLabel.Name = "energyConsumptionLabel";
            this.energyConsumptionLabel.Size = new System.Drawing.Size(61, 30);
            this.energyConsumptionLabel.TabIndex = 28;
            this.energyConsumptionLabel.Text = "0Wh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(28, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Rychlost simulace";
            // 
            // timeMultiplierTrackBar
            // 
            this.timeMultiplierTrackBar.Location = new System.Drawing.Point(26, 459);
            this.timeMultiplierTrackBar.Maximum = 600;
            this.timeMultiplierTrackBar.Minimum = 1;
            this.timeMultiplierTrackBar.Name = "timeMultiplierTrackBar";
            this.timeMultiplierTrackBar.Size = new System.Drawing.Size(104, 45);
            this.timeMultiplierTrackBar.TabIndex = 32;
            this.timeMultiplierTrackBar.Value = 1;
            this.timeMultiplierTrackBar.Scroll += new System.EventHandler(this.timeMultiplierTrackBar_Scroll);
            // 
            // timeMultiplierLabel
            // 
            this.timeMultiplierLabel.AutoSize = true;
            this.timeMultiplierLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeMultiplierLabel.Location = new System.Drawing.Point(62, 489);
            this.timeMultiplierLabel.Name = "timeMultiplierLabel";
            this.timeMultiplierLabel.Size = new System.Drawing.Size(19, 15);
            this.timeMultiplierLabel.TabIndex = 33;
            this.timeMultiplierLabel.Text = "1x";
            this.timeMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 528);
            this.Controls.Add(this.timeMultiplierLabel);
            this.Controls.Add(this.timeMultiplierTrackBar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.energyConsumptionLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.heatControlCheckBox);
            this.Controls.Add(this.stateControlCheckBox);
            this.Controls.Add(this.startSimulationButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.simulationTimeLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.controlStateLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.spiralStateLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.waterConsumptionLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.waterFlowLabel);
            this.Controls.Add(this.boiler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boilerTempLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinkTempTrackBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sinkTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showerTempTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showerTrackBar);
            this.Name = "Form1";
            this.Text = "Simulace bojleru";
            ((System.ComponentModel.ISupportInitialize)(this.showerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showerTempTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinkTempTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinkTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMultiplierTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar showerTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar showerTempTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar sinkTempTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar sinkTrackBar;
        private System.Windows.Forms.Label boilerTempLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox boiler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label waterFlowLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label waterConsumptionLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label spiralStateLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label controlStateLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label simulationTimeLabel;
        private System.Windows.Forms.Button startSimulationButton;
        private System.Windows.Forms.CheckBox stateControlCheckBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox heatControlCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label energyConsumptionLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar timeMultiplierTrackBar;
        private System.Windows.Forms.Label timeMultiplierLabel;
    }
}
