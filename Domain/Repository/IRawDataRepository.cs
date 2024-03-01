using Domain.Model.Raw;

namespace Domain.Repository
{
    internal interface IRawDataRepository
    {
        public RawNameList GetRawNameList(RawType rawType);
    }
}
