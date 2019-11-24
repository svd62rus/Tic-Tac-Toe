using System.Xml.Serialization;
using System.IO;
using System;

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
        /// Load file stream method
        /// </summary>
        /// <param name="formatter">Xml serializer</param>
        /// <returns>Result of load file stream</returns>
        private static ProfileActionResult LoadFileStream(XmlSerializer formatter)
        {
            ProfileActionResult actionResult = new ProfileActionResult();
            using (FileStream fs = new FileStream(fileSavesName, FileMode.Open))
            {          
                actionResult.Profile = (GameProfile)formatter.Deserialize(fs);
                actionResult.IsError = false;
            }
            return actionResult;
        }
        /// <summary>
        /// Load profile method
        /// </summary>
        /// <param name="formatter">Xml serializer</param>
        /// <returns>Result of load profile</returns>
        private static ProfileActionResult LoadProfile(XmlSerializer formatter)
        { 
            try
            {
                return LoadFileStream(formatter);
            }
            catch (Exception)
            {
                return GetFaultedResult();
            }
        }
        /// <summary>
        /// Save file stream method
        /// </summary>
        /// <param name="formatter">Xml serializer</param>
        /// <param name="profile">Game profile</param>
        /// <returns>Result of save file stream</returns>
        private static ProfileActionResult SaveFileStream(XmlSerializer formatter, GameProfile profile)
        {
            ProfileActionResult actionResult = new ProfileActionResult();
            using (FileStream fs = new FileStream(fileSavesName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, profile);
                actionResult.IsError = false;
            }
            return actionResult;
        }
        /// <summary>
        /// Save profile method
        /// </summary>
        /// <param name="formatter">Xml serializer</param>
        /// <param name="profile">Game profile</param>
        /// <returns>Result of save profile</returns>
        private static ProfileActionResult SaveProfile(XmlSerializer formatter, GameProfile profile)
        {
            try
            {
                return SaveFileStream(formatter, profile);
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
            ProfileActionResult actionResult = new ProfileActionResult();
            actionResult.Profile = new GameProfile();
            actionResult.IsError = true;
            return actionResult;
        }
        /// <summary>
        /// Save to file method
        /// </summary>
        /// <param name="profile">Game profile</param>
        public static ProfileActionResult Save(GameProfile profile)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(GameProfile));
            return SaveProfile(formatter, profile);
        }
        /// <summary>
        /// Load of file method
        /// </summary>
        public static ProfileActionResult Load()
        {
            GameProfile profile = new GameProfile();
            XmlSerializer formatter = new XmlSerializer(typeof(GameProfile));
            return LoadProfile(formatter);
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
