namespace TheClientLabAPI2
{
    partial class Form1
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
            grd1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            textduration = new TextBox();
            comtopicid = new ComboBox();
            btnadd = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grd1).BeginInit();
            SuspendLayout();
            // 
            // grd1
            // 
            grd1.BackgroundColor = Color.FromArgb(192, 192, 255);
            grd1.BorderStyle = BorderStyle.Fixed3D;
            grd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd1.GridColor = Color.Red;
            grd1.Location = new Point(12, 245);
            grd1.Name = "grd1";
            grd1.RowTemplate.Height = 25;
            grd1.Size = new Size(624, 193);
            grd1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 62);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Crs_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 99);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 131);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Topic id";
            // 
            // txtid
            // 
            txtid.Location = new Point(157, 20);
            txtid.Name = "txtid";
            txtid.Size = new Size(364, 23);
            txtid.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.Location = new Point(157, 62);
            txtname.Name = "txtname";
            txtname.Size = new Size(364, 23);
            txtname.TabIndex = 6;
            // 
            // textduration
            // 
            textduration.Location = new Point(157, 99);
            textduration.Name = "textduration";
            textduration.Size = new Size(364, 23);
            textduration.TabIndex = 7;
            // 
            // comtopicid
            // 
            comtopicid.FormattingEnabled = true;
            comtopicid.Location = new Point(159, 141);
            comtopicid.Name = "comtopicid";
            comtopicid.Size = new Size(362, 23);
            comtopicid.TabIndex = 8;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(128, 128, 255);
            btnadd.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnadd.ForeColor = SystemColors.ControlLightLight;
            btnadd.Location = new Point(129, 186);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(128, 42);
            btnadd.TabIndex = 9;
            btnadd.Text = "AddCourse";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(192, 0, 0);
            btndelete.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.ForeColor = SystemColors.ControlLightLight;
            btndelete.Location = new Point(377, 186);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(128, 42);
            btndelete.TabIndex = 10;
            btndelete.Text = "DeleteCourse";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(648, 450);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Controls.Add(comtopicid);
            Controls.Add(textduration);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grd1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox textduration;
        private ComboBox comtopicid;
        private Button btnadd;
        private Button btndelete;
    }
}