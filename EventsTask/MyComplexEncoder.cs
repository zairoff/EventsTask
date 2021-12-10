using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTask
{
    public class MyComplexEncoder
    {
        public event EventHandler Preparing;
        public event EventHandler Starting;
        public event EventHandler Finished;

        public void Encode(byte[] source)
        {
            OnPreparing();

            OnStarted();

            OnFinished();
        }

        protected void OnPreparing()
        {
            Preparing?.Invoke(this, EventArgs.Empty);
        }

        protected void OnStarted()
        {
            Starting?.Invoke(this, EventArgs.Empty);
        }

        protected void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
        }
    }
}
