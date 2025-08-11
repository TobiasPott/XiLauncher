//using Silk.NET.XInput;
//using System.Diagnostics;

//namespace xilauncher
//{
//    internal class Input
//    {
//        private static XInput? _input;

//        public Input()
//        {
//            if (_input == null)
//            {
//                _input = XInput.GetApi();

//                for (uint i = 0; i < XInput.XuserMaxCount; i++)
//                {
//                    State state = new State();
//                    uint result = _input.GetState(i, ref state);

//                    if (result == 0) // success
//                    {
//                        Debug.WriteLine($"Connected controller: {i}");
//                    }
//                    else
//                    {
//                        Debug.WriteLine($"No controller controller found: {i}");
//                    }
//                }
//            }
//            else
//            {
//                Debug.WriteLine($"XInput is already initialized. Updating controllers.");
//            }
//        }
//    }
//}
