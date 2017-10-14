using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Observer.Common;

namespace ObserverPattern_NotOptimized_POC {
    public partial class NotifyBannerForm : Form, IObserver {
        public NotifyBannerForm () {
            InitializeComponent ();
        }

        private void NotifyBannerForm_Load (object sender, EventArgs e) {

        }

        #region IObserver Members

        public void Notify (object pNotification) {
            label1.Text = pNotification.ToString ();
        }

        #endregion
    }
}