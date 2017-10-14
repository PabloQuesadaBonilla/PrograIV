using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Observer.Common {
    /// <summary>
    /// Define la clase del Objeto Sujeto. El que va a ser observado.
    /// </summary>
    public class BaseSubjectObservable : IObservable {
        /// <summary>
        /// representa la lista de suscripcion de objetos observados (osea que
        /// van a ser notificados)
        /// </summary>
        private Hashtable aObservableObjectList = new Hashtable (); 
        #region IObservable Members

        /// <summary>
        /// Registra un objeto para que sea observado
        /// </summary>
        /// <param name="pObserverObject">un objeto que herede de IObserver y que implementa el metodo Notify</param>
        public void Register (IObserver pObserverObject) {
            aObservableObjectList.Add (pObserverObject, pObserverObject);
        }
        /// <summary>
        /// Elimina un Objeto de la lista de objetos observados. 
        /// Este objeto ya no sera notificado
        /// </summary>
        /// <param name="pObserverObject">un objeto que herede de IObserver y que implementa el metodo Notify</param>
        public void UnRegister (IObserver pObserverObject) {
            aObservableObjectList.Remove(pObserverObject);
        }

        /// <summary>
        /// Notifica a todos los observadores con un objeto que se pasa por parametro
        /// </summary>
        /// <param name="pNotifyObject">Objeto que se va a notificar</param>
        public void NotifyObservers (object pNotifyObject) {
            foreach (IObserver vObserver in aObservableObjectList.Keys) {
                vObserver.Notify (pNotifyObject);
            }
        
        }

        #endregion
    }
}
