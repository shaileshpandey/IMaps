namespace IMaps.BusinessRules.Repository
{
  using System.Collections.Generic;
  using System.Xml;
  using Framework.Data;
  using Domain;
  using Contracts;

  /// <summary>
  /// Class to get domain information.
  /// </summary>
  public class DomainRepository : IDomainRepository
  {
    /// <summary>
    /// Path of the datasource to populate the records.
    /// </summary>
    private readonly string xmlFilePath;

    public DomainRepository(string xmlPath)
    {
      xmlFilePath = xmlPath;
    }

    /// <summary>
    /// Gets the member preferences.
    /// </summary>
    /// <returns>
    /// List of MemberPreference objects
    /// </returns>
    public List<MemberPreference> GetMemberPreferences()
    {
      var document = new XmlDocument();
      document.Load(xmlFilePath);
      return XmlHelper.Deserialize<List<MemberPreference>>(document.InnerXml);
    }


    /// <summary>
    /// Gets the team preferences.
    /// </summary>
    /// <returns>
    /// List of TeamPreference objects
    /// </returns>
    public List<TeamPreference> GetTeamPreferences()
    {
      var document = new XmlDocument();
      document.Load(xmlFilePath);
      return XmlHelper.Deserialize<List<TeamPreference>>(document.InnerXml);
    }


    /// <summary>
    /// Gets the program.
    /// </summary>
    /// <returns>
    /// Program having role and funtional details
    /// </returns>
    public Program GetProgram()
    {
      var document = new XmlDocument();
      document.Load(xmlFilePath);
      return XmlHelper.Deserialize<Program>(document.InnerXml);
    }
  }
}
