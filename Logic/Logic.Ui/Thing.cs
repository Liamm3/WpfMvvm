using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmwohlfart.tsbw.WpfMvvm.Logic.Ui
{
    public class Thing
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Thing(string name) => this.name = name;
    }
}
