
namespace Cronometro
{
    partial class Cronometro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cronometro));
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMiliseconds = new System.Windows.Forms.TextBox();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.Dots = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMinutes
            // 
            this.txtMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinutes.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutes.CausesValidation = false;
            this.txtMinutes.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinutes.ForeColor = System.Drawing.Color.Red;
            this.txtMinutes.Location = new System.Drawing.Point(171, 94);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(159, 125);
            this.txtMinutes.TabIndex = 0;
            this.txtMinutes.Text = "00";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeconds.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeconds.CausesValidation = false;
            this.txtSeconds.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSeconds.ForeColor = System.Drawing.Color.Red;
            this.txtSeconds.Location = new System.Drawing.Point(350, 93);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.ReadOnly = true;
            this.txtSeconds.Size = new System.Drawing.Size(160, 125);
            this.txtSeconds.TabIndex = 1;
            this.txtSeconds.Text = "00";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMiliseconds
            // 
            this.txtMiliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiliseconds.BackColor = System.Drawing.Color.Black;
            this.txtMiliseconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiliseconds.CausesValidation = false;
            this.txtMiliseconds.Font = new System.Drawing.Font("Segoe UI Light", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMiliseconds.ForeColor = System.Drawing.Color.Red;
            this.txtMiliseconds.Location = new System.Drawing.Point(534, 93);
            this.txtMiliseconds.Name = "txtMiliseconds";
            this.txtMiliseconds.ReadOnly = true;
            this.txtMiliseconds.Size = new System.Drawing.Size(159, 125);
            this.txtMiliseconds.TabIndex = 2;
            this.txtMiliseconds.Text = "000";
            this.txtMiliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(176, 33);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 30);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Iniciar";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(395, 33);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(96, 31);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Pausar";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Dots
            // 
            this.Dots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dots.BackColor = System.Drawing.Color.Transparent;
            this.Dots.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dots.Location = new System.Drawing.Point(350, 55);
            this.Dots.Name = "Dots";
            this.Dots.Size = new System.Drawing.Size(39, 78);
            this.Dots.TabIndex = 5;
            this.Dots.Text = ":";
            this.Dots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(583, 33);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 31);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reiniciar";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 328);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.txtMiliseconds);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.Dots);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cronometro";
            this.Text = "Cronometro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMiliseconds;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label Dots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
    }
}

