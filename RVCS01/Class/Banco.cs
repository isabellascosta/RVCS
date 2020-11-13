using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RVCS01.Class
{
    public static class Banco
    {//atributo
        //metodo
        public static MySqlCommand Abrir() 
        {
            MySqlCommand cmd = new MySqlCommand();
            string strcon = @"Server = 10.91.43.20;user id=root; Database=myescolarapp; Pwd=@Senac;";
            MySqlConnection cn = new MySqlConnection(strcon);
            cmd.Connection = cn;
            return cmd;
        }

    }
}
