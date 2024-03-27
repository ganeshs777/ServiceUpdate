using Microsoft.AspNetCore.SignalR.Client;
using ServiceUpdateService;
using System.Configuration;

namespace ServiceUpdate.Client.Forms
{
    public partial class ServiceUpdateClientForm : Form
    {
        SignalRServiceUpdaterService _SignalRServiceUpdaterService;

        public ServiceUpdateClientForm()
        {
            InitializeComponent();

            string hubURL = ConfigurationManager.AppSettings["ServiceUpdateNotifierUrl"];
            if (ConfigurationManager.AppSettings["ServiceUpdateNotifierUrl"] != null)
            {
                HubConnection connection = new HubConnectionBuilder()
                .WithUrl(hubURL)
                .Build();
                _SignalRServiceUpdaterService = new SignalRServiceUpdaterService(connection);
            }
            else
            {
                //LabelErrorMessage.Text = "Missing ServiceUpdateNotifierUrl setting";
            }
        }

        private void ServiceUpdateClientForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            _SignalRServiceUpdaterService.UpdateServiceMessageReceived += SignalRServiceUpdaterService_UpdateServiceMessageReceived;

            _SignalRServiceUpdaterService.Connect().ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    txtErrorInfo.Text = "Unable to connect to color chat hub";
                    lblErrorInfo.Visible = true;
                    txtErrorInfo.Visible = true;
                }
            });
            lblErrorInfo.Visible = false;
            txtErrorInfo.Visible = false;
        }

        private void SignalRServiceUpdaterService_UpdateServiceMessageReceived(ServiceUpdate.Models.Models.ServiceUpdate serviceUpdate)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            //txtServiceName.Text = "ServiceName : " + serviceUpdate.ServiceName + ", SetupFileLocation : " + serviceUpdate.SetupFileLocation;
            txtServiceName.Text = serviceUpdate.ServiceName;
            txtUpdateFileLocation.Text = serviceUpdate.SetupFileLocation;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            //to-do
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
