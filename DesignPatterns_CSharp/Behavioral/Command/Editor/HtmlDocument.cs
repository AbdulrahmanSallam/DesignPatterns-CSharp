using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DesignPatterns_CSharp.Behavioral.Command.Editor
{
    public class HtmlDocument
    {
        public string Content { get; set; } = string.Empty;
    

        public void MakeBold()
        {
            Content = $"<b> {Content} </b>";

        }
    }
}
