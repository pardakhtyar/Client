using System;
using System.IO;
using System.Threading.Tasks;

namespace PardakhtYar.Client {

    public interface ITextLogger {

        string FilePath { get; set; }

        Task LogAsync(string what);

        Task LogAsync(Exception ex);

        void Log(Exception ex);

    }


    public class TextLogger : ITextLogger {
        
        public TextLogger(string filePath) {
            FilePath = filePath;
        }

        public string FilePath { get; set; }

        private string getCurrentTime => DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        private void writeLineToFile(string what) {
            using (var writer = new StreamWriter(FilePath, true)) {
                writer.WriteLine(what);
                writer.Flush();
            }
        }

        private async Task writeLineToFileAsync(string what) {
            using (var writer = new StreamWriter(FilePath, true)) {
                await writer.WriteLineAsync(what);
                await writer.FlushAsync();
            }
        }

        private void writeToFile(string what) {
            using (var writer = new StreamWriter(FilePath, true)) {
                writer.Write(what);
                writer.Flush();
            }
        }

        private async Task writeToFileAsync(string what) {
            using (var writer = new StreamWriter(FilePath, true)) {
                await writer.WriteAsync(what);
                await writer.FlushAsync();
            }
        }

        public async Task LogAsync(string what) {
            string template = $"{getCurrentTime} - {what}";
            await writeLineToFileAsync(template);
        }

        public void Log(string what) {
            string template = $"{getCurrentTime} - {what}";
            writeLineToFile(what);
        }

        private string getExceptionLog(Exception ex) {
            var baseEx = ex.GetBaseException();
            string template = "--------Exception--------";
            template += Environment.NewLine + getCurrentTime;
            template += Environment.NewLine + $"Type : {ex.GetType().Name}";
            template += Environment.NewLine + $"Message : {ex.Message}";
            template += Environment.NewLine + $"StackTrace : {ex.StackTrace}";
            template += Environment.NewLine;

            return template;
        }

        public async Task LogAsync(Exception ex) {
            await writeToFileAsync(getExceptionLog(ex));
        }

        public void Log(Exception ex) {
            writeLineToFile(getExceptionLog(ex));
        }
         
    }
}
