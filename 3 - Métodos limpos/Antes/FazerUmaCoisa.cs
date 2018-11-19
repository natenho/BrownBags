class FooService
{
    public void UpdateFooStatusAndRepository(Foo foo)
    {
        if (foo.HasFjord())
        {
            repository.Update(foo.Id, collaborator.Calculate(foo));
        }

        if (ImportantBusinessLogic())
        {
            foo.Status = FooStatus.Fnagled;
            _collaborator.CollectFnagledState(foo);
        }
    }
}