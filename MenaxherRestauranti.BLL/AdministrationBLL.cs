using MenaxherRestauranti.BO;
using MenaxherRestauranti.DAL;
using System;
using System.Collections.Generic;

namespace MenaxherRestauranti.BLL
{
    public class AdministrationBLL
    {
        private readonly RoleDAL roleDal;
        private readonly UserDAL UserDal;
        readonly ProductDAL productDAL;
        private readonly OrderDAL orderDAL;
        private readonly OrderDetailsDAL orderDetailsDAL;
        private readonly CategoriesDAL categoriesDAL;

        public AdministrationBLL()
        {
            roleDal = new RoleDAL();
            UserDal = new UserDAL();
            productDAL = new ProductDAL();
            orderDAL = new OrderDAL();
            orderDetailsDAL = new OrderDetailsDAL();
            categoriesDAL = new CategoriesDAL();
        }

        public User Login(string username, string password)
        {
            return UserDal.Login(username, password);
        }

        public List<Role> GetAllRoles()
        {
            return roleDal.GetAll();
        }

        public bool Add(Role model)
        {
            try
            {
                return roleDal.Add(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Add(User model)
        {
            try
            {
                return UserDal.Add(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<User> GetAllUsers()
        {
            return UserDal.GetAll();
        }

        public int DeleteUser(int id)
        {
            return UserDal.Delete(id);
        }

        public List<Product> GetAllProducts(int id)
        {
            return productDAL.GetAll_User(id);
        }

        public List<Product> GetAllProducts()
        {
            return productDAL.GetAll();
        }
        public bool Add(Product model)
        {
            try
            {
                return productDAL.Add(model);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public bool Add(Order model)
        {
            try
            {
                return orderDAL.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int GetOrderDetails(int ID)
        {
            return orderDetailsDAL.GetOrderDetails(ID);
        }
        public bool GetProduct(Product model)
        {
            try
            {
                return productDAL.GetProduct(model);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<OrderDetail> GetAllOrderDetails()
        {
            return orderDetailsDAL.GetAll();
        }
        public bool Add(OrderDetail model)
        {
            try
            {
                return orderDetailsDAL.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Category> GetAllCategories()
        {
            return categoriesDAL.GetAll();
        }
        public bool Add(Category model)
        {
            try
            {
                return categoriesDAL.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Order> getAllOrders()
        {
            return orderDAL.GetAll();
        }
        public int DeleteRole(int id)
        {
            return roleDal.Delete(id);
        }
    }
}
