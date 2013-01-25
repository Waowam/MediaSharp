using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaSharp.Controller;
using MediaSharp.Model;
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
            m.AddDocument(new Audio("NAM1SPT","SuperTitle1", new Author("Name 1", "Firstname 1"), true,500));
            m.AddDocument(new Video("NAM2TES","Test", new Author("Name 2", "Firstname 2"), false,600));
            m.AddDocument(new Book("TXT3TP", "SuperText", new Author("bla", "bli"), true, "Vi", 2013));
            m.AddDocument(new Audio("Regarde", "Comme je suis", new Author("trop", "fort"), true, 700));
            m.AddDocument(new Video("hein", "hein", new Author("hein", "hein?"), false, 600));
            

            View_mdtq view = new View_mdtq();
            view.Visible = false;

            Ctrl_mediatheque controller = new Ctrl_mediatheque(m, view);
            controller.LoadView();
            view.ShowDialog();
        }
    }
}
