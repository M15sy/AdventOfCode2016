namespace AdventOfCode2016.Core.Day4
{
    /// <summary>
    /// A base class for day 4 solutions.
    /// </summary>
    internal abstract class Solution4 : SolutionBase
    {
        /// <inheritdoc />
        protected override string DataFileName
        {
            get { return "Day4"; }
        }
        // RealRooms
    }
    /// <summary>
    /// A structure representing a room.
    /// </summary>
    internal struct Room
    {
        internal string EncryptedName { get; set; }
        internal string Checksum { get; set; }
        internal int SectorId { get; set; }

        internal Room(string encryptedName, string checksum, int sectorId)
        {
            EncryptedName = encryptedName;
            Checksum = checksum;
            SectorId = sectorId;
        }
    }
}
