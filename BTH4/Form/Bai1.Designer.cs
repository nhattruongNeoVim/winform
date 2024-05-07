
namespace BTH4
{
    partial class Bai1
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
            this.lb_output = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_pow = new System.Windows.Forms.Button();
            this.btn_increase = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_delete_firt_last = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(317, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // lb_output
            // 
            this.lb_output.FormattingEnabled = true;
            this.lb_output.ItemHeight = 20;
            this.lb_output.Location = new System.Drawing.Point(6, 127);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(301, 184);
            this.lb_output.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_input);
            this.groupBox1.Controls.Add(this.btn_input);
            this.groupBox1.Controls.Add(this.lb_output);
            this.groupBox1.Location = new System.Drawing.Point(38, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // txt_input
            // 
            this.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_input.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txt_input.Location = new System.Drawing.Point(7, 37);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(300, 43);
            this.txt_input.TabIndex = 4;
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_KeyDown);
            // 
            // btn_input
            // 
            this.btn_input.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_input.Location = new System.Drawing.Point(7, 86);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(300, 35);
            this.btn_input.TabIndex = 3;
            this.btn_input.Text = "Nhập";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_pow);
            this.groupBox2.Controls.Add(this.btn_increase);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_delete_firt_last);
            this.groupBox2.Controls.Add(this.btn_sum);
            this.groupBox2.Location = new System.Drawing.Point(442, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 316);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lí Listbox";
            // 
            // btn_pow
            // 
            this.btn_pow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pow.Location = new System.Drawing.Point(6, 273);
            this.btn_pow.Name = "btn_pow";
            this.btn_pow.Size = new System.Drawing.Size(300, 35);
            this.btn_pow.TabIndex = 8;
            this.btn_pow.Text = "Thay bằng bình phương";
            this.btn_pow.UseVisualStyleBackColor = true;
            this.btn_pow.Click += new System.EventHandler(this.btn_pow_Click);
            // 
            // btn_increase
            // 
            this.btn_increase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_increase.Location = new System.Drawing.Point(6, 216);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(300, 35);
            this.btn_increase.TabIndex = 7;
            this.btn_increase.Text = "Tăng mỗi phần tử lên 2";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(6, 159);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(300, 35);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xoá phần tử đang chọn";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_delete_firt_last
            // 
            this.btn_delete_firt_last.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btn_delete_firt_last.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete_firt_last.Location = new System.Drawing.Point(6, 102);
            this.btn_delete_firt_last.Name = "btn_delete_firt_last";
            this.btn_delete_firt_last.Size = new System.Drawing.Size(300, 35);
            this.btn_delete_firt_last.TabIndex = 5;
            this.btn_delete_firt_last.Text = "Xoá phần tử đầu và cuối";
            this.btn_delete_firt_last.UseVisualStyleBackColor = true;
            this.btn_delete_firt_last.Click += new System.EventHandler(this.btn_delete_firt_last_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_sum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sum.Location = new System.Drawing.Point(6, 45);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(300, 35);
            this.btn_sum.TabIndex = 4;
            this.btn_sum.Text = "Tổng các phần tử trong listbox";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(38, 455);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(717, 42);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Kết thúc";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_pow;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_delete_firt_last;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_input;
    }
}

