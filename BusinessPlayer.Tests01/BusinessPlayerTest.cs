// <copyright file="BusinessPlayerTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using System.Data;
using Business;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Tests
{
    /// <summary>This class contains parameterized unit tests for BusinessPlayer</summary>
    [PexClass(typeof(BusinessPlayer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BusinessPlayerTest
    {
        /// <summary>Test stub for AddAccount(String, String, String)</summary>
        [PexMethod]
        public int AddAccountTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string user,
            string pass,
            string IDCustomer
        )
        {
            int result = target.AddAccount(user, pass, IDCustomer);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.AddAccountTest(BusinessPlayer, String, String, String)
        }

        /// <summary>Test stub for AddCustomer(String, String, String, String, String, String, String, String)</summary>
        [PexMethod]
        public int AddCustomerTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string firstname,
            string lastname,
            string avatar,
            string email,
            string phone,
            string birth,
            string sex,
            string idAddress
        )
        {
            int result = target.AddCustomer
                             (firstname, lastname, avatar, email, phone, birth, sex, idAddress);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.AddCustomerTest(BusinessPlayer, String, String, String, String, String, String, String, String)
        }

        /// <summary>Test stub for ChangePassWord(String, String, String)</summary>
        [PexMethod]
        public int ChangePassWordTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string user,
            string oldPass,
            string nPass
        )
        {
            int result = target.ChangePassWord(user, oldPass, nPass);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.ChangePassWordTest(BusinessPlayer, String, String, String)
        }

        /// <summary>Test stub for Connection()</summary>
        [PexMethod]
        public void ConnectionTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            target.Connection();
            // TODO: add assertions to method BusinessPlayerTest.ConnectionTest(BusinessPlayer)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public BusinessPlayer ConstructorTest()
        {
            BusinessPlayer target = new BusinessPlayer();
            return target;
            // TODO: add assertions to method BusinessPlayerTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String, String)</summary>
        [PexMethod]
        public BusinessPlayer ConstructorTest01(string username, string password)
        {
            BusinessPlayer target = new BusinessPlayer(username, password);
            return target;
            // TODO: add assertions to method BusinessPlayerTest.ConstructorTest01(String, String)
        }

        /// <summary>Test stub for GetCategories()</summary>
        [PexMethod]
        public List<string> GetCategoriesTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            List<string> result = target.GetCategories();
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetCategoriesTest(BusinessPlayer)
        }

        /// <summary>Test stub for GetDistrict(String)</summary>
        [PexMethod]
        public int GetDistrictTest([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.GetDistrict(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetDistrictTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for GetDistricts(String)</summary>
        [PexMethod]
        public List<string> GetDistrictsTest([PexAssumeUnderTest]BusinessPlayer target, string province)
        {
            List<string> result = target.GetDistricts(province);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetDistrictsTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for GetMadeIn()</summary>
        [PexMethod]
        public List<string> GetMadeInTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            List<string> result = target.GetMadeIn();
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetMadeInTest(BusinessPlayer)
        }

        /// <summary>Test stub for GetProvince(String)</summary>
        [PexMethod]
        public int GetProvinceTest([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.GetProvince(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetProvinceTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for GetProvinces(String)</summary>
        [PexMethod]
        public List<string> GetProvincesTest([PexAssumeUnderTest]BusinessPlayer target, string Country)
        {
            List<string> result = target.GetProvinces(Country);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetProvincesTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for GetSex()</summary>
        [PexMethod]
        public List<string> GetSexTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            List<string> result = target.GetSex();
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetSexTest(BusinessPlayer)
        }

        /// <summary>Test stub for GetSex(String)</summary>
        [PexMethod]
        public int GetSexTest01([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.GetSex(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.GetSexTest01(BusinessPlayer, String)
        }

        /// <summary>Test stub for InsertOrdersDetail(String, String, String, String)</summary>
        [PexMethod]
        public int InsertOrdersDetailTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string OrderID,
            string ProductID,
            string Quantity,
            string type
        )
        {
            int result = target.InsertOrdersDetail(OrderID, ProductID, Quantity, type);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.InsertOrdersDetailTest(BusinessPlayer, String, String, String, String)
        }

        /// <summary>Test stub for InsertOrders(String)</summary>
        [PexMethod]
        public int InsertOrdersTest([PexAssumeUnderTest]BusinessPlayer target, string customerID)
        {
            int result = target.InsertOrders(customerID);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.InsertOrdersTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for MD5Hash(String)</summary>
        [PexMethod]
        public string MD5HashTest(string input)
        {
            string result = BusinessPlayer.MD5Hash(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.MD5HashTest(String)
        }

        /// <summary>Test stub for SetPassword(String)</summary>
        [PexMethod]
        public void SetPasswordTest([PexAssumeUnderTest]BusinessPlayer target, string password)
        {
            target.SetPassword(password);
            // TODO: add assertions to method BusinessPlayerTest.SetPasswordTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for SetUserPass(String, String)</summary>
        [PexMethod]
        public void SetUserPassTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string username,
            string password
        )
        {
            target.SetUserPass(username, password);
            // TODO: add assertions to method BusinessPlayerTest.SetUserPassTest(BusinessPlayer, String, String)
        }

        /// <summary>Test stub for SetUsername(String)</summary>
        [PexMethod]
        public void SetUsernameTest([PexAssumeUnderTest]BusinessPlayer target, string username)
        {
            target.SetUsername(username);
            // TODO: add assertions to method BusinessPlayerTest.SetUsernameTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for addAddress(String, String, String, String)</summary>
        [PexMethod]
        public int addAddressTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string country,
            string province,
            string district,
            string location
        )
        {
            int result = target.addAddress(country, province, district, location);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addAddressTest(BusinessPlayer, String, String, String, String)
        }

        /// <summary>Test stub for addCategories(String, String)</summary>
        [PexMethod]
        public int addCategoriesTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string data,
            string parent
        )
        {
            int result = target.addCategories(data, parent);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addCategoriesTest(BusinessPlayer, String, String)
        }

        /// <summary>Test stub for addColor(String)</summary>
        [PexMethod]
        public int addColorTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.addColor(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addColorTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for addDistricts(String, String)</summary>
        [PexMethod]
        public int addDistrictsTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string district,
            string province
        )
        {
            int result = target.addDistricts(district, province);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addDistrictsTest(BusinessPlayer, String, String)
        }

        /// <summary>Test stub for addMadeIn(String)</summary>
        [PexMethod]
        public int addMadeInTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.addMadeIn(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addMadeInTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for addProducts(String, String, String, String, String, String, String, String)</summary>
        [PexMethod]
        public int addProductsTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string name,
            string Price,
            string Quantity,
            string Content,
            string Color,
            string Size,
            string Category,
            string MadeIn
        )
        {
            int result = target.addProducts
                             (name, Price, Quantity, Content, Color, Size, Category, MadeIn);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addProductsTest(BusinessPlayer, String, String, String, String, String, String, String, String)
        }

        /// <summary>Test stub for addProvince(String, String)</summary>
        [PexMethod]
        public int addProvinceTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string provice,
            string country
        )
        {
            int result = target.addProvince(provice, country);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addProvinceTest(BusinessPlayer, String, String)
        }

        /// <summary>Test stub for addSex(String)</summary>
        [PexMethod]
        public int addSexTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.addSex(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addSexTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for addSize(String)</summary>
        [PexMethod]
        public int addSizeTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.addSize(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addSizeTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for addStatus(String)</summary>
        [PexMethod]
        public int addStatusTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.addStatus(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addStatusTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for addWarranty(String)</summary>
        [PexMethod]
        public int addWarrantyTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.addWarranty(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.addWarrantyTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delAddress(String)</summary>
        [PexMethod]
        public int delAddressTest([PexAssumeUnderTest]BusinessPlayer target, string id)
        {
            int result = target.delAddress(id);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delAddressTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delCategories(String)</summary>
        [PexMethod]
        public int delCategoriesTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delCategories(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delCategoriesTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delColor(String)</summary>
        [PexMethod]
        public int delColorTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delColor(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delColorTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delCustomer(String)</summary>
        [PexMethod]
        public int delCustomerTest([PexAssumeUnderTest]BusinessPlayer target, string id)
        {
            int result = target.delCustomer(id);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delCustomerTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delDistricts(String)</summary>
        [PexMethod]
        public int delDistrictsTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delDistricts(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delDistrictsTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delMadeIn(String)</summary>
        [PexMethod]
        public int delMadeInTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delMadeIn(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delMadeInTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delOrdersDetail(String)</summary>
        [PexMethod]
        public int delOrdersDetailTest([PexAssumeUnderTest]BusinessPlayer target, string id)
        {
            int result = target.delOrdersDetail(id);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delOrdersDetailTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delOrders(String)</summary>
        [PexMethod]
        public int delOrdersTest([PexAssumeUnderTest]BusinessPlayer target, string id)
        {
            int result = target.delOrders(id);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delOrdersTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delProduct(String)</summary>
        [PexMethod]
        public int delProductTest([PexAssumeUnderTest]BusinessPlayer target, string id)
        {
            int result = target.delProduct(id);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delProductTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delProvince(String)</summary>
        [PexMethod]
        public int delProvinceTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delProvince(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delProvinceTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delSex(String)</summary>
        [PexMethod]
        public int delSexTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delSex(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delSexTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delSize(String)</summary>
        [PexMethod]
        public int delSizeTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delSize(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delSizeTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delStatus(String)</summary>
        [PexMethod]
        public int delStatusTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delStatus(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delStatusTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for delWarranty(String)</summary>
        [PexMethod]
        public int delWarrantyTest([PexAssumeUnderTest]BusinessPlayer target, string data)
        {
            int result = target.delWarranty(data);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.delWarrantyTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for getCategories(String)</summary>
        [PexMethod]
        public int getCategoriesTest([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.getCategories(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getCategoriesTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for getColor()</summary>
        [PexMethod]
        public List<string> getColorTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            List<string> result = target.getColor();
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getColorTest(BusinessPlayer)
        }

        /// <summary>Test stub for getColor(String)</summary>
        [PexMethod]
        public int getColorTest01([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.getColor(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getColorTest01(BusinessPlayer, String)
        }

        /// <summary>Test stub for getMadeIn(String)</summary>
        [PexMethod]
        public int getMadeInTest([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.getMadeIn(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getMadeInTest(BusinessPlayer, String)
        }

        /// <summary>Test stub for getSize()</summary>
        [PexMethod]
        public List<string> getSizeTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            List<string> result = target.getSize();
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getSizeTest(BusinessPlayer)
        }

        /// <summary>Test stub for getSize(String)</summary>
        [PexMethod]
        public int getSizeTest01([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.getSize(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getSizeTest01(BusinessPlayer, String)
        }

        /// <summary>Test stub for getStatus()</summary>
        [PexMethod]
        public List<string> getStatusTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            List<string> result = target.getStatus();
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getStatusTest(BusinessPlayer)
        }

        /// <summary>Test stub for getStatus(String)</summary>
        [PexMethod]
        public int getStatusTest01([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.getStatus(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getStatusTest01(BusinessPlayer, String)
        }

        /// <summary>Test stub for getWarranty()</summary>
        [PexMethod]
        public List<string> getWarrantyTest([PexAssumeUnderTest]BusinessPlayer target)
        {
            List<string> result = target.getWarranty();
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getWarrantyTest(BusinessPlayer)
        }

        /// <summary>Test stub for getWarranty(String)</summary>
        [PexMethod]
        public int getWarrantyTest01([PexAssumeUnderTest]BusinessPlayer target, string input)
        {
            int result = target.getWarranty(input);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.getWarrantyTest01(BusinessPlayer, String)
        }

        /// <summary>Test stub for querOrdersByMonth(DataTable, DateTime)</summary>
        [PexMethod]
        public void querOrdersByMonthTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            DataTable data,
            DateTime time
        )
        {
            target.querOrdersByMonth(data, time);
            // TODO: add assertions to method BusinessPlayerTest.querOrdersByMonthTest(BusinessPlayer, DataTable, DateTime)
        }

        /// <summary>Test stub for querOrdersByYear(DataTable, DateTime)</summary>
        [PexMethod]
        public void querOrdersByYearTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            DataTable data,
            DateTime time
        )
        {
            target.querOrdersByYear(data, time);
            // TODO: add assertions to method BusinessPlayerTest.querOrdersByYearTest(BusinessPlayer, DataTable, DateTime)
        }

        /// <summary>Test stub for queryAllCustomer(DataTable)</summary>
        [PexMethod]
        public void queryAllCustomerTest([PexAssumeUnderTest]BusinessPlayer target, DataTable data)
        {
            target.queryAllCustomer(data);
            // TODO: add assertions to method BusinessPlayerTest.queryAllCustomerTest(BusinessPlayer, DataTable)
        }

        /// <summary>Test stub for queryAllOrders(DataTable)</summary>
        [PexMethod]
        public void queryAllOrdersTest([PexAssumeUnderTest]BusinessPlayer target, DataTable data)
        {
            target.queryAllOrders(data);
            // TODO: add assertions to method BusinessPlayerTest.queryAllOrdersTest(BusinessPlayer, DataTable)
        }

        /// <summary>Test stub for queryAllProducts(DataTable)</summary>
        [PexMethod]
        public void queryAllProductsTest([PexAssumeUnderTest]BusinessPlayer target, DataTable data)
        {
            target.queryAllProducts(data);
            // TODO: add assertions to method BusinessPlayerTest.queryAllProductsTest(BusinessPlayer, DataTable)
        }

        /// <summary>Test stub for queryCustomerWithAccountByID(DataTable, String)</summary>
        [PexMethod]
        public void queryCustomerWithAccountByIDTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            DataTable data,
            string ID
        )
        {
            target.queryCustomerWithAccountByID(data, ID);
            // TODO: add assertions to method BusinessPlayerTest.queryCustomerWithAccountByIDTest(BusinessPlayer, DataTable, String)
        }

        /// <summary>Test stub for queryCustomerWithAccount(DataTable)</summary>
        [PexMethod]
        public void queryCustomerWithAccountTest([PexAssumeUnderTest]BusinessPlayer target, DataTable data)
        {
            target.queryCustomerWithAccount(data);
            // TODO: add assertions to method BusinessPlayerTest.queryCustomerWithAccountTest(BusinessPlayer, DataTable)
        }

        /// <summary>Test stub for queryOrdersDetail(String, DataTable)</summary>
        [PexMethod]
        public void queryOrdersDetailTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string idOrder,
            DataTable data
        )
        {
            target.queryOrdersDetail(idOrder, data);
            // TODO: add assertions to method BusinessPlayerTest.queryOrdersDetailTest(BusinessPlayer, String, DataTable)
        }

        /// <summary>Test stub for queryProductsByID(String, DataTable)</summary>
        [PexMethod]
        public void queryProductsByIDTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string id,
            DataTable data
        )
        {
            target.queryProductsByID(id, data);
            // TODO: add assertions to method BusinessPlayerTest.queryProductsByIDTest(BusinessPlayer, String, DataTable)
        }

        /// <summary>Test stub for updateOrderDetail(String, String, String, String, String)</summary>
        [PexMethod]
        public int updateOrderDetailTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string Id,
            string IDProduct,
            string IDOrder,
            string TypeWarranty,
            string Quantity
        )
        {
            int result
               = target.updateOrderDetail(Id, IDProduct, IDOrder, TypeWarranty, Quantity);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.updateOrderDetailTest(BusinessPlayer, String, String, String, String, String)
        }

        /// <summary>Test stub for updateOrder(String, String, String)</summary>
        [PexMethod]
        public int updateOrderTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string Id,
            string IDCustomer,
            string Status
        )
        {
            int result = target.updateOrder(Id, IDCustomer, Status);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.updateOrderTest(BusinessPlayer, String, String, String)
        }

        /// <summary>Test stub for updateProducts(String, String, String, String, String, String, String, String, String, String)</summary>
        [PexMethod]
        public int updateProductsTest(
            [PexAssumeUnderTest]BusinessPlayer target,
            string Id,
            string name,
            string Price,
            string Quantity,
            string img,
            string Content,
            string Color,
            string Size,
            string Category,
            string MadeIn
        )
        {
            int result = target.updateProducts
                             (Id, name, Price, Quantity, img, Content, Color, Size, Category, MadeIn);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.updateProductsTest(BusinessPlayer, String, String, String, String, String, String, String, String, String, String)
        }
    }
}
