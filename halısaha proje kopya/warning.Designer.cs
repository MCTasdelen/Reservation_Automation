namespace halısaha_proje_kopya
{
    partial class warning
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ıconButton1
            // 
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ıconButton1.IconColor = System.Drawing.Color.Red;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 60;
            this.ıconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.Location = new System.Drawing.Point(0, 0);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(315, 96);
            this.ıconButton1.TabIndex = 0;
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(315, 96);
            this.Controls.Add(this.ıconButton1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(315, 96);
            this.MinimumSize = new System.Drawing.Size(315, 96);
            this.Name = "warning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "warning";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}