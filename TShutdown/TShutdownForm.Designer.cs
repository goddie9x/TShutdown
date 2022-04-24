namespace TShutdown
{
    partial class TShutdownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TShutdownForm));
            this.ShutdownBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.TimerShutdownBtn = new System.Windows.Forms.Button();
            this.TimerField = new System.Windows.Forms.TextBox();
            this.TimerRestartBtn = new System.Windows.Forms.Button();
            this.ErrorTimerText = new System.Windows.Forms.Label();
            this.SetTimerBtn = new System.Windows.Forms.Button();
            this.CancelScheduleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShutdownBtn
            // 
            this.ShutdownBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShutdownBtn.FlatAppearance.BorderSize = 0;
            this.ShutdownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShutdownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShutdownBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShutdownBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShutdownBtn.Image")));
            this.ShutdownBtn.Location = new System.Drawing.Point(42, 23);
            this.ShutdownBtn.Name = "ShutdownBtn";
            this.ShutdownBtn.Size = new System.Drawing.Size(82, 78);
            this.ShutdownBtn.TabIndex = 0;
            this.ShutdownBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ShutdownBtn.UseVisualStyleBackColor = true;
            this.ShutdownBtn.Click += new System.EventHandler(this.ShutdownBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RestartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RestartBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RestartBtn.FlatAppearance.BorderSize = 0;
            this.RestartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RestartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartBtn.ForeColor = System.Drawing.Color.Transparent;
            this.RestartBtn.Image = ((System.Drawing.Image)(resources.GetObject("RestartBtn.Image")));
            this.RestartBtn.Location = new System.Drawing.Point(209, 23);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(77, 78);
            this.RestartBtn.TabIndex = 1;
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // TimerShutdownBtn
            // 
            this.TimerShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimerShutdownBtn.Image = ((System.Drawing.Image)(resources.GetObject("TimerShutdownBtn.Image")));
            this.TimerShutdownBtn.Location = new System.Drawing.Point(42, 224);
            this.TimerShutdownBtn.Name = "TimerShutdownBtn";
            this.TimerShutdownBtn.Size = new System.Drawing.Size(227, 78);
            this.TimerShutdownBtn.TabIndex = 2;
            this.TimerShutdownBtn.UseVisualStyleBackColor = true;
            this.TimerShutdownBtn.Visible = false;
            this.TimerShutdownBtn.Click += new System.EventHandler(this.TimerShutdownBtn_Click);
            // 
            // TimerField
            // 
            this.TimerField.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerField.Location = new System.Drawing.Point(42, 138);
            this.TimerField.Name = "TimerField";
            this.TimerField.PlaceholderText = "Input timer (for type: hh:mm:ss)";
            this.TimerField.Size = new System.Drawing.Size(567, 43);
            this.TimerField.TabIndex = 5;
            this.TimerField.Visible = false;
            this.TimerField.TextChanged += new System.EventHandler(this.TimerField_TextChanged);
            // 
            // TimerRestartBtn
            // 
            this.TimerRestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimerRestartBtn.Image = ((System.Drawing.Image)(resources.GetObject("TimerRestartBtn.Image")));
            this.TimerRestartBtn.Location = new System.Drawing.Point(387, 224);
            this.TimerRestartBtn.Name = "TimerRestartBtn";
            this.TimerRestartBtn.Size = new System.Drawing.Size(222, 78);
            this.TimerRestartBtn.TabIndex = 6;
            this.TimerRestartBtn.UseVisualStyleBackColor = true;
            this.TimerRestartBtn.Visible = false;
            this.TimerRestartBtn.Click += new System.EventHandler(this.TimerRestartBtn_Click);
            // 
            // ErrorTimerText
            // 
            this.ErrorTimerText.AutoSize = true;
            this.ErrorTimerText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorTimerText.ForeColor = System.Drawing.Color.Red;
            this.ErrorTimerText.Location = new System.Drawing.Point(42, 184);
            this.ErrorTimerText.Name = "ErrorTimerText";
            this.ErrorTimerText.Size = new System.Drawing.Size(221, 28);
            this.ErrorTimerText.TabIndex = 7;
            this.ErrorTimerText.Text = "Timer type not corected";
            this.ErrorTimerText.Visible = false;
            // 
            // SetTimerBtn
            // 
            this.SetTimerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SetTimerBtn.FlatAppearance.BorderSize = 0;
            this.SetTimerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SetTimerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SetTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetTimerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SetTimerBtn.Image = ((System.Drawing.Image)(resources.GetObject("SetTimerBtn.Image")));
            this.SetTimerBtn.Location = new System.Drawing.Point(366, 23);
            this.SetTimerBtn.Name = "SetTimerBtn";
            this.SetTimerBtn.Size = new System.Drawing.Size(81, 78);
            this.SetTimerBtn.TabIndex = 8;
            this.SetTimerBtn.UseVisualStyleBackColor = true;
            this.SetTimerBtn.Click += new System.EventHandler(this.CancelTimer_Click);
            // 
            // CancelScheduleBtn
            // 
            this.CancelScheduleBtn.FlatAppearance.BorderSize = 0;
            this.CancelScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelScheduleBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CancelScheduleBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelScheduleBtn.Image")));
            this.CancelScheduleBtn.Location = new System.Drawing.Point(527, 23);
            this.CancelScheduleBtn.Name = "CancelScheduleBtn";
            this.CancelScheduleBtn.Size = new System.Drawing.Size(82, 78);
            this.CancelScheduleBtn.TabIndex = 9;
            this.CancelScheduleBtn.UseVisualStyleBackColor = true;
            this.CancelScheduleBtn.Click += new System.EventHandler(this.CancelTimerBtnClick);
            // 
            // TShutdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(658, 335);
            this.Controls.Add(this.CancelScheduleBtn);
            this.Controls.Add(this.SetTimerBtn);
            this.Controls.Add(this.ErrorTimerText);
            this.Controls.Add(this.TimerRestartBtn);
            this.Controls.Add(this.TimerField);
            this.Controls.Add(this.TimerShutdownBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.ShutdownBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TShutdownForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TShutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ShutdownBtn;
        private Button RestartBtn;
        private Button TimerShutdownBtn;
        private TextBox TimerField;
        private Button TimerRestartBtn;
        private Label ErrorTimerText;
        private Button SetTimerBtn;
        private Button CancelScheduleBtn;
    }
}