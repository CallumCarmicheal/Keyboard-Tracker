using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Diagnostics;

namespace Keyboard_Tracker.Engine {
    class Loading {

        // May use another type of serialization so we can convay other versions
        // But for now...

        public static bool LoadSessions(string fileIn) {
            Log("LoadSessions(" + fileIn + ") -> Started");

            bool status = true;
            bool keyState = KeyTracker.ListenForKeys;
            KeyTracker.ListenForKeys = false;
            Log("\tKey State: " + keyState);

            try {
                FieldInfo[] fields = (typeof(KeyTracker)).GetFields(BindingFlags.Static | BindingFlags.Public);
                object[,] data = new object[fields.Length, 2];

                System.IO.Stream fileStream = System.IO.File.Open(fileIn, System.IO.FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                data = binaryFormatter.Deserialize(fileStream) as object[,];
                fileStream.Close();

                Log("\tLengths: Retrieved '" + data.GetLength(0) + "', Expecting '" + fields.Length + "'.");
                if (data.GetLength(0) != fields.Length) {
                    Log("\t\tLength is invalid");
                    // Invalid File
                    status = false;
                } Log("\t\tLength is valid");

                Log("\tForeach FieldInfo inside Static Member");
                int cnt = 0;
                foreach (FieldInfo field in fields) {
                    Log("\t\tField Count=" + cnt);
                    for (int x = 0; x < fields.Length; x++) {
                        if (field.Name == (data[x, 0] as string)) {
                            Log("\t\t\tField Name=" + field.Name);
                            Log("\t\t\tField Datatype=" + field.FieldType.Name);

                            if (field.FieldType == typeof(int)) 
                                Log("\t\t\tField Data=" + ((int)data[x, 1]));
                            else if (field.FieldType == typeof(string))
                                Log("\t\t\tField Data=" + ((string)data[x, 1]));
                            else
                                Log("\t\t\tField Data=Binary");

                            field.SetValue(null, data[x, 1]);
                            Log("\t\t\tField SetData=True");
                        }
                    } cnt++;
                }
            } catch (Exception ex) {
                Log("LoadSessions(" + fileIn + ") -> Error");
                Log("\t" + ex.Message);
                System.Windows.Forms.MessageBox.Show("Error while saving to file (" + fileIn + ")" + Environment.NewLine + ex.Message);
                status = false;
            } finally {
                KeyTracker.ListenForKeys = keyState;
            }

            Log("LoadSessions(" + fileIn + ") -> Ended");
            return status;
        }

        // if 'append' then add to the current list of sessions
        // if not the clear the sessions then add the session
        public static bool LoadSession(bool append) {
            return false;
        }

        private static void Log(string msg) {
            if (Debugger.IsAttached)
                Debugger.Log(0, "Bin.Loading", msg + "\n");
        }

    }
}
