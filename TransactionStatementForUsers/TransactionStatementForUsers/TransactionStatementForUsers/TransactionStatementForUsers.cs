using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace TransactionStatementForUsers
{

    /// <summary>
    /// Given a transaction type and location, access a REST API to get the total amount of transactions with the 
    /// given type and at the given location. 
    /// This information is to be grouped by users and ordered ascending by numerical id.
    /// To access the log of transactions, perform an HTTP GET request to: 
    /// https://jsonmock.hackerrank.com/api/transactions/search?txnType=<transactionType>&page=<pageNumber> 
    /// where <transactionType> is either "debit" or "credit" and <pageNumber> is the page of the results, as an integer
    /// For example, a GET request to https://jsonmock.hackerrank.com/api/transactions/search?txnType=debit&page=2 
    /// will return the second page of transactions with "debit" transaction type. 
    /// Pages are numbered from 1, so in order to access the first page, ask for page number 1.
    /// 
    /// The response to a request is a JSON with the following 5 fiels:
    /// page: the current page of the results;
    /// per_page: the maximum number of transaction records returned per page;
    /// total: the total number of transaction records available on all pages of the result;
    /// total_pages: the total number of pages with results;
    /// data: an array of objects containing transaction records on the requested page
    /// 
    /// Each transaction record has the following schema:
    /// id: the unique ID of the record;
    /// timestamp: the timestamp when the record was generated (in UTC millisenconds);
    /// UserId: the integer id of the user who performed the transaction;
    /// userName: the user name of the user who performed the transaction
    /// txnType: the transaction type of the transaction, either debit or credit;
    /// amount: the transaction amount stored as a string with currency structure and preficed with the $ sign, eg "$2,273.95","$23.52","$17"
    /// location: the object containing the location description of the transaction;
    /// ip: the IP address of the device which was used to perform the transaction;
    /// 
    /// 
    /// The location object has the followgin schema:
    /// id: the integer id of the location where the transaction took place;
    /// address: the address of the location where the transaction took place;
    /// cit: the city where the transaction took place;
    /// zipCode: the zip code of the location where the transaction took place;
    /// 
    /// 
    /// Return a 2d array of integers with two columns, where the first column contains user ids of all users that 
    /// made transactions in a given location using the given transaction type. 
    /// The second column for a row corresponding to some user must contain the total amount that this user spent in dollars, 
    /// truncated to an integer if necessary. E.g. $2,332.70 must be returned as 2332 and $42,15 must be returnde as 42. 
    /// The row in the array must be sorted in increasing order of user ids. 
    /// If there are no transactions matching the given location and transaction type, 
    /// the function must return a 2d array with one row and 2 columns having both values set to -1 e.g. [[-1,-1]]
    /// </summary>
    public class TransactionStatementForUsers
    {
        List<List<int>> responseTransactions;

        /// <summary>
        /// Complete the function totalTransactions in the editor
        /// </summary>
        /// <param name="locationId">the id of the location for which the summary must be computed</param>
        /// <param name="transactionType">the transaction type for which the summary must be computed</param>
        /// <returns>
        /// int[][]: a 2d array of integers that represents the results
        /// </returns>
        public List<List<int>> totalTransactions(int locationId, string transactionType)
        {
            responseTransactions = new List<List<int>>();
            responseTransactions.Add(new List<int>() { -1, -1 });

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
                }

                if (page > 1)
                {
                    for (; page <= callResult.total_pages; page++)
                    {
                        callResult = MakeCall(transactionType, page);
                        VerifyResult(callResult);
                        responseCol.AddRange(FindRequested(locationId, callResult));
                    }

                    if (responseCol.Count != 0)
                    {
                        responseTransactions = DoTheMath(responseCol);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return responseTransactions;
        }


        private List<List<int>> DoTheMath(List<Transaction> transactionsCol)
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

        private bool VerifyResult(Response callResult)
        {
            if (callResult == null)
                return false;

            return true;
        }

        private List<Transaction> FindRequested(int locationId, Response transactions)
        {
            return transactions.data.FindAll(x => x.location.id == locationId);
        }

        private Response MakeCall(string transactionType, int page)
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
