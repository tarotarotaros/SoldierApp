namespace Domain.Model.Raw
{
    /// <summary>
    /// 法令種別
    /// </summary>
    public enum RawType
    {
        r1_All = 1,
        r2_KenpouHourei = 2,
        r3_SeireiCyokurei = 3,
        r4_fusyochoKisoku = 4,
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
