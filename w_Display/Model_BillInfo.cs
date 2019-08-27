using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace w_Display
{
    public class Model_BillInfo
    {
        private string _status;

        public int PackageNo { get; set; }
        public string CusName { get; set; }
        public string LabelingStatus
        {
            get { return _status; }
            set
            {
                if (value == "0")
                    _status = "未完成";
                else
                    _status = "已完成";
            }
        }
        public string LineName { get; set; }
        public string BillCode { get; set; }
        public string OrderDate { get; set; }
        public string CusAddress { get; set; }
    }
    //public class CigColor
    //{
    //    public static Dictionary<string,Color> GetPairs()
    //    {
    //        Dictionary<string, Color> pairs = new Dictionary<string, Color>();
    //        pairs.Add("1430130", Color.LightCyan);
    //        pairs.Add("1320125", Color.LightGoldenrodYellow);
    //        pairs.Add("1430281", Color.Red);
            
    //        return pairs;
    //    }
    //    public static Color GetColor(string cigNo, Dictionary<string, Color> pairs)
    //    {
    //        return pairs[cigNo];
    //    }
    //}
}
