using System.Collections.Generic;

namespace LearningEfc.Models
{
    public class Foo
    {
        public int Id { get; set; }
        public int Something { get; set; }
        public int Secret { get; set; }
        public ICollection<Bar> Bars { get; set; }
        public Bar TestBar { get; set; }
        public int TestBarId { get; set; }
    }

    public class FooTestDto
    {
        public int Something { get; set; }
        public BarDto TestBar { get; set; }
    }

    public class FooDto
    {
        public int Something { get; set; }
        public List<BarDto> Bars { get; set; }
    }
}