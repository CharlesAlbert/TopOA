using System;

namespace TopOA.Core.Readers
{
    public class PositionsReader : IQueryHandler<PositionsQuery, PositionsList>, IValidator<PositionsQuery>
    {
        public PositionsList Query(PositionsQuery query)
        {
            throw new NotImplementedException();
        }

        public ErrorCode Validate(PositionsQuery commandOrQuery)
        {
            throw new NotImplementedException();
        }
    }
}