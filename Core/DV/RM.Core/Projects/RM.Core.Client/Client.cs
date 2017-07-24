using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Client
{
    public class Client
    {

        private HttpClient client = new HttpClient();

        public async Task<T> PostAsync<T, M>(M Model, string path)
            where T : class
            where M : class
        {
            T temp = null;

            try
            {
                var response = await client.PostAsJsonAsync<M>(path, Model);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    temp = response.Content.ReadAsAsync<T>().Result;
                }
                else
                {
                    return null;
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
