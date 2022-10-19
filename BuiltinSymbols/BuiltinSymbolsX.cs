namespace NetWolf
{
    public static class BuiltinSymbolX
    {
        ///<summary>
        ///represents an element in symbolic XML.
        ///https://reference.wolfram.com/language/ref/XMLElement.html
        ///</summary>
        public static Engine XMLElement(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("XMLElement[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents the head of an XML object in symbolic XML.
        ///https://reference.wolfram.com/language/ref/XMLObject.html
        ///</summary>
        public static Engine XMLObject(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("XMLObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject that represents an XML template to be applied using functions like TemplateApply.
        ///https://reference.wolfram.com/language/ref/XMLTemplate.html
        ///</summary>
        public static Engine XMLTemplate(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("XMLTemplate[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject with arguments, suitable for cloud deployment or other evaluation.
        ///https://reference.wolfram.com/language/ref/XMLTemplate.html
        ///</summary>
        public static Engine XMLTemplate(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("XMLTemplate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the logical XNOR (not XOR) function. It gives True if an even number of the  are True, and the rest are False. It gives False if an odd number of the  are True, and the rest are False.
        ///https://reference.wolfram.com/language/ref/Xnor.html
        ///</summary>
        public static Engine Xnor(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("Xnor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the logical XOR (exclusive OR) function. It gives True if an odd number of the  are True, and the rest are False. It gives False if an even number of the  are True, and the rest are False.
        ///https://reference.wolfram.com/language/ref/Xor.html
        ///</summary>
        public static Engine Xor(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("Xor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a color in the XYZ color space with tristimulus values x, y and z.
        ///https://reference.wolfram.com/language/ref/XYZColor.html
        ///</summary>
        public static Engine XYZColor(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("XYZColor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies opacity a.
        ///https://reference.wolfram.com/language/ref/XYZColor.html
        ///</summary>
        public static Engine XYZColor(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("XYZColor[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns a color from an HTML color name etc.
        ///https://reference.wolfram.com/language/ref/XYZColor.html
        ///</summary>
        public static Engine XYZColor(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("XYZColor[" + arg0 + "]", name);
        }


    }
}