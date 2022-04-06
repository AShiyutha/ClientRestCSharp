using Newtonsoft.Json;
using Pr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteRestCSharp
{
    public partial class Form1 : Form
    {
        public HttpClient c = new HttpClient { BaseAddress = new Uri("https://restcountries.com") };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnTodos_Click(object sender, EventArgs e)
        {
            var resp = await c.GetAsync("v3.1/all");
            var cont = await resp.Content.ReadAsStringAsync();

            //lstBandeira.Items.Add("1");
            //lstBandeira.Items.Add(cont);
            //lstBandeira.Items.Add("2");

            //txtNome.Text = "123   " + cont;
            var paises1 = JsonConvert.DeserializeObject<Paises[]>(cont);
            txtContent.Text = "123   " + cont;
            foreach(var p in paises1)
            {
                txtContent.Text = "123   " + p.Name;
            }
            
        }
        
    }
}


namespace Pr
{

    public enum Side { Left, Right };

    public enum Continent { Africa, Antarctica, Asia, Europe, NorthAmerica, Oceania, SouthAmerica };

    public enum Region { Africa, Americas, Antarctic, Asia, Europe, Oceania };

    public enum StartOfWeek { Monday, Sunday, Turday };

    
    public enum Status { OfficiallyAssigned, UserAssigned };
}

