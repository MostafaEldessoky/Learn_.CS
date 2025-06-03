using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connenctionstring = ConfigurationManager.ConnectionStrings["Zoo.Properties.Settings.ZooConnectionString"].ConnectionString; // make a configuration to database when connection making setup
        string query; // query will be sent to sql server
        SqlConnection sqlconnection; // making the connection of sql server object that store this connection channel with its configrations
        public MainWindow()
        {
            InitializeComponent();

            sqlconnection = new SqlConnection(connenctionstring); //  create object in the heap of the sql server connection with configurations needed to setup this connection  
            Show_Zoo();
            Show_Animal();
        }

        private void Con(string query,string MemberPath, ListBox lb, string ValuePath = "Id") 
        {
            using (SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlconnection)) // object that will open connection and send query then get data and stroe it then close the connection automatic
            {
                DataTable table = new DataTable(); // create object of datatable type that can store data form sqlData object

                sqlData.Fill(table); // pass data stored in sqlData to our zootable object to use it in our program

                lb.ItemsSource = table.DefaultView; // sending zootable data to our listbox Zooslb

                lb.DisplayMemberPath = MemberPath; // display Location Column in the listbox zooslb

                lb.SelectedValuePath = ValuePath; // value refrance whe selecte listbox Zooslb
            }
        }

        private void ShowOnTextBox(string tab, string MemberPath, ListBox lb)
        {
            query = $"select " + MemberPath + " from " + tab + $" where Id = {lb.SelectedValue}";

            using (SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlconnection)) 
            {
                DataTable table = new DataTable();
                
                sqlData.Fill(table);

                tb.Text = table.Rows[0][MemberPath].ToString();
            }
        }

        private void Show_Zoo()
        {
            query = "select * from Zoo"; 
            Con(query, "City", Zooslb);
        }
        private void Show_Animal()
        {
            query = "select * from Animal"; 
            Con(query, "Name", ExistedAnimalslb);
        }

        private void Zooslb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (Zooslb.SelectedValue != null)
            {
                query = $"select * from (Animal inner join ZooAnimal on Animal.Id = ZooAnimal.Animalid) where (ZooAnimal.Zooid = {Zooslb.SelectedValue})";
                Con(query, "Name", AssociatedAnimalslb,"Animalid");
                ShowOnTextBox("Zoo","City",Zooslb);
            }
        }
        private void ClickDeleteZoo(object sender, RoutedEventArgs e)
        {
            if (Zooslb.SelectedValue != null)
            {
                query = $"delete from Zoo where Id = {Zooslb.SelectedValue}";
                Con(query, "Name", AssociatedAnimalslb, "Animalid");
                Show_Zoo();
            }
        }
        private void ClickRemoveAnimal(object sender, RoutedEventArgs e)
        {
            if (AssociatedAnimalslb.SelectedValue != null)
            {
                query = $"delete from ZooAnimal where (ZooAnimal.Zooid = {Zooslb.SelectedValue})and(ZooAnimal.Animalid ={AssociatedAnimalslb.SelectedValue})";
                Con(query, "Name", AssociatedAnimalslb);
                Zooslb_SelectionChanged(sender, e);
            }
        }

        private void ClickDeleteAnimal(object sender, RoutedEventArgs e)
        {
            if (ExistedAnimalslb.SelectedValue != null)
            {
                query = $"delete from Animal where Id = {ExistedAnimalslb.SelectedValue}";
                Con(query, "Name", ExistedAnimalslb);
                Show_Animal();
                Zooslb_SelectionChanged(sender, e);
            }
        }

        private void ClickAddAnimaltoZoo(object sender, RoutedEventArgs e)
        {
            if (ExistedAnimalslb.SelectedValue != null && Zooslb.SelectedValue != null)
            {
                query = $"INSERT INTO ZooAnimal (Zooid, Animalid) VALUES ({Zooslb.SelectedValue}, {ExistedAnimalslb.SelectedValue})";
                Con(query, "Name", AssociatedAnimalslb, "Animalid");
                Zooslb_SelectionChanged(sender, e);
            }
        }

        private void ExistedAnimalslb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (ExistedAnimalslb.SelectedValue != null)
            {
                ShowOnTextBox("Animal", "Name", ExistedAnimalslb);
            }
        }

        private void ClickAddZoo(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb.Text))
            {
                query = $"INSERT INTO Zoo (City) VALUES ('{tb.Text}')";
                Con(query, "City", Zooslb);
                Show_Zoo();
            }
        }

        private void ClickUpdateZoo(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb.Text) && Zooslb.SelectedValue != null)
            {
                query = $"UPDATE Zoo SET City = '{tb.Text}' WHERE Id = {Zooslb.SelectedValue}";
                Con(query, "City", Zooslb);
                Show_Zoo();
            }
        }

        private void ClickAddAnimal(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb.Text))
            {
                query = $"INSERT INTO Animal (Name) VALUES ('{tb.Text}')";
                Con(query, "Name", ExistedAnimalslb);
                Show_Animal();
            }
        }

        private void ClickUpdateAnimal(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb.Text) && ExistedAnimalslb.SelectedValue != null)
            {
                query = $"UPDATE Animal SET Name = '{tb.Text}' WHERE Id = {ExistedAnimalslb.SelectedValue}";
                Con(query, "Name", ExistedAnimalslb);
                Show_Animal();
            }
        }
    }
}
