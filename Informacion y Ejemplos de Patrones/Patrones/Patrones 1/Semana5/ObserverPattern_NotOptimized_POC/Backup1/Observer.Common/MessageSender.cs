using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Common {
    public class MessageSender : BaseSubjectObservable {

        object aMessage;
        ///<summary>
        ///Asigna El Mensaje a los Observadoresy los notifica
        ///</summary>
        public object Message {
            set {
                this.aMessage = value;
                NotifyObservers (aMessage);
            }
        }
    }
}
