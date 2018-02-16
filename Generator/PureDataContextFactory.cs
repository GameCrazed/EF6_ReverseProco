

namespace Generator
{

    public class PureDataContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<PureDataContext>
    {
        public PureDataContext Create()
        {
            return new PureDataContext();
        }
    }
}
