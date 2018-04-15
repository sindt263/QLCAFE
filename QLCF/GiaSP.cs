using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLCF
{
    public partial class GiaSP : Form
    {
        public GiaSP()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        private void GiaSP_Load(object sender, EventArgs e)
        {
            conn.connect();
            string selectdata = "select * from GiaSP";
            SqlCommand cmd = new SqlCommand(selectdata);
            
        }
    }
}
