using System;

namespace DependencyInjectionDemo
{
    public class SingletonService : ISingletonService
    {
        private Guid Id { get; }

        public SingletonService()
        {
            this.Id = Guid.NewGuid();
        }

        public void Hello()
        {
            Console.WriteLine(nameof(SingletonService) + " " + this.Id);
        }
    }
}