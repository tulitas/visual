using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using SP = Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Search.Query;
using Microsoft.SharePoint;
using System.Web.UI.WebControls;
using ListItem = Microsoft.SharePoint.Client.ListItem;
using ListItemCollection = Microsoft.SharePoint.Client.ListItemCollection;
using DocumentFormat.OpenXml.Drawing;

namespace Share_library
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        static ClientContext clientContext = new ClientContext("https://tulitas.sharepoint.com/sites/Library2");

        static SP.List oList = clientContext.Web.Lists.GetByTitle("Books");
        static CamlQuery camlQuery = new CamlQuery();
        static ListItemCollection collListItem = oList.GetItems(camlQuery);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var str = textBox1.Text;
                var password = new SecureString();
                foreach (char c in str) password.AppendChar(c);


                clientContext.Credentials = new SharePointOnlineCredentials("tulitas@tulitas.onmicrosoft.com", password);

                label1.Hide();
                textBox1.Hide();
                button1.Hide();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {


            clientContext.Load(

                collListItem,
                items => items.Take(20).Include(
                item => item["Title"],
                item => item["Author"],
                item => item["Genre"],
                item => item["Pages"],
                item => item["Language"]));

            clientContext.ExecuteQuery();

            foreach (ListItem oListItem in collListItem)

            {
                FieldLookupValue user = (FieldLookupValue)oListItem["Author"];
                FieldLookupValue genre = (FieldLookupValue)oListItem["Genre"];
                string name = user.LookupValue;
                string name1 = genre.LookupValue;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete = textBox2.Text;

            ListItem oListItem = oList.GetItemById(delete);


            clientContext.ExecuteQuery();




        }

        private void button4_Click(object sender, EventArgs e)
        {

            ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
            ListItem oListItem = oList.AddItem(itemCreateInfo);

            var box = comboBox1.SelectedItem;
            string boxx = box.ToString();


            if (boxx == null)
            {
                this.label5.Text = "Add genre";
            }
            var box2 = comboBox2lang.SelectedItem;
            var tex1 = textBox3title.Text;
            var tex2 = textBox5pages.Text;
            var tex4 = textBox4.Text;

            oListItem["Title"] = tex1;
            try
            {
                oListItem["Genre"] = new SPFieldLookupValue(boxx);
            }
            catch (ArgumentException)
            {


            }
            oListItem["Pages"] = tex2;
            oListItem["Author4"] = tex4;
            oListItem["Language"] = box2;
            oListItem.Update();

            clientContext.ExecuteQuery();




        }



        private void button6_Click(object sender, EventArgs e)
        {

            clientContext.Load(
            collListItem,
                items => items.Take(1000).Include(

                item => item["Title"],
                item => item["Author4"],
                item => item["Genre"],
                item => item["Pages"],
                item => item["Language"])); ; ;

            clientContext.ExecuteQuery();


            var dtCoaching = new DataTable();

            dtCoaching.Columns.AddRange(new[]
            {
                new DataColumn("Title"), new DataColumn("Author"), new DataColumn("Genre"), new DataColumn("Pages"),
                new DataColumn("Language"),
            });

            foreach (var oListItem in collListItem)

            {
                string strCoIUnit = string.Empty;
                // FieldLookupValue user = (FieldLookupValue)oListItem["Author4"];
                // string name = user.LookupValue;
                FieldLookupValue genre = (FieldLookupValue)oListItem["Genre"];


                var name1 = genre.LookupValue.ToString();


                dtCoaching.Rows.Add(
                            oListItem["Title"] = oListItem["Title"],
                           oListItem["Author4"] = oListItem["Author4"],
                            oListItem["Genre"] = name1,

                            oListItem["Pages"] = oListItem["Pages"],
                            oListItem["Language"] = oListItem["Language"]
                                        ); ;

            }

            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = dtCoaching;
                dataGridView1.Refresh();
                dataGridView1.Columns[2].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
                var dataGridViewColumn = dataGridView1.Columns["ID"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
            }


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            /*var itemBox = comboBox1.SelectedItem;
            string tx = itemBox.ToString();
            SP.CamlQuery camlQuery = new SP.CamlQuery();

            var web = clientContext.Web;
            var myList = web.Lists.GetByTitle("Genres");
            var field = myList.Fields.GetByTitle("Title");
            clientContext.Load(field);

            FieldChoice fieldChoice = clientContext.CastTo<FieldChoice>(field);
            foreach (string choise in fieldChoice.Choices)
                

            {
                comboBox1.Items.Add(choise);
            }
clientContext.ExecuteQuery();

            SP.List oList = clientContext.Web.Lists.GetByTitle("books");


            SP.ListItemCollection collListItem = oList.GetItems(camlQuery);
            clientContext.Load(
            collListItem,
                items => items.Take(20).Include(

                item => item["Title"],
                item => item["Author4"],
                item => item[tx],
                item => item["Pages"],
                item => item["Language"])); ; ;

            clientContext.ExecuteQuery();
            var dtCoaching = new DataTable();

            dtCoaching.Columns.AddRange(new[]
            {
                new DataColumn("Title"), new DataColumn("Author"), new DataColumn("Genre"), new DataColumn("Pages"),
                new DataColumn("Language"),
            });





            foreach (var oListItem in collListItem)

            {
                // FieldLookupValue user = (FieldLookupValue)oListItem["Author4"];
                // string name = user.LookupValue;
                FieldLookupValue genre = (FieldLookupValue)oListItem["Genre"];
                var name1 = genre.LookupValue;


                dtCoaching.Rows.Add(

                                         oListItem["Title"] = oListItem["Title"],
                                        oListItem["Author4"] = oListItem["Author4"],
                                        oListItem["Genre"] = name1,
                                        oListItem["Pages"] = oListItem["Pages"],
                                        oListItem["Language"] = oListItem["Language"]


                                        ); ;

            }

            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = dtCoaching;
                dataGridView1.Refresh();
                dataGridView1.Columns[2].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
                var dataGridViewColumn = dataGridView1.Columns["ID"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
            }*/


            var web = clientContext.Web;
             var myList = web.Lists.GetByTitle("Books");
             var field = myList.Fields.GetByTitle("Genre");
             SP.CamlQuery camlQuery = new SP.CamlQuery();



             var itemBox = comboBox1.SelectedItem;
             string tx = itemBox.ToString();


                 SP.List oList = clientContext.Web.Lists.GetByTitle("Books");
             SP.ListItemCollection collListItem = oList.GetItems(camlQuery);


             clientContext.Load(
             collListItem,
                 items => items.Take(20).Include(

                 item => item["Title"],
                 item => item["Author4"],
                 item  => item["Genre"],
                 item => item["Pages"],
                 item => item["Language"])); ; ;

             clientContext.ExecuteQuery();


             var dtCoaching = new DataTable();

             dtCoaching.Columns.AddRange(new[]
             {
                 new DataColumn("Title"), new DataColumn("Author"), new DataColumn("Genre"), new DataColumn("Pages"),
                 new DataColumn("Language"),
             });





             foreach (var oListItem in collListItem)

             {



                 dtCoaching.Rows.Add(

                                       oListItem["Title"] = oListItem["Title"],
                                       oListItem["Author4"] = oListItem["Author4"],
                                         oListItem["Genre"] = tx,
                                         oListItem["Pages"] = oListItem["Pages"],
                                         oListItem["Language"] = oListItem["Language"]


                                         ); ;

             }

             if (dataGridView1 != null)
             {
                 dataGridView1.DataSource = dtCoaching;
                 dataGridView1.Refresh();
                 
                 var dataGridViewColumn = dataGridView1.Columns["ID"];
                 if (dataGridViewColumn != null)
                     dataGridViewColumn.Visible = false;
             }

            //clientContext.Credentials = onlineCredentials;

           /* List ShpList = clientContext.Web.Lists.GetByTitle("Books");
            CamlQuery CamlQ = CamlQuery.CreateAllItemsQuery(1000);
            DropDownList C_Company = new DropDownList();
            Microsoft.SharePoint.Client.ListItemCollection items = ShpList.GetItems(CamlQ);
            clientContext.Load(items);
            clientContext.ExecuteQuery();
            //C_Company.Items.Clear();
            foreach (ListItem I in items)
            {
                C_Company.Items.Add(new System.Web.UI.WebControls.ListItem() { Text = I["Genre"].ToString(), Value = I["ID"].ToString() });
            }
            */
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


        }
    }
}
