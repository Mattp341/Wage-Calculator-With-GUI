namespace Official_Wage_Calculator
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
            this.txt_MonHours = new System.Windows.Forms.TextBox();
            this.txt_TuesHours = new System.Windows.Forms.TextBox();
            this.txt_SunHours = new System.Windows.Forms.TextBox();
            this.txt_WedHours = new System.Windows.Forms.TextBox();
            this.txt_FriHours = new System.Windows.Forms.TextBox();
            this.txt_SatHours = new System.Windows.Forms.TextBox();
            this.txt_ThursHours = new System.Windows.Forms.TextBox();
            this.btn_OneWeek = new System.Windows.Forms.Button();
            this.txt_Wage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MonHours
            // 
            this.txt_MonHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MonHours.Location = new System.Drawing.Point(175, 85);
            this.txt_MonHours.Name = "txt_MonHours";
            this.txt_MonHours.Size = new System.Drawing.Size(100, 23);
            this.txt_MonHours.TabIndex = 0;
            this.txt_MonHours.TextChanged += new System.EventHandler(this.txt_MonHours_TextChanged);
            // 
            // txt_TuesHours
            // 
            this.txt_TuesHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TuesHours.Location = new System.Drawing.Point(175, 141);
            this.txt_TuesHours.Name = "txt_TuesHours";
            this.txt_TuesHours.Size = new System.Drawing.Size(100, 23);
            this.txt_TuesHours.TabIndex = 1;
            this.txt_TuesHours.TextChanged += new System.EventHandler(this.txt_TuesHours_TextChanged);
            // 
            // txt_SunHours
            // 
            this.txt_SunHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SunHours.Location = new System.Drawing.Point(175, 439);
            this.txt_SunHours.Name = "txt_SunHours";
            this.txt_SunHours.Size = new System.Drawing.Size(100, 23);
            this.txt_SunHours.TabIndex = 2;
            this.txt_SunHours.TextChanged += new System.EventHandler(this.txt_SunHours_TextChanged);
            // 
            // txt_WedHours
            // 
            this.txt_WedHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WedHours.Location = new System.Drawing.Point(175, 194);
            this.txt_WedHours.Name = "txt_WedHours";
            this.txt_WedHours.Size = new System.Drawing.Size(100, 23);
            this.txt_WedHours.TabIndex = 3;
            this.txt_WedHours.TextChanged += new System.EventHandler(this.txt_WedHours_TextChanged);
            // 
            // txt_FriHours
            // 
            this.txt_FriHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FriHours.Location = new System.Drawing.Point(175, 312);
            this.txt_FriHours.Name = "txt_FriHours";
            this.txt_FriHours.Size = new System.Drawing.Size(100, 23);
            this.txt_FriHours.TabIndex = 4;
            this.txt_FriHours.TextChanged += new System.EventHandler(this.txt_FriHours_TextChanged);
            // 
            // txt_SatHours
            // 
            this.txt_SatHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SatHours.Location = new System.Drawing.Point(175, 374);
            this.txt_SatHours.Name = "txt_SatHours";
            this.txt_SatHours.Size = new System.Drawing.Size(100, 23);
            this.txt_SatHours.TabIndex = 5;
            this.txt_SatHours.TextChanged += new System.EventHandler(this.txt_SatHours_TextChanged);
            // 
            // txt_ThursHours
            // 
            this.txt_ThursHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThursHours.Location = new System.Drawing.Point(175, 250);
            this.txt_ThursHours.Name = "txt_ThursHours";
            this.txt_ThursHours.Size = new System.Drawing.Size(100, 23);
            this.txt_ThursHours.TabIndex = 6;
            this.txt_ThursHours.TextChanged += new System.EventHandler(this.txt_ThursHours_TextChanged);
            // 
            // btn_OneWeek
            // 
            this.btn_OneWeek.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OneWeek.Location = new System.Drawing.Point(92, 507);
            this.btn_OneWeek.Name = "btn_OneWeek";
            this.btn_OneWeek.Size = new System.Drawing.Size(126, 23);
            this.btn_OneWeek.TabIndex = 14;
            this.btn_OneWeek.Text = "Calculate ";
            this.btn_OneWeek.UseVisualStyleBackColor = true;
            this.btn_OneWeek.Click += new System.EventHandler(this.btn_OneWeek_Click);
            // 
            // txt_Wage
            // 
            this.txt_Wage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Wage.Location = new System.Drawing.Point(175, 28);
            this.txt_Wage.Name = "txt_Wage";
            this.txt_Wage.Size = new System.Drawing.Size(100, 23);
            this.txt_Wage.TabIndex = 16;
            this.txt_Wage.TextChanged += new System.EventHandler(this.txt_Wage_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Friday Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thursday Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saturday Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wednesday Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sunday Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tuesday Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monday Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Wage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(377, 532);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Wage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_OneWeek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ThursHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SatHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_FriHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_WedHours);
            this.Controls.Add(this.txt_SunHours);
            this.Controls.Add(this.txt_TuesHours);
            this.Controls.Add(this.txt_MonHours);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MonHours;
        private System.Windows.Forms.TextBox txt_TuesHours;
        private System.Windows.Forms.TextBox txt_SunHours;
        private System.Windows.Forms.TextBox txt_WedHours;
        private System.Windows.Forms.TextBox txt_FriHours;
        private System.Windows.Forms.TextBox txt_SatHours;
        private System.Windows.Forms.TextBox txt_ThursHours;
        private System.Windows.Forms.Button btn_OneWeek;
        private System.Windows.Forms.TextBox txt_Wage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

