namespace DSS_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Min = new System.Windows.Forms.RadioButton();
            this.rb_Max = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_constrain = new System.Windows.Forms.NumericUpDown();
            this.nud_variable = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_genrate = new DevExpress.XtraEditors.SimpleButton();
            this.tlp_z = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_constrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_variable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter type of optimization";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Max);
            this.groupBox1.Controls.Add(this.rb_Min);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rb_Min
            // 
            this.rb_Min.AutoSize = true;
            this.rb_Min.Location = new System.Drawing.Point(249, 55);
            this.rb_Min.Name = "rb_Min";
            this.rb_Min.Size = new System.Drawing.Size(52, 23);
            this.rb_Min.TabIndex = 1;
            this.rb_Min.TabStop = true;
            this.rb_Min.Text = "Min";
            this.rb_Min.UseVisualStyleBackColor = true;
            // 
            // rb_Max
            // 
            this.rb_Max.AutoSize = true;
            this.rb_Max.Location = new System.Drawing.Point(249, 26);
            this.rb_Max.Name = "rb_Max";
            this.rb_Max.Size = new System.Drawing.Size(55, 23);
            this.rb_Max.TabIndex = 2;
            this.rb_Max.TabStop = true;
            this.rb_Max.Text = "Max";
            this.rb_Max.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_variable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nud_constrain);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Number of Constraints";
            // 
            // nud_constrain
            // 
            this.nud_constrain.Location = new System.Drawing.Point(249, 46);
            this.nud_constrain.Name = "nud_constrain";
            this.nud_constrain.Size = new System.Drawing.Size(120, 27);
            this.nud_constrain.TabIndex = 1;
            this.nud_constrain.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_variable
            // 
            this.nud_variable.Location = new System.Drawing.Point(249, 90);
            this.nud_variable.Name = "nud_variable";
            this.nud_variable.Size = new System.Drawing.Size(120, 27);
            this.nud_variable.TabIndex = 3;
            this.nud_variable.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Number of Variables ";
            // 
            // btn_genrate
            // 
            this.btn_genrate.Location = new System.Drawing.Point(671, 12);
            this.btn_genrate.Name = "btn_genrate";
            this.btn_genrate.Size = new System.Drawing.Size(101, 56);
            this.btn_genrate.TabIndex = 3;
            this.btn_genrate.Text = "Genrate Z";
            this.btn_genrate.Click += new System.EventHandler(this.btn_genrate_Click);
            // 
            // tlp_z
            // 
            this.tlp_z.ColumnCount = 1;
            this.tlp_z.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_z.Location = new System.Drawing.Point(441, 123);
            this.tlp_z.Name = "tlp_z";
            this.tlp_z.RowCount = 1;
            this.tlp_z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_z.Size = new System.Drawing.Size(369, 187);
            this.tlp_z.TabIndex = 4;
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 454);
            this.Controls.Add(this.tlp_z);
            this.Controls.Add(this.btn_genrate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_constrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_variable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Max;
        private System.Windows.Forms.RadioButton rb_Min;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_constrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_variable;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_genrate;
        private System.Windows.Forms.TableLayoutPanel tlp_z;

    }
}

