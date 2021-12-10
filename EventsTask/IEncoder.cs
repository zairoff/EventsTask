using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTask
{
    public interface IEncoder
    {
        event EventHandler Preparing;
        event EventHandler Starting;
        event EventHandler Finished;

        void Encode(byte[] source);
    }
}
