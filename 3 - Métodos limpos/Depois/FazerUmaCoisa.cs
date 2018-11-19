class FooService
{
    public void RegisterFoo(Foo foo)
    {
        HandleFjords(foo);
        UpdateFnagledState(foo);
    }

    private void HandleFjords(Foo foo)
    {
        if (foo.HasFjord())
        {
            repository.Save(foo.Id, _collaborator.Calculate(foo));
        }
    }

    private void UpdateFnagledState(Foo foo)
    {
        if (ImportantBusinessLogic())
        {
            foo.Status = FooStatus.Fnagled;
            _collaborator.CollectFnagledState(foo);
        }
    }
}