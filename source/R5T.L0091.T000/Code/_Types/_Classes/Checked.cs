using System;

using R5T.T0142;


namespace R5T.L0091.T000
{
    [UtilityTypeMarker, TypeMarker]
    public class Checked<TCheck> :
        IChecked<TCheck>
    {
    }


    [UtilityTypeMarker, TypeMarker]
    public static class Checked
    {
        public static Checked<TCheck> Check<TCheck>()
        {
            return new Checked<TCheck>();
        }
    }
}
