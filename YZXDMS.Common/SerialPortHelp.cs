using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YZXDMS.Model;

namespace YZXDMS.Common
{
    /// <summary>
    /// 串口帮助类，获取设备的串口实例
    /// </summary>
    public class SerialPortHelp
    {
        private static List<PortConfigModel> StaticPort { get; set; } = new List<PortConfigModel>();

        private static readonly SerialPortHelp instance = new SerialPortHelp();

        public static SerialPortHelp GetInstance()
        {
            return instance;
        }

        private SerialPortHelp()
        {
            InitPort();
        }

        /// <summary>
        /// 初始化串口列表，
        /// 根据配置文件创建。
        /// 联动关闭所有串口连接并清空串口列表
        /// </summary>
        public static void InitPort()
        {
            ClearPorts();
            //StaticPort.Add(new PortElement()
            //{
            //    DeviceType = DeviceType.LatticeScreen,
            //    DetectionType = DetectionType.Light,
            //    PortName = "COM1",
            //    BaudRate = 9600,
            //    DataBits = 8,
            //    Parity = Parity.None,
            //    StopBits = StopBits.One
            //});
            //StaticPort.Add(new PortElement()
            //{
            //    DeviceType = DeviceType.Photoelectric,
            //    DetectionType = DetectionType.Light,
            //    PortName = "COM1",
            //    BaudRate = 9600,
            //    DataBits = 8,
            //    Parity = Parity.None,
            //    StopBits = StopBits.One
            //});
        }

        /// <summary>
        /// 清空并关闭所有串口
        /// </summary>
        private static void ClearPorts()
        {
            if (StaticPort == null)
                return;
            CloseAllPort();
            StaticPort.Clear();
        }


        /// <summary>
        /// 获取指定的串口实例
        /// </summary>
        /// <param name="device">设备类型</param>
        /// <param name="detection">检测项目</param>
        /// <param name="index">编号</param>
        /// <returns></returns>
        public static PortConfigModel GetCoreDevicePort(DeviceProperty device, DetectionType detection, int index = 0)
        {
            try
            {
                if (StaticPort == null)
                    throw new Exception();
                var port = StaticPort.Single(x => x.DeviceProperty == device &&  x.Index == index);
                return port;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 获取指定辅助设备串口实例
        /// </summary>
        /// <param name="device">设备类型</param>
        /// <param name="detection">检测项目</param>
        /// <param name="index">编号</param>
        /// <returns></returns>
        public static PortConfigModel GetAssistDevicePort(DeviceProperty device, DetectionType detection, int index = 0)
        {
            try
            {
                if (StaticPort == null)
                    throw new Exception();
                var port = StaticPort.Single(x => x.DeviceProperty == device && x.Index == index);
                return port;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 断开全部串口，例：应用于全局配置文件修改后
        /// </summary>
        public static void CloseAllPort()
        {
            if (StaticPort == null)
                return;
            StaticPort.ForEach(x =>
            {
                if (x.Port.IsOpen)
                    x.Port.Close();
            });
        }

        /// <summary>
        /// 断开指定串口
        /// </summary>
        /// <param name="device"></param>
        /// <param name="detection"></param>
        /// <param name="index"></param>
        public static void ClosePort(DeviceProperty device, DetectionType detection, int index = 0)
        {
            try
            {
                if (StaticPort == null)
                    throw new Exception();
                var item = StaticPort.Single(x => x.DeviceProperty == device && x.Index == index);
                if (item.Port.IsOpen)
                    item.Port.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
