
using Exchange.Entity.ApiModels.Currencies;
using Exchange.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exchange.Service.Services.Concretes
{
    public class CurrencyService:ICurrencyService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private string _apiUrl;
        public CurrencyService()
        {
            
            _apiUrl = "https://finans.truncgil.com/v2/today.json";
        }

       

        public async Task <GoldCurrencyAndDateModel>  GetCurrenciesWithDate()
        {      

            HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);
            GoldCurrencyAndDateModel currencyAndDate = new GoldCurrencyAndDateModel();
            
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                //JObject jsonObject = JObject.Parse(jsonString);
                //var currencies = jsonObject.Properties().Skip(1).ToDictionary(p => p.Name, p => p.Value.ToObject<CurrencyModel>());
                var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(jsonString);
                //JToken, JSON belgesinin hiyerarşik yapısını anlamak, gezinmek ve manipüle etmek için kullanışlıdır.
                //Özellikle JSON belgesinin yapısı hakkında önceden bilgi sahibi olmadığınız durumlarda dinamik olarak veriye erişmek için kullanılabilir.

                currencyAndDate.Update_Date = jsonObject.ElementAt(0).Value.ToString();
                jsonObject.Remove("Update_Date");
                var currencies = jsonObject.ToDictionary(p => p.Key, p => p.Value.ToObject<GoldCurrencyModel>());              
               
                var value = jsonObject.ToDictionary(p => p.Key, p => p.Value.ToObject<GoldCurrencyModel>());
                currencyAndDate._currencies = value.Values.ToList();   
               
            }

            return currencyAndDate;


        }


        public async Task<List<GoldCurrencyModel>> GetCurrencies()
        {
            List<GoldCurrencyModel> _model = new();
            HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                //JObject jsonObject = JObject.Parse(jsonString);
                //var currencies = jsonObject.Properties().Skip(1).ToDictionary(p => p.Name, p => p.Value.ToObject<CurrencyModel>());
                var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(jsonString);
                //JToken, JSON belgesinin hiyerarşik yapısını anlamak, gezinmek ve manipüle etmek için kullanışlıdır.
                //Özellikle JSON belgesinin yapısı hakkında önceden bilgi sahibi olmadığınız durumlarda dinamik olarak veriye erişmek için kullanılabilir.
                jsonObject.Remove("Update_Date");
                var currencies = jsonObject.ToDictionary(p => p.Key, p => p.Value.ToObject<GoldCurrencyModel>());
                _model = currencies.Values.ToList();

                //Dictionary<string,CurrencyModel> x = JsonConvert.DeserializeObject<Dictionary<string, CurrencyModel>>(jsonString);

                //_model = new List<CurrencyModel>(x.Values);
            }

            return _model;

        }


    }
}
