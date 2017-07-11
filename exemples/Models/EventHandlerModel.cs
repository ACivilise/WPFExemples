using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemples.Models
{
    //Delegate utilisé pour mettre à jours les Targets
    public delegate void EventHandlerDelegate(string input);
    
    public class EventHandlerModel
    {
        public EventHandlerModel() { }

        public EventHandlerDelegate eventHandlerDelegate;
    }
}
