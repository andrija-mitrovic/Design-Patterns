using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Canvas
    {
        private ITool _tool;

        public void SetTool(ITool tool) 
            => _tool = tool;

        public void MouseDown()
            => _tool.MouseDown();

        public void MouseUp()
            => _tool.MouseUp();
    }
}
