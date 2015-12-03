namespace Nancy.Demo.ErrorHandling.Modules
{
    using Models;
    using Nancy;

    public class MainModule : NancyModule
    {
        public MainModule()
        {
            this.Get["/"] = _ =>
            {
                return this.Negotiate
                    .WithView("Index")
                    .WithModel(new User("Wayne", "Skylar"));
            };
        }
    }
}