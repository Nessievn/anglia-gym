using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// MySql Connector must be installed at this point
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Gym_administration
{
    class mySqlConn
    {
        string server;
        string database;
        string user;
        string password;
        string sMyConString;
        MySqlConnection connection;

        /**
        * @desc The constructor specifying the connection parameters
        *
        * @param string server
        *   Server IP 
        * @param string database
        *   The database Name 
        * @param string user
        *   The username
        * @param string password
        *   The password
        */
        public mySqlConn(string server, string database, string user, string password)
        {
            this.server = server;
            this.database = database;
            this.user = user;
            this.password = password;
        }
        /**
        * @desc The constructor by default with the connection information
        *
        */
        public mySqlConn()
        {
            this.server = "localhost";
            this.database = "gym";
            this.user = "gym";
            this.password = "gym";
        }
        /**
        * @desc Returns the connection string.
        *
        * @return [string]
        *   The connection string returned 
        *
        */
        public string sGetMyConnString()
        {
            return this.sMyConString;
        }

        /**
        * @desc Connects to the databse using the specified query string
        *
        */
        public void connect()
        {
            this.sMyConString = "server=" + this.server + ";User Id=" + this.user + ";password=" + this.password + ";Persist Security Info=True;database=" + this.database + ";";
            try
            {
                this.connection = new MySqlConnection(this.sMyConString);
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
        /**
        * @desc Returns the connection to the database, if it is closed, it
        * opens it.
        *
        * @return [MySqlConnection]
        *   The mysql connection object returned 
        *
        */
        public MySqlConnection mycGetConnection()
        {
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            return this.connection;
        }

        /**
        * @desc Execute an arbitrary query string against the active database, very similar
        * to the PHP way. Do not use this function for INSERT, UPDATE, or DELETE queries. 
        *
        * @param string sQuery
        *   The prepared statement query to run. 
        *
        * @return [List<Hashtable>]
        *   A List<HashTable> containing the data retrieved from the databse. This
        *   date can be used with a foreach loop or directly htResultset[index][fieldName]
        *
        */
        public List<Hashtable> lhSqlQuery(string sQuery)
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
                command.CommandText = sQuery;
                
                Reader = command.ExecuteReader();
                Hashtable resultset_tmp;
                int i;

                while (Reader.Read())
                { 
                    resultset_tmp = new Hashtable();
                    for (i = 0; i < Reader.FieldCount; i++)
                    {
                        // We check first if the key exists
                        if(!resultset_tmp.ContainsKey(Reader.GetName(i).ToString()))
                            resultset_tmp.Add(Reader.GetName(i).ToString(), Reader.GetValue(i).ToString()); 
                    } 
                    resultset.Add(resultset_tmp);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return resultset;
        }

        /**
         * @desc This function performs an insert statement on the database
         * and returns the id of the the last record inserted 
         * @params [string] sQuery
         * @return [int] The id of the last record inserted
         * or the update
         */
        public int iInsert(string sQuery)
        {
            string sLastInsertId = "-1";
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            try
            {
                MySqlCommand command = this.connection.CreateCommand();
                command.CommandText = sQuery;
                command.ExecuteNonQuery();

                List<Hashtable> result = this.lhSqlQuery("SELECT LAST_INSERT_ID() id");
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
        /**
         * @desc This function executes the specified query on the database and
         * returns a DataTable ready to use in a DataGridView component.
         * @params [string] sQuery
         * @return [DataTable] The DataTable object if there is no data, the object
         * will be returned empty.
         */
        public DataTable dtGetTableForDataGrid(string sQuery)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            try
            {
                MyDA.SelectCommand = new MySqlCommand(sQuery, this.mycGetConnection());
                MyDA.Fill(table);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return new DataTable();
            }
            return table;
        }

        /**
         * @desc This function Returns the datasource ready to be used in a combobox.
         * @params [string] sQuery
         * @return [ArrayList] ArrayList containing the items 
         */
        public ArrayList alGetComboFromDb(string sQuery, string sFieldId, string sFieldValue)
        {
            ArrayList alMyItems = new ArrayList();

            List<Hashtable> result = this.lhSqlQuery(sQuery);
            foreach (Hashtable record in result)
                alMyItems.Add(new DictionaryEntry(record[sFieldId].ToString(), record[sFieldValue].ToString()));

            return alMyItems;

        }

        /**
         * @desc This function returns the id of the the modified 
         * records affected by a Delete or Update sql statement 
         * @params [string] sQuery
         * @return [int] The number of modified rows by the delete
         * or the update
         */
        public int iDeleteOrUpdate(string sQuery)
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
                command.CommandText = sQuery;
                iAffectedRows = command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // We don't want to show that to the user
                switch (ex.Number)
                {
                    case 1451:
                        return -1;
                    default:
                        MessageBox.Show(ex.ToString());
                        break;
                }
                
            }

            this.connection.Close();
            return iAffectedRows;
        }


        public string uploadFileToDB(string filePath, string fileName)
        {



            //MySql.Data.MySqlClient.MySqlConnection thisConn;
            MySql.Data.MySqlClient.MySqlCommand cmd;

            //thisConn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();


            string SQL;
            int fileSize;
            byte[] rawData;
            FileStream fs;
            string id_file;

            //thisConn.ConnectionString = "server=localhost;uid=gym;pwd=gym;database=gym;";

            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            try
            {
                //string strFileName = "Picture";
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                fileSize = int.Parse(fs.Length.ToString());

                rawData = new byte[fileSize];
                fs.Read(rawData, 0, fileSize);
                fs.Close();

                //connection.Open();

                SQL = "INSERT INTO file VALUES(NULL, @FileName, @FileSize, @File)";

                cmd.Connection = connection;
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@FileSize", fileSize);
                cmd.Parameters.AddWithValue("@File", rawData);

                
                cmd.ExecuteNonQuery();

                MySqlDataReader Reader;
                cmd.CommandText = ("SELECT LAST_INSERT_ID() id");
                Reader = cmd.ExecuteReader();
                Reader.Read();
                id_file = Reader.GetValue(0).ToString();

                MessageBox.Show("File Inserted into database successfully!",
                                           "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                connection.Close();

                return id_file;



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }


                        

        }




        public Image loadImageFromDB(string id_file)
        {


            //MySql.Data.MySqlClient.MySqlConnection conn;
            MySql.Data.MySqlClient.MySqlCommand cmd;
            MySql.Data.MySqlClient.MySqlDataReader myData;

            //conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();

            string SQL;
            int FileSize;
            byte[] rawData;

            //conn.ConnectionString = "server=localhost;uid=gym;pwd=gym;database=gym;";

            SQL = "SELECT file_name, file_size, file FROM file WHERE id_file = '" + id_file + "' ";


            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            try
            {
                //connection.Open();

                cmd.Connection = connection;
                cmd.CommandText = SQL;

                myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                    throw new Exception("There are no BLOBs to save");

                myData.Read();

                FileSize = int.Parse(myData.GetUInt32(myData.GetOrdinal("file_size")).ToString());
                rawData = new byte[FileSize];

                myData.GetBytes(myData.GetOrdinal("file"), 0, rawData, 0, FileSize);


                MemoryStream picStream = new MemoryStream(rawData);




                myData.Close();
                connection.Close();
                return Image.FromStream(picStream);


                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }






        }





      }
}
