using System.Collections.Generic;

namespace CoreWolf
{
    public static class ExtendedFunctionsX
    {
        ///<summary>
        /// represents the head of an XML object in symbolic XML.
        /// https://reference.wolfram.com/language/ref/XMLObject.html
        ///</summary>
        public static Engine XMLObject(this Engine en, string? name = null)
        {
            return en.Execute("XMLObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a TemplateObject that represents an XML template to be applied using functions like TemplateApply.
        /// https://reference.wolfram.com/language/ref/XMLTemplate.html
        ///</summary>
        public static Engine XMLTemplate(this Engine en, string? name = null)
        {
            return en.Execute("XMLTemplate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a color from an HTML color name etc.
        /// https://reference.wolfram.com/language/ref/XYZColor.html
        ///</summary>
        public static Engine XYZColor(this Engine en, string? name = null)
        {
            return en.Execute("XYZColor[" + en.ValidNames.Last() + "]", name);
        }


    }
}