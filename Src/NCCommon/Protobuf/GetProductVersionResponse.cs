//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetProductVersionResponse.proto
// Note: requires additional types generated from: Commands/ProductVersion.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetProductVersionResponse")]
  public partial class GetProductVersionResponse : global::ProtoBuf.IExtensible
  {
    public GetProductVersionResponse() {}
    
    private Alachisoft.NCache.Common.Protobuf.ProductVersion _productVersion;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"productVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Alachisoft.NCache.Common.Protobuf.ProductVersion productVersion
    {
      get { return _productVersion; }
      set { _productVersion = value; }
    }

    private int _commandID = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"commandID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int commandID
    {
      get { return _commandID; }
      set { _commandID = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}