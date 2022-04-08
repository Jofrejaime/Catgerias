using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace Categorias
{
    /*
    CODIGOS COM EFICIENCIA E PUREZA, JOFRESCODE
    */
    class Operacoes
    {
       private MySqlConnection conecter = new MySqlConnection("server=localhost; user = root; password=''; database= soma");
       private MySqlCommand comand;
       private MySqlDataAdapter adapter;

        public void addCategoria(BunifuMaterialTextbox txtcateg)
        {
            
            if (txtcateg.Text.Equals(null) || txtcateg.Text.Equals("") )
            {
                throw new ArgumentException();
            }
            else
            {
           
            conecter.Open();
            comand = new MySqlCommand("INSERT INTO categorias(nome) values(@nome)",conecter);
            comand.Parameters.Add("@nome", MySqlDbType.String).Value = txtcateg.Text;
            comand.ExecuteNonQuery();
            conecter.Close();
            }
          

        }
        public void sendToCombo(ComboBox cat, ComboBox CategParaSub)
        {
            adapter = new MySqlDataAdapter("Select * From categorias",conecter);
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            cat.DataSource = table;
            cat.DisplayMember = "nome";
            cat.ValueMember = "nome";
            cat.SelectedValue = "nome";
            // Categoria da SubCategoria
            adapter = new MySqlDataAdapter("Select * From categorias", conecter);
            DataTable table02 = new DataTable();
            table02.Clear();
            adapter.Fill(table02);
            CategParaSub.DataSource = table02;
            CategParaSub.ValueMember = "nome";
            CategParaSub.DisplayMember = "nome";
           
            CategParaSub.SelectedValue = "";

           
        }
        public void addSubCateg(BunifuMaterialTextbox txtSubCateg, ComboBox CategeParaSubcateg)
        {
          
            if (txtSubCateg.Text.Equals("") && txtSubCateg.Text.Equals(null))
            {
                throw new ArgumentException();
                
            }
            else
            {
                
                conecter.Open();

                comand = new MySqlCommand("SELECT id FROM categorias where nome = '" + CategeParaSubcateg.SelectedValue + "'", conecter);
                int ID = Convert.ToInt16(comand.ExecuteScalar());

                conecter.Close();

                if (ID.Equals(0))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    
                    conecter.Open();
                    comand = new MySqlCommand("INSERT INTO subcategorias(nome, categoria) values(@nome, @categoria)", conecter);
                    comand.Parameters.Add("@nome", MySqlDbType.String).Value = txtSubCateg.Text;
                    comand.Parameters.Add("@categoria", MySqlDbType.Int32).Value = ID;
                    comand.ExecuteNonQuery();
                    conecter.Close();
                }
                
            }
           

        }
        public void sentToListBox(ListBox list, ComboBox cat)
        {

         
                conecter.Open();
                comand = new MySqlCommand("SELECT id FROM categorias where nome = '" + cat.SelectedValue + "'", conecter);
                int id = Convert.ToInt16(comand.ExecuteScalar());
                cat.DisplayMember = "nome";
                conecter.Close();

                adapter = new MySqlDataAdapter("Select nome From subcategorias where categoria = '" + id + "'", conecter);
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                list.DataSource = table;
                list.DisplayMember = "nome";
            
         
           
        }
    }
}
