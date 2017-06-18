using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Model
{
    /// <summary>
    /// 串口
    /// </summary>
    public class PortModel: SerialPort
    {
        /// <summary>
        /// 协议类型
        /// </summary>
        [Display(Name = "协议类型", Order = 99)]
        public string ProtocolType { get; set; }

        ///// <summary>
        ///// 设备类型
        ///// </summary>
        //[Display(Name = "设备类型")]
        //public DeviceType DeviceType { get; set; }

        ///// <summary>
        ///// 检测项目
        ///// </summary>
        //[Display(Name = "检测项目")]
        //public DetectionType DetectionType { get; set; }

        ///// <summary>
        ///// 编号。用于区分同一工位或流程中出现的同款设备
        ///// </summary>
        //[Display(Name = "编号", Description = "用于区分同一工位或流程中出现的同款设备")]
        //public int Index { get; set; }

        ///// <summary>
        ///// 设备在线情况
        ///// </summary>
        //public bool IsOnline { get; set; }
    }

    /// <summary>
    /// 串口配置文件
    /// </summary>
    public class PortConfigModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 串口
        /// </summary>
        public SerialPort Port { get; set; }
        /// <summary>
        /// 设备性质
        /// </summary>
        public DeviceProperty DeviceProperty { get; set; }
        /// <summary>
        /// 协议
        /// </summary>
        public ProtocolModel Protocol { get; set; }
        
    }

    /// <summary>
    /// 协议
    /// </summary>
    public class ProtocolModel
    {
        /// <summary>
        /// 协议名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 协议ID
        /// </summary>
        public int ID { get; set; }
    }
}
