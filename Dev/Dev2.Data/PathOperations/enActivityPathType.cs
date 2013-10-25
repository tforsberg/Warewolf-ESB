﻿using System;

namespace Dev2.PathOperations {

    /// <summary>
    /// PBI : 1172
    /// Status : New
    /// Purpose : To abstract IO endpoint types
    /// </summary>
    [Serializable]
    public enum enActivityIOPathType {

        FileSystem,
        FTP,
        FTPS,
        SFTP,
        FTPES,
        Invalid
    }
}
