namespace Blogaj.WebUI.Helpers
{
    public class HttpsClientInstance
    {
        public static HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress=new Uri( "https://localhost:7125");

            return client;
        }
    }
}
