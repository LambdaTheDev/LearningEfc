namespace LearningEfc.Models
{
    public class Bar
    {
        public int Id { get; set; }
        public int Something { get; set; }
        public int Something2 { get; set; }
        public int Secret { get; set; }
    }

    public record BarDto(int Something, int Something2);
}