// -----------------------------------------------------------------------
// <copyright file="MemberPreference.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IMaps.Domain
{
  using System.Collections.Generic;
  using System.Runtime.Serialization;

  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  [DataContract(Namespace = "")]
  public class TeamDependencyPreference
  {
    /// <summary>
    /// Gets or sets the controls.
    /// </summary>
    /// <value>
    /// The controls.
    /// </value>
    [DataMember]
    public List<PreferenceControl> Controls { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    [DataMember]
    public string Description { get; set; }
  }
}
