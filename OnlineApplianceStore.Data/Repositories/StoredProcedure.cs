using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Data.Repositories
{
    public class StoredProcedure
    {
        public const string CreateCustomerProcedure = "[Customer_Create]";
        public const string DeleteCustomerProcedure = "[Customer_DeleteById]";
        public const string SelectCustomerProcedure = "[Customer_SelectById]";
        public const string SelectAllCustomersProcedure = "[Customer_SelectAll]";
        public const string UpdateCustomerProcedure = "[Customer_UpdateById]";
    }
}
