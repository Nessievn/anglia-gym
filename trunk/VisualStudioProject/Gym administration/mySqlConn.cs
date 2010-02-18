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

        public Hashtable htSqlQuery(string query)
        {
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
                this.connect();
            Hashtable resultset = new Hashtable();
      
            try
            {
                MySqlCommand command = this.connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = query;
                connection.Open();
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
                    resultset.Add(i.ToString(), resultset_tmp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return resultset;
        }
        // TODO: Need to be adapted!!!
        public bool vInsert(string query)
        {
        
            string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "INSERT INTO Country (Name, HeadOfState, Continent) VALUES ('Disneyland','Mickey Mouse', 'North America')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            return true;
        }
            
        }
}
