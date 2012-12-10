// -----------------------------------------------------------------------
// <copyright file="XMLHelper.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IMaps.Framework.Data
{
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Runtime.Serialization;
  using System.Text;
  using System.Xml;
  using System.Xml.Serialization;

  /// <summary>
  /// Helper methods for xml data
  /// </summary>
  public static class XmlHelper
  {
   
    /// <summary>
    /// Deserializes the specified XML into the specified type
    /// </summary>
    /// <typeparam name="T">The type into which the XML would be deserialized</typeparam>
    /// <param name="xml">XML which would be deserialized</param>
    /// <returns>
    /// An inatnce of type T
    /// </returns>
    public static T Deserialize<T>(string xml)
    {
      return Deserialize<T>(xml, null);
    }

    /// <summary>
    /// Deserializes the specified XML into the specified type
    /// </summary>
    /// <typeparam name="T">The type into which the XML would be deserialized</typeparam>
    /// <param name="xml">XML which would be deserialized</param>
    /// <param name="knownTypes">The known types.</param>
    /// <returns>
    /// An inatnce of type T
    /// </returns>
    public static T Deserialize<T>(string xml, List<Type> knownTypes)
    {
      T obj = default(T);

      if (!string.IsNullOrEmpty(xml))
      {
        var dataContractSerializer = new DataContractSerializer(typeof(T), knownTypes);
        using (var stringReader = new StringReader(xml))
        {
          var xmlReader = XmlReader.Create(stringReader);

          obj = (T)dataContractSerializer.ReadObject(xmlReader);
        }
      }

      return obj;
    }

    /// <summary>
    /// Use this method to create / update a Test data file from apopulated object
    /// </summary>
    /// <typeparam name="T">The type of the object to serialise</typeparam>
    /// <param name="toSerialise">The object to serialise to a file</param>
    /// <param name="testFilePath">The path to the file to create / update</param>
    public static void Serialize<T>(T toSerialise, string testFilePath)
    {
      Serialize(toSerialise, testFilePath, null);
    }

    /// <summary>
    /// Use this method to create / update a Test data file from apopulated object
    /// </summary>
    /// <typeparam name="T">The type of the object to serialise</typeparam>
    /// <param name="toSerialise">The object to serialise to a file</param>
    /// <param name="testFilePath">The path to the file to create / update</param>
    /// <param name="knownTypes">A List of known types to use with the data contract serialiser</param>
    public static void Serialize<T>(T toSerialise, string testFilePath, List<Type> knownTypes)
    {
      var serialiser = knownTypes != null ? new DataContractSerializer(typeof(T), knownTypes) : new DataContractSerializer(typeof(T));

      var settings = new XmlWriterSettings { Indent = true };

      using (var w = XmlWriter.Create(testFilePath, settings))
      {
        serialiser.WriteObject(w, toSerialise);
      }
    }

    /// <summary>
    /// Use this method to create / update a Test data file from apopulated object
    /// </summary>
    /// <typeparam name="T">The type of the object to serialise</typeparam>
    /// <param name="toSerialise">The object to serialise to a file</param>
    /// <returns>
    /// String representing the serialized object
    /// </returns>
    public static string Serialize<T>(T toSerialise)
    {
      var types = new List<Type> { typeof(T) };
      return Serialize(toSerialise, types);
    }

    /// <summary>
    /// Use this method to create / update a Test data file from apopulated object
    /// </summary>
    /// <typeparam name="T">The type of the object to serialise</typeparam>
    /// <param name="toSerialise">The object to serialise to a file</param>
    /// <param name="knownTypes">The known types.</param>
    /// <returns>
    /// String representing the serialized object
    /// </returns>
    public static string Serialize<T>(T toSerialise, List<Type> knownTypes)
    {
      var objectXml = new StringBuilder();
      var x = new DataContractSerializer(typeof(T), knownTypes);
      var settings = new XmlWriterSettings { Indent = true };

      using (var w = XmlWriter.Create(objectXml, settings))
      {
        x.WriteObject(w, toSerialise);
      }

      return objectXml.ToString();
    }
  }
}
