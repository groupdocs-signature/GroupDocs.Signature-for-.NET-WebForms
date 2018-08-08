
using GroupDocs.Signature.WebForms.Products.Signature.Config;
using System;
using System.IO;

namespace GroupDocs.Signature.WebForms.Products.Signature.Util.Directory
{
    /// <summary>
    /// FilesDirectoryUtils
    /// </summary>
    public class FilesDirectoryUtils : IDirectoryUtils
    {
        private SignatureConfiguration signatureConfiguration;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="signatureConfiguration">SignatureConfiguration</param>
        public FilesDirectoryUtils(SignatureConfiguration signatureConfiguration)
        {
            this.signatureConfiguration = signatureConfiguration;

            // set files directory
            if (!File.Exists(signatureConfiguration.FilesDirectory))
            {
                signatureConfiguration.FilesDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "/../" + signatureConfiguration.FilesDirectory);
            }
        }

        /// <summary>
        /// Get path
        /// </summary>
        /// <returns>string</returns>
        public string GetPath()
        {
            return signatureConfiguration.FilesDirectory;
        }
    }
}