using System;

namespace DependencyInjectionDemo
{
    public class App
    {
        public App(IServiceProvider serviceProvider, 
            ITransientService transientService, 
            ITransientService transientService2,
            ISingletonService singletonService,
            ISingletonService singletonService2)
        {
            Console.WriteLine("App");

            transientService.Hello();
            transientService2.Hello();
            singletonService.Hello();
            singletonService2.Hello();

            Console.ReadKey();
        }
    }
}