using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;

namespace MathIS.Components
{
    public class AbortableBackgroundWorker : BackgroundWorker
    {
        private Thread workerThread;
        public bool Canceled { get; set; }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            Canceled = false;
            workerThread = Thread.CurrentThread;
            try
            {
                base.OnDoWork(e);
            }
            catch (ThreadAbortException)
            {
                e.Cancel = true;
                Thread.ResetAbort();
            }
        }

        public void Abort()
        {
            if (workerThread != null)
            {
                workerThread.Abort();
                workerThread = null;
                Canceled = true;
            }
        }
    }
}
