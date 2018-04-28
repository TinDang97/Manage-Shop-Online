using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DataAcess;
using System.Data;
using System.Security.Cryptography;

namespace Business
{
    public class BusinessPlayer
    {
        private ServerSQL server = new ServerSQL();

        private String servername = "Data Source=Trung-tin-it;Initial Catalog=ShopOnline;";

        private String address = "";

        public BusinessPlayer()
        {
            address = servername;
        }


        public BusinessPlayer(String username, String password)
        {
            if(username == null || password == null)
            {
                return;
            }

            address = servername + "User ID=" + username + "; Password = " + password;
            
        }

        public void SetUserPass(String username, String password)
        {
            if (username == null || password == null)
            {
                return;
            }

            address = servername + "User ID=" + username + "; Password = " + password;
            
        }

        public void SetUsername(String username)
        {
            if (username == null)
            {
                return;
            }

            if (address.Contains("User ID"))
            {
                address = servername;
            }

            address += "User ID=" + username + ";";
        }

        
        public void SetPassword(String password)
        {
            if ( password == null)
            {
                return;
            }

            if (address.Contains("Password"))
            {
                address = servername;
            }

            address += "Password = " + password + ";";
        }

        public int ChangePassWord(String user, String oldPass, String nPass)
        {
            if (user == null || oldPass == null || nPass == null)
            {
                user = "";
                oldPass = "";
                nPass = "";
            }

            String cmd = "ALTER LOGIN " + user +" WITH PASSWORD=N'" + nPass + "'" + " OLD_PASSWORD = '" + oldPass + "'";
            server.ExecuteScalar(cmd, address);
            try
            {
                server.connect(servername + "User ID=" + user + ";" + "Password = " + nPass + ";");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
            
        }

        public void Connection()
        {
            try
            {
                server.connect(address);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void queryAllOrders(DataTable data)
        {
            if(data == null)
            {
                data = new DataTable();
            }

            String cmd = "Select o.ID, o.IDCustomer, c.FirstName, c.LastName, o.Status, o.Timed, o.Total, o.Discount, o.Staff from Orders o, Customers c where o.IDCustomer = c.ID; ";
            SqlDataAdapter adapter =  server.ExecuteQueryAdapter(cmd, address);
            adapter.Fill(data);
        }

        public void querOrdersByMonth(DataTable data, DateTime time)
        {
            if (data == null)
            {
                data = new DataTable();
            }
            if (time == null)
            {
                time = DateTime.Today;
            }

            int month = time.Month;
            int year = time.Year;

            String cmd = "Select * from Orders";
            SqlDataAdapter adapter = server.ExecuteQueryAdapter(cmd, address);

            DataTable table = new DataTable();            
            adapter.Fill(table);

            data.Columns.Add("Timed", typeof(String));
            data.Columns.Add("Total", typeof(float));

            foreach (DataRow row in table.Rows)
            {
                DateTime timed = (DateTime)row["Timed"];

                if (timed.Year != year || timed.Month != month)
                {
                    continue;
                }

                DataRow nRow = data.NewRow();

                nRow["Timed"] = "Ngày " + timed.Day;

                nRow["Total"] = row["Total"];

                data.Rows.Add(nRow);
            }

        }

        public void querOrdersByYear(DataTable data, DateTime time)
        {
            if (data == null)
            {
                data = new DataTable();
            }
            if (time == null)
            {
                time = DateTime.Today;
            }

            int month = time.Month;
            int year = time.Year;

            String cmd = "Select * from Orders";
            SqlDataAdapter adapter = server.ExecuteQueryAdapter(cmd, address);

            DataTable table = new DataTable();
            adapter.Fill(table);

            data.Columns.Add("Timed", typeof(String));
            data.Columns.Add("Total", typeof(float));

            foreach (DataRow row in table.Rows)
            {
                DateTime timed = (DateTime)row["Timed"];

                if (timed.Year != year)
                {
                    continue;
                }

                DataRow nRow = data.NewRow();

                nRow["Timed"] = "Tháng " + timed.Month.ToString() + " Năm " +  timed.Year.ToString();

                nRow["Total"] = row["Total"];

                data.Rows.Add(nRow);
            }
        }

        public int delOrders(String id)
        {
            if(id == null)
            {
                return 0;
            }
            String cmd = "DELETE from orders where id = " + id;
            return server.ExecuteNonQuery(cmd, address);
        }
        public void queryAllCustomer(DataTable data)
        {
            if (data == null)
            {
                data = new DataTable();
            }

            String cmd = "Select * from Customers ";
            SqlDataAdapter adapter = server.ExecuteQueryAdapter(cmd, address);
            adapter.Fill(data);
        }

        public void queryCustomerWithAccount(DataTable data)
        {
            if (data == null)
            {
                data = new DataTable();
            }
            String cmd = "Select a.ID, a.UserName, a.Passwords, a.CustomerID, c.Avatar, c.FirstName, c.LastName, c.Sex, c.Birthday, c.Email, c.Phone,ad.Country, ad.Province, ad.District, ad.Location from Customers c , Accounts a , Address ad where c.ID = a.CustomerID AND c.IDAddress = ad.ID";
            SqlDataAdapter adapter = server.ExecuteQueryAdapter(cmd, address);
            adapter.Fill(data);
        }

        public void queryCustomerWithAccountByID(DataTable data, String ID)
        {
            if (data == null)
            {
                data = new DataTable();
            }

            if(ID == null)
            {
                return;
            }

            String cmd = "Select a.ID, a.UserName, a.Passwords, a.CustomerID, c.Avatar, c.FirstName, c.LastName, c.Sex, c.Birthday, c.Email, c.Phone, ad.Country, ad.Province, ad.District, ad.Location from Customers c , Accounts a , Address ad" +
                " where c.ID = a.CustomerID AND c.IDAddress = ad.ID AND c.ID = " + ID;
            SqlDataAdapter adapter = server.ExecuteQueryAdapter(cmd, address);
            adapter.Fill(data);
        }

        public int AddAccount(String user, String pass, String IDCustomer)
        {
            if(user == null || pass == null || IDCustomer == null)
            {
                return 0;
            }
            String cmd = "Insert into " +
                "Accounts(UserName, Passwords, CustomerID) " +
                "values (" +
                "N'" + user + "'," +
                "N'" + MD5Hash(pass) + "'," +
                "N'" + IDCustomer + "'" +
                ")";
            return server.ExecuteNonQuery(cmd, address);
        }

        public int AddCustomer(String firstname, String lastname,String avatar, String email, String phone, String birth, String sex, String idAddress)
        {
            if (firstname == null || lastname == null || avatar == null || email == null || phone == null || birth == null || sex == null || idAddress == null)
            {
                return 0;
            }

            String cmd = "Insert into Customers(FirstName, LastName, Avatar, Email, Phone, Birthday, Sex, IDAddress) output INSERTED.ID " +
                "values (" +
                "N'" + firstname + "'," +
                "N'" + lastname + "'," +
                "N'" + avatar + "'," +
                "N'" + email + "'," +
                "N'" + phone + "'," +
                "N'" + birth + "'," +
                "N'" + sex + "'," +
                "N'" + idAddress + "'" +
                ")";
            return server.ExecuteScalar(cmd, address);
        }

        public int delCustomer(String id)
        {
            if (id == null)
            {
                return 0;
            }

            String cmd = "delete from Customers where id=" + id;
            return server.ExecuteNonQuery(cmd, address);
        }

        public int addAddress(String country, String province, String district, String location)
        {
            if (country == null || province == null || district == null || location == null)
            {
                return 0;
            }

            String cmd = "Insert into Address(Country, Province, District, Location) output INSERTED.ID values ("
                + "N'" + country + "' ,"
                + "N'" + province + "' ,"
                + "N'" + district + "' ,"
                + "N'" + location + "'"
                + ")";
            return server.ExecuteScalar(cmd, address);
        }

        public int delAddress(String id)
        {
            if (id == null)
            {
                return 0;
            }
            String cmd = "delete from Address where id=" + id;
            return server.ExecuteNonQuery(cmd, address);
        }

        public void queryAllProducts(DataTable data)
        {
            if (data == null)
            {
                data = new DataTable();
            }
            String cmd = "Select * from products ";
            SqlDataAdapter adapter = server.ExecuteQueryAdapter(cmd, address);
            adapter.Fill(data);
        }

        public void queryProductsByID(String id, DataTable data)
        {
            if (data == null)
            {
                data = new DataTable();
            }
            String cmd = "Select * from products where id='"+ id +"'";
            SqlDataAdapter adapter =  server.ExecuteQueryAdapter(cmd, address);
            adapter.Fill(data);
        }

        public int addProducts(String name, String Price, String Quantity, String Content, String Color, String Size, String Category, String MadeIn)
        {
            if (name == null || Price == null || Quantity == null || Content == null || Color == null || Size == null || Category == null || MadeIn == null)
            {
                return 0;
            }

            String cmd = "Insert into products(name, price, quantity, content, color, size, category, madein) values (N'" + name + "', N'" + Price + "', N'" + Quantity + "', N'" + Content + "', N'" + Color + "', N'" + Size + "', N'" + Category + "', N'" + MadeIn + "')";
            return server.ExecuteNonQuery(cmd, address);
        }

        public int updateProducts(String Id, String name, String Price, String Quantity,String img, String Content, String Color, String Size, String Category, String MadeIn)
        {
            if (Id == null || name == null || Price == null || Quantity == null || img == null || Color == null || Content == null || Color == null || Size == null || Category == null || MadeIn == null)
            {
                return 0;
            }
            String cmd = "update products " +
                "SET name = N'" + name +"'"+
                ", price = N'" + Price + "'" +
                ", quantity = N'" + Quantity + "'"+
                ", content = N'" + Content + "'"+
                ", color = N'" + Color+"'"+
                ", image = '" + img + "'" +
                ", size = N'" + Size + "'"+
                ", category = N'" + Category +"'"+
                ", madein = N'" + MadeIn +"' "+
                "where id=" + Id;

            Console.WriteLine(cmd); 
            return server.ExecuteNonQuery(cmd, address);
        }

        public int delProduct(String id)
        {
            if (id == null)
            {
                return 0;
            }
            String cmd = "DELETE from products where id=" + id;
            return server.ExecuteNonQuery(cmd, address);
        }

        public int InsertOrders(String customerID)
        {
            if (customerID == null)
            {
                return 0;
            }
            String cmd = "Insert Into Orders(IDCustomer, Status) output INSERTED.ID values ('" + customerID + "', N'Chuẩn bị')";

             return server.ExecuteScalar(cmd, address);
        }

        public void queryOrdersDetail(String idOrder, DataTable data)
        {

            String cmd = "Select * from OrdersDetail o, Products p where o.IDProduct = p.ID AND o.IDOrder = " + idOrder;
            SqlDataAdapter adapter = server.ExecuteQueryAdapter(cmd, address);
            adapter.Fill(data);
        }

        public int updateOrder(String Id, String IDCustomer, String Status)
        {
            if (Id == null || IDCustomer == null || Status == null)
            {
                return 0;
            }
            String cmd = "update Orders " +
                "SET IDCustomer = N'" + IDCustomer + "'" +
                ", Status = N'" + Status + "'" +           
                "where id=" + Id;

            Console.WriteLine(cmd);
            return server.ExecuteNonQuery(cmd, address);
        }

        public int InsertOrdersDetail(String OrderID, String ProductID, String Quantity, String type)
        {
            if (OrderID == null || ProductID == null || type == null)
            {
                return 0;
            }
            String cmd = "Insert Into OrdersDetail(IDOrder, IDProduct, Quantity, TypeWarranty) " +
                "values ('" + OrderID + "', '" + ProductID + "', '" + Quantity + "', N'"+ type + "')";
            Console.WriteLine(cmd);
            return server.ExecuteNonQuery(cmd, address);
        }

        public int updateOrderDetail(String Id, String IDProduct, String IDOrder, String TypeWarranty, String Quantity)
        {
            if (Id == null || IDProduct == null || IDOrder == null || TypeWarranty == null || Quantity == null)
            {
                return 0;
            }
            String cmd = "update OrderDetail " +
                "SET IDProduct = N'" + IDProduct + "'" +
                ", IDOrder = N'" + IDOrder + "'" +
                ", TypeWarranty = N'" + TypeWarranty + "'" +
                ", Quantity = N'" + Quantity + "'" +
                "where id=" + Id;

            Console.WriteLine(cmd);
            return server.ExecuteNonQuery(cmd, address);
        }

        public int delOrdersDetail(String id)
        {
            if (id == null)
            {
                return 0;
            }
            String cmd = "DELETE from OrdersDetail where id=" + id;
            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> getColor()
        {

            String cmd = "Select * from colors";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> colors = new List<string>();

            foreach(DataRow row in dataTable.Rows)
            {
                colors.Add((String)row["color"]);
            }

            return colors; 
        }

        public int getColor(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from colors where color=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addColor(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "Insert into Colors(color) values (N'" + data + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delColor(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from colors where color = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> getStatus()
        {

            String cmd = "Select * from Status";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();

            try
            {
                reader.Fill(dataTable);
            }
            catch(Exception e)
            {                
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }
            

            List<String> colors = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                colors.Add((String)row["Status"]);
            }

            return colors;
        }

        public int getStatus(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from Status where Status=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addStatus(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "Insert into Status(Status) values (N'" + data + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delStatus(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Status where Status = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> getWarranty()
        {

            String cmd = "Select * from Warranty";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> colors = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                colors.Add((String)row["Type"]);
            }

            return colors;
        }

        public int getWarranty(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from Warranty where Type=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addWarranty(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "Insert into Warranty(Type) values (N'" + data + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delWarranty(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Warranty where Type = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> getSize()
        {

            String cmd = "Select * from sizes";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> sizes = new List<string>();

            

            foreach (DataRow row in dataTable.Rows)
            {
                sizes.Add((String)row["size"]);
            }

            return sizes;
        }

        public int getSize(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from sizes where size=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addSize(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "Insert into Sizes(size) values (N'" + data + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delSize(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Sizes where size = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> GetCategories()
        {

            String cmd = "Select * from categories";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> categories = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                categories.Add((String)row["category"]);
            }

            return categories;
        }

        public int getCategories(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from Categories where Category=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addCategories(String data, String parent)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "Insert into Categories(Category, CategoryParent) values (N'" + data + "', N'"+ parent + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delCategories(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Categories where Category = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }



        public List<String> GetMadeIn()
        {

            String cmd = "Select * from Countries";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> Countries = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                Countries.Add((String)row["Country"]);
            }

            return Countries;
        }
        public int getMadeIn(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from Countries where country=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addMadeIn(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "Insert into Countries(country) values (N'" + data + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delMadeIn(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Countries where country = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> GetSex()
        {

            String cmd = "Select * from Genders";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> Sex = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                Sex.Add((String)row["Sex"]);
            }

            return Sex;
        }
        public int GetSex(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from Genders where Sex=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addSex(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "Insert into Genders(Sex) values (N'" + data + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delSex(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Genders where sex = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> GetProvinces(String Country)
        {

            String cmd = "Select * from Provinces where Country=N'" + Country + "'";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> Province = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                Province.Add((String)row["Province"]);
            }

            return Province;
        }
        public int GetProvince(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from Provinces where Province=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addProvince(String provice, String country)
        {
            if (provice == null || country == null)
            {
                return 0;
            }


            String cmd = "Insert into Provinces(Province, Country) values (N'" + provice + "',N'" + country + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delProvince(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Provinces where Province = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public List<String> GetDistricts(String province)
        {

            String cmd = "Select * from Districts where Province = N'" + province + "'";
            SqlDataAdapter reader = server.ExecuteQueryAdapter(cmd, address);
            DataTable dataTable = new DataTable();
            try
            {
                reader.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("Permission is denied!");
                Console.WriteLine(e.ToString());
            }

            List<String> Sex = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                Sex.Add((String)row["District"]);
            }

            return Sex;
        }
        public int GetDistrict(String input)
        {
            if (input == null)
            {
                return 0;
            }
            String cmd = "Select count(*) from Districts where District=N'" + input + "'";

            return server.ExecuteScalar(cmd, address);
        }

        public int addDistricts(String district, String province)
        {
            if (district == null || province == null)
            {
                return 0;
            }
            String cmd = "Insert into Districts(District, Province) values (N'" + district +"', N'" + province + "')";

            return server.ExecuteNonQuery(cmd, address);
        }

        public int delDistricts(String data)
        {
            if (data == null)
            {
                return 0;
            }
            String cmd = "delete from Districts where District = N'" + data + "'";

            return server.ExecuteNonQuery(cmd, address);
        }

        public static string MD5Hash(string input)
        {
            if (input == null)
            {
                return "";
            }

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }



}
