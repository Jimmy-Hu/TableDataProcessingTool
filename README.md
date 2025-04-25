# TableDataProcessingTool

TableDataProcessingTool is just like its name. It process table data and save it into ".sheets" file.

### Related CodeReview Questions

- Information of Selected Cells from DataGridView in C#
  
  https://codereview.stackexchange.com/q/295311/231235

### Write / Read ".sheets" file

#### Origin TableDataProcessingTool project

In the file"TableDataProcessingTool\TableDataProcessingTool\CSharpFiles\SheetFileStructure\SheetFileStructure.cs", the following code block deals with read / write (load / save) ".sheets" file.

```C#
public void Save(string Filename)
{
    WriteToBinaryFile<Tuple<string, List<SheetStructure>>>(
        Filename,
        new Tuple<string, List<SheetStructure>>(this.Filename, this.SheetStructures)
        );
}

public void Load(string Filename)
{
    var LoadedData = ReadFromBinaryFile<Tuple<string, List<SheetStructure>>>(Filename);
    this.Filename = LoadedData.Item1;
    this.SheetStructures = LoadedData.Item2;
}
```

where `WriteToBinaryFile` and `ReadFromBinaryFile` is as follows (in the same file as above).

```C#
/// <summary>
/// Writes the given object instance to a binary file.
/// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
/// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
/// Reference: https://stackoverflow.com/a/22425211/6667035
/// </summary>
/// <typeparam name="T">The type of object being written to the XML file.</typeparam>
/// <param name="filePath">The file path to write the object instance to.</param>
/// <param name="objectToWrite">The object instance to write to the XML file.</param>
/// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
private static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
{
    using (System.IO.Stream stream = System.IO.File.Open(filePath, append ? System.IO.FileMode.Append : System.IO.FileMode.Create))
    {
        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        binaryFormatter.Serialize(stream, objectToWrite);
    }
}

/// <summary>
/// Reads an object instance from a binary file.
/// Reference: https://stackoverflow.com/a/22425211/6667035
/// </summary>
/// <typeparam name="T">The type of object to read from the XML.</typeparam>
/// <param name="filePath">The file path to read the object instance from.</param>
/// <returns>Returns a new instance of the object read from the binary file.</returns>
private static T ReadFromBinaryFile<T>(string filePath)
{
    using (System.IO.Stream stream = System.IO.File.Open(filePath, System.IO.FileMode.Open))
    {
        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        return (T)binaryFormatter.Deserialize(stream);
    }
}
```

However, the usage of `System.Runtime.Serialization.Formatters.Binary.BinaryFormatter` for serializing / deserializing is obsolete and a new form of serializaton should be used. Therefore, the new project "TableDataProcessingTool2" is created.

