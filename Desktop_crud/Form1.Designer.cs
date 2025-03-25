namespace Desktop_crud
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
            System.Windows.Forms.Button btnCLEAR;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtENO = new System.Windows.Forms.TextBox();
            this.txtENAME = new System.Windows.Forms.TextBox();
            this.txtJOB = new System.Windows.Forms.TextBox();
            this.txtSALARY = new System.Windows.Forms.TextBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnget = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.btnSHOWALL = new System.Windows.Forms.Button();
            this.btnCLOSE = new System.Windows.Forms.Button();
            btnCLEAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCLEAR
            // 
            btnCLEAR.Location = new System.Drawing.Point(652, 396);
            btnCLEAR.Name = "btnCLEAR";
            btnCLEAR.Size = new System.Drawing.Size(75, 23);
            btnCLEAR.TabIndex = 17;
            btnCLEAR.Text = "CLEAR";
            btnCLEAR.UseVisualStyleBackColor = true;
            btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "JOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // txtENO
            // 
            this.txtENO.Location = new System.Drawing.Point(227, 117);
            this.txtENO.Name = "txtENO";
            this.txtENO.Size = new System.Drawing.Size(100, 22);
            this.txtENO.TabIndex = 5;
            // 
            // txtENAME
            // 
            this.txtENAME.Location = new System.Drawing.Point(227, 173);
            this.txtENAME.Name = "txtENAME";
            this.txtENAME.Size = new System.Drawing.Size(100, 22);
            this.txtENAME.TabIndex = 6;
            // 
            // txtJOB
            // 
            this.txtJOB.Location = new System.Drawing.Point(227, 215);
            this.txtJOB.Name = "txtJOB";
            this.txtJOB.Size = new System.Drawing.Size(100, 22);
            this.txtJOB.TabIndex = 7;
            // 
            // txtSALARY
            // 
            this.txtSALARY.Location = new System.Drawing.Point(227, 258);
            this.txtSALARY.Name = "txtSALARY";
            this.txtSALARY.Size = new System.Drawing.Size(100, 22);
            this.txtSALARY.TabIndex = 8;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(227, 313);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(18, 17);
            this.chkStatus.TabIndex = 9;
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(96, 397);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 10;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(342, 117);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(40, 23);
            this.btnget.TabIndex = 11;
            this.btnget.Text = "Get Details";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(212, 397);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(332, 397);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Location = new System.Drawing.Point(432, 108);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.RowHeadersWidth = 51;
            this.dtgrid.RowTemplate.Height = 24;
            this.dtgrid.Size = new System.Drawing.Size(728, 233);
            this.dtgrid.TabIndex = 14;
            this.dtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_CellContentClick);
            // 
            // btnSHOWALL
            // 
            this.btnSHOWALL.Location = new System.Drawing.Point(447, 396);
            this.btnSHOWALL.Name = "btnSHOWALL";
            this.btnSHOWALL.Size = new System.Drawing.Size(84, 23);
            this.btnSHOWALL.TabIndex = 15;
            this.btnSHOWALL.Text = "SHOWALL";
            this.btnSHOWALL.UseVisualStyleBackColor = true;
            this.btnSHOWALL.Click += new System.EventHandler(this.btnSHOWALL_Click);
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(551, 396);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(75, 23);
            this.btnCLOSE.TabIndex = 16;
            this.btnCLOSE.Text = "CLOSE";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 702);
            this.Controls.Add(btnCLEAR);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.btnSHOWALL);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnget);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtSALARY);
            this.Controls.Add(this.txtJOB);
            this.Controls.Add(this.txtENAME);
            this.Controls.Add(this.txtENO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtENO;
        private System.Windows.Forms.TextBox txtENAME;
        private System.Windows.Forms.TextBox txtJOB;
        private System.Windows.Forms.TextBox txtSALARY;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.Button btnSHOWALL;
        private System.Windows.Forms.Button btnCLOSE;
    }
}

