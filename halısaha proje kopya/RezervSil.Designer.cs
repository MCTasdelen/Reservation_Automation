
namespace halısaha_proje_kopya
{
    partial class RezervSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(614, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // delButton
            // 
            this.delButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delButton.Location = new System.Drawing.Point(370, 432);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 40);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "Sil";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Location = new System.Drawing.Point(161, 432);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 40);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(638, 557);
            this.panelForm.TabIndex = 3;
            // 
            // RezervSil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(638, 557);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(638, 557);
            this.MinimumSize = new System.Drawing.Size(638, 557);
            this.Name = "RezervSil";
            this.Text = "RezervSil";
            this.Load += new System.EventHandler(this.RezervSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panelForm;
    }
}