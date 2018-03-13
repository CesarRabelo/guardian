using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace guardian.service.Models
{
    //[Table("Module", Schema = "guardian")]
    //public class Module
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Details { get; set; }
    //    public bool Activated { get; set; }

    //    public int SystemId { get; set; }
    //    public System System { get; set; }
    //}

    [Table("tb_modulo_modu", Schema = "atom")]
    public class Module
    {
        [Key]
        [Column("id_modulo")]
        public int Id { get; set; }

        [Column("dsc_modulo")]
        public string Name { get; set; }

        [Column("dsc_classe")]
        public string Class { get; set; }

        [Column("dsc_modulo_descricao")]
        public string Details { get; set; }

        [ForeignKey("SystemId")]
        public System System { get; set; }

        [Column("fk_sistema")]
        public int SystemId { get; set; }

    }
}
