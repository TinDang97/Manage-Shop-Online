// <copyright file="editProductTest.cs">Copyright ©  2017</copyright>

using System;
using DXApplication1;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DXApplication1.Tests
{
    [TestClass]
    [PexClass(typeof(editProduct))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class editProductTest
    {

        [PexMethod]
        public editProduct Constructor()
        {
            editProduct target = new editProduct();
            return target;
            // TODO: add assertions to method editProductTest.Constructor()
        }
    }
}
