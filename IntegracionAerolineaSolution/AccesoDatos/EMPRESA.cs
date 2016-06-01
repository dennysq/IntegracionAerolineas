namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPRESA")]
    public partial class EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESA()
        {
            CONSULTAS = new HashSet<CONSULTA>();
            RESERVAS = new HashSet<RESERVA>();
        }

        [Key]
        public int CODIGO_E { get; set; }

        [Required]
        [StringLength(128)]
        public string NOMBRE_E { get; set; }

        [StringLength(256)]
        public string SITO_WEB_E { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] CREATED_E { get; set; }

        [Required]
        [StringLength(64)]
        public string EMAIL_E { get; set; }

        [StringLength(64)]
        public string CIUDAD_E { get; set; }

        [StringLength(512)]
        public string DESCRIPCION_E { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTA> CONSULTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVAS { get; set; }
    }
}
