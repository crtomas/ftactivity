
namespace  FTActivity.Entities
{
    public class ActivityRepository: RepositoryBase<Activity>, IActivityRepository
    {
        public ActivityRepository(FTActivityDbContext repositoryContext):base(repositoryContext)
        {
        }
    }
}