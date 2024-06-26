using System.Text.Json.Serialization;


using Newtonsoft.Json;

namespace WepApiIndex.Extentions
{
    public static class SessionExtentions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string jsonObject = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonObject);
        }
        public static T GetObject<T>(this ISession session,string key) where T : class
        {
            string jasonObje = session.GetString(key);
            if (string.IsNullOrEmpty(jasonObje))
            {
                return null;
            }
            T obje = JsonConvert.DeserializeObject<T>(jasonObje);
            return obje;
        }
    }
}
