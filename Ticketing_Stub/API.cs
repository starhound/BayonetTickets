using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections;
using System.Net;

namespace Ticketing_Stub
{
    class API
    {
        const string ROOM_ID = "yourroomid";
        const string API_URL = "https://yourdomain.com/api/v1/";
        const string BOT_NAME = "yourbotname";
        const string BOT_PASSWORD = "yourbotpwd";

        public static void submitTicket(string ticket, string host_name)
        {
            //create rest client for posting ticket to IT tickets channel
            var client = new RestClient(API_URL);

            client.Authenticator = new SimpleAuthenticator("user", BOT_NAME, "password", BOT_PASSWORD);
            var request = new RestRequest("login", Method.POST);
            var response = client.Execute(request);
            dynamic content = JsonConvert.DeserializeObject(response.Content);
            var data = content.data;

            //grab auth token and bot id
            string auth = data.authToken.ToString();
            string userId = data.userId.ToString();

            string AUTH_TOKEN = auth;
            string USER_ID = userId;

            var ticketRequest = new RestRequest("chat.postMessage", Method.POST);
            ticketRequest.AddHeader("X-Auth-Token", AUTH_TOKEN);
            ticketRequest.AddHeader("X-User-Id", USER_ID);
            ticketRequest.AddHeader("Content-Type", "application/json");

            ticketRequest.AddJsonBody((new { text = ticket, roomId = ROOM_ID, alias = host_name }));

            client.Execute(ticketRequest);
        }

        public static ArrayList GetUserTickets()
        {
            var client = new RestClient(API_URL);

            client.Authenticator = new SimpleAuthenticator("user", BOT_NAME, "password", BOT_PASSWORD);
            var request = new RestRequest("login", Method.POST);
            var response = client.Execute(request);
            dynamic content = JsonConvert.DeserializeObject(response.Content);
            var data = content.data;

            //grab auth token and bot id
            string auth = data.authToken.ToString();
            string userId = data.userId.ToString();

            string AUTH_TOKEN = auth;
            string USER_ID = userId;

            var ticket_request = new RestRequest("groups.history", Method.GET);
            ticket_request.AddQueryParameter("roomId", ROOM_ID);

            ticket_request.AddHeader("X-Auth-Token", AUTH_TOKEN);
            ticket_request.AddHeader("X-User-Id", USER_ID);
            ticket_request.AddHeader("Content-Type", "application/json");

            var ticket_response = client.Execute(ticket_request);
            dynamic ticket_data = JsonConvert.DeserializeObject(ticket_response.Content);
            ArrayList user_tickets = new ArrayList();
            if (ticket_data is null)
            {
                return null;
            }
            else
            {
                JArray messages = ticket_data.messages;

                string host_name = Dns.GetHostName();

                foreach (var message in messages)
                {
                    string host = (string)message["alias"];
                    if (host == host_name)
                    {
                        user_tickets.Add(message);
                    }
                }
            }
            return user_tickets;
        }
    }
}
