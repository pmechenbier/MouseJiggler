// Original MS-PL copyright: Copyright Alistair J. R. Young, Arkane Systems, 2012-2013.
// Modified & copyrighted: Copyright Patrick Mechenbier 2015.

using System;
using System.Threading;
using System.Windows.Forms;

namespace MouseJiggle
{
    internal static class Program
    {
        public static bool StartJiggling = false;
        public static bool ZenJiggling = false;
        public static bool StartMinimized = false;

        /// <summary>The main entry point for the application.</summary>
        [STAThread]
        private static void Main(string[] args)
        {
            using (Mutex instance = new Mutex(false, "single instance: MouseJiggle"))
            {
                if (instance.WaitOne(0, false))
                {
                    // Check for command-line switches.
                    foreach (string arg in args)
                    {
                        if ((System.String.Compare(arg.ToUpperInvariant(), "--JIGGLE", System.StringComparison.Ordinal) == 0) ||
                            (System.String.Compare(arg.ToUpperInvariant(), "-J", System.StringComparison.Ordinal) == 0))
                        {
                            StartJiggling = true;
                        }

                        if ((System.String.Compare(arg.ToUpperInvariant(), "--ZEN", System.StringComparison.Ordinal) == 0) ||
                            (System.String.Compare(arg.ToUpperInvariant(), "-Z", System.StringComparison.Ordinal) == 0))
                        {
                            ZenJiggling = true;
                        }

                        if ((System.String.Compare(arg.ToUpperInvariant(), "--MINIMIZED", System.StringComparison.Ordinal) == 0) ||
                            (System.String.Compare(arg.ToUpperInvariant(), "-M", System.StringComparison.Ordinal) == 0))
                        {
                            StartMinimized = true;
                        }
                    }

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
            }
        }
    }
}