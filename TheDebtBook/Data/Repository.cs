using TheDebtBook.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace TheDebtBook.Data
{
    public class Repository
    {
        internal static ObservableCollection<Debtor> ReadFile(string fileName)
        {
            // Create an instance of the XmlSerializer class and specify the type of object to deserialize.
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Debtor>));
            TextReader reader = new StreamReader(fileName);
            // Deserialize all the debtor.
            var debtors = (ObservableCollection<Debtor>)serializer.Deserialize(reader);
            reader.Close();
            return debtors;
        }
        internal static void SaveFile(string fileName, ObservableCollection<Debtor> debtors)
        {
            // Create an instance of the XmlSerializer class and specify the type of object to serialize.
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Debtor>));
            TextWriter writer = new StreamWriter(fileName);
            // Serialize all the debtor.
            serializer.Serialize(writer, debtors);
            writer.Close();
        }
    }
}
