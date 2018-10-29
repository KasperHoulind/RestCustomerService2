using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ModelClassCustomer.model;
using Newtonsoft.Json;

namespace RestCustomerConsumer
{
    class RestHandler
    {
        public IList<Customer> GetCustomers()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = client.GetStringAsync("http://localhost:61404/api/Customers").Result;
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
    }
}


