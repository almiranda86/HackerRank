using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Solution
{

    static class Result
    {
        static List<List<int>> responseTransactions;

        public static List<List<int>> totalTransactions(int locationId, string transactionType)
        {
            int page = 1;
            List<Transaction> responseCol = new List<Transaction>();
            Response callResult = default;
            try
            {
                if (page == 1)
                {
                    callResult = MakeCall(transactionType, page);

                    if (VerifyResult(callResult))
                    {
                        responseCol.AddRange(FindRequested(locationId, callResult));
                        page++;
                    }
                    else
                    {
                        responseTransactions = new List<List<int>>();
                        responseTransactions.Add(new List<int>() { -1, -1 });
                    }
                }

                if (page > 1)
                {
                    for (; page <= callResult.total_pages; page++)
                    {
                        callResult = MakeCall(transactionType, page);
                        VerifyResult(callResult);
                        responseCol.AddRange(FindRequested(locationId, callResult));
                    }

                    responseTransactions = DoTheMath(responseCol);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return responseTransactions.OrderBy(u => u.;
        }

        private static List<List<int>> DoTheMath(List<Transaction> transactionsCol)
        {
            List<List<int>> responseTransactions = new List<List<int>>();

            var groupedUsers = transactionsCol.GroupBy(c => c.UserId);

            groupedUsers = groupedUsers.OrderBy(u => u.Key);

            foreach (var u in groupedUsers)
            {
                decimal totalAmount = 0;

                foreach (var transactions in u)
                {
                    totalAmount += decimal.Parse(transactions.amount,
                                   NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                   new CultureInfo("en-US"));
                }


                responseTransactions.Add(new List<int>()
                {
                    u.Key, (int)totalAmount
                });
            }

            return responseTransactions;
        }

        private static bool VerifyResult(Response callResult)
        {
            if (callResult == null)
                return false;

            return true;
        }

        private static List<Transaction> FindRequested(int locationId, Response transactions)
        {
            return transactions.data.FindAll(x => x.location.id == locationId);
        }

        private static Response MakeCall(string transactionType, int page)
        {
            const string URL = "https://jsonmock.hackerrank.com/";

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri($"{URL}");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string requestedUrl = $"api/transactions/search?txnType={transactionType}&page={page} ";

            Response response = default;

            try
            {
                HttpResponseMessage responseMessage = client.GetAsync(requestedUrl).Result;

                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseJson = responseMessage.Content.ReadAsStringAsync().Result;

                    response = JsonConvert.DeserializeObject<Response>(responseJson);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return response;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int locationId = Convert.ToInt32(Console.ReadLine().Trim());

            string transactionType = Console.ReadLine();

            List<List<int>> result = Result.totalTransactions(locationId, transactionType);

            textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

            textWriter.Flush();
            textWriter.Close();
        }
    }


    [Serializable]
    public class Response
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Transaction> data { get; set; }
    }

    [Serializable]
    public class Transaction
    {
        public int id { get; set; }
        public long timestamp { get; set; }
        public int UserId { get; set; }
        public string userName { get; set; }
        public string txnType { get; set; }
        public string amount { get; set; }
        public Location location { get; set; }
        public string ip { get; set; }
    }

    [Serializable]
    public class Location
    {
        public int id { get; set; }
        public string address { get; set; }
        public string cit { get; set; }
        public int zipCode { get; set; }
    }
}
