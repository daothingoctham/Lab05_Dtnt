using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04_2.Models
{
    public class CustomerRepository : DTNTICustomerRepository
    {
        //khởi tạo danh sách khách hàng
        private static readonly List<DtntCustomer> data = new List<DtntCustomer>()
{
        new DtntCustomer()
        {
        CustomerId = "KH001",
        FullName = "Đào Ngọc Thắm",Address = "Hà Nội",
        Email = "devmaster.founder@gmail.com",
        Phone = "0978.611.889",Balance = 15200000},
new DtntCustomer()
{ CustomerId = "KH002",
FullName = "Đỗ Thị Cúc",Address = "Hà Nội",
Email = "cucdt@gmail.com",Phone = "0986.767.444",
Balance = 2200000},
new DtntCustomer()
{ CustomerId = "KH003",
FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",
Email = "thangnt@gmail.com",Phone = "0924.656.542",
Balance = 1200000},
new DtntCustomer()
{ CustomerId = "KH004",
FullName = "Lê Ngọc Hải",Address = "Hà Nội",
Email = "hailn@gmail.com",Phone = "0996.555.267",
Balance = 6200000}
};

        //thực thi phương thức lấy danh sách khách hàng
        public IList<DtntCustomer> GetDtntCustomer()
        {
            return data;
        }
        //thực thi phương thức tìm khách hàng theo tên
        public IList<DtntCustomer> SearchDtntCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }
        //thực thi phương thức lấy khách hàng theo Id
        public DtntCustomer GetDtntCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }
        //thực thi phương thức thêm khách hàng
        public void AddDtntCustomer(DtntCustomer cus)
        {
            data.Add(cus);
        }
        //thực thi phương thức cập nhật khách hàng
        public void UpdateDtntCustomer(DtntCustomer cus)
        {
            //lấy khách hàng theo id
            var customer = data.FirstOrDefault(c =>
            c.CustomerId.Equals(cus.CustomerId));
            //nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }

        //thực thi phương thức xóa khách hàng
        public void DeleteDtntCustomer(DtntCustomer cus)
        {
            data.Remove(cus);
        }
    }
}