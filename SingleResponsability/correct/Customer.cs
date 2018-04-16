using System;

namespace SingleResponsability.correct
{
    class Customer
    {
        private readonly FileLogger logger = new FileLogger();

        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                logger.Handle(ex.ToString());
            }
        }
    }
}
