using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Common {
    /// <summary>
    /// Interfaz de la que deebe derivar los sujetos o clases que
    /// van a ser observadas
    /// </summary>
    public interface IObservable {
        /// <summary>
        /// permite registrar un objeto para que este sea observado
        /// </summary>
        /// <param name="pObserverObject">Un objeto que es derivado de IObserver</param>
        void Register (IObserver pObserverObject);
        /// <summary>
        /// permite eliminar un objeto para que este YA NO sea observado
        /// </summary>
        /// <param name="pObserverObject">Un objeto que es derivado de IObserver</param>
        void UnRegister (IObserver pObserverObject);
    }
}
