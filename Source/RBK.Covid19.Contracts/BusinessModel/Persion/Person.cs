namespace RBK.Covid19.Contracts.BusinessModel.Persion
{
    public class Person
    {
        public Name Name { get; set; }
        public int Age { get; set; }
    }

    public class Name
    {
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Suffix { get; set; }
        public Title Title { get; set; }
    }

    public enum Title
    {
        Mr,
        Ms,
        Mrs,
    }
}
