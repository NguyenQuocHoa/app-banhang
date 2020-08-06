using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }
        }

        private UserDAO() { }
        public List<User> Xem()
        {
            List<User> users = new List<User>();

            string query = "select * from Users";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string userName = item["UserName"].ToString(); // name
                string pass = item["PassWord"].ToString(); // id
                //DateTime dob = (DateTime)item.Cells["NgaySinh"].Value;
                //bool sex = (bool)item.Cells["sex"].Value;

                User user = new User(userName, pass);

                users.Add(user);
            }
            return users;
        }
    }
}
