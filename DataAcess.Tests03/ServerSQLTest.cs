// <copyright file="ServerSQLTest.cs">Copyright ©  2017</copyright>
using System;
using System.Data.SqlClient;
using DataAcess;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAcess.Tests
{
    /// <summary>This class contains parameterized unit tests for ServerSQL</summary>
    [PexClass(typeof(ServerSQL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ServerSQLTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ServerSQL ConstructorTest()
        {
            ServerSQL target = new ServerSQL();
            return target;
            // TODO: add assertions to method ServerSQLTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public ServerSQL ConstructorTest01(string address)
        {
            ServerSQL target = new ServerSQL(address);
            return target;
            // TODO: add assertions to method ServerSQLTest.ConstructorTest01(String)
        }

        /// <summary>Test stub for DeleteRow(String, String)</summary>
        [PexMethod]
        public int DeleteRowTest(
            [PexAssumeUnderTest]ServerSQL target,
            string cmd,
            string address
        )
        {
            int result = target.DeleteRow(cmd, address);
            return result;
            // TODO: add assertions to method ServerSQLTest.DeleteRowTest(ServerSQL, String, String)
        }

        /// <summary>Test stub for DeleteRow(String)</summary>
        [PexMethod]
        public int DeleteRowTest01([PexAssumeUnderTest]ServerSQL target, string cmd)
        {
            int result = target.DeleteRow(cmd);
            return result;
            // TODO: add assertions to method ServerSQLTest.DeleteRowTest01(ServerSQL, String)
        }

        /// <summary>Test stub for ExecuteNonQuery(String, String)</summary>
        [PexMethod]
        public int ExecuteNonQueryTest(
            [PexAssumeUnderTest]ServerSQL target,
            string cmd,
            string address
        )
        {
            int result = target.ExecuteNonQuery(cmd, address);
            return result;
            // TODO: add assertions to method ServerSQLTest.ExecuteNonQueryTest(ServerSQL, String, String)
        }

        /// <summary>Test stub for ExecuteNonQuery(String)</summary>
        [PexMethod]
        public int ExecuteNonQueryTest01([PexAssumeUnderTest]ServerSQL target, string cmd)
        {
            int result = target.ExecuteNonQuery(cmd);
            return result;
            // TODO: add assertions to method ServerSQLTest.ExecuteNonQueryTest01(ServerSQL, String)
        }

        /// <summary>Test stub for ExecuteQueryAdapter(String, String)</summary>
        [PexMethod]
        public SqlDataAdapter ExecuteQueryAdapterTest(
            [PexAssumeUnderTest]ServerSQL target,
            string cmd,
            string address
        )
        {
            SqlDataAdapter result = target.ExecuteQueryAdapter(cmd, address);
            return result;
            // TODO: add assertions to method ServerSQLTest.ExecuteQueryAdapterTest(ServerSQL, String, String)
        }

        /// <summary>Test stub for ExecuteQueryAdapter(String)</summary>
        [PexMethod]
        public SqlDataAdapter ExecuteQueryAdapterTest01([PexAssumeUnderTest]ServerSQL target, string cmd)
        {
            SqlDataAdapter result = target.ExecuteQueryAdapter(cmd);
            return result;
            // TODO: add assertions to method ServerSQLTest.ExecuteQueryAdapterTest01(ServerSQL, String)
        }

        /// <summary>Test stub for ExecuteQuery(String, String)</summary>
        [PexMethod]
        public SqlDataReader ExecuteQueryTest(
            [PexAssumeUnderTest]ServerSQL target,
            string cmd,
            string address
        )
        {
            SqlDataReader result = target.ExecuteQuery(cmd, address);
            return result;
            // TODO: add assertions to method ServerSQLTest.ExecuteQueryTest(ServerSQL, String, String)
        }

        /// <summary>Test stub for ExecuteQuery(String)</summary>
        [PexMethod]
        public SqlDataReader ExecuteQueryTest01([PexAssumeUnderTest]ServerSQL target, string cmd)
        {
            SqlDataReader result = target.ExecuteQuery(cmd);
            return result;
            // TODO: add assertions to method ServerSQLTest.ExecuteQueryTest01(ServerSQL, String)
        }

        /// <summary>Test stub for ExecuteScalar(String, String)</summary>
        [PexMethod]
        public int ExecuteScalarTest(
            [PexAssumeUnderTest]ServerSQL target,
            string cmd,
            string address
        )
        {
            int result = target.ExecuteScalar(cmd, address);
            return result;
            // TODO: add assertions to method ServerSQLTest.ExecuteScalarTest(ServerSQL, String, String)
        }

        /// <summary>Test stub for connect(String)</summary>
        [PexMethod]
        public int connectTest([PexAssumeUnderTest]ServerSQL target, string address)
        {
            int result = target.connect(address);
            return result;
            // TODO: add assertions to method ServerSQLTest.connectTest(ServerSQL, String)
        }

        /// <summary>Test stub for executeScalar(String)</summary>
        [PexMethod]
        public int executeScalarTest([PexAssumeUnderTest]ServerSQL target, string cmd)
        {
            int result = target.executeScalar(cmd);
            return result;
            // TODO: add assertions to method ServerSQLTest.executeScalarTest(ServerSQL, String)
        }
    }
}
