using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xilauncher
{
    public partial class Launcher
    {
        public bool IsGameActive => _procLoader is not null;

        public bool LaunchGame(XiLoaderConfig config)
        {
            if (_procLoader is not null)
                return false;

            _procLoader = Launch(_resources.fileLoaderExe, config.ToArguments(), _resources.dirLoader, true, true, "runas");
            if (_procLoader is not null)
            {
                XiLog.WriteLine("Started loader instance.");
                _procLoader.Exited += LoaderProcess_Exited;
            }
            else XiLog.WriteLine("Loader failed to start!");
            return _procLoader is not null;
        }

        public void StopGame()
        {
            if (_procLoader is not null)
            {
                XiLog.WriteLine($"Stopped loader instance (PID:{_procLoader.Id}).");
                _procLoader.Kill(true);
            }
            // Remark: Danger Zone: The loader is not meant to be killed as it holds into the running client
            //          though should work
            //foreach (Process? process in _processesLoader)
            //{
            //    if (process is not null)
            //    {
            //        XiLog.WriteLine($"Stopping game instance (PID:{process.Id}).");
            //        process.Kill(true);
            //    }
            //}
        }

        private void LoaderProcess_Exited(object? sender, EventArgs e)
        {
            // ToDo: add listener to process termination to track external changes to the processes
            //          (e.g. loader is shut down when exiting game, others may error critically)
            // ToDo: Add event to Launcher that passes out process exit/kill events to the UI
            //       Event might signal which process and if started or exited
            if (sender == _procLoader)
            {
                _procLoader = null;
            }
        }

    }
}
