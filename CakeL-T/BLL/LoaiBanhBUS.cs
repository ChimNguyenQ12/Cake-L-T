using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiBanhBUS
    {
        public List<LoaiBanh> GetCateCakes()
        {
            List<LoaiBanh> listCake = new List<LoaiBanh>();
            LoaiBanhDAL LoaiBanhDAL = new LoaiBanhDAL();
            listCake = LoaiBanhDAL.GetCateCakes().ToList();
            return listCake;
        }

        public List<LoaiBanh> GetCateCakeById(int code)
        {
            try
            {
                List<LoaiBanh> cateCakeById = new List<LoaiBanh>();
                LoaiBanhDAL LoaiBanhDAL = new LoaiBanhDAL();
                cateCakeById = LoaiBanhDAL.GetCakeById(code);
                return cateCakeById;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void UpdateCateCakeById(int code, string name)
        {
            try
            {
                LoaiBanhDAL LoaiBanhDAL = new LoaiBanhDAL();
                LoaiBanhDAL.UpdateCateCakeById(code, name);
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }

        public void DeleteCateCakeById(int code)
        {
            try
            {
                LoaiBanhDAL LoaiBanhDAL = new LoaiBanhDAL();
                LoaiBanhDAL.DeleteCateCakeById(code);
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }

        public string AddCateCake(string name, int code)
        {
            try
            {
                
                LoaiBanhDAL LoaiBanhDAL = new LoaiBanhDAL();
                var tbCateCake = LoaiBanhDAL.GetCateCakes();
                foreach (var cake in tbCateCake)
                {
                    if (cake.MaLoai == code)
                    {
                        return "Cake Category already exists";
                    }
                }

                if (LoaiBanhDAL.AddCateCake(code, name) == "success")
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

        public List<LoaiBanh> SearchCateCake(int key)
        {
            try
            {   
                string k = key.ToString();
                List<LoaiBanh> cakeCateSearch = new List<LoaiBanh>();
                LoaiBanhDAL LoaiBanhDAL = new LoaiBanhDAL();
                if (k == "0")
                {
                    cakeCateSearch = LoaiBanhDAL.SearchCateCake("0");

                }
                cakeCateSearch = LoaiBanhDAL.SearchCateCake(k);
                return cakeCateSearch;
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }
    }
}
