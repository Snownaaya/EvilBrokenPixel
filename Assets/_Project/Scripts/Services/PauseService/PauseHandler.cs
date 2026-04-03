using System.Collections.Generic;

namespace Assets._Project.Scripts.Services.PauseService
{
    public class PauseHandler
    {
        private List<IPause> _pauses = new List<IPause>();

        public void Register(IPause pause) =>
            _pauses.Add(pause);

        public void UnRegister(IPause pause) =>
            _pauses.Remove(pause);

        public void AddPause()
        {
            foreach (IPause pause in _pauses)
                pause.Pause();
        }

        public void RemovePause()
        {
            foreach(IPause pause in _pauses) 
                pause.Resume();
        }
    }
}