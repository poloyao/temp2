using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Detect;

namespace YZXDMS.DetectProvider
{
    /// <summary>
    /// 检测项目提供者
    /// </summary>
    public class DetecProvider
    {
        /// <summary>
        /// 获取大灯dll
        /// </summary>
        /// <returns></returns>
        public static ILightDetect GetLightDetect()
        {
            LightDetect.XXLight xx = new LightDetect.XXLight();
            return xx;
        }
        
    }
}
