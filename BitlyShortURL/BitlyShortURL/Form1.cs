using System; 
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BitlyShortURL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShortUrl_Click(object sender, EventArgs e)
        {  
            string longURL = HttpUtility.UrlEncode(txtLongUrl.Text);
            //https://bitly.com/ get api key and api username
            string login = "api_username";
            string apiKey = "api_key";
            string xmlFormat = "http://api.bitly.com/v3/shorten?format=xml&longUrl={0}&login={1}&apiKey={2}";
            var url = string.Format(xmlFormat, longURL, login, apiKey);
            XDocument document = XDocument.Load(url);
            string shortURL = document.Element("response").Element("data").Element("url").Value;
            string userHash = document.Element("response").Element("data").Element("hash").Value;
            txtShortUrl.Text = "http://bit.ly/" +userHash;
        }
    }
}
