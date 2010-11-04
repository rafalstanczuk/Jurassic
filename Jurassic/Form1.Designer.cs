namespace Jurassic
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_xmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_wyswietlregion = new System.Windows.Forms.Button();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.data_mapa = new System.Windows.Forms.DataGridView();
            this.data_tabelka = new System.Windows.Forms.DataGridViewImageColumn();
            this.label_xmax = new System.Windows.Forms.Label();
            this.label_ymax = new System.Windows.Forms.Label();
            this.label_ymin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mapa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(529, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(181, 389);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label_ymax);
            this.tabPage1.Controls.Add(this.label_ymin);
            this.tabPage1.Controls.Add(this.label_xmax);
            this.tabPage1.Controls.Add(this.label_xmin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_wyswietlregion);
            this.tabPage1.Controls.Add(this.label_Y);
            this.tabPage1.Controls.Add(this.label_X);
            this.tabPage1.Controls.Add(this.textBox_Y);
            this.tabPage1.Controls.Add(this.textBox_X);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(173, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Po współrzędnych";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_xmin
            // 
            this.label_xmin.AutoSize = true;
            this.label_xmin.Location = new System.Drawing.Point(54, 155);
            this.label_xmin.Name = "label_xmin";
            this.label_xmin.Size = new System.Drawing.Size(0, 13);
            this.label_xmin.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "[m]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "[m]";
            // 
            // button_wyswietlregion
            // 
            this.button_wyswietlregion.Location = new System.Drawing.Point(6, 89);
            this.button_wyswietlregion.Name = "button_wyswietlregion";
            this.button_wyswietlregion.Size = new System.Drawing.Size(100, 49);
            this.button_wyswietlregion.TabIndex = 9;
            this.button_wyswietlregion.Text = "Wyswietl";
            this.button_wyswietlregion.UseVisualStyleBackColor = true;
            this.button_wyswietlregion.Click += new System.EventHandler(this.button_wyswietlregion_Click);
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(3, 45);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(14, 13);
            this.label_Y.TabIndex = 8;
            this.label_Y.Text = "Y";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(3, 6);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(14, 13);
            this.label_X.TabIndex = 7;
            this.label_X.Text = "X";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(6, 61);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y.TabIndex = 6;
            this.textBox_Y.Text = "336711";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(6, 22);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 20);
            this.textBox_X.TabIndex = 5;
            this.textBox_X.Text = "497570";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(173, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // data_mapa
            // 
            this.data_mapa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_mapa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_mapa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_mapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_mapa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_tabelka});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_mapa.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_mapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_mapa.Location = new System.Drawing.Point(0, 0);
            this.data_mapa.Margin = new System.Windows.Forms.Padding(0);
            this.data_mapa.Name = "data_mapa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_mapa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_mapa.RowHeadersWidth = 50;
            this.data_mapa.Size = new System.Drawing.Size(529, 389);
            this.data_mapa.TabIndex = 2;
            this.data_mapa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_mapa_CellContentClick);
            // 
            // data_tabelka
            // 
            this.data_tabelka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.data_tabelka.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_tabelka.HeaderText = "497570";
            this.data_tabelka.MinimumWidth = 2;
            this.data_tabelka.Name = "data_tabelka";
            this.data_tabelka.Width = 27;
            // 
            // label_xmax
            // 
            this.label_xmax.AutoSize = true;
            this.label_xmax.Location = new System.Drawing.Point(54, 180);
            this.label_xmax.Name = "label_xmax";
            this.label_xmax.Size = new System.Drawing.Size(0, 13);
            this.label_xmax.TabIndex = 13;
            // 
            // label_ymax
            // 
            this.label_ymax.AutoSize = true;
            this.label_ymax.Location = new System.Drawing.Point(57, 247);
            this.label_ymax.Name = "label_ymax";
            this.label_ymax.Size = new System.Drawing.Size(0, 13);
            this.label_ymax.TabIndex = 15;
            // 
            // label_ymin
            // 
            this.label_ymin.AutoSize = true;
            this.label_ymin.Location = new System.Drawing.Point(57, 219);
            this.label_ymin.Name = "label_ymin";
            this.label_ymin.Size = new System.Drawing.Size(0, 13);
            this.label_ymin.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Xmin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Xmax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ymin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ymax";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 389);
            this.Controls.Add(this.data_mapa);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Jurassic Region by Stan ;)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_wyswietlregion;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_mapa;
        private System.Windows.Forms.DataGridViewImageColumn data_tabelka;
        private System.Windows.Forms.Label label_xmin;
        private System.Windows.Forms.Label label_xmax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ymax;
        private System.Windows.Forms.Label label_ymin;



    }
}

