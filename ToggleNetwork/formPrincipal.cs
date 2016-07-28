using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ToggleNetwork
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;

            var ethernet = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(q => q.NetworkInterfaceType == NetworkInterfaceType.Ethernet && q.IsReceiveOnly == false && q.OperationalStatus == OperationalStatus.Up);
            Status(ethernet == null);
        }

        private void Status(bool internet)
        {
            lblConnect.Location = internet ? new Point(170, 63) : new Point(56, 63);
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1, "Toggle Network", internet ? "Conectado ao Wi-FI" : "Conectado a rede interna Magazine Luiza", ToolTipIcon.Info);
        }

        private void btnInternet_Click(object sender, System.EventArgs e)
        {
            Status(true);
            Connection.Fire(true);
        }

        private void btnIntranet_Click(object sender, System.EventArgs e)
        {
            Status(false);
            Connection.Fire(false);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
