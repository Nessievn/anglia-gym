using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// MySql Connector must be installed at this point
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Gym_administration
{
    class mySqlConn
    {
        string server;
        string database;
        string user;
        string password;
        MySqlConnection connection;

        public mySqlConn(string server, string database, string user, string password)
        {
            this.server = server;
            this.database = database;
            this.user = user;
            this.password = password;
        }
        public mySqlConn()
        {
            this.server = "localhost";
            this.database = "gym";
            this.user = "gym";
            this.password = "gym";
        }
        
        public void connect()
        {
            string MyConString = "server=" + this.server + ";User Id=" + this.user + ";password=" + this.password + ";Persist Security Info=True;database=" + this.database + ";";
            try
            {
                this.connection = new MySqlConnection(MyConString);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password when connecting to the database, please contact with an administrator.");
                        break;
                    default:
                        MessageBox.Show(ex.ToString());
                        break;
                }
            }

        }

        public List<Hashtable> lhSqlQuery(string query)
        {
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }

            // Create and populate a List.
            List<Hashtable> resultset = new List<Hashtable>();

      
            try
            {
                MySqlCommand command = this.connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = query;
                
                Reader = command.ExecuteReader();
                Hashtable resultset_tmp;
                int i;

                while (Reader.Read())
                { 
                    resultset_tmp = new Hashtable();
                    for (i = 0; i < Reader.FieldCount; i++)
                    {
                        resultset_tmp.Add(Reader.GetName(i).ToString(), Reader.GetValue(i).ToString()); 
                    } 
                    resultset.Add(resultset_tmp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return resultset;
        }
    
        // This function returns the id of the record inserted
        public int iInsert(string query)
        {
            string sLastInsertId = "0";
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            try
            {
                MySqlCommand command = this.connection.CreateCommand();
                
                
                command.CommandText = query;
                

                command.ExecuteNonQuery();
                
              

                List <Hashtable> result = this.lhSqlQuery("SELECT LAST_INSERT_ID() id");
                sLastInsertId = result[0]["id"].ToString();
               
            }
            catch (Exception ex)
            {
                // We don't want to show that to the user
                MessageBox.Show(ex.ToString());
            }

            this.connection.Close();
            return int.Parse(sLastInsertId);
        }
        // This function returns the id of the the modified records 
        // affected by a Delete or Update sql statement
        public int iDeleteOrUpdate(string query)
        {
            int iAffectedRows = 0;
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            try
            {
                MySqlCommand command = this.connection.CreateCommand();
                command.CommandText = query;
                iAffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // We don't want to show that to the user
                MessageBox.Show(ex.ToString());
            }

            this.connection.Close();
            return iAffectedRows;
        }
        }
}
