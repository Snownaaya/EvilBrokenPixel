using Assets._Project.Scripts.Services.SceneLoaderServices;
using VContainer;

namespace Assets._Project.Scripts.UI.Buttons
{
    public class StartGameButton : ButtonHelper
    {
        private SceneTransition _sceneTransition;

        [Inject]
        private void Construct(SceneTransition sceneTransition) =>
            _sceneTransition = sceneTransition;

        protected override void OnClicked()
        {
            base.OnClicked();
            _sceneTransition.SceneLoader(SceneID.GameScene);
        }
    }
}