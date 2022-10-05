namespace NetWolf
{
    public static class BuiltinSymbolX
    {
        ///<summary>
        ///represents the head of an XML object in symbolic XML.
        ///https://reference.wolfram.com/language/ref/XMLObject.html
        ///</summary>
        public static Engine XMLObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("XMLObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the head of an XML object in symbolic XML.
        ///https://reference.wolfram.com/language/ref/XMLObject.html
        ///</summary>
        public static Engine XMLObject(this Engine en, string? name = null)
        {
            return en.Execute("XMLObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the logical XNOR (not XOR) function. It gives True if an even number of the  are True, and the rest are False. It gives False if an odd number of the  are True, and the rest are False. 
        ///https://reference.wolfram.com/language/ref/Xnor.html
        ///</summary>
        public static Engine Xnor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Xnor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a color in the XYZ color space with tristimulus values x, y and z.
        ///https://reference.wolfram.com/language/ref/XYZColor.html
        ///</summary>
        public static Engine XYZColor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("XYZColor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an element in symbolic XML.
        ///https://reference.wolfram.com/language/ref/XMLElement.html
        ///</summary>
        public static Engine XMLElement(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("XMLElement[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject that represents an XML template to be applied using functions like TemplateApply.
        ///https://reference.wolfram.com/language/ref/XMLTemplate.html
        ///</summary>
        public static Engine XMLTemplate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("XMLTemplate[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject that represents an XML template to be applied using functions like TemplateApply.
        ///https://reference.wolfram.com/language/ref/XMLTemplate.html
        ///</summary>
        public static Engine XMLTemplate(this Engine en, string? name = null)
        {
            return en.Execute("XMLTemplate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the logical XOR (exclusive OR) function. It gives True if an odd number of the  are True, and the rest are False. It gives False if an even number of the  are True, and the rest are False. 
        ///https://reference.wolfram.com/language/ref/Xor.html
        ///</summary>
        public static Engine Xor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Xor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }


    }
}