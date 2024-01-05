namespace _23пр
{
    partial class Colors
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
            this.lb_red = new System.Windows.Forms.Label();
            this.lb_green = new System.Windows.Forms.Label();
            this.ln_blue = new System.Windows.Forms.Label();
            this.red_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.green_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.blue_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.red_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.green_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blue_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.picResultColor = new System.Windows.Forms.PictureBox();
            this.other_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_red
            // 
            this.lb_red.AutoSize = true;
            this.lb_red.Location = new System.Drawing.Point(45, 45);
            this.lb_red.Name = "lb_red";
            this.lb_red.Size = new System.Drawing.Size(27, 13);
            this.lb_red.TabIndex = 0;
            this.lb_red.Text = "Red";
            // 
            // lb_green
            // 
            this.lb_green.AutoSize = true;
            this.lb_green.Location = new System.Drawing.Point(45, 96);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(36, 13);
            this.lb_green.TabIndex = 1;
            this.lb_green.Text = "Green";
            // 
            // ln_blue
            // 
            this.ln_blue.AutoSize = true;
            this.ln_blue.Location = new System.Drawing.Point(45, 143);
            this.ln_blue.Name = "ln_blue";
            this.ln_blue.Size = new System.Drawing.Size(28, 13);
            this.ln_blue.TabIndex = 2;
            this.ln_blue.Text = "Blue";
            // 
            // red_hScrollBar
            // 
            this.red_hScrollBar.LargeChange = 1;
            this.red_hScrollBar.Location = new System.Drawing.Point(111, 45);
            this.red_hScrollBar.Maximum = 255;
            this.red_hScrollBar.Name = "red_hScrollBar";
            this.red_hScrollBar.Size = new System.Drawing.Size(170, 17);
            this.red_hScrollBar.TabIndex = 3;
            this.red_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.red_hScrollBar_Scroll);
            // 
            // green_hScrollBar
            // 
            this.green_hScrollBar.LargeChange = 1;
            this.green_hScrollBar.Location = new System.Drawing.Point(111, 96);
            this.green_hScrollBar.Maximum = 255;
            this.green_hScrollBar.Name = "green_hScrollBar";
            this.green_hScrollBar.Size = new System.Drawing.Size(170, 17);
            this.green_hScrollBar.TabIndex = 4;
            this.green_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.green_hScrollBar_Scroll);
            // 
            // blue_hScrollBar
            // 
            this.blue_hScrollBar.LargeChange = 1;
            this.blue_hScrollBar.Location = new System.Drawing.Point(111, 143);
            this.blue_hScrollBar.Maximum = 255;
            this.blue_hScrollBar.Name = "blue_hScrollBar";
            this.blue_hScrollBar.Size = new System.Drawing.Size(170, 17);
            this.blue_hScrollBar.TabIndex = 5;
            this.blue_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blue_hScrollBar_Scroll);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(48, 185);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 6;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(164, 185);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // red_numericUpDown
            // 
            this.red_numericUpDown.Location = new System.Drawing.Point(334, 45);
            this.red_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.red_numericUpDown.Name = "red_numericUpDown";
            this.red_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.red_numericUpDown.TabIndex = 8;
            this.red_numericUpDown.ValueChanged += new System.EventHandler(this.red_numericUpDown_ValueChanged);
            // 
            // green_numericUpDown
            // 
            this.green_numericUpDown.Location = new System.Drawing.Point(334, 96);
            this.green_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.green_numericUpDown.Name = "green_numericUpDown";
            this.green_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.green_numericUpDown.TabIndex = 9;
            this.green_numericUpDown.ValueChanged += new System.EventHandler(this.green_numericUpDown_ValueChanged);
            // 
            // blue_numericUpDown
            // 
            this.blue_numericUpDown.Location = new System.Drawing.Point(334, 143);
            this.blue_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blue_numericUpDown.Name = "blue_numericUpDown";
            this.blue_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.blue_numericUpDown.TabIndex = 10;
            this.blue_numericUpDown.ValueChanged += new System.EventHandler(this.blue_numericUpDown_ValueChanged);
            // 
            // picResultColor
            // 
            this.picResultColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picResultColor.Location = new System.Drawing.Point(503, 45);
            this.picResultColor.Name = "picResultColor";
            this.picResultColor.Size = new System.Drawing.Size(139, 118);
            this.picResultColor.TabIndex = 11;
            this.picResultColor.TabStop = false;
            // 
            // other_btn
            // 
            this.other_btn.Location = new System.Drawing.Point(536, 185);
            this.other_btn.Name = "other_btn";
            this.other_btn.Size = new System.Drawing.Size(75, 23);
            this.other_btn.TabIndex = 12;
            this.other_btn.Text = "Other colors";
            this.other_btn.UseVisualStyleBackColor = true;
            this.other_btn.Click += new System.EventHandler(this.other_btn_Click);
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 228);
            this.Controls.Add(this.other_btn);
            this.Controls.Add(this.picResultColor);
            this.Controls.Add(this.blue_numericUpDown);
            this.Controls.Add(this.green_numericUpDown);
            this.Controls.Add(this.red_numericUpDown);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.blue_hScrollBar);
            this.Controls.Add(this.green_hScrollBar);
            this.Controls.Add(this.red_hScrollBar);
            this.Controls.Add(this.ln_blue);
            this.Controls.Add(this.lb_green);
            this.Controls.Add(this.lb_red);
            this.Name = "Colors";
            this.Text = "Colors";
            
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_red;
        private System.Windows.Forms.Label lb_green;
        private System.Windows.Forms.Label ln_blue;
        private System.Windows.Forms.HScrollBar red_hScrollBar;
        private System.Windows.Forms.HScrollBar green_hScrollBar;
        private System.Windows.Forms.HScrollBar blue_hScrollBar;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.NumericUpDown red_numericUpDown;
        private System.Windows.Forms.NumericUpDown green_numericUpDown;
        private System.Windows.Forms.NumericUpDown blue_numericUpDown;
        private System.Windows.Forms.PictureBox picResultColor;
        private System.Windows.Forms.Button other_btn;
    }
}