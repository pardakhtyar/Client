using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PardakhtYar.Client.UI;
using Shaparak.PaymentFacilitation;
using Shaparak.PaymentFacilitation.Models;
using Shaparak.PaymentFacilitation.Enums;
using Shaparak.PaymentFacilitation.Infrastructure;

namespace PardakhtYar.Client
{
    public partial class MainForm : Form {

        private ShaparakUI shaparakUI;

        public MainForm() {
            InitializeComponent();
            initComponent();

        }

        private void doWork() {
            //_shaparak.WriteExternalRequestAsync(new ShaparakWriteRequest {
            //    RequestType = ShaparakRequestType.RequestNewTerminalFromPsp,
            //    Merchant = new ShaparakMerchant {
                    
            //    }
            //});

        }


        #region Methods

        private void initComponent() {
            shaparakUI = new ShaparakUI { Dock = DockStyle.Fill };
            tabShaparak.Controls.Add(shaparakUI);
        }

        private void initShaparak() {
            
        }

        private void sendShaparakRequest() {

        }

        #endregion

        private void btnShaparakSend_Click(object sender, EventArgs e) {

        }
    }
}
