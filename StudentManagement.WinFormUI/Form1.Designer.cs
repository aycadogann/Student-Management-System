
namespace StudentManagement.WinFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.num_MidTerm = new System.Windows.Forms.NumericUpDown();
            this.num_Final = new System.Windows.Forms.NumericUpDown();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgw_List = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Average = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_LetterGrade = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.FisrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avarege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterGrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MidTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Final)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_List)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.num_Final);
            this.groupBox1.Controls.Add(this.num_MidTerm);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.txt_FirstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Paneli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vize Notu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final Notu:";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_FirstName.Location = new System.Drawing.Point(122, 31);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(189, 26);
            this.txt_FirstName.TabIndex = 0;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_LastName.Location = new System.Drawing.Point(122, 67);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(189, 26);
            this.txt_LastName.TabIndex = 1;
            // 
            // num_MidTerm
            // 
            this.num_MidTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_MidTerm.Location = new System.Drawing.Point(122, 105);
            this.num_MidTerm.Name = "num_MidTerm";
            this.num_MidTerm.Size = new System.Drawing.Size(76, 26);
            this.num_MidTerm.TabIndex = 2;
            // 
            // num_Final
            // 
            this.num_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_Final.Location = new System.Drawing.Point(122, 143);
            this.num_Final.Name = "num_Final";
            this.num_Final.Size = new System.Drawing.Size(76, 26);
            this.num_Final.TabIndex = 3;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Calculate.Location = new System.Drawing.Point(122, 176);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(189, 29);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Hesapla";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Status);
            this.groupBox2.Controls.Add(this.lbl_LetterGrade);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_Average);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(382, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuç Paneli";
            // 
            // dgw_List
            // 
            this.dgw_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FisrtName,
            this.LastName,
            this.Avarege,
            this.LetterGrate});
            this.dgw_List.Location = new System.Drawing.Point(13, 260);
            this.dgw_List.Name = "dgw_List";
            this.dgw_List.RowHeadersWidth = 51;
            this.dgw_List.RowTemplate.Height = 24;
            this.dgw_List.Size = new System.Drawing.Size(672, 178);
            this.dgw_List.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ortalama:";
            // 
            // lbl_Average
            // 
            this.lbl_Average.AutoSize = true;
            this.lbl_Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Average.Location = new System.Drawing.Point(139, 61);
            this.lbl_Average.Name = "lbl_Average";
            this.lbl_Average.Size = new System.Drawing.Size(0, 29);
            this.lbl_Average.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(52, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Harf Notu:";
            // 
            // lbl_LetterGrade
            // 
            this.lbl_LetterGrade.AutoSize = true;
            this.lbl_LetterGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_LetterGrade.Location = new System.Drawing.Point(139, 101);
            this.lbl_LetterGrade.Name = "lbl_LetterGrade";
            this.lbl_LetterGrade.Size = new System.Drawing.Size(0, 29);
            this.lbl_LetterGrade.TabIndex = 3;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Status.Location = new System.Drawing.Point(117, 152);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 20);
            this.lbl_Status.TabIndex = 4;
            // 
            // FisrtName
            // 
            this.FisrtName.HeaderText = "Ad";
            this.FisrtName.MinimumWidth = 6;
            this.FisrtName.Name = "FisrtName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Soyad";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // Avarege
            // 
            this.Avarege.HeaderText = "Ortalama";
            this.Avarege.MinimumWidth = 6;
            this.Avarege.Name = "Avarege";
            // 
            // LetterGrate
            // 
            this.LetterGrate.HeaderText = "Harf Notu";
            this.LetterGrate.MinimumWidth = 6;
            this.LetterGrate.Name = "LetterGrate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.dgw_List);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Hesaplama Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MidTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Final)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.NumericUpDown num_Final;
        private System.Windows.Forms.NumericUpDown num_MidTerm;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_LetterGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Average;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgw_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn FisrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avarege;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterGrate;
    }
}

