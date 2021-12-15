using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace GameAppBV.Forms
{
    public partial class Pokésearch : Form
    {
        public Pokésearch()
        {
            InitializeComponent();
        }

        private void Pokésearch_Load(object sender, EventArgs e)
        {
            buttonSubmitAPI.BackColor = Color.FromArgb(57, 73, 87);
            buttonSubmitAPI.ForeColor = Color.Snow;
            //buttonSubmitAPI.FlatAppearance.BorderColor = Color.FromArgb(57, 73, 87);
        }

        private void buttonSubmitAPI_Click(object sender, EventArgs e)
        {
                textBoxName.Text = "";
                pictureBoxPic.Image = null;
                listBoxType.Items.Clear();
                string name = textBoxPokeName.Text.ToLower();
                RestClient client = new RestClient("https://pokeapi.co/api/v2/pokemon/" + name);
                client.Timeout = -1;
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
            try
            {
                dynamic file = JsonConvert.DeserializeObject(response.Content);
            
            
                foreach (var obj in file.types)
                {
                    listBoxType.Items.Add(obj.type.name);
                    //textBoxType = obj.type.type;
                }
                //textBoxName.Text = name;
                textBoxName.Text = file.name;
                int id = file.id;
                string url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + id.ToString() + ".png";
                pictureBoxPic.Load(url);
            }
            catch (Exception)
            {
                textBoxName.Text = "";
                pictureBoxPic.Image = null;
                listBoxType.Items.Clear();
                MessageBox.Show("Sorry, this Pokémon is not in the list.");
            }
        }
    }
}
