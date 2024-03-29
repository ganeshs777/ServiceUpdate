using Microsoft.AspNetCore.SignalR.Client;
using ServiceUpdateService;
using System.Configuration;

namespace ServiceUpdate.Server
{
    public partial class ServiceUpdateServer : Form
    {
        SignalRServiceUpdaterService _SignalRServiceUpdaterService;
        public ServiceUpdateServer()
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
                if(lblError.InvokeRequired )
                {
                    this.Invoke(() =>
                    {
                        lblError.Visible = true;
                        lblError.Text = "Missing ServiceUpdateNotifierUrl setting";
                    });
                }
                
            }
        }

        private async void btnSendServiceUpdateMessage_Click(object sender, EventArgs e)
        {
            try
            {
                await _SignalRServiceUpdaterService.SendServiceUpdateMessage(new ServiceUpdate.Models.Models.ServiceUpdate()
                {
                    ServiceName = TextBoxServiceName.Text,
                    SetupFileLocation = TextBoxSetupFilePath.Text
                });

                lblError.Text = string.Empty;
            }
            catch (Exception)
            {
                if (lblError.InvokeRequired)
                {
                    this.Invoke(() =>
                    {
                        lblError.Visible = true;
                        lblError.Text = "Unable to send update service message.";
                    });
                }
            }
        }

        private void ServiceUpdateServer_Load(object sender, EventArgs e)
        {
            _SignalRServiceUpdaterService.UpdateServiceMessageReceived += SignalRServiceUpdaterService_UpdateServiceMessageReceived;

            _SignalRServiceUpdaterService.Connect().ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    if (lblError.InvokeRequired)
                    {
                        this.Invoke(() =>
                        {
                            lblError.Text = "Unable to connect to service update hub";
                        });
                    }
                }
            });
        }

        private void SignalRServiceUpdaterService_UpdateServiceMessageReceived(ServiceUpdate.Models.Models.ServiceUpdate serviceUpdate)
        {
            if (LabelServiceUpdateMessage.InvokeRequired)
            {
                this.Invoke(() =>
                {
                    LabelServiceUpdateMessage.Text = "ServiceName : " + serviceUpdate.ServiceName + ", SetupFileLocation : " + serviceUpdate.SetupFileLocation;
                });
            }
        }

    }

}
