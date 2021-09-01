using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Shaparak.PaymentFacilitation;
using Shaparak.PaymentFacilitation.Enums;
using Shaparak.PaymentFacilitation.Models;
using Shaparak.PaymentFacilitation.Infrastructure;

namespace PardakhtYar.Client.Services {

    public class ShaparakService {

        public const string _METHOD_WriteExternalRequest = "WriteExternalRequest";
        public const string _METHOD_ReadRequestCartable = "ReadRequestCartable";

        private IShaparakClient _shaparak;
        private readonly IHttpRestClient _restClient;
        private readonly HttpClient _httpClient;
        private readonly ITextLogger _logger;


        public ShaparakService() {
            _logger = new TextLogger(AppUtils.getAppLogPath());
            _httpClient = new HttpClient();
            _restClient = new HttpRestClient(_httpClient);
        }

        public string BaseUrl { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public void Initialize(string baseUrl, string userName, string password) {
            BaseUrl = baseUrl;
            UserName = userName;
            Password = password;

            Initialize();
        }

        public void Initialize() {
            if (string.IsNullOrEmpty(BaseUrl))
                throw new ArgumentNullException(nameof(BaseUrl));

            if (string.IsNullOrEmpty(UserName))
                throw new ArgumentNullException(nameof(UserName));

            if (string.IsNullOrEmpty(Password))
                throw new ArgumentNullException(nameof(Password));

            _shaparak = new ShaparakClient(_restClient,
                BaseUrl,
                UserName,
                Password);
        }

        public async Task<ShaparakWriteResponse> SendAsync(ShaparakWriteRequest request) 
           => await _shaparak.WriteExternalRequestAsync(request);
        
        public async Task<ShaparakReadRequestCartableResponse> SendAsync(ShaparakReadRequest request)
            => await _shaparak.ReadRequestCartableAsync(request);

        public async Task<ShaparakWriteResponse> SendWriteRequestAsync(string requestBody) {
            if (string.IsNullOrWhiteSpace(requestBody))
                throw new ArgumentNullException(nameof(requestBody));

            try {

                //var request = requestBody.ToObject<ShaparakWriteRequest>();
                var request = requestBody.ToWriteRequest();

                var response = await SendAsync(request);

                return await Task.FromResult(response);
            }
            catch(Exception ex) {
                await _logger.LogAsync(ex);
            }

            return null;
        }

        public async Task<ShaparakReadRequestCartableResponse> SendReadRequestAsync(string requestBody) {
            if (string.IsNullOrWhiteSpace(requestBody))
                throw new ArgumentNullException(nameof(requestBody));

            try {
                var request = requestBody.ToObject<ShaparakReadRequest>();

                var response = await SendAsync(request);

                return await Task.FromResult(response);
            }
            catch(Exception ex) {
                await _logger.LogAsync(ex);
            }

            return null;
        }
    }
}
