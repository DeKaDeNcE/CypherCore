// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/user_manager_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol.UserManager.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/user_manager_types.proto</summary>
  public static partial class UserManagerTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/user_manager_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserManagerTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipiZ3MvbG93L3BiL2NsaWVudC91c2VyX21hbmFnZXJfdHlwZXMucHJvdG8S",
            "HGJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEaJGJncy9sb3cvcGIvY2xp",
            "ZW50L2VudGl0eV90eXBlcy5wcm90bxonYmdzL2xvdy9wYi9jbGllbnQvYXR0",
            "cmlidXRlX3R5cGVzLnByb3RvIrQBCgxSZWNlbnRQbGF5ZXISKQoJZW50aXR5",
            "X2lkGAEgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEg8KB3Byb2dyYW0Y",
            "AiABKAkSGAoQdGltZXN0YW1wX3BsYXllZBgDIAEoBhIrCgphdHRyaWJ1dGVz",
            "GAQgAygLMhcuYmdzLnByb3RvY29sLkF0dHJpYnV0ZRINCgJpZBgFIAEoBzoB",
            "MBISCgdjb3VudGVyGAYgASgHOgEwInIKDUJsb2NrZWRQbGF5ZXISKgoKYWNj",
            "b3VudF9pZBgBIAIoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIMCgRuYW1l",
            "GAIgASgJEhAKBHJvbGUYAyADKA1CAhABEhUKCnByaXZpbGVnZXMYBCABKAQ6",
            "ATA="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.EntityTypesReflection.Descriptor, global::Bgs.Protocol.AttributeTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.UserManager.V1.RecentPlayer), global::Bgs.Protocol.UserManager.V1.RecentPlayer.Parser, new[]{ "EntityId", "Program", "TimestampPlayed", "Attributes", "Id", "Counter" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.UserManager.V1.BlockedPlayer), global::Bgs.Protocol.UserManager.V1.BlockedPlayer.Parser, new[]{ "AccountId", "Name", "Role", "Privileges" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RecentPlayer : pb::IMessage<RecentPlayer> {
    private static readonly pb::MessageParser<RecentPlayer> _parser = new pb::MessageParser<RecentPlayer>(() => new RecentPlayer());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RecentPlayer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.UserManager.V1.UserManagerTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecentPlayer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecentPlayer(RecentPlayer other) : this() {
      _hasBits0 = other._hasBits0;
      entityId_ = other.HasEntityId ? other.entityId_.Clone() : null;
      program_ = other.program_;
      timestampPlayed_ = other.timestampPlayed_;
      attributes_ = other.attributes_.Clone();
      id_ = other.id_;
      counter_ = other.counter_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecentPlayer Clone() {
      return new RecentPlayer(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::Bgs.Protocol.EntityId entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.EntityId EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }
    /// <summary>Gets whether the entity_id field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasEntityId {
      get { return entityId_ != null; }
    }
    /// <summary>Clears the value of the entity_id field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEntityId() {
      entityId_ = null;
    }

    /// <summary>Field number for the "program" field.</summary>
    public const int ProgramFieldNumber = 2;
    private readonly static string ProgramDefaultValue = "";

    private string program_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Program {
      get { return program_ ?? ProgramDefaultValue; }
      set {
        program_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "program" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasProgram {
      get { return program_ != null; }
    }
    /// <summary>Clears the value of the "program" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearProgram() {
      program_ = null;
    }

    /// <summary>Field number for the "timestamp_played" field.</summary>
    public const int TimestampPlayedFieldNumber = 3;
    private readonly static ulong TimestampPlayedDefaultValue = 0UL;

    private ulong timestampPlayed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TimestampPlayed {
      get { if ((_hasBits0 & 1) != 0) { return timestampPlayed_; } else { return TimestampPlayedDefaultValue; } }
      set {
        _hasBits0 |= 1;
        timestampPlayed_ = value;
      }
    }
    /// <summary>Gets whether the "timestamp_played" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasTimestampPlayed {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "timestamp_played" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTimestampPlayed() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "attributes" field.</summary>
    public const int AttributesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.Attribute> _repeated_attributes_codec
        = pb::FieldCodec.ForMessage(34, global::Bgs.Protocol.Attribute.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.Attribute> attributes_ = new pbc::RepeatedField<global::Bgs.Protocol.Attribute>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Bgs.Protocol.Attribute> Attributes {
      get { return attributes_; }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 5;
    private readonly static uint IdDefaultValue = 0;

    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { if ((_hasBits0 & 2) != 0) { return id_; } else { return IdDefaultValue; } }
      set {
        _hasBits0 |= 2;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "counter" field.</summary>
    public const int CounterFieldNumber = 6;
    private readonly static uint CounterDefaultValue = 0;

    private uint counter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Counter {
      get { if ((_hasBits0 & 4) != 0) { return counter_; } else { return CounterDefaultValue; } }
      set {
        _hasBits0 |= 4;
        counter_ = value;
      }
    }
    /// <summary>Gets whether the "counter" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCounter {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "counter" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCounter() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RecentPlayer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RecentPlayer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Program != other.Program) return false;
      if (TimestampPlayed != other.TimestampPlayed) return false;
      if(!attributes_.Equals(other.attributes_)) return false;
      if (Id != other.Id) return false;
      if (Counter != other.Counter) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasEntityId) hash ^= EntityId.GetHashCode();
      if (HasProgram) hash ^= Program.GetHashCode();
      if (HasTimestampPlayed) hash ^= TimestampPlayed.GetHashCode();
      hash ^= attributes_.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasCounter) hash ^= Counter.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasEntityId) {
        output.WriteRawTag(10);
        output.WriteMessage(EntityId);
      }
      if (HasProgram) {
        output.WriteRawTag(18);
        output.WriteString(Program);
      }
      if (HasTimestampPlayed) {
        output.WriteRawTag(25);
        output.WriteFixed64(TimestampPlayed);
      }
      attributes_.WriteTo(output, _repeated_attributes_codec);
      if (HasId) {
        output.WriteRawTag(45);
        output.WriteFixed32(Id);
      }
      if (HasCounter) {
        output.WriteRawTag(53);
        output.WriteFixed32(Counter);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasEntityId) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (HasProgram) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Program);
      }
      if (HasTimestampPlayed) {
        size += 1 + 8;
      }
      size += attributes_.CalculateSize(_repeated_attributes_codec);
      if (HasId) {
        size += 1 + 4;
      }
      if (HasCounter) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RecentPlayer other) {
      if (other == null) {
        return;
      }
      if (other.HasEntityId) {
        if (!HasEntityId) {
          EntityId = new global::Bgs.Protocol.EntityId();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.HasProgram) {
        Program = other.Program;
      }
      if (other.HasTimestampPlayed) {
        TimestampPlayed = other.TimestampPlayed;
      }
      attributes_.Add(other.attributes_);
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasCounter) {
        Counter = other.Counter;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (!HasEntityId) {
              EntityId = new global::Bgs.Protocol.EntityId();
            }
            input.ReadMessage(EntityId);
            break;
          }
          case 18: {
            Program = input.ReadString();
            break;
          }
          case 25: {
            TimestampPlayed = input.ReadFixed64();
            break;
          }
          case 34: {
            attributes_.AddEntriesFrom(input, _repeated_attributes_codec);
            break;
          }
          case 45: {
            Id = input.ReadFixed32();
            break;
          }
          case 53: {
            Counter = input.ReadFixed32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BlockedPlayer : pb::IMessage<BlockedPlayer> {
    private static readonly pb::MessageParser<BlockedPlayer> _parser = new pb::MessageParser<BlockedPlayer>(() => new BlockedPlayer());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BlockedPlayer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.UserManager.V1.UserManagerTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlockedPlayer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlockedPlayer(BlockedPlayer other) : this() {
      _hasBits0 = other._hasBits0;
      accountId_ = other.HasAccountId ? other.accountId_.Clone() : null;
      name_ = other.name_;
      role_ = other.role_.Clone();
      privileges_ = other.privileges_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlockedPlayer Clone() {
      return new BlockedPlayer(this);
    }

    /// <summary>Field number for the "account_id" field.</summary>
    public const int AccountIdFieldNumber = 1;
    private global::Bgs.Protocol.EntityId accountId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.EntityId AccountId {
      get { return accountId_; }
      set {
        accountId_ = value;
      }
    }
    /// <summary>Gets whether the account_id field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAccountId {
      get { return accountId_ != null; }
    }
    /// <summary>Clears the value of the account_id field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAccountId() {
      accountId_ = null;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private readonly static string NameDefaultValue = "";

    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_ ?? NameDefaultValue; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "role" field.</summary>
    public const int RoleFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_role_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> role_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> Role {
      get { return role_; }
    }

    /// <summary>Field number for the "privileges" field.</summary>
    public const int PrivilegesFieldNumber = 4;
    private readonly static ulong PrivilegesDefaultValue = 0UL;

    private ulong privileges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Privileges {
      get { if ((_hasBits0 & 1) != 0) { return privileges_; } else { return PrivilegesDefaultValue; } }
      set {
        _hasBits0 |= 1;
        privileges_ = value;
      }
    }
    /// <summary>Gets whether the "privileges" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasPrivileges {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "privileges" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPrivileges() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BlockedPlayer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BlockedPlayer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AccountId, other.AccountId)) return false;
      if (Name != other.Name) return false;
      if(!role_.Equals(other.role_)) return false;
      if (Privileges != other.Privileges) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasAccountId) hash ^= AccountId.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      hash ^= role_.GetHashCode();
      if (HasPrivileges) hash ^= Privileges.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasAccountId) {
        output.WriteRawTag(10);
        output.WriteMessage(AccountId);
      }
      if (HasName) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      role_.WriteTo(output, _repeated_role_codec);
      if (HasPrivileges) {
        output.WriteRawTag(32);
        output.WriteUInt64(Privileges);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasAccountId) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccountId);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += role_.CalculateSize(_repeated_role_codec);
      if (HasPrivileges) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Privileges);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BlockedPlayer other) {
      if (other == null) {
        return;
      }
      if (other.HasAccountId) {
        if (!HasAccountId) {
          AccountId = new global::Bgs.Protocol.EntityId();
        }
        AccountId.MergeFrom(other.AccountId);
      }
      if (other.HasName) {
        Name = other.Name;
      }
      role_.Add(other.role_);
      if (other.HasPrivileges) {
        Privileges = other.Privileges;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (!HasAccountId) {
              AccountId = new global::Bgs.Protocol.EntityId();
            }
            input.ReadMessage(AccountId);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            role_.AddEntriesFrom(input, _repeated_role_codec);
            break;
          }
          case 32: {
            Privileges = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
