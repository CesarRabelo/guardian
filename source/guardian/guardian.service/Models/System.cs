using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace guardian.service.Models
{
    //[Table("System", Schema = "guardian")]
    //public class System
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Details { get; set; }
    //    public string Url { get; set; }
    //    public string UrlIcon { get; set; }
    //    public bool Activated { get; set; }

    //    public List<Module> Modules { get; set; }
    //}

    [Table("tb_sistema_sist", Schema = "atom")]
    public class System
    {
        [Key]
        [Column("id_sistema")]
        public int Id { get; set; }

        [Column("dsc_sistema")]
        public string Name { get; set; }

        [Column("dsc_sistema_descricao")]
        public string Details { get; set; }

        [Column("dsc_sigla")]
        public string Initials { get; set; }

        [Column("dsc_url_principal")]
        public string Url { get; set; }

        [Column("dsc_logo")]
        public string UrlIcon { get; set; }

        //[Column("flg_ativo")]
        //public bool Activated { get; set; }

        public List<Module> Modules { get; set; }
    }
}
