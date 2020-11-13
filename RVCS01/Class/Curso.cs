using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVCS01.Class
{
    class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }
        public double Valor{ get; set; }

        public Curso(int id = 0, string nome = null, string descricao = null, int cargaHoraria = 0, double valor = 0)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            CargaHoraria = cargaHoraria;
            Valor = valor;
        }

        public List<Curso> Listar()
        {
        
            List<Curso> list = new List<Curso>();
            var comando = Banco.Abrir();
            comando.CommandText = "Select * from curso";
            var dr = comando.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Curso(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetDouble(3)
                    )); 
            }
            return list;
        }
    }
}
