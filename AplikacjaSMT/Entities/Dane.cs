namespace AplikacjaSMT.Entities
{
    [Table("Dane")]
    public class Dane
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(1024)]
        public string Name { get; set; }

        public byte[] ImageBytes { get; set; }

    }
}