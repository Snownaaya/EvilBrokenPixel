using Assets._Project.Scripts.Services.PauseService;
using Assets._Project.Scripts.Services.SceneLoaderServices;
using VContainer;
using VContainer.Unity;

namespace Assets._Project.Scripts.Installers
{
    public class ServicesInstaller : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder) 
        {
            base.Configure(builder);

            SceneTranditionBind(builder);
            PauseBind(builder);
        }

        private void SceneTranditionBind(IContainerBuilder builder) => 
            builder.Register<SceneTransition>(Lifetime.Singleton);

        private void PauseBind(IContainerBuilder builder) =>
            builder.RegisterInstance(new PauseHandler());
    }
}