#region Usings

using AngleSharp;
using AngleSharp.Xml;
using AngleSharp.XHtml;
using AngleSharp.Services;
using AngleSharp.Parser;
using AngleSharp.Network;
using AngleSharp.Html;
using AngleSharp.Extensions;
using AngleSharp.Dom;
using AngleSharp.Css;
using AngleSharp.Commands;
using AngleSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using QuickType.Product;
using prod = QuickType.Product;
using cate = QuickType.Category;
using System.Diagnostics;

#endregion

namespace WebsiteScraper_fullDNET
{
    public enum PageType { none, Product, Category };

    class Program
    {
        const string jsonPath = "C:\\Users\\Kip\\Desktop\\AssetStore json\\";

        static IConfiguration netConfiguration;

        static string[] productsURL = {
                "https://assetstore.unity.com/packages/vfx/shaders/aquas-water-lite-53519",
                "https://assetstore.unity.com/packages/vfx/shaders/suimono-water-system-4387",
                "https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-32351",
                "https://assetstore.unity.com/packages/templates/systems/ufps-ultimate-fps-2943",
        };
        static string[] categoryUrl =
        {
            "https://assetstore.unity.com/search?order_by=relevance&q=category%3A6&rows=35",
        };

        static void Main(string[] args)
        {
            Console.Clear();

            netConfiguration = Configuration.Default.WithDefaultLoader();
            StartScrapingAsync();

            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Q)
                {
                    Console.WriteLine("exiting");
                    Environment.Exit(0);
                }
                else if (key == ConsoleKey.T)
                {
                    Console.WriteLine("I'm alive!");
                }
                else if (key == ConsoleKey.R)
                {
                    Console.Clear();
                    StartScrapingAsync();
                }
            }
        }

        static async void StartScrapingAsync()
        {
            Console.WriteLine("Started...");

            Stopwatch watch = Stopwatch.StartNew();

            var targetData = CreateTargetData(categoryUrl);

            IEnumerable<Task<object>> tasks = new List<Task<object>>();

            Console.WriteLine("Creating Tasks");
            tasks = targetData.Select(x => Task.Run(() => GetData(x.Path.AbsoluteUri, x.Type)));
            object[] resutls = await Task.WhenAll(tasks);
            Console.WriteLine("Tasks finished");

            Console.Clear();
            watch.Stop();

            for (int i = 0; i < resutls.Length; i++)
            {
                OutputData(resutls[i], targetData[i]);
            }

            Console.WriteLine($"\nEverything was done in {watch.ElapsedMilliseconds} miliseconds.");
        }
        static List<TargetData> CreateTargetData(IEnumerable<string> urls)
        {
            return urls.Select(x => {
                var uri = new Uri(x);
                PageType type;

                if (uri.Query.Contains("category"))
                    type = PageType.Category;
                else if (uri.LocalPath.Contains("packages"))
                    type = PageType.Product;
                else
                    type = PageType.none;

                //Console.WriteLine($"creating {type}, uri: {uri.AbsoluteUri}");
                return new TargetData()
                {
                    Path = uri,
                    Type = type,
                };
            }).ToList();
        }

        static async Task<object> GetData(string url, PageType type)
        {
            var dom = await LoadPage(netConfiguration, url);
            var json = await GetJson(dom);
            var data = await ToJson(json, type);

            return data;
        }

        static async Task<object> ToJson(string json, PageType type)
        {
            if (type == PageType.Category)
                return await Task.Run(() => cate.ProdcutCategory.FromJson(json));
            if (type == PageType.none)
                return await Task.Run(() => cate.ProdcutCategory.FromJson(json));
            else
                return await Task.Run(() => { return new object(); });
        }
        static async Task<string> GetJson(IDocument document)
        {
            var scripts = document.Body.QuerySelectorAll("script");
            var script = scripts.Where(x => x.InnerHtml.Contains("ReactDOMrender"))
                                .First().InnerHtml;

            int start = script.IndexOf("{\"data\"");
            string uncomplete = script.Substring(start);

            return await Task.Run(() => GuessJson(uncomplete));
        }
        static async Task<IDocument> LoadPage(IConfiguration conf, string url)
        {
            Console.WriteLine("Loding: " + url);
            return await BrowsingContext.New(conf).OpenAsync(url);
        }

        static void OutputData(object data, TargetData targetData)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Original request: {targetData.Path}");
            Console.WriteLine($"Type: {targetData.Type}");
            Console.WriteLine("- - - - - - - - - - -");

            if (data is cate.ProdcutCategory)
            {
                OutputCategory((cate.ProdcutCategory)data);
            }
            else if (data is prod.ProductPage)
            {
                OutputProduct((prod.ProductPage)data);
            }

            Console.WriteLine("---------------------");
        }
        static void OutputCategory(cate.ProdcutCategory data)
        {
            Console.WriteLine("total: " + data.Data.Entity.Product.Count);
            foreach (var x in data.Data.Entity.Product)
            {
                Console.WriteLine(x.Value.Name);
            }
        }
        static void OutputProduct(prod.ProductPage data)
        {
            Console.WriteLine(data.Data.Entity.Product.First().Value.Name);
        }

        /*
        static void OutputFinalProducts(ProductPage[] products)
        {
            foreach (var store in products)
            {
                var product = store.Data.Entity.Product.First().Value;
                var publisher = store.Data.Entity.ProductPublisher.First().Value;

                var otherProducts = store.Data.Entity.Product.Values.Where(y => y.Id != product.Id).ToArray();

                OutputProductInfo(product, publisher, store);
            }
        }
        static void OutputProductInfo(Product prod, ProductPublisher pub, ProductPage store)
        {
            Console.WriteLine($"\n-- Name: {prod.Name} ({store.Data.ProductId}) --");
            Console.WriteLine($"Published: {pub.Name} ({pub.Id})");
            Console.WriteLine($"Price {prod.OriginalPrice.FinalPrice} {store.Data.Currency}");
            Console.WriteLine($"Ratings {prod.Rating.Average}/5 | rated: {prod.Rating.Count} | reviewed: {prod.ReviewCount}");

            var size = Convert.ToInt32(prod.DownloadSize) / 1000000f;
            Console.WriteLine($"Files: {prod.AssetCount}, Size: { Math.Round(size, 1):######.##} MB");
        }
        static void OutputContextInfo(Product[] otherProducts)
        {
            var otherProdNames = otherProducts.Select(x => x.Name);
            Console.WriteLine($"other assets: {string.Join(", \n   ", otherProdNames)}");
        }
        */
        static string GuessJson(string uncomplete)
        {
            string json = "";
            for (int i = 0, delta = 0, lastValid = 0; i < uncomplete.Length; i++)
            {
                if (uncomplete[i] == '{' || uncomplete[i] == '}')
                {
                    delta += (uncomplete[i] == '{') ? 1 : -1;
                    if (delta < 0)
                    {
                        //Console.WriteLine("Cutting: " + (toCut.Length - lastValid));
                        json = uncomplete.Remove(lastValid + 1, uncomplete.Length - lastValid - 1);

                        break;
                    }
                    else
                    {
                        lastValid = i;
                    }
                }
            }

            SaveJson(json);
            return json;
        }
        static void SaveJson(string json)
        {
            if (File.Exists(jsonPath))
            {
                File.WriteAllText(jsonPath + Guid.NewGuid().ToString() + ".txt", json);
            }
        }

        //Temp, slow down
        static void SlowDown()
        {
            FindPrimeNumber(1000);
        }
        static public long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }
    }
}