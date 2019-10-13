//using System;


//namespace R5T.Gepidia
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    /// <remarks>
//    /// Immutable.
//    /// </remarks>
//    public abstract class FileSystemEntry
//    {
//        #region Static

//        public static FileSystemEntry New(string path, FileSystemEntryType type)
//        {
//            var output = new FileSystemEntry(path, type);
//            return output;
//        }

//        #endregion


//        public string Path { get; }
//        public FileSystemEntryType Type { get; }


//        public FileSystemEntry(string path, FileSystemEntryType type)
//        {
//            this.Path = path;
//            this.Type = type;
//        }
//    }
//}
