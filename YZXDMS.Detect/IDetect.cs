using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Model;

namespace YZXDMS.Detect
{
    /// <summary>
    /// 检测项目接口
    /// </summary>
    public interface IDetect
    {

        #region 属性
        /// <summary>
        /// 检测项目状态，派生类使用get赋值。
        /// </summary>
        DetectStatusEnum DetectStatus { get; }


        #endregion

        /// <summary>
        /// 开始检测
        /// </summary>
        void StartDetect();

        /// <summary>
        /// 停止检测
        /// </summary>
        void StopDetect();

        /// <summary>
        /// 复位设备
        /// </summary>
        void ResetDetect();

    }

}
