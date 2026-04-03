using Assets._Project.Scripts.Services.SceneLoaderServices;
using UnityEngine;
using VContainer;

namespace Assets._Project.Scripts.UI
{
    public class StartGameButton : ButtonHelper
    {
        private SceneTransition _sceneTransition;

        [Inject]
        private void Construct(SceneTransition sceneTransition) =>
            _sceneTransition = sceneTransition;

        private void OnEnable() =>
            Button.onClick.AddListener(OnClickedStart);

        private void OnDisable() =>
            Button.onClick.RemoveListener(OnClickedStart);

        private void OnClickedStart() => 
            _sceneTransition.SceneLoader(SceneID.GameScene);
    }
}