using RM.Common.CustomException;
using RM.Common.Helpers;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Client
{
    public class WebClient
    {

        //private HttpClient client = new HttpClient();

        public async Task<T> PostAsync<T, M>(M Model, string Path)
            where T : class
            where M : class
        {
            T temp = null;

            try
            {
                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    
                    var data = new StringContent(content: Model.ToJsonString(),
                    encoding: Encoding.UTF8,
                    mediaType: "application/json");

                    var response = await client.PostAsync(Path, data);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        temp = await response.Content.ReadAsAsync<T>();
                    }
                    else
                    {
                        throw new CustomException();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return temp;
        }

        
    }
}
