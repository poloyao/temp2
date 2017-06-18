using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using YZXDMS.Model;
using System.Collections.Generic;

namespace YZXDMS.ViewModels
{
    [POCOViewModel]
    public class SettingPortViewModel
    {

        public List<PortConfigModel> Items { get; set; } = new List<PortConfigModel>();



        public SettingPortViewModel()
        {
            Items.Add(new PortConfigModel() { Name = "光电", DeviceProperty = DeviceProperty.AssistDevice, Port = new System.IO.Ports.SerialPort() });

        }

    }
}