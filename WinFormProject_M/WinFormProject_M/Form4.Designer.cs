namespace WinFormProject_M
{
    partial class Form4
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOdri = new System.Windows.Forms.TextBox();
            this.textBoxOpro = new System.Windows.Forms.TextBox();
            this.textBoxOinven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(669, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Rix오늘의만화", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInsert.Location = new System.Drawing.Point(786, 579);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(79, 29);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxOdri);
            this.groupBox1.Controls.Add(this.textBoxOpro);
            this.groupBox1.Controls.Add(this.textBoxOinven);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxOname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxOnumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rix오늘의만화", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Location = new System.Drawing.Point(688, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 412);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // textBoxOdate
            // 
            this.textBoxOdate.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxOdate.Location = new System.Drawing.Point(218, 304);
            this.textBoxOdate.Name = "textBoxOdate";
            this.textBoxOdate.Size = new System.Drawing.Size(123, 27);
            this.textBoxOdate.TabIndex = 16;
            this.textBoxOdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(68, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "날짜(yyyy-mm-dd) : ";
            // 
            // textBoxOdri
            // 
            this.textBoxOdri.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxOdri.Location = new System.Drawing.Point(136, 263);
            this.textBoxOdri.Name = "textBoxOdri";
            this.textBoxOdri.Size = new System.Drawing.Size(141, 27);
            this.textBoxOdri.TabIndex = 14;
            this.textBoxOdri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOpro
            // 
            this.textBoxOpro.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxOpro.Location = new System.Drawing.Point(154, 186);
            this.textBoxOpro.Name = "textBoxOpro";
            this.textBoxOpro.Size = new System.Drawing.Size(123, 27);
            this.textBoxOpro.TabIndex = 12;
            this.textBoxOpro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOinven
            // 
            this.textBoxOinven.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxOinven.Location = new System.Drawing.Point(123, 224);
            this.textBoxOinven.Name = "textBoxOinven";
            this.textBoxOinven.Size = new System.Drawing.Size(110, 27);
            this.textBoxOinven.TabIndex = 11;
            this.textBoxOinven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(68, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "배송지 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(68, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "수량 : ";
            // 
            // textBoxOname
            // 
            this.textBoxOname.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxOname.Location = new System.Drawing.Point(154, 149);
            this.textBoxOname.Name = "textBoxOname";
            this.textBoxOname.Size = new System.Drawing.Size(123, 27);
            this.textBoxOname.TabIndex = 5;
            this.textBoxOname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(68, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "주문제품 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(68, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "주문고객 :  ";
            // 
            // textBoxOnumber
            // 
            this.textBoxOnumber.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxOnumber.Location = new System.Drawing.Point(154, 112);
            this.textBoxOnumber.Name = "textBoxOnumber";
            this.textBoxOnumber.Size = new System.Drawing.Size(123, 27);
            this.textBoxOnumber.TabIndex = 1;
            this.textBoxOnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rix오늘의만화", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(68, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문번호 :  ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Rix오늘의만화", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.Location = new System.Drawing.Point(871, 579);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rix오늘의만화", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(421, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 77);
            this.label7.TabIndex = 6;
            this.label7.Text = "주문";
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelect.Font = new System.Drawing.Font("Rix오늘의만화", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSelect.Location = new System.Drawing.Point(702, 579);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(78, 29);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "검색";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rix오늘의만화", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "DB연결상태";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Rix오늘의만화", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.Location = new System.Drawing.Point(953, 579);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Rix오늘의만화", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.Location = new System.Drawing.Point(702, 614);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(327, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "검색 조건 초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 673);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOinven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOpro;
        private System.Windows.Forms.TextBox textBoxOdri;
        private System.Windows.Forms.TextBox textBoxOdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}