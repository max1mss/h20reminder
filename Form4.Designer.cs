namespace H2Oreminder
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sedentaryRadioButton = new System.Windows.Forms.RadioButton();
            this.moderatelyActiveRadioButton = new System.Windows.Forms.RadioButton();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.veryActiveRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.waterIntakeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vidējā aktivitāte nedēļā";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Water consumption calculator";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Location = new System.Drawing.Point(81, 133);
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.weightNumericUpDown.TabIndex = 6;
            this.weightNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sedentaryRadioButton
            // 
            this.sedentaryRadioButton.AutoSize = true;
            this.sedentaryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedentaryRadioButton.Location = new System.Drawing.Point(25, 280);
            this.sedentaryRadioButton.Name = "sedentaryRadioButton";
            this.sedentaryRadioButton.Size = new System.Drawing.Size(159, 22);
            this.sedentaryRadioButton.TabIndex = 11;
            this.sedentaryRadioButton.TabStop = true;
            this.sedentaryRadioButton.Text = "pasīvais dzīvesveids";
            this.sedentaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // moderatelyActiveRadioButton
            // 
            this.moderatelyActiveRadioButton.AutoSize = true;
            this.moderatelyActiveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moderatelyActiveRadioButton.Location = new System.Drawing.Point(207, 280);
            this.moderatelyActiveRadioButton.Name = "moderatelyActiveRadioButton";
            this.moderatelyActiveRadioButton.Size = new System.Drawing.Size(100, 22);
            this.moderatelyActiveRadioButton.TabIndex = 12;
            this.moderatelyActiveRadioButton.TabStop = true;
            this.moderatelyActiveRadioButton.Text = "vidēji aktīvs";
            this.moderatelyActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeRadioButton.Location = new System.Drawing.Point(25, 325);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(64, 22);
            this.activeRadioButton.TabIndex = 13;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "aktīvs";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            // 
            // veryActiveRadioButton
            // 
            this.veryActiveRadioButton.AutoSize = true;
            this.veryActiveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veryActiveRadioButton.Location = new System.Drawing.Point(207, 325);
            this.veryActiveRadioButton.Name = "veryActiveRadioButton";
            this.veryActiveRadioButton.Size = new System.Drawing.Size(87, 22);
            this.veryActiveRadioButton.TabIndex = 14;
            this.veryActiveRadioButton.TabStop = true;
            this.veryActiveRadioButton.Text = "ļoti aktīvs";
            this.veryActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(112, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aprēķināt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // waterIntakeLabel
            // 
            this.waterIntakeLabel.AutoSize = true;
            this.waterIntakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterIntakeLabel.Location = new System.Drawing.Point(68, 452);
            this.waterIntakeLabel.Name = "waterIntakeLabel";
            this.waterIntakeLabel.Size = new System.Drawing.Size(0, 18);
            this.waterIntakeLabel.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Location = new System.Drawing.Point(112, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Iestatīt atgādinājumu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(335, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.waterIntakeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.veryActiveRadioButton);
            this.Controls.Add(this.activeRadioButton);
            this.Controls.Add(this.moderatelyActiveRadioButton);
            this.Controls.Add(this.sedentaryRadioButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton sedentaryRadioButton;
        private System.Windows.Forms.RadioButton moderatelyActiveRadioButton;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.RadioButton veryActiveRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label waterIntakeLabel;
        private System.Windows.Forms.Button button2;
    }
}