namespace MTC_Capstone
{
    partial class Form2
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
            this.btn_Scan = new System.Windows.Forms.Button();
            this.btn_Retrieve = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.cb_PaymentMethod = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.mc_Date = new System.Windows.Forms.MonthCalendar();
            this.tb_Payee = new System.Windows.Forms.TextBox();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.cb_BillType = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_Scan
            // 
            this.btn_Scan.Location = new System.Drawing.Point(15, 264);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(162, 23);
            this.btn_Scan.TabIndex = 32;
            this.btn_Scan.Text = "Scan Bill/Receipt";
            this.btn_Scan.UseVisualStyleBackColor = true;
            // 
            // btn_Retrieve
            // 
            this.btn_Retrieve.Location = new System.Drawing.Point(276, 234);
            this.btn_Retrieve.Name = "btn_Retrieve";
            this.btn_Retrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_Retrieve.TabIndex = 31;
            this.btn_Retrieve.Text = "Retrieve";
            this.btn_Retrieve.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(189, 234);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 30;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(102, 234);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 29;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(15, 234);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 28;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // cb_PaymentMethod
            // 
            this.cb_PaymentMethod.FormattingEnabled = true;
            this.cb_PaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Credit",
            "Owe"});
            this.cb_PaymentMethod.Location = new System.Drawing.Point(15, 108);
            this.cb_PaymentMethod.Name = "cb_PaymentMethod";
            this.cb_PaymentMethod.Size = new System.Drawing.Size(93, 64);
            this.cb_PaymentMethod.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date of Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Payee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Type of Expense";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(12, 209);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 22;
            this.Amount.Text = "Amount";
            // 
            // mc_Date
            // 
            this.mc_Date.Location = new System.Drawing.Point(125, 31);
            this.mc_Date.Name = "mc_Date";
            this.mc_Date.TabIndex = 21;
            // 
            // tb_Payee
            // 
            this.tb_Payee.Location = new System.Drawing.Point(210, 205);
            this.tb_Payee.Name = "tb_Payee";
            this.tb_Payee.Size = new System.Drawing.Size(100, 20);
            this.tb_Payee.TabIndex = 20;
            // 
            // tb_Amount
            // 
            this.tb_Amount.Location = new System.Drawing.Point(61, 206);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(100, 20);
            this.tb_Amount.TabIndex = 19;
            // 
            // cb_BillType
            // 
            this.cb_BillType.CheckOnClick = true;
            this.cb_BillType.FormattingEnabled = true;
            this.cb_BillType.Items.AddRange(new object[] {
            "Healthcare",
            "Dental",
            "Vision"});
            this.cb_BillType.Location = new System.Drawing.Point(15, 31);
            this.cb_BillType.Name = "cb_BillType";
            this.cb_BillType.Size = new System.Drawing.Size(93, 49);
            this.cb_BillType.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 296);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.btn_Retrieve);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.cb_PaymentMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.mc_Date);
            this.Controls.Add(this.tb_Payee);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.cb_BillType);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Scan;
        private System.Windows.Forms.Button btn_Retrieve;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.CheckedListBox cb_PaymentMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.MonthCalendar mc_Date;
        private System.Windows.Forms.TextBox tb_Payee;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.CheckedListBox cb_BillType;
    }
}