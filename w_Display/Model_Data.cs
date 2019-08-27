using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace w_Display
{
    public class Model_Data
    {
        public decimal PNo { get; set; }
        public int ID { get; set; }
        /// <summary>
        /// 线路名称
        /// </summary>
        public string LineName { get; set; }

        /// <summary>
        /// 线路代码
        /// </summary>
        public string LineCode { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public string CusName { get; set; }

        /// <summary>
        /// 客户代码
        /// </summary>
        public string CusCode { get; set; }

        /// <summary>
        /// 订单哈
        /// </summary>
        public string BillCode { get; set; }

        /// <summary>
        /// 订单日期
        /// </summary>
        public string OrderDate { get; set; }

        /// <summary>
        /// 包号
        /// </summary>
        public int PackageNo { get; set; }

        /// <summary>
        /// 空1
        /// </summary>
        public string Null1 { get; set; }

        /// <summary>
        /// 空2
        /// </summary>
        public string Null2 { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public string Length { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        public string Height { get; set; }

        /// <summary>
        /// 卷烟名称
        /// </summary>
        public string CigName { get; set; }

        /// <summary>
        /// 卷烟代码
        /// </summary>
        public string CigCode { get; set; }

        /// <summary>
        /// 坐标X方向
        /// </summary>
        public string PositionX { get; set; }
        /// <summary>
        /// 坐标Y方向
        /// </summary>
        public string PositionY { get; set; }
        /// <summary>
        /// 坐标Z方向
        /// </summary>
        public string PositionZ { get; set; }
        /// <summary>
        /// 卷烟数量
        /// </summary>
        public string CigNum { get; set; }
        /// <summary>
        /// 客户电话
        /// </summary>
        public string CusPhoneNum { get; set; }
        /// <summary>
        /// 客户地址
        /// </summary>
        public string CusAddress { get; set; }

        /// <summary>
        /// 法人
        /// </summary>
        public int LegalPerson { get; set; }
        /// <summary>
        /// 客户营业执照
        /// </summary>
        public string CusBusiness { get; set; }
        /// <summary>
        /// 分拣日期
        /// </summary>
        public string SortDate { get; set; }
        /// <summary>
        /// 空3
        /// </summary>
        public string Null3 { get; set; }
        /// <summary>
        /// 客户顺序
        /// </summary>
        public string CusSeq { get; set; }
        /// <summary>
        /// 客户送货顺序
        /// </summary>
        public string CusDeliverSeq { get; set; }
        /// <summary>
        /// 空4
        /// </summary>
        public string Null4 { get; set; }
        /// <summary>
        /// 卷烟长度
        /// </summary>
        public string CigLength { get; set; }
        /// <summary>
        /// 卷烟宽度
        /// </summary>
        public string CigWidth { get; set; }
        /// <summary>
        /// 卷烟高度
        /// </summary>
        public string CigHeight { get; set; }
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
        /// <summary>
        /// 该包数量
        /// </summary>
        public string PackageNum { get; set; }
        /// <summary>
        /// 客户数量
        /// </summary>
        public string CusNum { get; set; }
        /// <summary>
        /// 线路户数
        /// </summary>
        public string LineCusCount { get; set; }
        public string LabelingStatus { get; set; }
    }
}
