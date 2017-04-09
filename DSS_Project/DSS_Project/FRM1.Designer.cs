namespace DSS_Project
{
    partial class FRM1
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
            this.P_Constrain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Max = new System.Windows.Forms.RadioButton();
            this.rb_Min = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add_Constrain = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nud_variable = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.P_Zequation = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_variable)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Constrain
            // 
            this.P_Constrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Constrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.P_Constrain.Font = new System.Drawing.Font("Tahoma", 12F);
            this.P_Constrain.Location = new System.Drawing.Point(0, 250);
            this.P_Constrain.Name = "P_Constrain";
            this.P_Constrain.Size = new System.Drawing.Size(824, 161);
            this.P_Constrain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.P_Zequation);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Add_Constrain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nud_variable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 243);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Max);
            this.groupBox1.Controls.Add(this.rb_Min);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(381, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rb_Max
            // 
            this.rb_Max.AutoSize = true;
            this.rb_Max.Location = new System.Drawing.Point(217, 16);
            this.rb_Max.Name = "rb_Max";
            this.rb_Max.Size = new System.Drawing.Size(55, 23);
            this.rb_Max.TabIndex = 2;
            this.rb_Max.TabStop = true;
            this.rb_Max.Text = "Max";
            this.rb_Max.UseVisualStyleBackColor = true;
            // 
            // rb_Min
            // 
            this.rb_Min.AutoSize = true;
            this.rb_Min.Location = new System.Drawing.Point(296, 16);
            this.rb_Min.Name = "rb_Min";
            this.rb_Min.Size = new System.Drawing.Size(52, 23);
            this.rb_Min.TabIndex = 1;
            this.rb_Min.TabStop = true;
            this.rb_Min.Text = "Min";
            this.rb_Min.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter type of optimization";
            // 
            // btn_Add_Constrain
            // 
            this.btn_Add_Constrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_Constrain.Location = new System.Drawing.Point(731, 154);
            this.btn_Add_Constrain.Name = "btn_Add_Constrain";
            this.btn_Add_Constrain.Size = new System.Drawing.Size(93, 77);
            this.btn_Add_Constrain.TabIndex = 7;
            this.btn_Add_Constrain.Text = "Add_Constrain";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 102);
            this.panel2.TabIndex = 6;
            // 
            // nud_variable
            // 
            this.nud_variable.Location = new System.Drawing.Point(255, 8);
            this.nud_variable.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_variable.Name = "nud_variable";
            this.nud_variable.Size = new System.Drawing.Size(120, 27);
            this.nud_variable.TabIndex = 5;
            this.nud_variable.ValueChanged += new System.EventHandler(this.nud_variable_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Number of Variables ";
            // 
            // P_Zequation
            // 
            this.P_Zequation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Zequation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.P_Zequation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.P_Zequation.Location = new System.Drawing.Point(0, 44);
            this.P_Zequation.Name = "P_Zequation";
            this.P_Zequation.Size = new System.Drawing.Size(725, 92);
            this.P_Zequation.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(731, 51);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 77);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Add_Z_equation";
            // 
            // FRM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_Constrain);
            this.MaximizeBox = false;
            this.Name = "FRM1";
            this.Text = "FRM1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_variable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Constrain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nud_variable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_Add_Constrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Max;
        private System.Windows.Forms.RadioButton rb_Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P_Zequation;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}