using System;
using System.Management;

namespace BenchmarkLab {
    class CPU {
        public static string getInfo(string element) {
            string info = string.Empty;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mj in mos.Get())
                info = Convert.ToString(mj[element]);
            return info;
        }
    }
}