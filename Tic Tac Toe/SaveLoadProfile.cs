using System.Xml.Serialization;
using System.IO;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Static class for save/load profile to file
    /// </summary>
    static class SaveLoadProfile
    {
        /// <summary>
        /// Name of save file
        /// </summary>
        private static string fileSavesName { get; } = "save.xml";
        /// <summary>
        /// Save to file method
        /// </summary>
        /// <param name="profile"></param>
        public static void Save(GameProfile profile)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(GameProfile));
            using (FileStream fs = new FileStream(fileSavesName, FileMode.OpenOrCreate))
                    formatter.Serialize(fs, profile);
        }
        /// <summary>
        /// Load of file method
        /// </summary>
        /// <param name="profile"></param>
        public static GameProfile Load()
        {
            GameProfile profile = new GameProfile();
            XmlSerializer formatter = new XmlSerializer(typeof(GameProfile));
            using (FileStream fs = new FileStream(fileSavesName, FileMode.Open))
            {
                profile = (GameProfile)formatter.Deserialize(fs);
            }
            return profile;
        }
        /// <summary>
        /// CheckExistFileSave method
        /// </summary>
        /// <returns>Exist or not exist file save</returns>
        public static bool CheckExistFileSave()
        {
            return File.Exists(fileSavesName);
        }
    }
}
