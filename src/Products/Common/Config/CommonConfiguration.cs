using GroupDocs.Signature.WebForms.Products.Common.Util.Parser;

namespace GroupDocs.Signature.WebForms.Products.Common.Config
{
    /// <summary>
    /// CommonConfiguration
    /// </summary>
    public class CommonConfiguration
    {
        public bool isPageSelector { get; set; }
        public bool isDownload { get; set; }
        public bool isUpload { get; set; }
        public bool isPrint { get; set; }
        public bool isBrowse { get; set; }
        public bool isRewrite { get; set; }        

        /// <summary>
        /// Constructor
        /// </summary>
        public CommonConfiguration()
        {
            YamlParser parser = new YamlParser();
            dynamic configuration = parser.GetConfiguration("common");
            ConfigurationValuesGetter valuesGetter = new ConfigurationValuesGetter(configuration);
            isPageSelector = valuesGetter.GetBooleanPropertyValue("pageSelector", isPageSelector);
            isDownload = valuesGetter.GetBooleanPropertyValue("download", isDownload);
            isUpload = valuesGetter.GetBooleanPropertyValue("upload", isUpload);
            isPrint = valuesGetter.GetBooleanPropertyValue("print", isPrint);
            isBrowse = valuesGetter.GetBooleanPropertyValue("browse", isBrowse);
            isRewrite = valuesGetter.GetBooleanPropertyValue("rewrite", isRewrite);
        }
    }
}