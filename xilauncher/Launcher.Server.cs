namespace xilauncher
{
    internal partial class Launcher
    {
        public bool LaunchServer()
        {
            if (_procConnect is null)
            {
                Console.WriteLine("Starting server's xi_connect...");
                _procConnect = Launch(_resources.fileConnectExe, "", _resources.dirServer);
                if (_procConnect is not null)
                {
                    Console.WriteLine("...xi_connect is running.");
                    Thread.Sleep(250);
                }
                else Console.WriteLine("...failed to start!");
            }
            if (_procSearch is null)
            {
                Console.WriteLine("Starting server's xi_search...");
                _procSearch = Launch(_resources.fileSearchExe, "", _resources.dirServer);
                if (_procSearch is not null)
                {
                    Console.WriteLine("...xi_search is running.");
                    Thread.Sleep(250);
                }
                else Console.WriteLine("...failed to start!");
            }
            if (_procWorld is null)
            {
                Console.WriteLine("Starting server's xi_world...");
                _procWorld = Launch(_resources.fileWorldExe, "", _resources.dirServer);
                if (_procWorld is not null)
                {
                    Console.WriteLine("...xi_world is running.");
                    Thread.Sleep(1250);
                }
                else Console.WriteLine("...failed to start!");
            }
            if (_procMap is null)
            {
                Console.WriteLine("Starting server's xi_map...");
                _procMap = Launch(_resources.fileMapExe, "", _resources.dirServer);
                if (_procMap is not null)
                {
                    Console.WriteLine("...xi_map is running.");
                    //Thread.Sleep(250);
                }
                else Console.WriteLine("...failed to start!");
            }
            return _procConnect is not null
                && _procSearch is not null
                && _procWorld is not null
                && _procMap is not null;
        }

        private void StopServer()
        {
            if (_procMap is not null)
            {
                _procMap.Kill(true);
                Console.WriteLine("Stopped xi_map server.");
            }
            if (_procWorld is not null)
            {
                _procWorld.Kill(true);
                Console.WriteLine("Stopped xi_world server.");
            }
            if (_procSearch is not null)
            {
                _procSearch.Kill(true);
                Console.WriteLine("Stopped xi_search server.");
            }
            if (_procConnect is not null)
            {
                _procConnect.Kill(true);
                Console.WriteLine("Stopped xi_connect server.");
            }
        }

    }
}
