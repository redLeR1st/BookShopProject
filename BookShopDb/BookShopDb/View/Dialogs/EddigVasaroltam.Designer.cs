namespace BookShopDb.View.Dialogs
{
    partial class EddigVasaroltam
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.KonyvdataGridView1 = new System.Windows.Forms.DataGridView();
			this.FilmdataGridView2 = new System.Windows.Forms.DataGridView();
			this.ZenedataGridView3 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.KonyvdataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FilmdataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ZenedataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.KonyvdataGridView1);
			this.panel1.Location = new System.Drawing.Point(12, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(286, 321);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.FilmdataGridView2);
			this.panel2.Location = new System.Drawing.Point(304, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(286, 321);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.ZenedataGridView3);
			this.panel3.Location = new System.Drawing.Point(596, 51);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(286, 321);
			this.panel3.TabIndex = 2;
			// 
			// KonyvdataGridView1
			// 
			this.KonyvdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.KonyvdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.KonyvdataGridView1.Location = new System.Drawing.Point(0, 0);
			this.KonyvdataGridView1.Name = "KonyvdataGridView1";
			this.KonyvdataGridView1.Size = new System.Drawing.Size(286, 321);
			this.KonyvdataGridView1.TabIndex = 0;
			this.KonyvdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KonyvdataGridView1_CellContentClick);
			// 
			// FilmdataGridView2
			// 
			this.FilmdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FilmdataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilmdataGridView2.Location = new System.Drawing.Point(0, 0);
			this.FilmdataGridView2.Name = "FilmdataGridView2";
			this.FilmdataGridView2.Size = new System.Drawing.Size(286, 321);
			this.FilmdataGridView2.TabIndex = 0;
			// 
			// ZenedataGridView3
			// 
			this.ZenedataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ZenedataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ZenedataGridView3.Location = new System.Drawing.Point(0, 0);
			this.ZenedataGridView3.Name = "ZenedataGridView3";
			this.ZenedataGridView3.Size = new System.Drawing.Size(286, 321);
			this.ZenedataGridView3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(119, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Könyv";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(411, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Film";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(703, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Zene";
			// 
			// EddigVasaroltam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 401);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "EddigVasaroltam";
			this.Text = "Eddig vásároltam";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.KonyvdataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FilmdataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ZenedataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView KonyvdataGridView1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView FilmdataGridView2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView ZenedataGridView3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}