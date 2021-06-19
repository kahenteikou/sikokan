using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikokan
{
    class FileSelectMenus
    {
        public string TitlePic { get; set; }
        public string Text { get; set; }
        public delegate void ClickdedDelegate(object sender, EventArgs e);
        public event ClickdedDelegate clicked;
        public void MouseDowned(object sender,EventArgs e)
        {
            clicked(sender, e);
        }
    }
}
