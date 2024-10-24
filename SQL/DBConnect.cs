﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SQL
{
    public class DBConnect
    {
        private SqlConnection _conn;
        private string _strConnect, _strServerName, _strDBName, _strUserID, _strPassword;
        private DataSet _dset;

        public DataSet Dset
        {
            get { return _dset; }
            set { _dset = value; }
        }
        public SqlConnection conn
        {
            get { return _conn; }
            set { _conn = value; }
        }
        public string strConnect
        {
            get { return _strConnect; }
            set { _strConnect = value; }
        }
        public string strServerName
        {
            get { return _strServerName; }
            set { _strServerName = value; }
        }
        public string strDBName
        {
            get { return _strDBName; }
            set { _strDBName = value; }
        }
        public string strUserID
        {
            get { return _strUserID; }
            set { _strUserID = value; }
        }
        public string strPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }
        public DBConnect(string strDBName)
        {
            strServerName = "CongManhPC\\MSSQLSERVER01"; //Tên máy server của mình (tên máy của SV)
            this.strDBName = strDBName;
            //Dùng với quyền của của Windows
            strConnect = @"Data Source=" + strServerName + ";Initial Catalog=" + strDBName +
            ";Integrated Security=true";
            //Dùng với quyền của SQL Server
            //strUserID = "";
            //strPassword = "";
            //strConnect = @"Data Source=" + strServerName + ";Initial Catalog=" + strDBName + ";User ID=" + strUserID + ";Password=" + strPassword;
            conn = new SqlConnection(strConnect); //Khởi tạo đối tượng kết nối đến CSDL
            Dset = new DataSet(strConnect);
        }
        public DBConnect(string pServerName, string pDBName)
        { //Dùng với quyền của của Windows
            strServerName = pServerName;
            strDBName = pDBName;
            strConnect = @"Data Source=" + strServerName + ";Initial Catalog=" + strDBName +
        ";Integrated Security=true";
            conn = new SqlConnection(strConnect); //Khởi tạo đối tượng kết nối đến CSDL
        }
        public DBConnect(string pServerName, string pDBName, string pUserID, string pPassword)
        { //Dùng với quyền của SQL Server
            strServerName = pServerName;
            strDBName = pDBName;
            strUserID = pUserID;
            strPassword = pPassword;
            strConnect = @"Data Source=" + strServerName + ";Initial Catalog=" + strDBName +
            ";User ID=" + strUserID + ";Password=" + strPassword;
            conn = new SqlConnection(strConnect); //Khởi tạo đối tượng kết nối đến CSDL
        }
        public void openConnect()
        { //Mở kết nối
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void closeConnect()
        { //Đóng kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public void disposeConnect()
        { //Hủy đối tượng kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Dispose(); //Giải phóng vùng nhớ đã cấp phát cho conn
        }
        public void updateToDataBase(string strSQL)
        { //Cho phép cập nhật CSDL với các thao tác gồm: Thêm, Xóa, Sửa
            openConnect(); //Mở kết nối
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL; //Câu truy vấn đưa vào
            cmd.ExecuteNonQuery(); //Thực thi
            closeConnect(); //Đóng kết nối
        }
        public int getCount(string strSQL)
        {
            openConnect(); //Mở kết nối
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL; //Câu truy vấn đưa vào
            int count = (int)cmd.ExecuteScalar(); //Thực thi
            closeConnect(); //Đóng kết nối
            return count;
        }
        public string getId(string strSQL)
        {
            openConnect(); //Mở kết nối
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL; //Câu truy vấn đưa vào
            string tmp = (string)cmd.ExecuteScalar(); //Thực thi
            closeConnect(); //Đóng kết nối
            return tmp;
        }
        public bool checkExist(string tableName, string fieldName, string fieldValue)
        {
            string strSQL = "SELECT COUNT(*) FROM " + tableName + " WHERE " + fieldName + "=N'"
            + fieldValue + "'";
            return getCount(strSQL) > 0 ? true : false;
        }

        public SqlDataAdapter getDataAdapter(string strSQL, string tableName)
        {
            openConnect();
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, conn);
            ada.Fill(Dset, tableName);
            closeConnect();
            return ada;
        }
        public DataTable getDataTable(string strSQL, string tableName)
        {
            openConnect();
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, conn);
            ada.Fill(Dset, tableName);
            closeConnect();
            return Dset.Tables[tableName];
        }
        public DataTable getDataTable(string strSQL, string tableName, params string[] keyName)
        {
            openConnect();
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, conn);
            ada.Fill(Dset, tableName);
            int n = keyName.Length;
            // Tao khoa chinh 
            DataColumn[] primaryKey = new DataColumn[n];
            for (int i = 0; i < n; i++)
            {
                primaryKey[i] = Dset.Tables[tableName].Columns[keyName[i]];
            }
            Dset.Tables[tableName].PrimaryKey = primaryKey;
            closeConnect();
            return Dset.Tables[tableName];
        }
        public decimal GetTotalAmount()
        {
            decimal totalAmount = 0;
            string query = "SELECT SUM(dongia * soluong) AS tongtien FROM CHITIETPHIEUNHAP";

            openConnect();
            SqlCommand command = new SqlCommand(query, conn);
            totalAmount = (decimal)command.ExecuteScalar();
            closeConnect(); // Ensure the connection is closed

            return totalAmount;
        }
    }
}
