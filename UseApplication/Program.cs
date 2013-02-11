using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaSharp.Controller;
using MediaSharp.Model;
using MediaSharp.View;

using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            Mediatheque m = UseApplication.Program.DeSerializeObject();
            /****Serialization test - END*****/

            View_mdtq view = new View_mdtq();
            view.Visible = false;

            Ctrl_mediatheque controller = new Ctrl_mediatheque(m, view);
            controller.LoadView();
            view.ShowDialog();
        }

        static public Mediatheque DeSerializeObject()
        {
            Mediatheque res;
            Stream stream = File.Open("Mediatheque.dat", FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                res = (Mediatheque)bFormatter.Deserialize(stream);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return res;
        }

       /* static public void SerializeToXML(Mediatheque mediatheque)
        {
            Type[] extraTypes = new Type[5];
                extraTypes[0] = typeof(Article);
                extraTypes[1] = typeof(Audio);
                extraTypes[2] = typeof(Book);
                extraTypes[3] = typeof(Multimedia);
                extraTypes[4] = typeof(Video);

            FileStream fsOverwrite = new FileStream("Document.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Mediatheque), extraTypes);
            TextWriter textWriter = new StreamWriter(fsOverwrite);
            try
            {
                serializer.Serialize(textWriter, mediatheque);
            }
            finally
            {
                textWriter.Close();
                fsOverwrite.Close();
            }
        }

        static Mediatheque DeserializeFromXML()
        {
            Type[] extraTypes = new Type[5];
                extraTypes[0] = typeof(Article);
                extraTypes[1] = typeof(Audio);
                extraTypes[2] = typeof(Book);
                extraTypes[3] = typeof(Multimedia);
                extraTypes[4] = typeof(Video);

            XmlSerializer deserializer = new XmlSerializer(typeof(Mediatheque), extraTypes);
            TextReader textReader = new StreamReader("Document.xml", true);
            Mediatheque mediatheque;
            try
            {
                mediatheque = (Mediatheque)deserializer.Deserialize(textReader);
            }
            finally
            {
                textReader.Close();
            }

            return mediatheque;
        }*/
    }
}
