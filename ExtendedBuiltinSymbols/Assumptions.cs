namespace NetWolf
{
    public class Assumptions : WLObj
    {
        public List<string> AssList { get; set; }

        public Assumptions()
        {
            AssList = new List<string>();
        }

        public override string ToString()
        {
            return "Assumptions -> {" + string.Join(',', AssList) + "}";
        }
    }
}