using AddressBookProgram;
namespace AddressBookMsTesting
{
    [TestClass]
    public class UnitTest1
    {
        AddressBook_ADO_NET addressBook_ADO_NET = new AddressBook_ADO_NET();
        /// <summary>
        /// Refactor Uc16
        /// </summary>
        [TestMethod]
        public void CheckDatabaseConnection_ToGetAllAddressContact_ShouldReturnAddressBookDatae()
        {     
            string retriveQuery = @"SELECT * FROM AddressBookList ";
            int actual=addressBook_ADO_NET.GetAllAddressBookData(retriveQuery);
            Assert.AreEqual(1, actual);
        }
    }
}