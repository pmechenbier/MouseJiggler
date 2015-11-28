// Original MS-PL copyright: Copyright Alistair J. R. Young, Arkane Systems, 2012-2013.
// Modified & copyrighted: Copyright Patrick Mechenbier 2015.

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MouseJiggle
{
    public static class Jiggler
    {
        internal const int INPUT_MOUSE = 0;
        internal const int MOUSEEVENTF_MOVE = 0x0001;

        [DllImport ("user32.dll", SetLastError = true)]
        private static extern uint SendInput (uint nInputs, ref INPUT pInputs, int cbSize);

        public static void Jiggle (int dx, int dy)
        {
            var inp = new INPUT ();
            inp.TYPE = Jiggler.INPUT_MOUSE;
            inp.dx = dx;
            inp.dy = dy;
            inp.mouseData = 0;
            inp.dwFlags = Jiggler.MOUSEEVENTF_MOVE;
            inp.time = 0;
            inp.dwExtraInfo = (IntPtr) 0;

            if (SendInput (1, ref inp, 28) != 1)
                throw new Win32Exception ();
        }
    }

    /* This is a kludge, presetting all this, but WTF. It works. And for a program this trivial, who's bothered? */
    internal struct INPUT
    {
        public int TYPE;
        public int dx;
        public int dy;
        public int mouseData;
        public int dwFlags;
        public int time;
        public IntPtr dwExtraInfo;
    }
}