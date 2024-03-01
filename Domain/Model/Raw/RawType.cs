namespace Domain.Model.Raw
{
    /// <summary>
    /// 法令種別
    /// </summary>
    public enum RawType
    {
        r1_全法令 = 1,
        r2_憲法法令 = 2,
        r3_政令勅令 = 3,
        r4_府省庁規則 = 4,
    }

    /// <summary>
    /// 法令種別値オブジェクト
    /// </summary>
    public class RawTypeValue
    {
        private readonly RawType _rawType;

        public RawTypeValue(RawType rawType)
        {
            _rawType = rawType;
        }

        public int ToCodeValue()
        {
            return (int)_rawType;
        }
    }
}
