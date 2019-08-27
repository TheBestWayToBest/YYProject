using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace w_Display
{
    public class BLL_Data
    {
        public static bool InsertUnnormalData(Model_Data data)
        {
            data.OrderDate = data.OrderDate.Substring(0, data.OrderDate.IndexOf(" ") + 1);
            data.SortDate = data.SortDate.Substring(0, data.SortDate.IndexOf(" ") + 1);
            string sqlStr = "insert into T_PRODUCE_CALLBACK values('" + data.LineName + "','" + data.LineCode + "','" +
                data.CusName + "','" + data.CusCode + "','" + data.BillCode + "','" + data.OrderDate + "','" + data.PackageNo + "','" +
                data.Null1 + "','" + data.Null2 + "','" + data.Length + "','" + data.Width + "','" + data.Height + "','" +
                data.CigName + "','" + data.CigCode + "','" + data.PositionX + "','" + data.PositionY + "','" + data.PositionZ + "','" +
                data.CigNum + "','" + data.CusPhoneNum + "','" + data.CusAddress + "','" + data.CusBusiness + "','" +
                data.SortDate + "','" + data.Null3 + "','" + data.CusSeq + "','" + data.CusDeliverSeq + "','" + data.CigLength + "','" +
                data.CigWidth + "','" + data.CigHeight + "','" + data.CusPackageSeq + "','" + data.CusTotalPackage + "','" + data.LinePackageSeq + "','" +
                data.LineTotalPackage + "','" + data.PackageNum + "','" + data.CusNum + "','" + data.LineCusCount + "','" + data.LabelingStatus + "','" + data.ID + "','" + data.Null4 + "','" + data.LegalPerson + "'," + data.PNo + ")";
            return OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr) > 0;
        }

        public static bool InsertNormalData(Model_NormalData data)
        {
            data.OrderDate = data.OrderDate.Substring(0, data.OrderDate.IndexOf(" ") + 1);
            string sqlStr = "insert into T_PRODUCE_CALLBACK(linename,linecode,customername,customercode,billcode,orderdate,packageno,null1,cigarettename,cigarettecode,cigarettenum," +
                "CUSTOMERPHONE,CUSTOMERADDRESS,CUSTOMERSEQ,CUSDELIVERSEQ,CUSPACKAGESEQ,CUSTOTALPACKAGE,LINEPACKAGESEQ,LINETOTALPACKAGE,PACKAGENUM,CUSTOMERNUM,LABELINGSTATUS,ID,PNO) values('" +
                data.LineName + "','" + data.LineCode + "','" +
                data.CusName + "','" + data.CusCode + "','" + data.BillCode + "','" + data.OrderDate + "','" + data.PackageNo + "','" + data.Null1 + "','" +
                data.CigName + "','" + data.CigCode + "','" +
                data.CigNum + "','" + data.CusPhoneNum + "','" + data.CusAddress + "','" +
                data.CusSeq + "','" + data.CusDeliverSeq + "','" +
                data.CusPackageSeq + "','" + data.CusTotalPackage + "','" + data.LinePackageSeq + "','" +
                data.LineTotalPackage + "','" + data.PackageNum + "','" + data.CusNum + "','" + data.LabelingStatus + "','" + data.ID + "'," + data.PNo + ")";
            return OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr) > 0;
        }

        public static List<Model_BillInfo> GetAllBillInfo(decimal pno)
        {
            string sqlStr = "select PACKAGENO,CUSTOMERNAME,LABELINGSTATUS,LINENAME,BILLCODE,ORDERDATE,CUSTOMERADDRESS from t_produce_callback T " +
                "where PNO=" + pno + " GROUP BY PACKAGENO,CUSTOMERNAME,LABELINGSTATUS,LINENAME,BILLCODE,ORDERDATE,CUSTOMERADDRESS ORDER BY PACKAGENO ";
            OracleDataReader reader = OracleHelper.ExecuteReader(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr);
            List<Model_BillInfo> list = new List<Model_BillInfo>();
            while (reader.Read())
            {
                Model_BillInfo billInfo = new Model_BillInfo()
                {
                    PackageNo = Convert.ToInt32(reader["PACKAGENO"].ToString().Trim()),
                    BillCode = reader["BILLCODE"].ToString(),
                    CusAddress = reader["CUSTOMERADDRESS"].ToString(),
                    CusName = reader["CUSTOMERNAME"].ToString(),
                    LabelingStatus = reader["LABELINGSTATUS"].ToString(),
                    LineName = reader["LINENAME"].ToString(),
                    OrderDate = reader["ORDERDATE"].ToString()
                };
                list.Add(billInfo);
            }
            reader.Close();
            return list;
        }

        public static bool ClearData(decimal pno)
        {
            string sqlStr = "delete from t_produce_callback where pno=" + pno;
            return OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr) > 0;
        }

        public static int GetIDByPackageNo(int packageNo,int pno)
        {
            string sqlStr = "";
            if (pno == 1)
                sqlStr = "select min(id) from t_produce_callback where pno=" + pno + " and packageno=" + packageNo;
            else
                sqlStr = "select min(id) from t_produce_callback where pno=" + pno + " and null1=" + packageNo;
            return Convert.ToInt32(OracleHelper.ExecuteScalar(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr));
        }

        public static bool DataPosition(int packageno, int currentPackageno, decimal pno)
        {
            //string sqlStr = "select packageno from t_produce_callback where id =" + packageno + " and PNO=" + pno;

            //int pack = Convert.ToInt32(OracleHelper.ExecuteScalar(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr));
            string sqlStr1 = "update t_produce_callback set LABELINGSTATUS='1' where  LABELINGSTATUS='0' and null1<" + packageno + " and PNO=" + pno;

            string sqlStr2 = "update t_produce_callback set LABELINGSTATUS='0' where  LABELINGSTATUS='1' and null1>=" + packageno + " and PNO=" + pno;
            bool flag1 = OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr1) >= 0;
            bool flag2 = OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr2) >= 0;
            return flag1 && flag2;
        }
        public static bool DataPosition(int packageno, decimal pno)
        {
            //string sqlStr = "select packageno from t_produce_callback where id =" + packageno + " and PNO=" + pno;

            //int pack = Convert.ToInt32(OracleHelper.ExecuteScalar(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr));
            string sqlStr1 = "update t_produce_callback set LABELINGSTATUS='1' where  LABELINGSTATUS='0' and packageno<" + packageno + " and PNO=" + pno;

            string sqlStr2 = "update t_produce_callback set LABELINGSTATUS='0' where  LABELINGSTATUS='1' and packageno>=" + packageno + " and PNO=" + pno;
            bool flag1 = OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr1) >= 0;
            bool flag2 = OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr2) >= 0;
            return flag1 && flag2;

        }

        public static List<Model_Data> GetData(decimal pno)
        {
            string sqlStr = "select * from T_PRODUCE_CALLBACK where PNO=" + pno + " order by id";
            OracleDataReader reader = OracleHelper.ExecuteReader(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr);
            List<Model_Data> list = new List<Model_Data>();
            while (reader.Read())
            {
                Model_Data billInfo = new Model_Data()
                {
                    CigName = reader["CIGARETTENAME"].ToString(),
                    CigCode = reader["CIGARETTECODE"].ToString(),
                    ID = Convert.ToInt32(reader["ID"]),
                    PackageNo = Convert.ToInt32(reader["PACKAGENO"].ToString().Trim()),
                    BillCode = reader["BILLCODE"].ToString(),
                    CusAddress = reader["CUSTOMERADDRESS"].ToString(),
                    CusName = reader["CUSTOMERNAME"].ToString(),
                    LabelingStatus = reader["LABELINGSTATUS"].ToString(),
                    LineName = reader["LINENAME"].ToString(),
                    OrderDate = reader["ORDERDATE"].ToString(),
                    PositionY = reader["POSITIONY"].ToString(),
                    PositionZ = reader["POSITIONZ"].ToString(),
                    CusTotalPackage = reader["CUSTOTALPACKAGE"].ToString(),
                    PackageNum = reader["PACKAGENUM"].ToString(),
                    LineCusCount = reader["LINECUSCOUNT"].ToString(),
                    LineTotalPackage = reader["LINETOTALPACKAGE"].ToString(),
                    LinePackageSeq = reader["LINEPACKAGESEQ"].ToString(),
                    Length = reader["LENGTH"].ToString(),
                    Width = reader["WIDTH"].ToString(),
                    Height = reader["HEIGHT"].ToString()
                };
                list.Add(billInfo);
            }
            reader.Close();
            return list;
        }
        public static bool UpdateLabelingStatus(int packageNo, decimal pno)
        {
            string sqlStr = "update T_PRODUCE_CALLBACK set LABELINGSTATUS='1' where PACKAGENO=" + packageNo + " and PNO=" + pno;
            return OracleHelper.ExecuteNonQuery(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr) > 0;
        }

        public static int GetMaxID(decimal pno)
        {
            string sqlStr = "select max(id) from t_produce_callback where PNO=" + pno;
            string k = OracleHelper.ExecuteScalar(OracleHelper.ConnectionString, System.Data.CommandType.Text, sqlStr).ToString();
            int id;
            if (int.TryParse(k, out id))
            {
                return id;
            }
            return 0;
        }
    }
}
