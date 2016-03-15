using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Keyboard_Tracker.Engine {
    class Saving {

        public static bool Everything(string FileOut) {
            // We'll use binary serialization so the results/keys pressed cannot be 
            // Modified, or faked.

            bool status = true;
            bool keyState = KeyTracker.ListenForKeys;
            KeyTracker.ListenForKeys = false;
            try {
                FieldInfo[] fields = (typeof(KeyTracker)).GetFields(BindingFlags.Static | BindingFlags.Public);

                object[,] data = new object[fields.Length, 2];

                int x = 0;
                foreach (FieldInfo field in fields) {
                    data[x, 0] = field.Name;
                    data[x, 1] = field.GetValue(null);
                    x++;
                }

                System.IO.Stream fileStream = System.IO.File.Open(FileOut, System.IO.FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fileStream, data);
                fileStream.Close();
            } catch(Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error while saving to file (" + FileOut + ")" + Environment.NewLine + ex.Message);
                status = false;
            } finally {
                KeyTracker.ListenForKeys = keyState;
            }

            return status;
        }
    }
}
