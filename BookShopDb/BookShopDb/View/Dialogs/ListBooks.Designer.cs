namespace BookShopDb.View.Dialogs
{
    partial class ListBooks
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
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mufaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eladottdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiadasidat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldalszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ar,
            this.cim,
            this.mufaj,
            this.eladottdb,
            this.szerzo,
            this.kiadasidat,
            this.oldalszam});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // ar
            // 
            this.ar.HeaderText = "Ár";
            this.ar.Name = "ar";
            // 
            // cim
            // 
            this.cim.HeaderText = "Cím";
            this.cim.Name = "cim";
            // 
            // mufaj
            // 
            this.mufaj.HeaderText = "Műfaj";
            this.mufaj.Name = "mufaj";
            // 
            // eladottdb
            // 
            this.eladottdb.HeaderText = "Eladott db";
            this.eladottdb.Name = "eladottdb";
            // 
            // szerzo
            // 
            this.szerzo.HeaderText = "Szerző";
            this.szerzo.Name = "szerzo";
            // 
            // kiadasidat
            // 
            this.kiadasidat.HeaderText = "Kiadási dátum";
            this.kiadasidat.Name = "kiadasidat";
            // 
            // oldalszam
            // 
            this.oldalszam.HeaderText = "Oldalszám";
            this.oldalszam.Name = "oldalszam";
            // 
            // ListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListBooks";
            this.Text = "Könyvek listázása";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
        private System.Windows.Forms.DataGridViewTextBoxColumn mufaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn eladottdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiadasidat;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldalszam;
    }
}