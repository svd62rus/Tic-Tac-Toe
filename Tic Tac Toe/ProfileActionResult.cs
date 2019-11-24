using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Result of profile action class
    /// </summary>
    class ProfileActionResult
    {
        /// <summary>
        /// Game profile
        /// </summary>
        public GameProfile Profile { get; set;}
        /// <summary>
        /// Result with error or not
        /// </summary>
        public bool IsError { get; set;}
    }
}
