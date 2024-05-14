using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04_2.Models
{
    public class DTNTICustomerRepository
    {
        public interface ICustomerRepository
        {
            //khai báo phương thức lấy danh sách khách hàng
            IList<DtntCustomer> GetCustomers();
            //khai báo phương thức lấy khách hàng
            DtntCustomer GetCustomer(string customerId);
            //khai báo phương thức thêm khách hàng
            void AddCustomer(DtntCustomer cus);
            //khai báo phương thức cập nhật khách hàng
            void UpdateCustomer(DtntCustomer cus);
            //khai báo phương thức tìm kiếm khách hàng
            IList<DtntCustomer> SearchCustomer(string name);
            //khai báo phương thức xóa khách hàng
            void DeleteCustomer(DtntCustomer cus);
        }
    }
}
