using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web11
{
    public class Nhanvien
    {
        private string hoten;
        private int namsinh; 
       
        public Nhanvien(string hoten, int namsinh)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
        }

        public Nhanvien()
        {
            
        }

        public string getHoten()
        {
            return hoten;
        }
        public void setHoten(string name)
        {
            this.hoten = name;
        }

        public int getNamsinh()
        {
            return namsinh;
        }
        public void setNamsinh(int namsinh)
        {
            this.namsinh = namsinh;
        }
    }
}