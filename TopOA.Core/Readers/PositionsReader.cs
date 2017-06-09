namespace TopOA.Core.Readers
{
    public class PositionsReader : IQueryHandler<PositionsQuery, PositionsList>, IValidator<PositionsQuery>
    {
        public PositionsList Query(PositionsQuery query)
        {
            return new PositionsList();
        }

        public ErrorCode Validate(PositionsQuery commandOrQuery)
        {
            return ErrorCode.NoError;
        }
    }
}