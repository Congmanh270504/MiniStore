﻿using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Forms
{
    public partial class frm_UserPermission : Form
    {
        User user = new User();
        DBConnect db;
        public frm_UserPermission()
        {
            InitializeComponent();
            user = frm_Login.LoggedInUser;
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
        }


    }
}
