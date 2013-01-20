using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaSharp.Controller;
using MediaSharp.Modal;
using MediaSharp.View;

namespace UseApplication
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mediatheque m = new Mediatheque();
            m.AddDocument(new Document("SuperTitle1", new Author("Name 1", "Firstname 1"), true));
            m.AddDocument(new Document("Test", new Author("Name 2", "Firstname 2"), false));

            View_mdtq view = new View_mdtq();
            view.Visible = false;

            Ctrl_mediatheque controller = new Ctrl_mediatheque(m, view);
            controller.LoadView();
            view.ShowDialog();
        }
    }
}
