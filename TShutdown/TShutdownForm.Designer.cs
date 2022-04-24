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
            this.ShutdownBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.TimerShutdownBtn = new System.Windows.Forms.Button();
            this.TimerField = new System.Windows.Forms.TextBox();
            this.TimerRestartBtn = new System.Windows.Forms.Button();
            this.ErrorTimerText = new System.Windows.Forms.Label();
            this.CancelTimer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShutdownBtn
            // 
            this.ShutdownBtn.Location = new System.Drawing.Point(42, 23);
            this.ShutdownBtn.Name = "ShutdownBtn";
            this.ShutdownBtn.Size = new System.Drawing.Size(81, 78);
            this.ShutdownBtn.TabIndex = 0;
            this.ShutdownBtn.Text = "Shutdown";
            this.ShutdownBtn.UseVisualStyleBackColor = true;
            this.ShutdownBtn.Click += new System.EventHandler(this.ShutdownBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.Location = new System.Drawing.Point(192, 23);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(81, 78);
            this.RestartBtn.TabIndex = 1;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // TimerShutdownBtn
            // 
            this.TimerShutdownBtn.Location = new System.Drawing.Point(42, 224);
            this.TimerShutdownBtn.Name = "TimerShutdownBtn";
            this.TimerShutdownBtn.Size = new System.Drawing.Size(164, 78);
            this.TimerShutdownBtn.TabIndex = 2;
            this.TimerShutdownBtn.Text = "Set shutdown timer";
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
            this.TimerRestartBtn.Location = new System.Drawing.Point(445, 224);
            this.TimerRestartBtn.Name = "TimerRestartBtn";
            this.TimerRestartBtn.Size = new System.Drawing.Size(164, 78);
            this.TimerRestartBtn.TabIndex = 6;
            this.TimerRestartBtn.Text = "Set restart timer";
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
            // CancelTimer
            // 
            this.CancelTimer.Location = new System.Drawing.Point(332, 23);
            this.CancelTimer.Name = "CancelTimer";
            this.CancelTimer.Size = new System.Drawing.Size(81, 78);
            this.CancelTimer.TabIndex = 8;
            this.CancelTimer.Text = "Timer";
            this.CancelTimer.UseVisualStyleBackColor = true;
            this.CancelTimer.Click += new System.EventHandler(this.CancelTimer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 78);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelTimerBtnClick);
            // 
            // TShutdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(658, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CancelTimer);
            this.Controls.Add(this.ErrorTimerText);
            this.Controls.Add(this.TimerRestartBtn);
            this.Controls.Add(this.TimerField);
            this.Controls.Add(this.TimerShutdownBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.ShutdownBtn);
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
        private Button CancelTimer;
        private Button button2;
    }
}