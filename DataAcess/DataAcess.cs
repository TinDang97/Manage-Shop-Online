using System;
using System.Data.SqlClient;

namespace DataAcess
{
    public class ServerSQL
    {
        private SqlConnection sqlConnection = new SqlConnection();
        public ServerSQL() { }

        public ServerSQL(String address)
        {
            if (address == null)
            {
                return;
            }
            try
            {
                sqlConnection.ConnectionString = address;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public int connect(String address)
        {
            if (address == null)
            {
                return 0;
            }
            try
            {
                sqlConnection.ConnectionString = address;
                sqlConnection.Open();
                return 1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public SqlDataAdapter ExecuteQueryAdapter(String cmd, String address)
        {
            if (cmd == null || address == null)
            {
                return new SqlDataAdapter();
            }
            try
            {
                sqlConnection.ConnectionString = address;
                return ExecuteQueryAdapter(cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new SqlDataAdapter();
            }
            
           
        }

        public SqlDataAdapter ExecuteQueryAdapter(String cmd)
        {
            if (cmd == null)
            {
                return null;
            }
            try
            {
                sqlConnection.Open();
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, sqlConnection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                return adapter;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public SqlDataReader ExecuteQuery(String cmd, String address)
        {
            if (cmd == null || address == null)
            {
                return null;
            }
            try
            {
                sqlConnection.ConnectionString = address;
                return ExecuteQuery(cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public SqlDataReader ExecuteQuery(String cmd)
        {
            if(cmd == null)
            {
                return null;
            }
            try
            {
                sqlConnection.Open();

                SqlCommand builder = new SqlCommand(cmd, sqlConnection);
                SqlDataReader reader = builder.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public int ExecuteScalar(String cmd, String address)
        {
            if (cmd == null || address == null)
            {
                return 0;
            }
            try
            {
                sqlConnection.ConnectionString = address;
                return executeScalar(cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }

        public int executeScalar(String cmd)
        {
            if (cmd == null)
            {
                return 0;
            }
            try
            {
                sqlConnection.Open();

                SqlCommand cmdSQL = new SqlCommand(cmd, sqlConnection);
                Object result = cmdSQL.ExecuteScalar();

                return (int) result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public int ExecuteNonQuery(String cmd, String address)
        {
            if (cmd == null || address == null)
            {
                return 0;
            }
            try
            {
                sqlConnection.ConnectionString = address;
                return ExecuteNonQuery(cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }

        public int ExecuteNonQuery(String cmd)
        {
            if (cmd == null)
            {
                return 0;
            }
            try
            {
                sqlConnection.Open();

                SqlCommand cmdSQL = new SqlCommand(cmd, sqlConnection);
                int result = cmdSQL.ExecuteNonQuery();

                return (int)result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public int DeleteRow(String cmd, String address)
        {
            if (cmd == null || address == null)
            {
                return 0;
            }
            try
            {
                sqlConnection.ConnectionString = address;
                return ExecuteNonQuery(cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }

        public int DeleteRow(String cmd)
        {
            if (cmd == null)
            {
                return 0;
            }
            try
            {
                sqlConnection.Open();

                SqlCommand cmdSQL = new SqlCommand(cmd, sqlConnection);
                int result = cmdSQL.ExecuteNonQuery();

                return (int)result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
