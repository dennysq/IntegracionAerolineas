namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESERVAS")]
    public partial class RESERVA
    {
        [Key]
        public int CODIGO_R { get; set; }

        public int? CODIGO_E { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP_R { get; set; }

        [Required]
        [StringLength(20)]
        public string ORIGEN_R { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIO_TOTAL_R { get; set; }

        public int? NUM_RESERVA_R { get; set; }

        public DateTime? FECHA_ENTRADA_R { get; set; }

        public DateTime? FECHA_SALIDA_R { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
