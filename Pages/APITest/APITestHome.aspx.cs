using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;

namespace asset_tracker_web.Pages.APITest
{
    public partial class APITestHome : System.Web.UI.Page
    {
        private RestClient client = new RestClient("http://localhost:49725");
        private string test = "<tag>test</tag>";

        protected void Page_Load(object sender, EventArgs e)
        {
            client.Authenticator = new HttpBasicAuthenticator("rbstester", "rbscrp");
            RestRequest request = new RestRequest("/api/Asset", Method.GET);
            request.AddHeader("Accept", "text/xml");
            request.RequestFormat = DataFormat.Xml;
            var response = client.Execute(request);
            responseContent.Text = response.Content;

        }
    }
}