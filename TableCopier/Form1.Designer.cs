namespace TableCopier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbServerFrom = new System.Windows.Forms.TextBox();
            this.tbUserIdFrom = new System.Windows.Forms.TextBox();
            this.tbPasswordFrom = new System.Windows.Forms.TextBox();
            this.tbDatabaseFrom = new System.Windows.Forms.TextBox();
            this.tbTableFrom = new System.Windows.Forms.TextBox();
            this.tbTableTo = new System.Windows.Forms.TextBox();
            this.tbDatabaseTo = new System.Windows.Forms.TextBox();
            this.tbPasswordTo = new System.Windows.Forms.TextBox();
            this.tbUserIdTo = new System.Windows.Forms.TextBox();
            this.tbServerTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Table:";
            // 
            // tbServerFrom
            // 
            this.tbServerFrom.Location = new System.Drawing.Point(92, 32);
            this.tbServerFrom.Name = "tbServerFrom";
            this.tbServerFrom.Size = new System.Drawing.Size(100, 20);
            this.tbServerFrom.TabIndex = 5;
            this.tbServerFrom.Text = "localhost";
            // 
            // tbUserIdFrom
            // 
            this.tbUserIdFrom.Location = new System.Drawing.Point(92, 60);
            this.tbUserIdFrom.Name = "tbUserIdFrom";
            this.tbUserIdFrom.Size = new System.Drawing.Size(100, 20);
            this.tbUserIdFrom.TabIndex = 6;
            this.tbUserIdFrom.Text = "sa";
            // 
            // tbPasswordFrom
            // 
            this.tbPasswordFrom.Location = new System.Drawing.Point(92, 88);
            this.tbPasswordFrom.Name = "tbPasswordFrom";
            this.tbPasswordFrom.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordFrom.TabIndex = 7;
            this.tbPasswordFrom.Text = "123";
            this.tbPasswordFrom.UseSystemPasswordChar = true;
            // 
            // tbDatabaseFrom
            // 
            this.tbDatabaseFrom.Location = new System.Drawing.Point(92, 116);
            this.tbDatabaseFrom.Name = "tbDatabaseFrom";
            this.tbDatabaseFrom.Size = new System.Drawing.Size(100, 20);
            this.tbDatabaseFrom.TabIndex = 8;
            this.tbDatabaseFrom.Text = "GPSDB_OLD";
            // 
            // tbTableFrom
            // 
            this.tbTableFrom.Location = new System.Drawing.Point(92, 148);
            this.tbTableFrom.Name = "tbTableFrom";
            this.tbTableFrom.Size = new System.Drawing.Size(100, 20);
            this.tbTableFrom.TabIndex = 9;
            // 
            // tbTableTo
            // 
            this.tbTableTo.Location = new System.Drawing.Point(320, 148);
            this.tbTableTo.Name = "tbTableTo";
            this.tbTableTo.Size = new System.Drawing.Size(100, 20);
            this.tbTableTo.TabIndex = 19;
            // 
            // tbDatabaseTo
            // 
            this.tbDatabaseTo.Location = new System.Drawing.Point(320, 116);
            this.tbDatabaseTo.Name = "tbDatabaseTo";
            this.tbDatabaseTo.Size = new System.Drawing.Size(100, 20);
            this.tbDatabaseTo.TabIndex = 18;
            this.tbDatabaseTo.Text = "GPSDB";
            // 
            // tbPasswordTo
            // 
            this.tbPasswordTo.Location = new System.Drawing.Point(320, 88);
            this.tbPasswordTo.Name = "tbPasswordTo";
            this.tbPasswordTo.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordTo.TabIndex = 17;
            this.tbPasswordTo.Text = "123";
            this.tbPasswordTo.UseSystemPasswordChar = true;
            // 
            // tbUserIdTo
            // 
            this.tbUserIdTo.Location = new System.Drawing.Point(320, 60);
            this.tbUserIdTo.Name = "tbUserIdTo";
            this.tbUserIdTo.Size = new System.Drawing.Size(100, 20);
            this.tbUserIdTo.TabIndex = 16;
            this.tbUserIdTo.Text = "sa";
            // 
            // tbServerTo
            // 
            this.tbServerTo.Location = new System.Drawing.Point(320, 32);
            this.tbServerTo.Name = "tbServerTo";
            this.tbServerTo.Size = new System.Drawing.Size(100, 20);
            this.tbServerTo.TabIndex = 15;
            this.tbServerTo.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Table:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "DB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "UserID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Server:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "FROM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "TO";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(344, 196);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 40);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "From";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "To";
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Location = new System.Drawing.Point(120, 196);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFrom.TabIndex = 27;
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.Location = new System.Drawing.Point(120, 224);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(200, 20);
            this.dtPickerTo.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.dtPickerTo);
            this.Controls.Add(this.dtPickerFrom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTableTo);
            this.Controls.Add(this.tbDatabaseTo);
            this.Controls.Add(this.tbPasswordTo);
            this.Controls.Add(this.tbUserIdTo);
            this.Controls.Add(this.tbServerTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbTableFrom);
            this.Controls.Add(this.tbDatabaseFrom);
            this.Controls.Add(this.tbPasswordFrom);
            this.Controls.Add(this.tbUserIdFrom);
            this.Controls.Add(this.tbServerFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbServerFrom;
        private System.Windows.Forms.TextBox tbUserIdFrom;
        private System.Windows.Forms.TextBox tbPasswordFrom;
        private System.Windows.Forms.TextBox tbDatabaseFrom;
        private System.Windows.Forms.TextBox tbTableFrom;
        private System.Windows.Forms.TextBox tbTableTo;
        private System.Windows.Forms.TextBox tbDatabaseTo;
        private System.Windows.Forms.TextBox tbPasswordTo;
        private System.Windows.Forms.TextBox tbUserIdTo;
        private System.Windows.Forms.TextBox tbServerTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.DateTimePicker dtPickerTo;

    }
}

