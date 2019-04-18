namespace Gestion_de_conge.Personnel
{
    partial class Searching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searching));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Stext = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Nserviceradio = new System.Windows.Forms.RadioButton();
            this.Diplomeradio = new System.Windows.Forms.RadioButton();
            this.Prenomradio = new System.Windows.Forms.RadioButton();
            this.NOMradio = new System.Windows.Forms.RadioButton();
            this.CINradion = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Stext
            // 
            this.Stext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stext.Location = new System.Drawing.Point(930, 17);
            this.Stext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stext.Multiline = true;
            this.Stext.Name = "Stext";
            this.Stext.Size = new System.Drawing.Size(218, 39);
            this.Stext.TabIndex = 4;
            this.Stext.TextChanged += new System.EventHandler(this.Stext_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 100);
            this.panel1.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1114, 29);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching personel";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.Stext);
            this.panel2.Controls.Add(this.Nserviceradio);
            this.panel2.Controls.Add(this.Diplomeradio);
            this.panel2.Controls.Add(this.Prenomradio);
            this.panel2.Controls.Add(this.NOMradio);
            this.panel2.Controls.Add(this.CINradion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 72);
            this.panel2.TabIndex = 4;
            // 
            // Nserviceradio
            // 
            this.Nserviceradio.AutoSize = true;
            this.Nserviceradio.Location = new System.Drawing.Point(707, 26);
            this.Nserviceradio.Name = "Nserviceradio";
            this.Nserviceradio.Size = new System.Drawing.Size(151, 24);
            this.Nserviceradio.TabIndex = 3;
            this.Nserviceradio.Text = "NUM_SERVICE";
            this.Nserviceradio.UseVisualStyleBackColor = true;
            // 
            // Diplomeradio
            // 
            this.Diplomeradio.AutoSize = true;
            this.Diplomeradio.Location = new System.Drawing.Point(594, 26);
            this.Diplomeradio.Name = "Diplomeradio";
            this.Diplomeradio.Size = new System.Drawing.Size(106, 24);
            this.Diplomeradio.TabIndex = 3;
            this.Diplomeradio.Text = "DIPLOME";
            this.Diplomeradio.UseVisualStyleBackColor = true;
            // 
            // Prenomradio
            // 
            this.Prenomradio.AutoSize = true;
            this.Prenomradio.Location = new System.Drawing.Point(475, 26);
            this.Prenomradio.Name = "Prenomradio";
            this.Prenomradio.Size = new System.Drawing.Size(103, 24);
            this.Prenomradio.TabIndex = 3;
            this.Prenomradio.Text = "PRENOM";
            this.Prenomradio.UseVisualStyleBackColor = true;
            // 
            // NOMradio
            // 
            this.NOMradio.AutoSize = true;
            this.NOMradio.Location = new System.Drawing.Point(381, 26);
            this.NOMradio.Name = "NOMradio";
            this.NOMradio.Size = new System.Drawing.Size(70, 24);
            this.NOMradio.TabIndex = 3;
            this.NOMradio.Text = "NOM";
            this.NOMradio.UseVisualStyleBackColor = true;
            // 
            // CINradion
            // 
            this.CINradion.AutoSize = true;
            this.CINradion.Location = new System.Drawing.Point(301, 26);
            this.CINradion.Name = "CINradion";
            this.CINradion.Size = new System.Drawing.Size(61, 24);
            this.CINradion.TabIndex = 3;
            this.CINradion.Text = "CIN";
            this.CINradion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search with :";
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv.HeaderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv.Location = new System.Drawing.Point(11, 177);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1160, 537);
            this.dgv.TabIndex = 5;
            // 
            // Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Searching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searching";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Stext;
        private System.Windows.Forms.RadioButton Nserviceradio;
        private System.Windows.Forms.RadioButton Diplomeradio;
        private System.Windows.Forms.RadioButton Prenomradio;
        private System.Windows.Forms.RadioButton NOMradio;
        private System.Windows.Forms.RadioButton CINradion;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}