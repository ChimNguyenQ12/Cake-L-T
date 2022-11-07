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

        public void UpdateCakeById(int code, int category, string name, bool status, int price, string image)
        {
            try
            {
                BanhDAL banhDAL = new BanhDAL();
                banhDAL.UpdateCakeById(code, category, name, status, price,image);
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

        public string AddCake(int code, int category, string name, int price, string image)
        {
            try
            {
                BanhDAL banhDAL = new BanhDAL();
                var tbCake = banhDAL.GetCakes();
                foreach (var cake in tbCake)
                {
                    if (cake.MaBanh == code)
                    {
                        return "Cake already exists";
                    }
                }

                if (banhDAL.AddCake(code, category, name, price,image) == "success")
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

        public List<Banh> SearchCake(int key)
        {
            try
            {
                string k = key.ToString();
                List<Banh> cakeSearch = new List<Banh>();
                BanhDAL banhDAL = new BanhDAL();
                if (key == 0)
                {
                    cakeSearch = banhDAL.SearchCake("0");

                }
                cakeSearch = banhDAL.SearchCake(k);
                return cakeSearch;
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }

        public List<Banh> SearchCakeMulti(int price, int codeCategory, bool status)
        {
            try
            {
                List<Banh> cakeSearch = new List<Banh>();
                BanhDAL banhDAL = new BanhDAL();
                cakeSearch = banhDAL.SearchCakeMulti(price,codeCategory, status);
                return cakeSearch;
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }
    }
}
