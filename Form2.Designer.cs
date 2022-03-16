
namespace Serial_port
{
    partial class Form2
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
            this.dGridVMySQL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGridVMySQL)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridVMySQL
            // 
            this.dGridVMySQL.AllowUserToAddRows = false;
            this.dGridVMySQL.AllowUserToDeleteRows = false;
            this.dGridVMySQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridVMySQL.Location = new System.Drawing.Point(5, 12);
            this.dGridVMySQL.Name = "dGridVMySQL";
            this.dGridVMySQL.ReadOnly = true;
            this.dGridVMySQL.Size = new System.Drawing.Size(260, 379);
            this.dGridVMySQL.TabIndex = 0;
            this.dGridVMySQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 403);
            this.Controls.Add(this.dGridVMySQL);
            this.Name = "Form2";
            this.Text = "База данных MySQL";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridVMySQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridVMySQL;
    }
}