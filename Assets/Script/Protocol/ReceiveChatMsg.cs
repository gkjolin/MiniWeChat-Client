//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ReceiveChatMsg.proto
// Note: requires additional types generated from: ChatData.proto
namespace protocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReceiveChatReq")]
  public partial class ReceiveChatReq : global::ProtoBuf.IExtensible
  {
    public ReceiveChatReq() {}
    
    private readonly global::System.Collections.Generic.List<protocol.ChatItem> _chatData = new global::System.Collections.Generic.List<protocol.ChatItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"chatData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<protocol.ChatItem> chatData
    {
      get { return _chatData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReceiveChatRsp")]
  public partial class ReceiveChatRsp : global::ProtoBuf.IExtensible
  {
    public ReceiveChatRsp() {}
    
    private protocol.ReceiveChatRsp.ResultCode _resultCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"resultCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public protocol.ReceiveChatRsp.ResultCode resultCode
    {
      get { return _resultCode; }
      set { _resultCode = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ResultCode")]
    public enum ResultCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SUCCESS", Value=0)]
      SUCCESS = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FAIL", Value=1)]
      FAIL = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}