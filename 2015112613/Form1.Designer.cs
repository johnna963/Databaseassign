namespace _2015112613
{
    partial class Form1
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
            this.PrintCustom = new System.Windows.Forms.Label();
            this.Good = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.Sell = new System.Windows.Forms.Button();
            this.Consult = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.PrintGood = new System.Windows.Forms.Label();
            this.PrintSell = new System.Windows.Forms.Label();
            this.PrintConsult = new System.Windows.Forms.Label();
            this.PrintBill = new System.Windows.Forms.Label();
            this.NCuTable = new System.Windows.Forms.TextBox();
            this.CuNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Execute1 = new System.Windows.Forms.Button();
            this.Execute2 = new System.Windows.Forms.Button();
            this.GoNum = new System.Windows.Forms.TextBox();
            this.NGTable = new System.Windows.Forms.TextBox();
            this.Execute3 = new System.Windows.Forms.Button();
            this.Snum = new System.Windows.Forms.TextBox();
            this.NSTable = new System.Windows.Forms.TextBox();
            this.Execute4 = new System.Windows.Forms.Button();
            this.NConTable = new System.Windows.Forms.TextBox();
            this.Execute5 = new System.Windows.Forms.Button();
            this.BNum = new System.Windows.Forms.TextBox();
            this.NBTable = new System.Windows.Forms.TextBox();
            this.CuName = new System.Windows.Forms.TextBox();
            this.SCuNum = new System.Windows.Forms.TextBox();
            this.SGoNum = new System.Windows.Forms.TextBox();
            this.ConNum = new System.Windows.Forms.TextBox();
            this.ConCuNum = new System.Windows.Forms.TextBox();
            this.ConGoNum = new System.Windows.Forms.TextBox();
            this.ConConsult = new System.Windows.Forms.TextBox();
            this.ConWant = new System.Windows.Forms.TextBox();
            this.GoName = new System.Windows.Forms.TextBox();
            this.BConNum = new System.Windows.Forms.TextBox();
            this.BSum = new System.Windows.Forms.TextBox();
            this.CuAddress = new System.Windows.Forms.TextBox();
            this.DeleteSe = new System.Windows.Forms.TextBox();
            this.DeleteCon = new System.Windows.Forms.TextBox();
            this.DeleteB = new System.Windows.Forms.TextBox();
            this.DeleteBBu = new System.Windows.Forms.Button();
            this.DeleteConBu = new System.Windows.Forms.Button();
            this.DeleteSeBu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrintCustom
            // 
            this.PrintCustom.AutoSize = true;
            this.PrintCustom.Location = new System.Drawing.Point(12, 9);
            this.PrintCustom.Name = "PrintCustom";
            this.PrintCustom.Size = new System.Drawing.Size(109, 12);
            this.PrintCustom.TabIndex = 0;
            this.PrintCustom.Text = "고객 테이블 출력창";
            // 
            // Good
            // 
            this.Good.Location = new System.Drawing.Point(1486, 38);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(75, 23);
            this.Good.TabIndex = 1;
            this.Good.Text = "제품테이블";
            this.Good.UseVisualStyleBackColor = true;
            this.Good.Click += new System.EventHandler(this.Good_Click);
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(1486, 9);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(75, 23);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "고객테이블";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(1486, 67);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(75, 23);
            this.Sell.TabIndex = 3;
            this.Sell.Text = "구매테이블";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // Consult
            // 
            this.Consult.Location = new System.Drawing.Point(1486, 96);
            this.Consult.Name = "Consult";
            this.Consult.Size = new System.Drawing.Size(75, 23);
            this.Consult.TabIndex = 4;
            this.Consult.Text = "상담테이블";
            this.Consult.UseVisualStyleBackColor = true;
            this.Consult.Click += new System.EventHandler(this.Consult_Click);
            // 
            // Bill
            // 
            this.Bill.Location = new System.Drawing.Point(1486, 125);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(75, 23);
            this.Bill.TabIndex = 5;
            this.Bill.Text = "요금테이블";
            this.Bill.UseVisualStyleBackColor = true;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // PrintGood
            // 
            this.PrintGood.AutoSize = true;
            this.PrintGood.Location = new System.Drawing.Point(233, 9);
            this.PrintGood.Name = "PrintGood";
            this.PrintGood.Size = new System.Drawing.Size(109, 12);
            this.PrintGood.TabIndex = 6;
            this.PrintGood.Text = "제품 테이블 출력창";
            // 
            // PrintSell
            // 
            this.PrintSell.AutoSize = true;
            this.PrintSell.Location = new System.Drawing.Point(506, 9);
            this.PrintSell.Name = "PrintSell";
            this.PrintSell.Size = new System.Drawing.Size(109, 12);
            this.PrintSell.TabIndex = 7;
            this.PrintSell.Text = "구매 테이블 출력창";
            // 
            // PrintConsult
            // 
            this.PrintConsult.AutoSize = true;
            this.PrintConsult.Location = new System.Drawing.Point(759, 9);
            this.PrintConsult.Name = "PrintConsult";
            this.PrintConsult.Size = new System.Drawing.Size(109, 12);
            this.PrintConsult.TabIndex = 8;
            this.PrintConsult.Text = "상담 테이블 출력창";
            // 
            // PrintBill
            // 
            this.PrintBill.AutoSize = true;
            this.PrintBill.Location = new System.Drawing.Point(1169, 9);
            this.PrintBill.Name = "PrintBill";
            this.PrintBill.Size = new System.Drawing.Size(109, 12);
            this.PrintBill.TabIndex = 9;
            this.PrintBill.Text = "요금 테이블 출력창";
            // 
            // NCuTable
            // 
            this.NCuTable.Location = new System.Drawing.Point(21, 374);
            this.NCuTable.Name = "NCuTable";
            this.NCuTable.ReadOnly = true;
            this.NCuTable.Size = new System.Drawing.Size(67, 21);
            this.NCuTable.TabIndex = 10;
            // 
            // CuNum
            // 
            this.CuNum.Location = new System.Drawing.Point(115, 374);
            this.CuNum.Name = "CuNum";
            this.CuNum.Size = new System.Drawing.Size(67, 21);
            this.CuNum.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "삽입 테이블";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "삽입 데이터";
            // 
            // Execute1
            // 
            this.Execute1.Location = new System.Drawing.Point(508, 372);
            this.Execute1.Name = "Execute1";
            this.Execute1.Size = new System.Drawing.Size(75, 23);
            this.Execute1.TabIndex = 14;
            this.Execute1.Text = "실행";
            this.Execute1.UseVisualStyleBackColor = true;
            this.Execute1.Click += new System.EventHandler(this.ExcuteInsert_Click);
            // 
            // Execute2
            // 
            this.Execute2.Location = new System.Drawing.Point(508, 408);
            this.Execute2.Name = "Execute2";
            this.Execute2.Size = new System.Drawing.Size(75, 23);
            this.Execute2.TabIndex = 17;
            this.Execute2.Text = "실행";
            this.Execute2.UseVisualStyleBackColor = true;
            this.Execute2.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoNum
            // 
            this.GoNum.Location = new System.Drawing.Point(115, 410);
            this.GoNum.Name = "GoNum";
            this.GoNum.Size = new System.Drawing.Size(67, 21);
            this.GoNum.TabIndex = 16;
            // 
            // NGTable
            // 
            this.NGTable.Location = new System.Drawing.Point(21, 410);
            this.NGTable.Name = "NGTable";
            this.NGTable.ReadOnly = true;
            this.NGTable.Size = new System.Drawing.Size(67, 21);
            this.NGTable.TabIndex = 15;
            // 
            // Execute3
            // 
            this.Execute3.Location = new System.Drawing.Point(508, 444);
            this.Execute3.Name = "Execute3";
            this.Execute3.Size = new System.Drawing.Size(75, 23);
            this.Execute3.TabIndex = 20;
            this.Execute3.Text = "실행";
            this.Execute3.UseVisualStyleBackColor = true;
            this.Execute3.Click += new System.EventHandler(this.Execute3_Click);
            // 
            // Snum
            // 
            this.Snum.Location = new System.Drawing.Point(115, 446);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(67, 21);
            this.Snum.TabIndex = 19;
            // 
            // NSTable
            // 
            this.NSTable.Location = new System.Drawing.Point(21, 446);
            this.NSTable.Name = "NSTable";
            this.NSTable.ReadOnly = true;
            this.NSTable.Size = new System.Drawing.Size(67, 21);
            this.NSTable.TabIndex = 18;
            // 
            // Execute4
            // 
            this.Execute4.Location = new System.Drawing.Point(508, 481);
            this.Execute4.Name = "Execute4";
            this.Execute4.Size = new System.Drawing.Size(75, 23);
            this.Execute4.TabIndex = 23;
            this.Execute4.Text = "실행";
            this.Execute4.UseVisualStyleBackColor = true;
            this.Execute4.Click += new System.EventHandler(this.Execute4_Click);
            // 
            // NConTable
            // 
            this.NConTable.Location = new System.Drawing.Point(21, 483);
            this.NConTable.Name = "NConTable";
            this.NConTable.ReadOnly = true;
            this.NConTable.Size = new System.Drawing.Size(67, 21);
            this.NConTable.TabIndex = 21;
            // 
            // Execute5
            // 
            this.Execute5.Location = new System.Drawing.Point(508, 520);
            this.Execute5.Name = "Execute5";
            this.Execute5.Size = new System.Drawing.Size(75, 23);
            this.Execute5.TabIndex = 26;
            this.Execute5.Text = "실행";
            this.Execute5.UseVisualStyleBackColor = true;
            this.Execute5.Click += new System.EventHandler(this.Execute5_Click);
            // 
            // BNum
            // 
            this.BNum.Location = new System.Drawing.Point(115, 522);
            this.BNum.Name = "BNum";
            this.BNum.Size = new System.Drawing.Size(67, 21);
            this.BNum.TabIndex = 25;
            // 
            // NBTable
            // 
            this.NBTable.Location = new System.Drawing.Point(21, 522);
            this.NBTable.Name = "NBTable";
            this.NBTable.ReadOnly = true;
            this.NBTable.Size = new System.Drawing.Size(67, 21);
            this.NBTable.TabIndex = 24;
            // 
            // CuName
            // 
            this.CuName.Location = new System.Drawing.Point(188, 374);
            this.CuName.Name = "CuName";
            this.CuName.Size = new System.Drawing.Size(67, 21);
            this.CuName.TabIndex = 27;
            // 
            // SCuNum
            // 
            this.SCuNum.Location = new System.Drawing.Point(188, 446);
            this.SCuNum.Name = "SCuNum";
            this.SCuNum.Size = new System.Drawing.Size(67, 21);
            this.SCuNum.TabIndex = 28;
            this.SCuNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SCuNum_KeyPress);
            // 
            // SGoNum
            // 
            this.SGoNum.Location = new System.Drawing.Point(261, 446);
            this.SGoNum.Name = "SGoNum";
            this.SGoNum.Size = new System.Drawing.Size(67, 21);
            this.SGoNum.TabIndex = 29;
            this.SGoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SGoNum_KeyPress);
            // 
            // ConNum
            // 
            this.ConNum.Location = new System.Drawing.Point(115, 483);
            this.ConNum.Name = "ConNum";
            this.ConNum.Size = new System.Drawing.Size(67, 21);
            this.ConNum.TabIndex = 30;
            // 
            // ConCuNum
            // 
            this.ConCuNum.Location = new System.Drawing.Point(188, 483);
            this.ConCuNum.Name = "ConCuNum";
            this.ConCuNum.Size = new System.Drawing.Size(67, 21);
            this.ConCuNum.TabIndex = 31;
            this.ConCuNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConCuNum_KeyPress);
            // 
            // ConGoNum
            // 
            this.ConGoNum.Location = new System.Drawing.Point(261, 483);
            this.ConGoNum.Name = "ConGoNum";
            this.ConGoNum.Size = new System.Drawing.Size(67, 21);
            this.ConGoNum.TabIndex = 32;
            this.ConGoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConGoNum_KeyPress);
            // 
            // ConConsult
            // 
            this.ConConsult.Location = new System.Drawing.Point(334, 483);
            this.ConConsult.Name = "ConConsult";
            this.ConConsult.Size = new System.Drawing.Size(67, 21);
            this.ConConsult.TabIndex = 33;
            // 
            // ConWant
            // 
            this.ConWant.Location = new System.Drawing.Point(407, 483);
            this.ConWant.Name = "ConWant";
            this.ConWant.Size = new System.Drawing.Size(67, 21);
            this.ConWant.TabIndex = 34;
            // 
            // GoName
            // 
            this.GoName.Location = new System.Drawing.Point(188, 410);
            this.GoName.Name = "GoName";
            this.GoName.Size = new System.Drawing.Size(176, 21);
            this.GoName.TabIndex = 35;
            // 
            // BConNum
            // 
            this.BConNum.Location = new System.Drawing.Point(188, 522);
            this.BConNum.Name = "BConNum";
            this.BConNum.Size = new System.Drawing.Size(67, 21);
            this.BConNum.TabIndex = 36;
            this.BConNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BConNum_KeyPress);
            // 
            // BSum
            // 
            this.BSum.Location = new System.Drawing.Point(261, 522);
            this.BSum.Name = "BSum";
            this.BSum.Size = new System.Drawing.Size(67, 21);
            this.BSum.TabIndex = 37;
            // 
            // CuAddress
            // 
            this.CuAddress.Location = new System.Drawing.Point(261, 374);
            this.CuAddress.Name = "CuAddress";
            this.CuAddress.Size = new System.Drawing.Size(213, 21);
            this.CuAddress.TabIndex = 38;
            // 
            // DeleteSe
            // 
            this.DeleteSe.Location = new System.Drawing.Point(608, 446);
            this.DeleteSe.Name = "DeleteSe";
            this.DeleteSe.Size = new System.Drawing.Size(67, 21);
            this.DeleteSe.TabIndex = 41;
            this.DeleteSe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteSe_KeyPress);
            // 
            // DeleteCon
            // 
            this.DeleteCon.Location = new System.Drawing.Point(608, 481);
            this.DeleteCon.Name = "DeleteCon";
            this.DeleteCon.Size = new System.Drawing.Size(67, 21);
            this.DeleteCon.TabIndex = 42;
            this.DeleteCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteCon_KeyPress);
            // 
            // DeleteB
            // 
            this.DeleteB.Location = new System.Drawing.Point(608, 520);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(67, 21);
            this.DeleteB.TabIndex = 43;
            this.DeleteB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteB_KeyPress);
            // 
            // DeleteBBu
            // 
            this.DeleteBBu.Location = new System.Drawing.Point(704, 520);
            this.DeleteBBu.Name = "DeleteBBu";
            this.DeleteBBu.Size = new System.Drawing.Size(75, 23);
            this.DeleteBBu.TabIndex = 48;
            this.DeleteBBu.Text = "실행";
            this.DeleteBBu.UseVisualStyleBackColor = true;
            this.DeleteBBu.Click += new System.EventHandler(this.DeleteBBu_Click);
            // 
            // DeleteConBu
            // 
            this.DeleteConBu.Location = new System.Drawing.Point(704, 481);
            this.DeleteConBu.Name = "DeleteConBu";
            this.DeleteConBu.Size = new System.Drawing.Size(75, 23);
            this.DeleteConBu.TabIndex = 47;
            this.DeleteConBu.Text = "실행";
            this.DeleteConBu.UseVisualStyleBackColor = true;
            this.DeleteConBu.Click += new System.EventHandler(this.DeleteConBu_Click);
            // 
            // DeleteSeBu
            // 
            this.DeleteSeBu.Location = new System.Drawing.Point(704, 444);
            this.DeleteSeBu.Name = "DeleteSeBu";
            this.DeleteSeBu.Size = new System.Drawing.Size(75, 23);
            this.DeleteSeBu.TabIndex = 46;
            this.DeleteSeBu.Text = "실행";
            this.DeleteSeBu.UseVisualStyleBackColor = true;
            this.DeleteSeBu.Click += new System.EventHandler(this.DeleteSeBu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "삭제 테이블\r\n맨 앞 속성을 입력하세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 732);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteBBu);
            this.Controls.Add(this.DeleteConBu);
            this.Controls.Add(this.DeleteSeBu);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.DeleteCon);
            this.Controls.Add(this.DeleteSe);
            this.Controls.Add(this.CuAddress);
            this.Controls.Add(this.BSum);
            this.Controls.Add(this.BConNum);
            this.Controls.Add(this.GoName);
            this.Controls.Add(this.ConWant);
            this.Controls.Add(this.ConConsult);
            this.Controls.Add(this.ConGoNum);
            this.Controls.Add(this.ConCuNum);
            this.Controls.Add(this.ConNum);
            this.Controls.Add(this.SGoNum);
            this.Controls.Add(this.SCuNum);
            this.Controls.Add(this.CuName);
            this.Controls.Add(this.Execute5);
            this.Controls.Add(this.BNum);
            this.Controls.Add(this.NBTable);
            this.Controls.Add(this.Execute4);
            this.Controls.Add(this.NConTable);
            this.Controls.Add(this.Execute3);
            this.Controls.Add(this.Snum);
            this.Controls.Add(this.NSTable);
            this.Controls.Add(this.Execute2);
            this.Controls.Add(this.GoNum);
            this.Controls.Add(this.NGTable);
            this.Controls.Add(this.Execute1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuNum);
            this.Controls.Add(this.NCuTable);
            this.Controls.Add(this.PrintBill);
            this.Controls.Add(this.PrintConsult);
            this.Controls.Add(this.PrintSell);
            this.Controls.Add(this.PrintGood);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.Consult);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Good);
            this.Controls.Add(this.PrintCustom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrintCustom;
        private System.Windows.Forms.Button Good;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Button Consult;
        private System.Windows.Forms.Button Bill;
        private System.Windows.Forms.Label PrintGood;
        private System.Windows.Forms.Label PrintSell;
        private System.Windows.Forms.Label PrintConsult;
        private System.Windows.Forms.Label PrintBill;
        private System.Windows.Forms.TextBox NCuTable;
        private System.Windows.Forms.TextBox CuNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Execute1;
        private System.Windows.Forms.Button Execute2;
        private System.Windows.Forms.TextBox GoNum;
        private System.Windows.Forms.TextBox NGTable;
        private System.Windows.Forms.Button Execute3;
        private System.Windows.Forms.TextBox Snum;
        private System.Windows.Forms.TextBox NSTable;
        private System.Windows.Forms.Button Execute4;
        private System.Windows.Forms.TextBox NConTable;
        private System.Windows.Forms.Button Execute5;
        private System.Windows.Forms.TextBox BNum;
        private System.Windows.Forms.TextBox NBTable;
        private System.Windows.Forms.TextBox CuName;
        private System.Windows.Forms.TextBox SCuNum;
        private System.Windows.Forms.TextBox SGoNum;
        private System.Windows.Forms.TextBox ConNum;
        private System.Windows.Forms.TextBox ConCuNum;
        private System.Windows.Forms.TextBox ConGoNum;
        private System.Windows.Forms.TextBox ConConsult;
        private System.Windows.Forms.TextBox ConWant;
        private System.Windows.Forms.TextBox GoName;
        private System.Windows.Forms.TextBox BConNum;
        private System.Windows.Forms.TextBox BSum;
        private System.Windows.Forms.TextBox CuAddress;
        private System.Windows.Forms.TextBox DeleteSe;
        private System.Windows.Forms.TextBox DeleteCon;
        private System.Windows.Forms.TextBox DeleteB;
        private System.Windows.Forms.Button DeleteBBu;
        private System.Windows.Forms.Button DeleteConBu;
        private System.Windows.Forms.Button DeleteSeBu;
        private System.Windows.Forms.Label label3;
    }
}

