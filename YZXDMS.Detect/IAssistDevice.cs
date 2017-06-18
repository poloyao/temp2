using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Detect
{
    /// <summary>
    /// 辅助设备接口
    /// </summary>
    public interface IAssistDevice
    {
        /// <summary>
        /// 开启设备
        /// </summary>
        void OpenDevice();

        /// <summary>
        /// 关闭设备
        /// </summary>
        void CloseDevice();



    }

    /// <summary>
    /// 光电设备接口
    /// </summary>
    public interface IPhotoelectricDevice:IAssistDevice
    {
        /// <summary>
        /// 光电触发状态 true触发，false未触发
        /// </summary>
        bool IsTrigger { get; }

    }
}
