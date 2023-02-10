using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestApi_Library.Models;
namespace RestApi_Library
{
    public class WorkProcess
    {
        public static async Task<ModelComic> LoadComic(int num=0) {
            string url = "";
            if(num>0)
            {
                url = $"https://xkcd.com/{num}/info.0.json";
            }
            else
            {
                url = $"https://xkcd.com/info.0.json";
            }
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ModelComic modelComic=await response.Content.ReadAsAsync<ModelComic>();
                    return modelComic;
                    
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
        public static async Task<ModelJoke> LoadJoke(int num = 0)
        {
            string url = "";
            if (num>0)
            {
                url = $"https://icanhazdadjoke.com/search?page={num}";
            }
            else
            {
                 url = $"https://icanhazdadjoke.com/";
               // url = $"https://icanhazdadjoke.com/";
            }
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ModelJoke joke = await response.Content.ReadAsAsync<ModelJoke>();
                  // ModelJoke joke= await response.Content.ReadAsStreamAsync<ModelJoke>();
                    Console.WriteLine(response);
                    return joke;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
