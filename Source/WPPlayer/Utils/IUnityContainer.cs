namespace WPPlayer.Utils
{
    public interface IUnityContainer
    {
        void Register<TInterface, TImplemenation>();

        T Resolve<T>() where T : class;
    }
}