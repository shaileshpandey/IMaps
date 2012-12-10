// -----------------------------------------------------------------------
// <copyright file="PreferenceControl.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------



namespace IMaps.Domain
{
  using System.Runtime.Serialization;

  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  [DataContract(Namespace = "")]
  public class PreferenceControl
  {
    /// <summary>
    /// Gets or sets the type of the control.
    /// </summary>
    /// <value>
    /// The type of the control.
    /// </value>
    [DataMember]
    public string ControlType { get; set; }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    /// <value>
    /// The label.
    /// </value>
    [DataMember]
    public string Label { get; set; }
  }
}
