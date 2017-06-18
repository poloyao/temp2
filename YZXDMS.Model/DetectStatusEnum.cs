using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Model
{
    /// <summary>
    /// 检测项目状态
    /// </summary>
    public enum DetectStatusEnum
    {
        /// <summary>
        /// 空闲中，无车
        /// </summary>
        Idle,
        /// <summary>
        /// 待检中，有车
        /// </summary>
        Waiting,
        /// <summary>
        /// 检测中
        /// </summary>
        Detecting,
        /// <summary>
        /// 复位中
        /// </summary>
        Reseting,
        /// <summary>
        /// 完成
        /// </summary>
        complete


    }

}
