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
            Mediatheque m = new Mediatheque();
            m.AddDocument(new Audio("NAM1SPT","SuperTitle1", new Author("Name 1", "Firstname 1"), true,3,2));
            m.AddDocument(new Video("NAM2TES", "Test", new Author("Name 2", "Firstname 2"), false,00,28,2));
            m.AddDocument(new Book("TXT3TP", "SuperText", new Author("bla", "bli"), true, "Vi", 2013));
            m.AddDocument(new Audio("Regarde", "Comme je suis", new Author("trop", "fort"), true,2,52));
            m.AddDocument(new Video("hein", "hein", new Author("hein", "hein?"), false,0,43,32));
            
            /****Serialization test - START*****/ 
            /* //XML version
            UseApplication.Program.SerializeToXML(m);

            Mediatheque mCpy = UseApplication.Program.DeserializeFromXML();*/
            UseApplication.Program.SerializeObject(m);

            Mediatheque mCpy = UseApplication.Program.DeSerializeObject();
            /****Serialization test - END*****/

            View_mdtq view = new View_mdtq();
            view.Visible = false;

            Ctrl_mediatheque controller = new Ctrl_mediatheque(mCpy, view);
            controller.LoadView();
            view.ShowDialog();
        }

        static public void SerializeObject(Mediatheque objectToSerialize)
        {
            Stream stream = File.Open("Mediatheque.dat", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                bFormatter.Serialize(stream, objectToSerialize);
            }
            finally
            {
                stream.Close();
            }
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

        static public void SerializeToXML(Mediatheque mediatheque)
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
        }
    }
}
