namespace Infrastructure.Repository
{
    public class RawDataRepository
    {
        // https://learning-collection.com/c-httpclient%E3%81%A7%E3%81%AEapi%E3%82%B3%E3%83%BC%E3%83%AB%E3%81%AE%E3%82%B5%E3%83%B3%E3%83%97%E3%83%AB/

        private const string VERSION_TEXT = "1";
        private const string RAWLIST_BASE_URL = "https://elaws.e-gov.go.jp/api/{0}/lawlists/{1}";

        public string GetRawList(int rawTypeNumber)
        {
            HttpClient client = new HttpClient();

            // 「Result」で同期
            var response = client.GetAsync(string.Format(RAWLIST_BASE_URL, VERSION_TEXT, rawTypeNumber)).Result;

            // レスポンスボディからレスポンス値を取得　※「Result」で同期
            var result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}