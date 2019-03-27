namespace DotNetCoreWebApi.Model {
    public class Measurement {

        [Key] // Klucz główny
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,2)")] // zaokrąglenie
        public decimal Value { get; set; }

        [Required]
        public string CreateBy { get; set; }

        [Required] // Wymagany
        public DateTime CreatedAt { get; set; }
    }
}