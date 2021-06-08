using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Serialization;
using System.Net;
using Newtonsoft.Json;
namespace APIPractice.Models
{
    public class APIService
    {

        public async Task<Teacher> GetATeacher()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://seriouslyfundata.azurewebsites.net/api/ateacher");
            response.EnsureSuccessStatusCode();
            string responseContent = await response.Content.ReadAsStringAsync();

            using (var stringReader = new System.IO.StringReader(responseContent))
            {
                var serializer = new XmlSerializer(typeof(Teacher));
                return serializer.Deserialize(stringReader) as Teacher;
            }
        }

        public async Task<int> getRandomNumberAsync()
        {
            var randomNum = 0;
            var url = "https://seriouslyfundata.azurewebsites.net/api/generatearandomnumber";

            using (WebClient webClient = new WebClient())
            {
                var num = await webClient.DownloadStringTaskAsync(url);

                randomNum = Convert.ToInt32(num);
                return randomNum;
            }
        }

        public async Task<ChuckNorris> getChuckNorrisJoke()
        {
            var url = "https://seriouslyfundata.azurewebsites.net/api/chucknorrisfact";
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<ChuckNorris>(
                    await webClient.DownloadStringTaskAsync(url)
                );
            }
        }
        public async Task<SeleucidResponse> getSeleucidsAsync()
        {
            var url = "https://seriouslyfundata.azurewebsites.net/api/seleucids";
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<SeleucidResponse>(
                    await webClient.DownloadStringTaskAsync(url)
                );
            }
        }

    }
}
