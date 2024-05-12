using net.zemberek.erisim;
using net.zemberek.tr.yapi;
using net.zemberek.yapi;
using System;
using System.Web.Services;

namespace TurkishNLPWebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private Zemberek zemberek = new Zemberek(new TurkiyeTurkcesi());

        [WebMethod]
        public Kelime[] kelimeCozumle(String kelime)
        {
            return zemberek.kelimeCozumle(kelime);
        }

        [WebMethod]
        public bool kelimeDenetle(string kelime)
        {
            return zemberek.kelimeDenetle(kelime);
        }

        [WebMethod]
        public Kelime[] asciiCozumle(string kelime)
        {
            return zemberek.asciiCozumle(kelime);
        }

        [WebMethod]
        public string[] asciidenTurkceye(string kelime)
        {
            return zemberek.asciidenTurkceye(kelime);
        }

        [WebMethod]
        public string asciiyeDonustur(string kelime)
        {
            return zemberek.asciiyeDonustur(kelime);
        }

        [WebMethod]
        public string[] hecele(string kelime)
        {
            return zemberek.hecele(kelime);
        }

        [WebMethod]
        public string[] oner(string kelime)
        {
            return zemberek.oner(kelime);
        }

        [WebMethod]
        public string temizle(string kelime)
        {
            return zemberek.temizle(kelime);
        }

        [WebMethod]
        public int dilTesti(string kelime)
        {
            return zemberek.dilTesti(kelime);
        }
    }
}
