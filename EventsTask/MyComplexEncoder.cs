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
            OnPreparing(source);

            OnStarted(source);

            OnFinished(source);
        }

        protected void OnPreparing(object source)
        {
            Preparing?.Invoke(source, EventArgs.Empty);
        }

        protected void OnStarted(object source)
        {
            Starting?.Invoke(this, EventArgs.Empty);
        }

        protected void OnFinished(object source)
        {
            Finished?.Invoke(this, EventArgs.Empty);
        }
    }
}
