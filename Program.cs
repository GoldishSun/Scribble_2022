using System.Net;

namespace Gold
{
    class Test
    {
        static void Main(string[] args)
        {
            run().Wait();
        }

        static async Task run()
        {
            string URL = "https://docs.google.com/spreadsheets/d/1u6carnkAmj88nmezudUKbzKnPuUORB3L_ArnLbaMxA4";
            URL += "/export?format=tsv";
            var client = new HttpClient();
            var checkCon = await client.GetAsync(URL);
            if (checkCon.StatusCode == HttpStatusCode.OK) 
            {
                var result = await client.GetStringAsync(URL);
                Console.WriteLine(result);
            }
        }
        // static void Main(string[] args)
        // {
        //     string URL = 
        // "https://docs.google.com/spreadsheets/d/1u6carnkAmj88nmezudUKbzKnPuUORB3L_ArnLbaMxA4/export?format=tsv";
        //     WebRequest request = WebRequest.Create(URL);
        //     request.Credentials = CredentialCache.DefaultCredentials;
        //     HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //     Stream dataStream = response.GetResponseStream();
        //     StreamReader reader = new StreamReader(dataStream);
        //     string responseFromServer = reader.ReadToEnd();
        //     reader.Close();
        //     dataStream.Close();
        //     response.Close();

        //     Console.WriteLine(responseFromServer);
        // }
    }
}
