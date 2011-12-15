namespace app.infrastructure.containers.simple
{
    public class SimpleContainer : IFetchDependencies
    {
        IFindFactoriesThatCanCreateDependencies factories;
        private ItemCreationExceptionFactory itemCreationExceptionFactory;

        public SimpleContainer(IFindFactoriesThatCanCreateDependencies factories, ItemCreationExceptionFactory itemCreationExceptionFactory)
        {
            this.itemCreationExceptionFactory = itemCreationExceptionFactory;
            this.factories = factories;
        }

        public Dependency an<Dependency>()
        {
            return (Dependency)factories.get_factory_that_can_create(typeof(Dependency)).create();
        }
    }
}