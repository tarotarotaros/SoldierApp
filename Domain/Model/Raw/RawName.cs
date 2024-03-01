namespace Domain.Model.Raw
{
    /// <summary>
    /// 法令
    /// </summary>
    public class RawName
    {
        private readonly string _id;
        private readonly string _name;
        private readonly string _number;
        private readonly DateTime _promuigationDate;

        public string ID { get { return _id; } }
        public string Name { get { return _name; } }
        public string Number { get { return _number; } }
        public DateTime PromuigationDate { get { return _promuigationDate; } }

        public RawName(string id, string name, string number, string promuigationDate)
        {
            _id = id;
            _name = name;
            _number = number;
            _promuigationDate = DateTime.ParseExact(promuigationDate, "yyyyMMdd", null);

        }
    }
}
