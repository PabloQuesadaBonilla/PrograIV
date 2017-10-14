using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Common {
    /// <summary>
    /// Interfaz que expone el método de notificacion a los observadores.
    /// </summary>
    public interface IObserver {
        /// <summary>
        /// Notifica a los observadores con un objeto que se envia desde el
        /// observado.
        /// </summary>
        /// <param name="pNotification">Objeto de notificacion</param>
        void Notify (object pNotification);
    }
}
