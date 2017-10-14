using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Observer.Common;

namespace ObserverPattern_NotOptimized_POC {
    /// <summary>
    /// Implementa IObserver para que sea un objeto que escucha las notificaciones
    /// de un sujeto al cual esta suscrito.
    /// </summary>
    public partial class NotifyListForm : Form, IObserver {
        public NotifyListForm () {
            InitializeComponent ();
        }

        private void NotifyListForm_Load (object sender, EventArgs e) {

        }

        #region IObserver Members
        // deberia llamarse updating 
        public void Notify (object pNotification) {
            listBox1.Items.Add (pNotification.ToString ());
        }

        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}