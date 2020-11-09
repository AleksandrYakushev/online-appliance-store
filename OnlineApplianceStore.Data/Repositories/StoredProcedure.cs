using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Data.Repositories
{
    public class StoredProcedure
    {
        public const string MergeCustomerProcedure = "[Customer_Merge]";
        public const string CreateCustomerProcedure = "[Customer_Create]";
        public const string UpdateCustomerProcedure = "[Customer_UpdateById]";
        public const string SelectCustomerProcedure = "[Customer_SelectById]";
        public const string SelectAllCustomersProcedure = "[Customer_SelectAll]";
        public const string DeleteCustomerProcedure = "[Customer_DeleteById]";

        public const string CreateProductProcedure = "[Product_Create]";
        public const string MergeProductProcedure = "[Product_Merge]";
        public const string UpdateProductProcedure = "[Product_UpdateById]";
        public const string SelectProductProcedure = "[Product_SelectById]";
        public const string SelectAllProductsProcedure = "[Product_SelectAll]";
        public const string DeleteProductProcedure = "[Product_DeleteById]";

        public const string MergeOrderProcedure = "[Order_Merge]";
        public const string SelectOrderProcedure = "[Order_SelectById]";
        public const string SelectAllOrdersProcedure = "[Order_SelectAll]";
        public const string DeleteOrderProcedure = "[Order_DeleteById]";
    }
}
