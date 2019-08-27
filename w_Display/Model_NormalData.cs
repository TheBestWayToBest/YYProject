using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w_Display
{
    public class Model_NormalData
    {

        public decimal PNo { get; set; }
        public int ID { get; set; }
        /// <summary>
        /// 订单日期
        /// </summary>
        public string OrderDate { get; set; }
        /// <summary>
        /// 包号
        /// </summary>
        public int PackageNo { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string BillCode { get; set; }
        /// <summary>
        /// 客户编码
        /// </summary>
        public string CusCode { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CusName { get; set; }

        /// <summary>
        /// 客户顺序
        /// </summary>
        public string CusSeq { get; set; }

        /// <summary>
        /// 客户地址
        /// </summary>
        public string CusAddress { get; set; }

        /// <summary>
        /// 客户电话
        /// </summary>
        public string CusPhoneNum { get; set; }

        /// <summary>
        /// 线路代码
        /// </summary>
        public string LineCode { get; set; }
        /// <summary>
        /// 线路名称
        /// </summary>
        public string LineName { get; set; }
        /// <summary>
        /// 客户送货顺序
        /// </summary>
        public string CusDeliverSeq { get; set; }
        /// <summary>
        /// 卷烟代码
        /// </summary>
        public string CigCode { get; set; }
        /// <summary>
        /// 卷烟名称
        /// </summary>
        public string CigName { get; set; }
        /// <summary>
        /// 卷烟数量
        /// </summary>
        public string CigNum { get; set; }
        /// <summary>
        /// 该包数量
        /// </summary>
        public string PackageNum { get; set; }
        /// <summary>
        /// 客户数量
        /// </summary>
        public string CusNum { get; set; }
        /// <summary>
        /// 客户包序
        /// </summary>
        public string CusPackageSeq { get; set; }
        /// <summary>
        /// 客户总包数
        /// </summary>
        public string CusTotalPackage { get; set; }
        /// <summary>
        /// 线路包序
        /// </summary>
        public string LinePackageSeq { get; set; }
        /// <summary>
        /// 线路总包数
        /// </summary>
        public string LineTotalPackage { get; set; }

        public string LabelingStatus { get; set; }
        public decimal Null1 { get; set; }
    }
}
