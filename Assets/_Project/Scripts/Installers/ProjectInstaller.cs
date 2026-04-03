using Assets._Project.Scripts.Counter;
using Assets._Project.Scripts.Counters;
using Assets._Project.Scripts.UI.Score;
using VContainer;
using VContainer.Unity;

namespace Assets._Project.Scripts.Installers
{
    public class ProjectInstaller : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            ScoreBind(builder);
        }

        private void ScoreBind(IContainerBuilder builder)
        {
            builder.Register<ScoreCounter>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.RegisterComponentInHierarchy<ScoreView>().AsImplementedInterfaces();

            builder.Register<ScorePresenter>(Lifetime.Singleton);
        }
    }
}
