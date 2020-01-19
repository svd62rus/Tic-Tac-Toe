using System.Xml.Serialization;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

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
        private static string FileSavesName { get; } = "titactoe_save";
        /// <summary>
        /// Load file stream method
        /// </summary>
        /// <returns>Result of load file stream</returns>
        private static ProfileActionResult LoadFileStream()
        {
            //XmlSerializer formatter = new XmlSerializer(typeof(GameProfile));
            BinaryFormatter formatter = new BinaryFormatter();
            ProfileActionResult actionResult = new ProfileActionResult();
            using (FileStream fs = new FileStream(GetFileSavePath(), FileMode.Open))
            {
                actionResult.Profile = (GameProfile)formatter.Deserialize(fs);
                actionResult.IsError = false;
            }
            return actionResult;
        }
        /// <summary>
        /// Load profile method
        /// </summary>
        /// <returns>Result of load profile</returns>
        private static ProfileActionResult LoadProfile()
        { 
            try
            {
                return LoadFileStream();
            }
            catch (Exception)
            {
                return GetFaultedResult();
            }
        }
        /// <summary>
        /// Save file stream method
        /// </summary>
        /// <param name="profile">Game profile</param>
        /// <returns>Result of save file stream</returns>
        private static ProfileActionResult SaveFileStream(GameProfile profile)
        {
            //XmlSerializer formatter = new XmlSerializer(typeof(GameProfile));
            BinaryFormatter formatter = new BinaryFormatter();
            ProfileActionResult actionResult = new ProfileActionResult();
            using (FileStream fs = new FileStream(GetFileSavePath(), FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, profile);
                actionResult.IsError = false;
            }
            return actionResult;
        }
        /// <summary>
        /// Save profile method
        /// </summary>
        /// <param name="profile">Game profile</param>
        /// <returns>Result of save profile</returns>
        private static ProfileActionResult SaveProfile(GameProfile profile)
        {
            try
            {
                return SaveFileStream(profile);
            }
            catch (Exception)
            {
                return GetFaultedResult();
            }
        }
        /// <summary>
        /// Create faulted result
        /// </summary>
        /// <returns>Result of faulted action on profile</returns>
        private static ProfileActionResult GetFaultedResult()
        {
            ProfileActionResult actionResult = new ProfileActionResult
            {
                Profile = new GameProfile(),
                IsError = true
            };
            return actionResult;
        }
        /// <summary>
        /// Save to file method
        /// </summary>
        /// <param name="profile">Game profile</param>
        public static ProfileActionResult Save(GameProfile profile)
        {
            return SaveProfile(profile);
        }
        /// <summary>
        /// Load of file method
        /// </summary>
        public static ProfileActionResult Load()
        {
            return LoadProfile();
        }
        /// <summary>
        /// CheckExistFileSave method
        /// </summary>
        /// <returns>Exist or not exist file save</returns>
        public static bool CheckExistFileSave()
        {
            return File.Exists(GetFileSavePath());
        }
        private static string GetFileSavePath()
        {
            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(myDocuments, FileSavesName);
        }
    }
}
