using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Castle
{
    public class Conexao

    {
        SqlConnection Con = new SqlConnection();

     public Conexao()
        {
            Con.ConnectionString = "C:\\Users\\HP\\Desktop\\PROJETOS\\Castle\\BANCO";
        }

      public SqlConnection Conectar()
        {
            if(Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }

            return Con;
        } 
    
       public void Desconectar()
        {


        if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }





        }



    }

        
        


        

        }





    

