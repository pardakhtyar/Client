using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PardakhtYar.Client.Services;

namespace PardakhtYar.Client.UI {

    public partial class ShaparakUI : UserControl {

        private readonly ShaparakService _shaparak;
        private readonly ITextLogger _logger;

        public ShaparakUI() {
            InitializeComponent();
            _logger = new TextLogger(AppUtils.getAppLogPath());
            _shaparak = new ShaparakService();
            initComponents();
        }

        private const string _RES_writeModel_JSON = "PardakhtYar.Client.Resources.shaparak-writeModel.json";
        private const string _RES_readModel_JSON = "PardakhtYar.Client.Resources.shaparak-readModel.json";
           
        #region Properties

        public string BaseUrl {
            get => txtShaparakBaseUrl.Text.Trim();
            set => txtShaparakBaseUrl.Text = value;
        }

        public string UserName {
            get => txtUsername.Text.Trim();
            set => txtUsername.Text = value;
        }

        public string Password {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }

        public string RequestBody {
            get => txtShaparakBody.Text;
            set => txtShaparakBody.Text = value;
        }

        public string ResponseBody {
            get => txtShaparakResponse.Text;
            set => txtShaparakResponse.Text = value;
        }

        #endregion

        #region Methods

        private void showRequestErrror() {
            Invoke(new MethodInvoker(
                        () => MessageBox.Show("The Request stopped with an error, please check exception logs for details.",
                                                "Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error)
                ));
        }

        private void initComponents() {
            txtShaparakBody.Language = FastColoredTextBoxNS.Language.JS;

            cboMethods.Items.Clear();
            cboMethods.Items.Add(ShaparakService._METHOD_WriteExternalRequest);
            cboMethods.Items.Add(ShaparakService._METHOD_ReadRequestCartable);
            cboMethods.SelectedIndex = 0;
            cboMethods.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool IsWriteRequest => cboMethods.SelectedIndex == 0;

        private bool IsReadRequest => cboMethods.SelectedIndex == 1;

        private bool ValidateInputs() {
            const string __Required = "Please enter `{0}` field.";

            if(string.IsNullOrWhiteSpace(BaseUrl)) {
                errorProvider.SetError(
                    txtShaparakBaseUrl,
                    string.Format(__Required, "BaseUrl")
                );
                txtShaparakBaseUrl.Focus(); 
                return false;
            }

            if(string.IsNullOrWhiteSpace(UserName)) {
                errorProvider.SetError(
                    txtUsername,
                    string.Format(__Required, "UserName")
                );
                txtUsername.Focus();
                return false;
            }

            if(string.IsNullOrWhiteSpace(Password)) {
                errorProvider.SetError(
                    txtPassword,
                    string.Format(__Required, "Password")
                );
                txtPassword.Focus();
                return false;
            }

            if(string.IsNullOrWhiteSpace(RequestBody)) {
                showErrorMsg("The request body cannot be empty. Please fill request JSON body or load it form Menu.");
                txtShaparakBody.Focus();
                return false;
            }

            if(!BaseUrl.IsUrlValid()) {
                var error = "The BaseURL is not a valid url. Please check that the `BaseURL` is valid.";
                errorProvider.SetError(
                    txtShaparakBaseUrl,
                    error
                );
                showErrorMsg(error);
                txtShaparakBaseUrl.Focus();
                return false;
            }

            //if(!BaseUrl.CheckUrlIsReachable()) {
            //    var error = $"The requested url `{BaseUrl}` is not reachable right now or not found.";
            //    errorProvider.SetError(
            //        txtShaparakBaseUrl,
            //        error
            //    );
            //    showErrorMsg(error);
            //    txtShaparakBaseUrl.Focus();
            //    return false;
            //}

            return true;
        }

        private void showErrorMsg(string msg) {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private async void btnShaparakSend_Click(object sender, EventArgs e) {
            if (!ValidateInputs())
                return;

            Cursor = Cursors.WaitCursor;

            backgroundWorker.RunWorkerAsync();
            
            
        }

        private void mnuLoadSampleJson_Click(object sender, EventArgs e) {
            if(!string.IsNullOrWhiteSpace(RequestBody)) {
                if (MessageBox.Show(
                    "The request body is not empty. If you click 'Yes' the sample json will replace the body. Are you sure?",
                    "Load sample Json",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            if(IsWriteRequest)
                RequestBody = _RES_writeModel_JSON.ReadResourceFile();

            if (IsReadRequest)
                RequestBody = _RES_readModel_JSON.ReadResourceFile();

        }

        private void btnShaprakMenu_Click(object sender, EventArgs e) {
            menuServices.Show(
                btnShaprakMenu.PointToScreen(
                    new Point(0, btnShaprakMenu.Height))
            );
        }

        

        private async void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            _shaparak.Initialize(BaseUrl,
                UserName,
                Password);

            if (IsWriteRequest) {
                var response = await _shaparak.SendWriteRequestAsync(RequestBody);
                if(response == null) {
                    showRequestErrror();
                    return;
                }

                Invoke(new MethodInvoker(
                    () => ResponseBody = response.ToJson())
                );
            }

            if (IsReadRequest) {
                var response = await _shaparak.SendReadRequestAsync(RequestBody);
                if(response == null) {
                    showRequestErrror();
                    return;
                }

                Invoke(new MethodInvoker(
                    () => ResponseBody = response.ToJson())
                );
            }

            Invoke(new MethodInvoker(
                () => Cursor = Cursors.Default)
            );
            
        }
    }
}
