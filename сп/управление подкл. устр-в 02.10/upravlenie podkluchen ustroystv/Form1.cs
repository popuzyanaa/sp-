using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace upravlenie_podkluchen_ustroystv
{
    public partial class Form1 : Form
    {
        private ManagementObjectSearcher _searcher;

        public Form1()
        {
            InitializeComponent();
            _searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDeviceList();
        }

        private void UpdateDeviceList()
        {
            listBoxDevices.Items.Clear();
            foreach (ManagementObject device in _searcher.Get())
            {
                if (device != null)
                {
                    string deviceName = "";
                    if (device["Caption"] != null)
                    {
                        deviceName = device["Caption"].ToString();
                    }
                    else
                    {
                        deviceName = "Unknown device";
                    }
                    listBoxDevices.Items.Add(deviceName);
                }
                else
                {
                    listBoxDevices.Items.Add("Unknown device");
                }
            }
        }
        private void listBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDevices.SelectedItem != null)
            {
                string deviceName = listBoxDevices.SelectedItem.ToString();
                foreach (ManagementObject device in _searcher.Get())
                {
                    if (device != null)
                    {
                        if (device.Properties["Caption"] != null && device.Properties["Caption"].Value != null)
                        {
                            if (device.Properties["Caption"].Value.ToString() == deviceName)
                            {
                                string deviceInfo = "";
                                foreach (PropertyData property in device.Properties)
                                {
                                    if (property.Value != null)
                                    {
                                        deviceInfo += property.Name + ": " + property.Value.ToString() + "\n";
                                    }
                                }
                                textBoxDeviceInfo.Text = deviceInfo;
                            }
                        }
                    }
                }
            }
            else
            {
                textBoxDeviceInfo.Text = "";
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDeviceList();
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            DeviceItem device = (DeviceItem)listBoxDevices.SelectedItem;
            if (device != null)
            {
                if (MessageBox.Show("Вы уверены, что хотите отключить устройство?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        device.Disable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка отключения устройства: " + ex.Message);
                    }
                }
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateDeviceList();
        }
    }

    public class DeviceItem
    {
        private ManagementObject _device;

        public DeviceItem(ManagementObject device)
        {
            _device = device;
        }

        public string GetDeviceInfo()
        {
            string deviceInfo = "";
            deviceInfo += "Тип устройства: " + _device["Caption"] + "\n";
            deviceInfo += "Имя устройства: " + _device["Name"] + "\n";
            deviceInfo += "Статус устройства: " + _device["Status"] + "\n";
            deviceInfo += "Модель устройства: " + _device["Model"] + "\n";
            deviceInfo += "Идентификатор устройства: " + _device["DeviceID"] + "\n";

            // Add more properties as needed

            return deviceInfo;
        }

        public void Disable()
        {
            try
            {
                _device.InvokeMethod("Disable", null);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка отключения устройства: " + ex.Message);
            }
        }
    }
}