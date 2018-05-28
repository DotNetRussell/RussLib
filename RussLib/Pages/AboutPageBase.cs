using BasecodeLibrary.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace RussLib.Pages
{
    internal class AboutPageBase : ControlContainer
    {
        public string _bio = @"Born and raised in Northeast Ohio, I am a full time engineer that loves building cool new things. In my free time I like working with children and teaching them how to program or work with hardware." + System.Environment.NewLine + System.Environment.NewLine + @"Check out my blog or reach out to me on twitter if you'd like to communicate.";

        public AboutPageBase()
        {

        }
    }
}
