using Newtonsoft.Json;

namespace WepApiIndex.ShoppingClasses
{
    [Serializable] 
    public class CartItem
    {
        public CartItem()
        {
            Amount++;
        }
        [JsonProperty("ID")]
        public int ID { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("UnitPrice")]
        public decimal UnitPrice { get; set; }
        [JsonProperty("Amount")]
        public int Amount { get; set; }
        [JsonProperty("SubTotal")]
        public decimal SubTotal { get { return Amount * UnitPrice; } }

        [JsonProperty("CategoryID")]

        public int? CategoryID { get; set; }

        [JsonProperty("CategoryName")]
        public string CategoryName { get; set; }
    }
}
