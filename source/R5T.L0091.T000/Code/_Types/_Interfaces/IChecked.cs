using System;

using R5T.T0142;


namespace R5T.L0091.T000
{
    /// <summary>
    /// Allows methods to communicate required (input) checks and performed (output) checks.
    /// </summary>
    /// <typeparam name="TCheck">Should be an interface check type. See R5T.T0244 for marker attribute and marker interface type.</typeparam>
    [UtilityTypeMarker, TypeMarker]
    // Covariant ("out") type parameter to allow IChecked<TDerivedCheck>, TDerivedCheck : TCheck to be used wherever an IChecked<TCheck> is needed.
    public interface IChecked<out TCheck>
    {
    }

    /// <summary>
    /// Allows methods to communicate required (input) checks and performed (output) checks.
    /// </summary>
    [UtilityTypeMarker, TypeMarker]
    public interface IChecked
    {
    }
}
