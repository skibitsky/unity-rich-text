
namespace RichText
{
    public static class RichText
    {
        #region Modifications

        /// <summary>
        /// Renders the text in boldface.	
        /// </summary>
        /// <param name="obj">Original object</param>
        public static string Bold(this object obj) { return $"<b>{obj}</b>"; }
        
        /// <summary>
        /// Renders the text in italics.	
        /// </summary>
        /// <param name="obj">Original object</param>
        public static string Italic(this object obj) { return $"<i>{obj}</i>"; }

        #endregion
        
        #region Size

        /// <summary>
        /// Sets the size of the text according to the parameter value, given in pixels.	
        /// </summary>
        /// <param name="obj">Original object</param>
        /// <param name="size">Desired text size in pixels</param>
        public static string Size(this object obj, int size) { return $"<size={size}>{obj}</size>"; }

        #endregion
        
        #region Colors

	     /// <summary> Paint it Aqua!</summary>
        public static string Aqua(this object obj) { return ColorProcessor(obj, "aqua"); }
        
        /// <summary> Paint it Black!</summary>
        public static string Black(this object obj) { return ColorProcessor(obj, "black");}
        
        /// <summary> Paint it Blue!</summary>
        public static string Blue(this object obj) { return ColorProcessor(obj, "blue"); }
        
        /// <summary> Paint it Brown!</summary>
        public static string Brown(this object obj) { return ColorProcessor(obj, "brown"); }
        
        /// <summary> Paint it Cyan!</summary>
        public static string Cyan(this object obj) { return ColorProcessor(obj, "cyan"); }
        
        /// <summary> Paint it Dark Blue!</summary>
        public static string DarkBlue(this object obj) { return ColorProcessor(obj, "darkblue"); }
        
        /// <summary> Paint it Fuchsia!</summary>
        public static string Fuchsia(this object obj) { return ColorProcessor(obj, "fuchsia"); }
        
        /// <summary> Paint it Green!</summary>
        public static string Green(this object obj) { return ColorProcessor(obj, "green"); }
        
        /// <summary> Paint it Grey!</summary>
        public static string Grey(this object obj) { return ColorProcessor(obj, "grey"); }
        
        /// <summary> Paint it Light Blue!</summary>
        public static string LightBlue(this object obj) { return ColorProcessor(obj, "lightblue"); }
        
        /// <summary> Paint it Lime!</summary>
        public static string Lime(this object obj) { return ColorProcessor(obj, "lime"); }

        /// <summary> Paint it Magenta!</summary>
        public static string Magenta(this object obj) { return ColorProcessor(obj, "magenta"); }
        
        /// <summary> Paint it Maroon!</summary>
        public static string Maroon(this object obj) { return ColorProcessor(obj, "maroon"); }
        
        /// <summary> Paint it Navy!</summary>
        public static string Navy(this object obj) { return ColorProcessor(obj, "navy"); }
        
        /// <summary> Paint it Olive!</summary>
        public static string Olive(this object obj) { return ColorProcessor(obj, "olive"); }
        
        /// <summary> Paint it Orange!</summary>
        public static string Orange(this object obj) { return ColorProcessor(obj, "orange"); }
        
        /// <summary> Paint it Purple!</summary>
        public static string Purple(this object obj) { return ColorProcessor(obj, "purple"); }
        
        /// <summary> Paint it Red!</summary>
        public static string Red(this object obj) { return ColorProcessor(obj, "red"); }
        
        /// <summary> Paint it Silver!</summary>
        public static string Silver(this object obj) { return ColorProcessor(obj, "silver"); }
        
        /// <summary> Paint it Teal!</summary>
        public static string Teal(this object obj) { return ColorProcessor(obj, "teal"); }
        
        /// <summary> Paint it White!</summary>
        public static string White(this object obj) { return ColorProcessor(obj, "white"); }
        
        /// <summary> Paint it Yellow!</summary>
        public static string Yellow(this object obj) { return ColorProcessor(obj, "yellow"); }
        
        private static string ColorProcessor(object obj, string color)
        {
            return $"<color={color}>{obj}</color>";
        }
        
        #endregion
    }

}