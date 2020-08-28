namespace CO435_WinFormsAnswer.App07
{
    partial class SimulatorForm
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
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.stepButton = new System.Windows.Forms.Button();
            this.rabbitLabel = new System.Windows.Forms.Label();
            this.foxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldPanel
            // 
            this.fieldPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.fieldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldPanel.Location = new System.Drawing.Point(14, 66);
            this.fieldPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(800, 600);
            this.fieldPanel.TabIndex = 0;
            this.fieldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fieldPanel_Paint);
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(971, 502);
            this.stepButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(97, 59);
            this.stepButton.TabIndex = 1;
            this.stepButton.Text = "Run";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // rabbitLabel
            // 
            this.rabbitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rabbitLabel.Location = new System.Drawing.Point(822, 66);
            this.rabbitLabel.Name = "rabbitLabel";
            this.rabbitLabel.Size = new System.Drawing.Size(163, 32);
            this.rabbitLabel.TabIndex = 3;
            this.rabbitLabel.Text = "Rabbits:";
            // 
            // foxLabel
            // 
            this.foxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foxLabel.Location = new System.Drawing.Point(822, 118);
            this.foxLabel.Name = "foxLabel";
            this.foxLabel.Size = new System.Drawing.Size(163, 32);
            this.foxLabel.TabIndex = 4;
            this.foxLabel.Text = "Foxes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Predator-Prey Simulation";
            // 
            // stepsNumericUpDown
            // 
            this.stepsNumericUpDown.Location = new System.Drawing.Point(861, 525);
            this.stepsNumericUpDown.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.stepsNumericUpDown.Name = "stepsNumericUpDown";
            this.stepsNumericUpDown.Size = new System.Drawing.Size(102, 36);
            this.stepsNumericUpDown.TabIndex = 6;
            this.stepsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stepsNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(871, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Steps";
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 723);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stepsNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foxLabel);
            this.Controls.Add(this.rabbitLabel);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.fieldPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SimulatorForm";
            this.Text = "Derek\'s Rabbits & Foxes Simulation";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SimulatorForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel fieldPanel;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Label rabbitLabel;
        private System.Windows.Forms.Label foxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown stepsNumericUpDown;
        private System.Windows.Forms.Label label2;
    }
}