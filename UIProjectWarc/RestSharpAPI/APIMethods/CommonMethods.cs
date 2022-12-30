using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAPI.APIMethods
{
    internal class CommonMethods
    {
        Bookings Booking = new Bookings();
        string bookingID;
        string token;
       string base_URI = "https://restful-booker.herokuapp.com";
        

        public void GetRequest()
        {
            //
            var client = new RestClient(base_URI);
            //client.Timeout = -1;
            var request = new RestRequest("booking/1", Method.Get);
            request.AddHeader("Accept", "*/*");
            var response = client.Execute(request);
               

            Console.WriteLine(response.Content);
            
        }
        public void CreateBooking()
        {
            Booking = new Bookings();
            Booking.firstname = "ade";
            Booking.lastname = "sue";
            Booking.totalprice = 50;
            Booking.depositpaid = true;
            Booking.bookingdates=new BookingDates(){ Checkin = "2018-01-01", Checkout = "2018-02-01" };
            Booking.additionalneeds = "Breakfast";
           var client = new RestClient("https://restful-booker.herokuapp.com");
            
            var request = new RestRequest("/booking",Method.Post);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Host", "restful-booker.herokuapp.com");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
        
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Ssl3 |
           SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
            SecurityProtocolType.Tls;
            //var resArray = new object[] { Booking, Bookings, Additionalneeds };
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            var result = JsonConvert.SerializeObject(Booking, jsonSerializerSettings);
            var t=request.AddParameter("application/json", result, ParameterType.RequestBody);

            var response = client.Execute(t);
            var d = JToken.FromObject(response.Content);
            bookingID= JToken.Parse(response.Content).SelectToken("bookingid").ToString();

        }

        public void  Auth()
        {
            var client = new RestClient("https://restful-booker.herokuapp.com");
            
            var request = new RestRequest("/auth",Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +
            @"    ""username"" : ""admin""," + "\n" +
            @"    ""password"" : ""password123""" + "\n" +
            @"}";
            
            var t=request.AddParameter("application/json",body, ParameterType.RequestBody);
            var response = client.Execute(t);
            JObject json = JObject.Parse(response.Content); 
             token = json.SelectToken("token").ToString();
           
        }

        public void Delete()
        {
            var booked = new Booked();
           //var CustBooking=  CreateBooking();
            
           // var res = JsonSerializer.Deserialize<Booked>(CustBooking.ToString());
            //booked.bookingid = res["id"];
            //var p = booked.bookingid.ToString();   
            var client = new RestClient("https://restful-booker.herokuapp.com/booking");
            var request = new RestRequest(bookingID,Method.Delete);
            request.AddHeader("Accept", "*/*");
            var tr= request.AddHeader("Content-Type", "application/json");
            var ft=request.AddHeader("Cookie", "token=" +token);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);

            
        }
    }

}
