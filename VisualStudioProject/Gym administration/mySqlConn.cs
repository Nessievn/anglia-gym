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

    /**
     * @desc It holds methods for managing mysql connections and queries
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
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
        * @param string query
        *   The prepared statement query to run. 
        *
        * @return [List<Hashtable>]
        *   A List<HashTable> containing the data retrieved from the databse. This
        *   date can be used with a foreach loop or directly htResultset[index][fieldName]
        *
        */
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
         * @params [string] query
         * @return [int] The id of the last record inserted
         * or the update
         */
        public int iInsert(string query)
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
                command.CommandText = query;
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
         * @params [string] query
         * @return [DataTable] The DataTable object if there is no data, the object
         * will be returned empty.
         */
        public DataTable dtGetTableForDataGrid(string query)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            try
            {
                MyDA.SelectCommand = new MySqlCommand(query, this.mycGetConnection());
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
         * @params [string] query
         * @return [ArrayList] ArrayList containing the items 
         */
        public ArrayList alGetComboFromDb(string query, string sFieldId, string sFieldValue)
        {
            ArrayList alMyItems = new ArrayList();

            List<Hashtable> result = this.lhSqlQuery(query);
            foreach (Hashtable record in result)
                alMyItems.Add(new DictionaryEntry(record[sFieldId].ToString(), record[sFieldValue].ToString()));

            return alMyItems;

        }

        /**
         * @desc This function returns the id of the the modified 
         * records affected by a Delete or Update sql statement 
         * @params [string] query
         * @return [int] The number of modified rows by the delete
         * or the update
         */
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

        /**
         * @desc This function uploads a file to the database
         * and returns the id of the the last record inserted 
         * @params [string] filePath: The path on the hard drive to the file to be inserted
         * @params [string] fileName: The inserted file's name
         * @return [int] The id of the last record inserted
         * or the update
         */
        public string uploadFileToDB(string filePath, string fileName)
        {
            // Create a mysql command object
            MySql.Data.MySqlClient.MySqlCommand cmd;
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            int fileSize;
            byte[] rawData;
            FileStream fs;
            string id_file;
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            try
            {
                // Create a filestream object for the file
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                // Retrieve the filesize
                fileSize = int.Parse(fs.Length.ToString());
                // Create a byte[] object for the raw data
                rawData = new byte[fileSize];
                // Copy the binary contents of the file into the byte[] object
                fs.Read(rawData, 0, fileSize);
                // Close the filestream
                fs.Close();
                // Add mysql connection to mysql command object
                cmd.Connection = connection;
                // Add insert file query with parameters to mysql command object
                cmd.CommandText = "INSERT INTO file VALUES(NULL, @FileName, @FileSize, @File)";
                // Add parameter values to mysql command object
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@FileSize", fileSize);
                cmd.Parameters.AddWithValue("@File", rawData);
                // Launch query of mysql command object
                cmd.ExecuteNonQuery();
                // Create a mysql datareader object for holding results of query
                MySqlDataReader Reader;
                // Create query for checking insert query result
                cmd.CommandText = "SELECT LAST_INSERT_ID() id";
                // Launch query for checking insert query result
                Reader = cmd.ExecuteReader();
                // Read the reader
                Reader.Read();
                // Retrieve reader result
                id_file = Reader.GetValue(0).ToString();
                MessageBox.Show("File Inserted into database successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // Close the connection
                connection.Close();
                // Return last inserted file's ID
                return id_file;
            }
            // Error catching
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }
        }

        /**
         * @desc This function downloads an image from the database
         * @params [string] id_file: the file ID in the database that has to be downloaded
         * @return [Image] an image ready to be loaded into a pictureBox
         */
        public Image loadImageFromDB(string id_file)
        {
            // Create a mysql command object
            MySql.Data.MySqlClient.MySqlCommand cmd;
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            // Create a mysql datareader object
            MySqlDataReader Reader;
            int FileSize;
            byte[] rawData;
            // The connection is forced when its not connected
            if (this.connection.State.ToString() == "Closed")
            {
                this.connect();
                connection.Open();
            }
            try
            {
                cmd.Connection = connection;
                // Add query to find and download the image to mysql command object
                cmd.CommandText = "SELECT file_name, file_size, file FROM file WHERE id_file = '" + id_file + "' ";
                // Launch query
                Reader = cmd.ExecuteReader();
                // If there is 0 result
                if (!Reader.HasRows)
                    throw new Exception("There are no BLOBs to save");
                // Read the reader
                Reader.Read();
                // retrive the file size from reader data
                FileSize = int.Parse(Reader.GetUInt32(Reader.GetOrdinal("file_size")).ToString());
                // Create a new byte[] object foe holding binary image data
                rawData = new byte[FileSize];
                // Add image data to the byte[] object from reader
                Reader.GetBytes(Reader.GetOrdinal("file"), 0, rawData, 0, FileSize);
                // Create memory stream that can be read into Image object as source
                MemoryStream picStream = new MemoryStream(rawData);
                // Close reader
                Reader.Close();
                // Close connection
                connection.Close();
                // Return the ready image from memory stream
                return Image.FromStream(picStream);
            }
            // Catch the errors
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
