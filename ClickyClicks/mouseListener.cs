using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickyClicks
{
    internal class mouseListener
    {
     
        private IKeyboardMouseEvents events;
        public bool isEnabled = false;
        private autoclicker ac;
       
        public void subscribe()
        {
            events = Hook.GlobalEvents();

            events.MouseDownExt += GlobalHookMouseDown;
            events.MouseUpExt += GlobalHookMouseUp;
            events.MouseClick += GHookMClickEnable;
        }

        public void unsubscribe()
        {
            events.MouseDownExt += GlobalHookMouseDown;
            events.MouseUpExt += GlobalHookMouseUp;
            events.MouseClick += GHookMClickEnable;
            events.Dispose();
        }

        private void GlobalHookMouseDown(object sender, MouseEventArgs e)
        {
            ac = new autoclicker();

            if (e.Button == MouseButtons.Left && isEnabled)
            {
                ac.Click = true;
            }
        }

        private void GlobalHookMouseUp(object sender, MouseEventArgs e)
        {
            ac = new autoclicker();

            if (e.Button == MouseButtons.Left && isEnabled)
            {
                ac.Click = false;
            }
        }

        private void GHookMClickEnable(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (isEnabled)
                {
                    isEnabled = false;
                } 
                else
                {
                    isEnabled = true;
                }
            }
        }
    }
}
