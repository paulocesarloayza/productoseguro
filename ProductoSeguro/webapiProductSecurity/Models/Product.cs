namespace webapiProductSecurity.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Nombre del Producto")]
        public string Name { get; set; }
        [Range(0, 1000000, ErrorMessage = "El valor debe ser mayor a cero")]
        public double Value { get; set; }
    }
}