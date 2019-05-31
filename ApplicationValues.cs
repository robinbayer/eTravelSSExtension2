using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCH_ODC_BF_CDriver
{
    class ApplicationValues
    {

        public const string CHILKAT_SFTP_UNLOCK_CODE = "TEQUACSSH_Z6OmCPat1Rnd";
        public const string CHILKAT_ZIP_UNLOCK_CODE = "TEQUACZIP_GazYoMb3oTy8";

        public const string DOCUMENT_FORMAT_TIFF_MULTI_PAGE = "TIFF - Multiple Page";
        public const string DOCUMENT_FORMAT_PDF_IMAGE_ONLY = "PDF - Image Only";
        public const string DOCUMENT_FORMAT_PDF_SEARCHABLE = "PDF - Searchable";

        public const string MANIFEST_FILENAME_EXTENSION = "mnf";
        public const string TIFF_FILE_EXTENSION = "tif";
        public const string UPLOAD_BUNDLE_FILE_EXTENSION = "uploadbz";

        /*
        m_objLogger.Error(String.Format("Could not upload file.  Reported error is '{0}'", objSFTPController.LastErrorText));
        m_objLogger.Error(String.Format("Could not open remote file.  Reported error is '{0}'", objSFTPController.LastErrorText));
        m_objLogger.Error(String.Format("Unable to initialize SFTP subsystem.  Reported error is '{0}'", objSFTPController.LastErrorText));
        m_objLogger.Error(String.Format("Unable to authenticate.  Reported error is '{0}'", objSFTPController.LastErrorText));
        m_objLogger.Error(String.Format("Unable to connect to SFTP server.  Reported error is '{0}'", objSFTPController.LastErrorText));
        m_objLogger.Error("Unable to unlock SFTP component");
        m_objLogger.Error(String.Format("Could not close and write zip file.  Reported error is '{0}'", objZipController.LastErrorText));
        m_objLogger.Error(String.Format("Could not append files from directory '{0}'.  Reported error is '{1}'", m_objDriverSettings.TemporaryFilePath, 
        objZipController.LastErrorText));
        m_objLogger.Error(String.Format("Unable to create new ZIP file '{0}'.  Reported error is '{1}'", strZIPFileName, objZipController.LastErrorText));
        m_objLogger.Error("Unable to unlock Zip component");

         * */

        public const int ERROR_COULD_NOT_UPLOAD_FILE = -1;
        public const int ERROR_COULD_NOT_OPEN_REMOTE_FILE = -2;
        public const int ERROR_COULD_NOT_INITIALIZE_SFTP = -3;
        public const int ERROR_COULD_NOT_AUTH_SFTP_SERVER = -4;
        public const int ERROR_COULD_NOT_CONNECT_SFTP_SERVER = -5;
        public const int ERROR_COULD_NOT_UNLOCK_SFTP_COMPONENT = -6;
        public const int ERROR_COULD_NOT_CLOSE_WRITE_ZIP_FILE = -7;
        public const int ERROR_COULD_NOT_APPEND_FILES_TO_ZIP = -8;
        public const int ERROR_COULD_NOT_CREATE_NEW_ZIP_FILE = -9;
        public const int ERROR_COULD_NOT_UNLOCK_ZIP_COMPONENT = -10;

        public const int ERROR_UNHANLDED_EXECEPTION = -999;


    }
}
