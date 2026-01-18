using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BTLWindowForm
{
    public class ClsThaoTacCSDL
    {

        string strConnect = @"Server=localhost;Initial Catalog=Deso10_TranTuyetAnh;Integrated Security=true;TrustServerCertificate=True;";
        SqlDataAdapter sqlAdap;
        DataTable dt;

        /// <summary>
        /// Phương thức lấy dữ liệu và thực thi câu lệnh SQL (Insert, Update, Detele...)
        /// </summary>
        /// <param name="strSQL">Chuỗi string mô tả câu lệnh select</param>
        /// <returns></returns>
        public DataTable ThucThiSQL(string strSQL)
        {
            //Bước 1: Khởi tạo DataAdapter và DataTable 
            //Chú ý: DataAdapter cần 2 chuỗi string
            sqlAdap = new SqlDataAdapter(strSQL, strConnect);
            dt = new DataTable();

            //Bước 2: Lấy dữ liệu
            sqlAdap.Fill(dt);

            //Bước 3: Return
            return dt;
        }
        public int ThucThiNonQuery(string sql, List<SqlParameter> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                return cmd.ExecuteNonQuery();
            }
        }
       
       

    }
}
