using System;
using System.Collections.Generic;

namespace LQT.GUI
{
    public struct BackupOperationStatus
    {
        public BackupOperationStatus(bool pSucceeded, Exception pRaisedException, string pOutputFile, long pOutputFileSize, long pBackupFileSize)
        {
            Succeeded = pSucceeded;
            RaisedException = pRaisedException;
            OutputFile = pOutputFile;
            OutputFileSize = pOutputFileSize;
            BackupFileSize = pBackupFileSize;
        }

        public bool Succeeded;
        public Exception RaisedException;
        public string OutputFile;
        public long OutputFileSize;
        public long BackupFileSize;
    }

    public struct Script
    {
        public string current;
        public string expected;
        public string scriptName;
    }

    public struct ExecuteScriptResult
    {
        public ExecuteScriptResult(bool pSuccessfull, int pQueriesCount, string pErrorMessage, string pFailedQuery)
        {
            successfull = pSuccessfull;
            queriesCount = pQueriesCount;
            errorMessage = pErrorMessage;
            failedQuery = pFailedQuery;
        }

        public bool successfull;
        public int queriesCount;
        public string errorMessage;
        public string failedQuery;
    }

}
