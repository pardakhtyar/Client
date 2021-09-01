using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using Shaparak.PaymentFacilitation.Models;

namespace PardakhtYar.Client {

    public static class Extensions {

        public static bool IsUrlValid(this string url) {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException(nameof(url));

            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        public static bool CheckUrlIsReachable(this string url) {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException(nameof(url));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 30000;
            request.Method = "HEAD";
            try {
                using (var response = (HttpWebResponse)request.GetResponse()) {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch(WebException) {
                return false;
            }
        }

        public static string ReadResourceFile(this string resourceName) {
            string result = null;
            var assembly = Assembly.GetExecutingAssembly();

            using(Stream stream = assembly.GetManifestResourceStream(resourceName))
            using(StreamReader reader = new StreamReader(stream)) {
                result = reader.ReadToEnd();
            }

            return result;
        }

        public static T ToObject<T>(this string body) where T: class {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentNullException(nameof(body));

            return JsonConvert.DeserializeObject<T>(body);
        }

        public static ShaparakWriteRequest ToWriteRequest(this string body) {
            if (string.IsNullOrWhiteSpace(body))
                throw new ArgumentNullException(nameof(body));

            return JsonConvert.DeserializeObject<ShaparakWriteRequest>(body);
        }

    }

    public static class AppUtils {

        public static string getAppLogPath() {
            return $"{Application.StartupPath}\\exceptions.log";
        }

    }
}
