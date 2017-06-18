using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.DLLProvider
{
    public class DLLProvider
    {
        /// <summary>
        /// 获取大灯dll
        /// </summary>
        /// <returns></returns>
        public static Detect.ILightDetect GetLightDetectDLL()
        {
            LightDetect.XXLight xx = new LightDetect.XXLight();
            return xx;
        }

        /// <summary>
        /// 获取光电dll
        /// </summary>
        /// <returns></returns>
        public static Detect.IPhotoelectricDevice GetPhotoelectricDLL()
        {
            LightDetect.XXPhotoelectric xx = new LightDetect.XXPhotoelectric();
            return xx;
        }
    }
}
