using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    public class CADASTRAR_CLIENTE

    {

        Conexao conexao = new Conexao();
        SqlCommand sqc = new SqlCommand();
        public string mensagem = "";


        public CADASTRAR_CLIENTE (string nome, string endereço, string cpf, string cidade, string estado)

        {

            sqc.CommandText = "insert into BancoCastle(nome,endreço,cpf,cidade,estado) values(@nome,@endereço,@cpf,@cidade,@estado)";
            sqc.Parameters.AddWithValue("@nome", nome);
            sqc.Parameters.AddWithValue("endereço", endereço);
            sqc.Parameters.AddWithValue("@cpf", cpf);
            sqc.Parameters.AddWithValue("@cidade", cidade);
            sqc.Parameters.AddWithValue("@estado", estado);



            try
            {

                sqc.Connection = conexao.Conectar();
                sqc.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "CADASTRADO COM SUCESSO";

            }

            catch (SqlException e)

            {

                this.mensagem = "ERRO AO SE CONECTAR AO BANCO DE DADOS";
            }


        }


    }
}
