using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogCore.Models
{
    public class Articulo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del artículo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio es obligatoria")]
        public float Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatoria")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]       
        public string Descripcion { get; set; }

        [Display(Name = "Fecha de creación")]
        public string FechaCreacion { get; set; }

        [Display(Name = "Fecha de creación")]
        public string Proveedor { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

    }
}
