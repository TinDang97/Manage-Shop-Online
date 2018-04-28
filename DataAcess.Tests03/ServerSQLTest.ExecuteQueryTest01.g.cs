using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using DataAcess;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ServerSQLTest.ExecuteQueryTest01.g.cs">Copyright ©  2017</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace DataAcess.Tests
{
    public partial class ServerSQLTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest01565()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL((string)null);
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, (string)null);
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest01489()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL((string)null);
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, "");
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest0156501()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL("");
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, (string)null);
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest0156502()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL("\0");
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, (string)null);
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest0156503()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL("");
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, (string)null);
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest01130()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL("薢");
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, "薢");
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest01567()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL("\0");
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, "\0");
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest0156504()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL("ꓱ=");
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, (string)null);
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ServerSQLTest))]
public void ExecuteQueryTest0156505()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ServerSQL serverSQL;
      SqlDataReader sqlDataReader;
      serverSQL = new ServerSQL("䆢=誥");
      sqlDataReader = this.ExecuteQueryTest01(serverSQL, (string)null);
      disposables.Add((IDisposable)sqlDataReader);
      disposables.Dispose();
      Assert.IsNull((object)sqlDataReader);
      Assert.IsNotNull((object)serverSQL);
    }
}
    }
}
