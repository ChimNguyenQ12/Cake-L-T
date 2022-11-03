using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanhBUS
    {
        public List<Banh> GetCakes()
        {
            List<Banh> listCake = new List<Banh>();
            BanhDAL banhDAL = new BanhDAL();
            listCake = banhDAL.GetCakes().ToList();
            return listCake;
        }

        public List<Banh> GetCakeById(int code)
        {
            try
            {
                List<Banh> accountById = new List<Banh>();
                BanhDAL banhDAL = new BanhDAL();
                accountById = banhDAL.GetCakeById(code);
                return accountById;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void UpdateCakeById(int code, int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
        {
            try
            {
                BanhDAL banhDAL = new BanhDAL();
                banhDAL.UpdateCakeById(code, category, name, quanity, price, dateManu, dateExpire,image);
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }

        public void DeleteCakeById(int code)
        {
            try
            {
                BanhDAL banhDAL = new BanhDAL();
                banhDAL.DeleteCakeById(code);
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }

        public string AddCake(int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
        {
            try
            {
                int code = int.Parse(DateTime.Now.ToString("MMddHHmmss"));
                BanhDAL banhDAL = new BanhDAL();
                var tbCake = banhDAL.GetCakes();
                foreach (var cake in tbCake)
                {
                    if (cake.MaBanh == code)
                    {
                        return "Cake already exists";
                    }
                }

                if (banhDAL.AddCake(code, category, name, quanity, price, dateManu, dateExpire,image) == "success")
                {
                    return "success";
                }
            }
            catch (Exception)
            {
                return "error";
            }
            return "success";
        }
    }
}
