using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml;

namespace FirstAssignment
{

    public partial class UI : Form
    {

        #region Constructor
        public UI()
        {
            this.BackColor = Color.LightGreen;
            InitializeComponent();
            if (companies == null)
                companies = new OutputScreen();
        }
        #endregion


        #region VariablesandDeclarations
        int _mserial = 1;
        string url = string.Empty;
        OutputScreen companies = null;
        HttpClient client = new HttpClient();
        XmlDocument responseDocument = new XmlDocument();
        IList<string> NameList = new List<string>();
        string CompNameAddress = string.Empty;
        string LocationTextField = string.Empty;
        string responseString;
        List<string> listComp = new List<string>();
        IList<string> AddressList = new List<string>();
        #endregion


        #region xmlParse

        private void XmlParse(string responseString)
        {
            responseDocument.LoadXml(responseString);

            XmlNodeList nameList = responseDocument.GetElementsByTagName("name");
            XmlNodeList addressList = responseDocument.GetElementsByTagName("formatted_address");

            foreach (XmlNode CompName in nameList)
            {
                NameList.Add(CompName.InnerText);
            }

            foreach (XmlNode CompAddress in addressList)
            {
                AddressList.Add(CompAddress.InnerText);
            }
            
            foreach (var word in NameList.Zip(AddressList, (string namelist, string addresslist) => new { t = namelist, w = addresslist }))
            {
                CompNameAddress = string.Empty;
                CompNameAddress = (_mserial + "." + " " + word.t + "\n " + word.w);
                listComp.Add(CompNameAddress);
                _mserial++;
            }

          

        }
        #endregion


        #region setcompanies

        private void setcompanies(List<string> listComp )
        {
            if (listComp.Any())
            {
                if (companies != null)
                {
                    companies.SetCompanies(listComp);
                    companies.ShowDialog();
                }
            }

        }

        #endregion


        #region callApi

        private void CallApi(string location)
        {
            Task.Run(async () =>
            {
                url = "https://maps.googleapis.com/maps/api/place/textsearch/xml?query=it+companies+in+" + location + "&key=AIzaSyC_SL4Eig9Gc49GlcLl7wqWMp0KYqA6-k0";
            HttpResponseMessage response = await client.GetAsync(url);
             responseString = await response.Content.ReadAsStringAsync();
                XmlParse(responseString);
                setcompanies(listComp);
            });



        }
        #endregion

        #region Search_Click
        /// <summary>
        /// when we click on the search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            
            string locationName = EnterLocation.Text;
            string[] words = locationName.Split(' ');
            string Location = string.Empty;
            foreach (var a in words)
            {
                Location = Location + a + "+";
            }
            CallApi(Location);
        }

        #endregion


        #region Exit_Click

        /// <summary>
        /// when we click on the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
         #endregion
