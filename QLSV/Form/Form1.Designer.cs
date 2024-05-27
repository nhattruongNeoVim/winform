namespace QLSV
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_NgaySinh = new DateTimePicker();
            cb_K = new ComboBox();
            cb_Khoa = new ComboBox();
            txt_SDT = new TextBox();
            txt_DiaChi = new TextBox();
            txt_HoTen = new TextBox();
            txt_MaSV = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btn_exit = new Button();
            btn_Xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(914, 172);
            dataGridView1.TabIndex = 0;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 2;
            label1.Text = "Danh Sách Sinh Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_NgaySinh);
            groupBox1.Controls.Add(cb_K);
            groupBox1.Controls.Add(cb_Khoa);
            groupBox1.Controls.Add(txt_SDT);
            groupBox1.Controls.Add(txt_DiaChi);
            groupBox1.Controls.Add(txt_HoTen);
            groupBox1.Controls.Add(txt_MaSV);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(928, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // txt_NgaySinh
            // 
            txt_NgaySinh.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NgaySinh.Format = DateTimePickerFormat.Short;
            txt_NgaySinh.Location = new Point(338, 27);
            txt_NgaySinh.Name = "txt_NgaySinh";
            txt_NgaySinh.Size = new Size(125, 30);
            txt_NgaySinh.TabIndex = 6;
            // 
            // cb_K
            // 
            cb_K.FormattingEnabled = true;
            cb_K.Location = new Point(547, 72);
            cb_K.Name = "cb_K";
            cb_K.Size = new Size(151, 31);
            cb_K.TabIndex = 17;
            // 
            // cb_Khoa
            // 
            cb_Khoa.FormattingEnabled = true;
            cb_Khoa.Location = new Point(767, 26);
            cb_Khoa.Name = "cb_Khoa";
            cb_Khoa.Size = new Size(151, 31);
            cb_Khoa.TabIndex = 16;
            // 
            // txt_SDT
            // 
            txt_SDT.BorderStyle = BorderStyle.FixedSingle;
            txt_SDT.Location = new Point(547, 26);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(125, 30);
            txt_SDT.TabIndex = 14;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.BorderStyle = BorderStyle.FixedSingle;
            txt_DiaChi.Location = new Point(338, 72);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(125, 30);
            txt_DiaChi.TabIndex = 13;
            // 
            // txt_HoTen
            // 
            txt_HoTen.BorderStyle = BorderStyle.FixedSingle;
            txt_HoTen.Location = new Point(83, 73);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(125, 30);
            txt_HoTen.TabIndex = 11;
            // 
            // txt_MaSV
            // 
            txt_MaSV.BorderStyle = BorderStyle.FixedSingle;
            txt_MaSV.Location = new Point(83, 26);
            txt_MaSV.Name = "txt_MaSV";
            txt_MaSV.Size = new Size(125, 30);
            txt_MaSV.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(695, 30);
            label8.Name = "label8";
            label8.Size = new Size(49, 23);
            label8.TabIndex = 10;
            label8.Text = "Khoa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(485, 76);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 9;
            label7.Text = "Khoá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 0;
            label2.Text = "MaSV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(485, 30);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 8;
            label6.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 5;
            label3.Text = "HoTen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(231, 76);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 7;
            label5.Text = "DiaChi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(231, 30);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 6;
            label4.Text = "NgaySinh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(926, 200);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_exit);
            groupBox3.Controls.Add(btn_Xoa);
            groupBox3.Controls.Add(btn_sua);
            groupBox3.Controls.Add(btn_them);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(926, 91);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác";
            // 
            // btn_exit
            // 
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 10.2F);
            btn_exit.Location = new Point(773, 37);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.FlatStyle = FlatStyle.Flat;
            btn_Xoa.Font = new Font("Segoe UI", 10.2F);
            btn_Xoa.Location = new Point(534, 37);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Segoe UI", 10.2F);
            btn_sua.Location = new Point(295, 37);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Segoe UI", 10.2F);
            btn_them.Location = new Point(56, 37);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 518);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "SinhVien";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cb_Khoa;
        private TextBox txt_SDT;
        private TextBox txt_DiaChi;
        private TextBox txt_HoTen;
        private TextBox txt_MaSV;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
        private ComboBox cb_K;
        private GroupBox groupBox3;
        private Button btn_exit;
        private Button btn_Xoa;
        private Button btn_sua;
        private Button btn_them;
        private DateTimePicker txt_NgaySinh;
    }
}
