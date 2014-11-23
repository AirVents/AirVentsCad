using System;
using System.Threading;

namespace DelegateWpfBackgroundProgressBar
{
    class DelegateSample
    {
        public delegate string MyDelegate(int param);

        public event Action<int, string> SomethingDoing;//Событие

        public Action<int, string> SomethingDoinigProp { get; set; } //Propertie

        public void Run()
        {
            SomethingDoinigProp(0, "");
            SomethingDoing(0, "");

            //SomethingDoing(1, "Step 1");
            //Thread.Sleep(2000);

            //SomethingDoing(2, "Step 2");
            //Thread.Sleep(2000);            
        }                

        /*
        public void Run(string str)
        {
            var str2 = str + "2";
        }
         * */

        public void Run(Action<int, string> progressCallback)
        {
            progressCallback(10, "Step 1");
            Thread.Sleep(1000);

            progressCallback(25, "Step 2");
            Thread.Sleep(1000);

            progressCallback(45, "Step 3");
            Thread.Sleep(1000);

            progressCallback(65, "Step 4");
            Thread.Sleep(1000);

            progressCallback(95, "Step 5");
            Thread.Sleep(1000);
        }

/*
        #region sample
        string Mymethod(int param)
        {
            return param.ToString();
        }

        void DoSomething(Func<string> callback)
        {
        }

        void DoSomething(MyDelegate callback)
        {
            //string str = callback(5);
            string str = Mymethod(5);
        }
        #endregion
*/
    }
}
