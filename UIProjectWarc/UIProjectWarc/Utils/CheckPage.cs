using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectWarc.Utils
{
    public static class CheckPage
    {
        public static async Task<bool> DoesUrlExists(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //Do only Head request to avoid download full file
                    var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, url));

                    if (response.IsSuccessStatusCode)
                    {
                        //Url is available is we have a SuccessStatusCode
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
