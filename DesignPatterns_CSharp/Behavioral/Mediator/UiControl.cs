using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Mediator
{
    public class UiControl
    {
        protected DialogBox owner;

        public UiControl(DialogBox owner)
        {
            this.owner = owner;
        }
    }

}
