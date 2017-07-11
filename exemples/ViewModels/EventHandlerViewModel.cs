using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemples.Models;

namespace exemples.ViewModels
{
    public class EventHandlerViewModel
    {
        private EventHandlerModel EventHandlerModel { get; set; }

        public EventHandlerViewModel(EventHandlerModel eventHandlerModel)
        {
            this.EventHandlerModel = eventHandlerModel;
        }

        public void Event_Handler_OnClick()
        {
            this.EventHandlerModel.eventHandlerDelegate("test");
        }
    }
}
