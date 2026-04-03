using System.Collections.Generic;

namespace Assets._Project.Scripts.Services.PauseService
{
    public class PauseHandler
    {
        private List<IPause> _pauses = new List<IPause>();

        public void AddPause()
        {
            foreach (IPause pause in _pauses)
                pause.Add();
        }

        public void RemovePause()
        {
            foreach(IPause pause in _pauses) 
                pause.Remove();
        }
    }
}