using System.Linq;
using System.Management;

namespace ToggleNetwork
{
    public static class Connection
    {
        public static void Fire(bool internet)
        {
            Toogle("Ethernet", !internet);
            Toogle("Wi-Fi", internet);
        }
        private static void Toogle(string interfaceName, bool activate)
        {
            using (var searcher = new ManagementObjectSearcher(new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL")))
            using (var results = searcher.Get())
            {
                var item = results.Cast<ManagementObject>().FirstOrDefault(x => ((string)x["NetConnectionId"]) == interfaceName);
                item?.InvokeMethod(activate ? "Enable" : "Disable", null);
                item?.Dispose();
            }
        }
    }
}
