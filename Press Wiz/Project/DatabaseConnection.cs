using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Project
{
    class DatabaseConnection
    {
        SqlConnection myConnection = new SqlConnection("Data Source=MAKS-PC;Initial Catalog=PressWiz;Integrated Security=True");
        int i = -1;

        public String OpenConection()
        {
            try
            {
                myConnection.Open();
            }

            catch (InvalidOperationException ioe)
            {
                return(ioe.ToString());
            }

            catch(SqlException se)
            {
                return(se.ToString());
            }
            catch (Exception e)
            {
                return(e.ToString());
            }

            return "Successfully Connected to DB”";
        }

        public String CloseConnection()
        {
            myConnection.Close();
            return "Successfully DisConnected to DB";
        }

        public void addRow(User user)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "INSERT INTO UserAccounts(UserId,First_Name,Last_Name,Telephone,Password,Admin) VALUES ('" + user.UserId + "','" + user.First_Name + "','" + user.Last_Name + "','" + user.Telephone + "','" + user.Password + "','" + user.Admin + "');";
           
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show(ice.ToString());
            }
            catch (ObjectDisposedException ode)
            {
                MessageBox.Show(ode.ToString());
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.ToString());
            }           
        }

        public DataTable ReadValues()
        {
            DataTable myTable = new DataTable();            
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "SELECT * FROM UserAccounts";
            SqlDataReader myReader = myCommand.ExecuteReader();
            myTable.Load(myReader);
            return myTable;
        }

        public bool RowsCheck()
        {
            OpenConection();
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM UserAccounts", myConnection);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            int numberOfRows;
            numberOfRows = myTable.Rows.Count;
            if (i+1 < numberOfRows)
            {
                return true;
            }
            return false;
        }

        public User ReadRows()
        {
            OpenConection();
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM UserAccounts", myConnection);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            User user = new User();
            i++;
            user = fillData(user, myTable);          
            return user;
        }


        public User specificRow()
        {
            OpenConection();
            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM UserAccounts", myConnection);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            User user = new User();
            i--;
            user = fillData(user,myTable);
            return user;
        }

        public void updateRow(User user)
        {
            OpenConection();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "UPDATE UserAccounts SET Password ='" + user.Password + "', Admin ='" + user.Admin + "' WHERE UserId ='" + user.UserId + "';";
            try
            {
                myCommand.ExecuteNonQuery();
            }

            catch (InvalidCastException ice)
            {
                MessageBox.Show(ice.ToString());
            }

            catch (ObjectDisposedException ode)
            {
                MessageBox.Show(ode.ToString());

            }

            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());

            }

            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.ToString());

            }
        }

        public void deleteRow(string UserId)
        {
            OpenConection();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "DELETE * FROM UserAccounts WHERE UserId = '" + UserId + "';";
            try
            {
                myCommand.ExecuteNonQuery();
            }

            catch (InvalidCastException ice)
            {
                MessageBox.Show(ice.ToString());
            }

            catch (ObjectDisposedException ode)
            {
                MessageBox.Show(ode.ToString());

            }

            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());

            }

            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.ToString());

            }
        }

        public User findRow(string UserId,string First_Name, string Last_Name)
        {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM [UserAccounts] WHERE UserId LIKE '%" + UserId + "%' AND First_Name LIKE '%" + First_Name + "%' AND Last_Name LIKE '%" + Last_Name + "%'", myConnection);
                SqlDataReader myReader;
                myConnection.Open();
                myReader = myCommand.ExecuteReader();
                int count = 0;
                User user = new User();
                while (myReader.Read())
                {
                    count++;   
                    user.UserId = myReader["UserId"].ToString();
                    user.First_Name = myReader["First_Name"].ToString();
                    user.Last_Name = myReader["Last_Name"].ToString();
                    user.Telephone = Int32.Parse(myReader["Telephone"].ToString());
                    user.Admin = (bool)myReader["Admin"];
                    user.ip = myReader["ip"].ToString(); 
                }
                myReader.Close();
                myConnection.Close();
                if (count == 1)
                {
                    MessageBox.Show("Result Found : " + user.First_Name + user.Last_Name, "Found !",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    return user;
                }
                else if(count>1)
                {
                    MessageBox.Show(count+" Results Found !\nBe more spesific !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                else
                {
                    MessageBox.Show("No results Found !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
        }

        public User fillData(User user, DataTable myTable)
        {
            user.UserId = myTable.Rows[i]["UserId"].ToString();
            user.First_Name = myTable.Rows[i]["First_Name"].ToString();
            user.Last_Name = myTable.Rows[i]["Last_Name"].ToString();
            user.Telephone = Int32.Parse(myTable.Rows[i]["Telephone"].ToString());
            user.Admin =  (bool)myTable.Rows[i]["Admin"];
            user.ip = myTable.Rows[i]["ip"].ToString();
            return user;
        }

        public void addPages(string type, int number)
        {
            SqlCommand myCommand = new SqlCommand("SELECT * FROM Page_Stock WHERE Page_Type LIKE '" + type + "'", myConnection);
            SqlDataReader myReader;
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            number = number + Int32.Parse(myReader["In_Stock"].ToString());
            myReader.Close();
            SqlCommand myCommand2 = new SqlCommand();
            myCommand2.Connection = myConnection;
            myCommand2.CommandText = "UPDATE Page_Stock SET In_Stock ='" + number + "' WHERE Page_Type ='" + type + "';";
            try
            {
                myCommand2.ExecuteNonQuery();
            }

            catch (InvalidCastException ice)
            {
                MessageBox.Show(ice.ToString());
            }

            catch (ObjectDisposedException ode)
            {
                MessageBox.Show(ode.ToString());

            }

            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());

            }

            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.ToString());

            }
        }
    }
}
