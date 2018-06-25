using System;

namespace ConsoleApp2
{
    public class TransientService : ITransientService
    {
        private Guid Id { get; }

        public TransientService()
        {
            this.Id = Guid.NewGuid();
        }

        public void Hello()
        {
            Console.WriteLine(nameof(SingletonService) + " " + this.Id);
        }
    }
}