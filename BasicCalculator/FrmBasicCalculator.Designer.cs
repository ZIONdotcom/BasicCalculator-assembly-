namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.computebtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.SystemColors.Desktop;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.ForeColor = System.Drawing.Color.Lime;
            this.number1.Location = new System.Drawing.Point(38, 97);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(272, 22);
            this.number1.TabIndex = 1;
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.SystemColors.MenuText;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.ForeColor = System.Drawing.Color.Lime;
            this.number2.Location = new System.Drawing.Point(38, 176);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(272, 22);
            this.number2.TabIndex = 2;
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.SystemColors.MenuText;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.ForeColor = System.Drawing.Color.Lime;
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cb.Location = new System.Drawing.Point(111, 134);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 24);
            this.cb.TabIndex = 3;
            // 
            // computebtn
            // 
            this.computebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.computebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computebtn.ForeColor = System.Drawing.Color.Lime;
            this.computebtn.Location = new System.Drawing.Point(136, 331);
            this.computebtn.Name = "computebtn";
            this.computebtn.Size = new System.Drawing.Size(81, 28);
            this.computebtn.TabIndex = 4;
            this.computebtn.Text = "Compute";
            this.computebtn.UseVisualStyleBackColor = false;
            this.computebtn.Click += new System.EventHandler(this.computebtn_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Lime;
            this.output.Location = new System.Drawing.Point(29, 220);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(290, 93);
            this.output.TabIndex = 5;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::BasicCalculator.Properties.Resources.istockphoto_865457032_612x612;
            this.ClientSize = new System.Drawing.Size(351, 394);
            this.Controls.Add(this.output);
            this.Controls.Add(this.computebtn);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button computebtn;
        private System.Windows.Forms.TextBox output;
    }
}