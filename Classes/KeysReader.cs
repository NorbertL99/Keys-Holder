using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysHolder.Classes
{
    class KeysReader
    {
        /// <summary>
        /// Variables
        /// </summary>
        DESControler desControler = new DESControler();
        public string filePath { get; private set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="filePath">Path of keys file</param>
        public KeysReader(string filePath)
        {
            this.filePath = filePath;
        }

        /// <summary>
        /// This method is used to get config from file
        /// </summary>
        /// <returns>List of KeysObjects with store as many object with keys config as user create</returns>
        public List<KeysObjects> GetKeys()
        {
            List<KeysObjects> keysObjects = new List<KeysObjects>();
            StreamReader streamReader = new StreamReader(filePath);
            var skipThisLine = streamReader.ReadLine();
            var line = desControler.DESDecryption(streamReader.ReadLine());
            while(line != null)
            {
                string platform = string.Empty;
                string login = string.Empty;
                string password = string.Empty;
                string description = string.Empty;
                string whatRead = "PL";               
                for(int i = 0; i < line.Length; i++)
                {
                    switch(whatRead)
                    {
                        case "PL":
                            if(line[i] == '{')
                            {
                                whatRead = "LO";
                            }
                            else
                            {
                                platform = platform + line[i];
                            }
                            break;
                        case "LO":
                            if (line[i] == ';')
                            {
                                whatRead = "PA";
                            }
                            else
                            {
                                login = login + line[i];
                            }
                            break;
                        case "PA":
                            if (line[i] == ';')
                            {
                                whatRead = "DE";
                            }
                            else
                            {
                                password = password + line[i];
                            }
                            break;
                        case "DE":
                            if (line[i] != '}')
                            {
                                description = description + line[i];
                            }
                            break;
                    }                  
                }
                keysObjects.Add(new KeysObjects(platform, login, password, description));
                line = desControler.DESDecryption(streamReader.ReadLine());
            }
            streamReader.Close();
            return keysObjects;
        }
    }
}
