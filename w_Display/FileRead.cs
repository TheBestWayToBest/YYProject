using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace w_Display
{
    public class FileRead
    {
        public static List<Model_Data> ReadUnFile(string path,out string msg)
        {
            StreamReader reader;
            List<Model_Data> list = new List<Model_Data>();
            string strs = "";
            try
            {
                reader = new StreamReader(path, Encoding.Default);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] str = new string[37];
                    str = line.Split(',');
                    Model_Data data = new Model_Data()
                    {
                        LineName = str[0],
                        LineCode = str[1],
                        CusName = str[2],
                        CusCode = str[3],
                        BillCode = str[4],
                        OrderDate = str[5],
                        PackageNo = Convert.ToInt32(str[6]),
                        Null1 = str[7],
                        Null2 = str[8],
                        Length = str[9],
                        Width = str[10],
                        Height = str[11],
                        CigName = str[12],
                        CigCode = str[13],
                        PositionX = str[14],
                        PositionY = str[15],
                        PositionZ = str[16],
                        CigNum = str[17],
                        CusPhoneNum = str[18],
                        CusAddress = str[19],
                        LegalPerson = Convert.ToInt32(str[20]),
                        CusBusiness = str[21],
                        SortDate = str[22],
                        Null3 = str[23],
                        CusSeq = str[24],
                        CusDeliverSeq = str[25],
                        Null4 = str[26],
                        CigLength = str[27],
                        CigWidth = str[28],
                        CigHeight = str[29],
                        CusPackageSeq = str[30],
                        CusTotalPackage = str[31],
                        LinePackageSeq = str[32],
                        LineTotalPackage = str[33],
                        PackageNum = str[34],
                        CusNum = str[35],
                        LineCusCount = str[36]
                    };
                    list.Add(data);
                    line = null;
                }
            }
            catch(Exception ex)
            {
                strs = ex.Message;
            }
            msg = strs;
            
            return list;
        }
        public static List<Model_NormalData> ReadNormalFile(string path,out string msg)
        {
            StreamReader reader;
            List<Model_NormalData> list = new List<Model_NormalData>();
            string strs = "";
            try
            {
                reader = new StreamReader(path, Encoding.Default);
                string line;
                int k = 0;
                int j = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] str = new string[31];
                    str = line.Split(',');
                    
                    if (Convert.ToInt32(str[21]) > 1)
                    {
                        for (int i = 0; i < Convert.ToInt32(str[21]); i++)
                        {
                            Model_NormalData data = new Model_NormalData()
                            {
                                LineName = str[16],
                                LineCode = str[15],
                                CusName = str[9],
                                CusCode = str[8],
                                BillCode = str[7],
                                OrderDate = str[5],
                                PackageNo = Convert.ToInt32(str[6]),
                                CigName = str[19],
                                CigCode = str[18],
                                CigNum = "1",
                                CusPhoneNum = str[14],
                                CusAddress = str[13],
                                CusSeq = str[10],
                                CusDeliverSeq = str[17],
                                CusPackageSeq = str[24],
                                CusTotalPackage = str[25],
                                LinePackageSeq = str[26],
                                LineTotalPackage = str[27],
                                PackageNum = str[22],
                                CusNum = str[23],
                            };
                            k++;
                            data.Null1 = j;
                            list.Add(data);
                            line = null;
                        }
                    }
                    else
                    {
                        Model_NormalData data = new Model_NormalData()
                        {
                            LineName = str[16],
                            LineCode = str[15],
                            CusName = str[9],
                            CusCode = str[8],
                            BillCode = str[7],
                            OrderDate = str[5],
                            PackageNo = Convert.ToInt32(str[6]),
                            CigName = str[19],
                            CigCode = str[18],
                            CigNum = str[21],
                            CusPhoneNum = str[14],
                            CusAddress = str[13],
                            CusSeq = str[10],
                            CusDeliverSeq = str[17],
                            CusPackageSeq = str[24],
                            CusTotalPackage = str[25],
                            LinePackageSeq = str[26],
                            LineTotalPackage = str[27],
                            PackageNum = str[22],
                            CusNum = str[23],
                        };
                        data.Null1 = j;
                        k++;
                        list.Add(data);
                        line = null;
                    }
                    if (k.ToString() == str[22])
                    {
                        j++;
                        k = 0;
                    }
                        
                }
            }
            catch (Exception ex)
            {
                strs = ex.Message;
            }
            msg = strs;

            return list;
        }
    }
}
