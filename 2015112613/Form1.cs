using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace _2015112613
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server =linux.mme.dongguk.edu;uid=s2015112613;port=33060;database=s2015112613;pwd=;charset =utf8;");
        int Ccount;//고객번호
        int Gcount;//제품번호
        int Scount;//구매번호
        int Concount;//상담번호
        int Bcount;//청구번호
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //MySqlCommand cmd = new MySqlCommand("Insert into NCustomer VALUES(2, '강현구','경기도 의정부시')", conn);
            //cmd.ExecuteNonQuery();
            NCuTable.Text = "NCustomer";
            NGTable.Text = "NGood";
            NSTable.Text = "Nsell";
            NConTable.Text = "consult";
            NBTable.Text = "NBill";
            
            
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            conn.Open();
            PrintCustom.Text = null;
            PrintCustom.Text = "고객 테이블 출력창(NCustomer)";
            PrintCustom.Text += "\r\n";
            PrintCustom.Text += "고객번호    고객이름    주소";
            string str = "select * from NCustomer";
            MySqlCommand rdr = new MySqlCommand(str, conn);
            MySqlDataReader reader = rdr.ExecuteReader();
            Ccount = 0;
            while (reader.Read())
            {
                CuNum.Clear();
                Ccount++;
                PrintCustom.Text += "\r\n";
                PrintCustom.Text +="    "+ reader["고객번호"] + "            " + reader["고객이름"] + "      " + reader["주소"];
                CuNum.Text += Ccount + 1;
            }
            conn.Close();
        }

        private void Good_Click(object sender, EventArgs e)
        {
            conn.Open();
            PrintGood.Text = null;
            PrintGood.Text = "제품 테이블 출력창(NGood)";
            PrintGood.Text += "\r\n";
            PrintGood.Text += "제품번호     제품이름";
            string str = "select * from NGood";
            MySqlCommand rdr = new MySqlCommand(str, conn);
            MySqlDataReader reader = rdr.ExecuteReader();
            Gcount = 0;
            while (reader.Read())
            {
                Gcount++;
                GoNum.Clear();
                PrintGood.Text += "\r\n";
                PrintGood.Text += "     "+reader["제품번호"] + "             " + reader["제품이름"];
                GoNum.Text += Gcount + 1;
            }
            conn.Close();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            conn.Open();
            PrintSell.Text = null;
            PrintSell.Text = "구매 테이블 출력창(Nsell)";
            PrintSell.Text += "\r\n";
            PrintSell.Text += "구매번호     고객번호    제품번호";
            string str = "select * from Nsell";
            MySqlCommand rdr = new MySqlCommand(str, conn);
            MySqlDataReader reader = rdr.ExecuteReader();
            Scount = 0;
            while (reader.Read())
            {
                Scount++;
                Snum.Clear();
                PrintSell.Text += "\r\n";
                PrintSell.Text += "     "+reader["구매번호"] + "                " + reader["고객번호"] + "               " + reader["제품번호"];
                Snum.Text += Scount+1;
            }
            conn.Close();
        }

        private void Consult_Click(object sender, EventArgs e)
        {
            conn.Open();
            PrintConsult.Text = null;
            PrintConsult.Text = "상담 테이블 출력창(consult)";
            PrintConsult.Text += "\r\n";
            PrintConsult.Text += "상담번호   고객번호    제품번호    상담사유    출장여부";
            string str = "select * from consult";
            MySqlCommand rdr = new MySqlCommand(str, conn);
            MySqlDataReader reader = rdr.ExecuteReader();
            Concount = 0;
            while (reader.Read())
            {
                Concount++;
                ConNum.Clear();
                PrintConsult.Text += "\r\n";
                PrintConsult.Text += "  "+reader["상담번호"] + "               " + reader["고객번호"] + "                " + reader["제품번호"] + "               " + reader["상담사유"] + "            " + reader["출장여부"];
                ConNum.Text += Concount + 1;
            }
            conn.Close();
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            conn.Open();
            PrintBill.Text = null;
            PrintBill.Text = "요금 테이블 출력창(NBill)";
            PrintBill.Text += "\r\n";
            PrintBill.Text += "청구번호  상담번호    합계";
            string str = "select * from NBill";
            MySqlCommand rdr = new MySqlCommand(str, conn);
            MySqlDataReader reader = rdr.ExecuteReader();
            Bcount = 0;
            while (reader.Read())
            {
                Bcount++;
                BNum.Clear();
                PrintBill.Text += "\r\n";
                PrintBill.Text += "     "+reader["청구번호"] + "          " + reader["상담번호"] + "              " + reader["합계"];
                BNum.Text += Bcount + 1;

            }
            conn.Close();
        }

        private void ExcuteInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into " + NCuTable.Text + " Values(" + Convert.ToInt32(CuNum.Text) + ", '" + CuName.Text + "', '" + CuAddress.Text + "' )", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            CuName.Clear();
            CuAddress.Clear();
            CuNum.Clear();
            //MySqlCommand cmd = new MySqlCommand("Insert into NCustomer VALUES(2, '강현구','경기도 의정부시')", conn);
            //cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into " + NGTable.Text + " Values(" + Convert.ToInt32(GoNum.Text) + ", '" + GoName.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            GoNum.Clear();
            GoName.Clear();
          
            //MySqlCommand cmd = new MySqlCommand("Insert into NCustomer VALUES(2, '강현구','경기도 의정부시')", conn);
            //cmd.ExecuteNonQuery();
        }

        private void Execute3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into " + NSTable.Text + " Values(" + Convert.ToInt32(Snum.Text) + ", " + Convert.ToInt32(SCuNum.Text) + ","+ Convert.ToInt32(SGoNum.Text) + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Snum.Clear();
            SCuNum.Clear();
            SGoNum.Clear();
        }

        private void Execute4_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into " + NConTable.Text + " Values(" + Convert.ToInt32(ConNum.Text) + ", " + Convert.ToInt32(ConCuNum.Text) + "," + Convert.ToInt32(ConGoNum.Text) +",'"+ConConsult.Text+"','"+ConWant.Text+ "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            ConNum.Clear();
            ConCuNum.Clear();
            ConGoNum.Clear();
            ConConsult.Clear();
            ConWant.Clear();
        }

        private void Execute5_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into " + NBTable.Text + " Values(" + Convert.ToInt32(BNum.Text) + ", " + Convert.ToInt32(BConNum.Text) + "," + Convert.ToInt32(BSum.Text) + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            BNum.Clear();
            BConNum.Clear();
            BSum.Clear();
        }

        private void SCuNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))

            {
             
                e.Handled = true;
            }

        }

        private void SGoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))

            {

                e.Handled = true;
            }
        }

        
private void ConCuNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))

            {

                e.Handled = true;
            }
        }

        private void ConGoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))

            {

                e.Handled = true;
            }
        }

        private void BConNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }


        private void DeleteSe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void DeleteCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void DeleteB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void DeleteSeBu_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete from " + NSTable.Text + " where 구매번호 = "+DeleteSe.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void DeleteConBu_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete from " + NConTable.Text + " where 상담번호 = " + DeleteCon.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void DeleteBBu_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete from " + NBTable.Text + " where 청구번호 = " + DeleteB.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
