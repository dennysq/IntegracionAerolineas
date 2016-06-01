namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONSULTAS")]
    public partial class CONSULTA
    {
        [Key]
        public int CODIGO_C { get; set; }

        public int? CODIGO_E { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP_C { get; set; }

        [Required]
        [StringLength(20)]
        public string ORIGEN_C { get; set; }

        [Required]
        [StringLength(20)]
        public string DESTINO_C { get; set; }

        [StringLength(1024)]
        public string CONSULTA_C { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
