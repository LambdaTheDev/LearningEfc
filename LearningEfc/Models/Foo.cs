using System.Collections.Generic;

namespace LearningEfc.Models
{
    public class Foo
    {
        public int Id { get; set; }
        public int Something { get; set; }
        public int Secret { get; set; }
        public ICollection<Bar> Bars { get; set; }
    }

    public record FooDto(int Something, List<BarDto> Bars);
}