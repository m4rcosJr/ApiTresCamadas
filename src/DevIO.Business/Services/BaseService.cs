namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        protected bool ExecutarValidação<TV, TE>( TV validacao, TE entidade)
        {
            return false;
        }
    }
}
