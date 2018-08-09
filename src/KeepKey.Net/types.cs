// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: types.proto

namespace KeepKey.Net.Contracts
{

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
    [global::ProtoBuf.ProtoContract()]
    public partial class HDNodeType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"depth", IsRequired = true)]
        public uint Depth { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"fingerprint", IsRequired = true)]
        public uint Fingerprint { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"child_num", IsRequired = true)]
        public uint ChildNum { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"chain_code", IsRequired = true)]
        public byte[] ChainCode { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"private_key")]
        public byte[] PrivateKey
        {
            get { return __pbn__PrivateKey; }
            set { __pbn__PrivateKey = value; }
        }
        public bool ShouldSerializePrivateKey() => __pbn__PrivateKey != null;
        public void ResetPrivateKey() => __pbn__PrivateKey = null;
        private byte[] __pbn__PrivateKey;

        [global::ProtoBuf.ProtoMember(6, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HDNodePathType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"node", IsRequired = true)]
        public HDNodeType Node { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CoinType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"coin_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CoinName
        {
            get { return __pbn__CoinName ?? ""; }
            set { __pbn__CoinName = value; }
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [global::ProtoBuf.ProtoMember(2, Name = @"coin_shortcut")]
        [global::System.ComponentModel.DefaultValue("")]
        public string CoinShortcut
        {
            get { return __pbn__CoinShortcut ?? ""; }
            set { __pbn__CoinShortcut = value; }
        }
        public bool ShouldSerializeCoinShortcut() => __pbn__CoinShortcut != null;
        public void ResetCoinShortcut() => __pbn__CoinShortcut = null;
        private string __pbn__CoinShortcut;

        [global::ProtoBuf.ProtoMember(3, Name = @"address_type")]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint AddressType
        {
            get { return __pbn__AddressType ?? 0; }
            set { __pbn__AddressType = value; }
        }
        public bool ShouldSerializeAddressType() => __pbn__AddressType != null;
        public void ResetAddressType() => __pbn__AddressType = null;
        private uint? __pbn__AddressType;

        [global::ProtoBuf.ProtoMember(4, Name = @"maxfee_kb")]
        public ulong MaxfeeKb
        {
            get { return __pbn__MaxfeeKb.GetValueOrDefault(); }
            set { __pbn__MaxfeeKb = value; }
        }
        public bool ShouldSerializeMaxfeeKb() => __pbn__MaxfeeKb != null;
        public void ResetMaxfeeKb() => __pbn__MaxfeeKb = null;
        private ulong? __pbn__MaxfeeKb;

        [global::ProtoBuf.ProtoMember(5, Name = @"address_type_p2sh")]
        [global::System.ComponentModel.DefaultValue(5)]
        public uint AddressTypeP2sh
        {
            get { return __pbn__AddressTypeP2sh ?? 5; }
            set { __pbn__AddressTypeP2sh = value; }
        }
        public bool ShouldSerializeAddressTypeP2sh() => __pbn__AddressTypeP2sh != null;
        public void ResetAddressTypeP2sh() => __pbn__AddressTypeP2sh = null;
        private uint? __pbn__AddressTypeP2sh;

        [global::ProtoBuf.ProtoMember(6, Name = @"address_type_p2wpkh")]
        [global::System.ComponentModel.DefaultValue(6)]
        public uint AddressTypeP2wpkh
        {
            get { return __pbn__AddressTypeP2wpkh ?? 6; }
            set { __pbn__AddressTypeP2wpkh = value; }
        }
        public bool ShouldSerializeAddressTypeP2wpkh() => __pbn__AddressTypeP2wpkh != null;
        public void ResetAddressTypeP2wpkh() => __pbn__AddressTypeP2wpkh = null;
        private uint? __pbn__AddressTypeP2wpkh;

        [global::ProtoBuf.ProtoMember(7, Name = @"address_type_p2wsh")]
        [global::System.ComponentModel.DefaultValue(10)]
        public uint AddressTypeP2wsh
        {
            get { return __pbn__AddressTypeP2wsh ?? 10; }
            set { __pbn__AddressTypeP2wsh = value; }
        }
        public bool ShouldSerializeAddressTypeP2wsh() => __pbn__AddressTypeP2wsh != null;
        public void ResetAddressTypeP2wsh() => __pbn__AddressTypeP2wsh = null;
        private uint? __pbn__AddressTypeP2wsh;

        [global::ProtoBuf.ProtoMember(8, Name = @"signed_message_header")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SignedMessageHeader
        {
            get { return __pbn__SignedMessageHeader ?? ""; }
            set { __pbn__SignedMessageHeader = value; }
        }
        public bool ShouldSerializeSignedMessageHeader() => __pbn__SignedMessageHeader != null;
        public void ResetSignedMessageHeader() => __pbn__SignedMessageHeader = null;
        private string __pbn__SignedMessageHeader;

        [global::ProtoBuf.ProtoMember(9, Name = @"bip44_account_path")]
        public uint Bip44AccountPath
        {
            get { return __pbn__Bip44AccountPath.GetValueOrDefault(); }
            set { __pbn__Bip44AccountPath = value; }
        }
        public bool ShouldSerializeBip44AccountPath() => __pbn__Bip44AccountPath != null;
        public void ResetBip44AccountPath() => __pbn__Bip44AccountPath = null;
        private uint? __pbn__Bip44AccountPath;

        [global::ProtoBuf.ProtoMember(12, Name = @"forkid")]
        public uint Forkid
        {
            get { return __pbn__Forkid.GetValueOrDefault(); }
            set { __pbn__Forkid = value; }
        }
        public bool ShouldSerializeForkid() => __pbn__Forkid != null;
        public void ResetForkid() => __pbn__Forkid = null;
        private uint? __pbn__Forkid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MultisigRedeemScriptType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pubkeys")]
        public global::System.Collections.Generic.List<HDNodePathType> Pubkeys { get; } = new global::System.Collections.Generic.List<HDNodePathType>();

        [global::ProtoBuf.ProtoMember(2, Name = @"signatures")]
        public global::System.Collections.Generic.List<byte[]> Signatures { get; } = new global::System.Collections.Generic.List<byte[]>();

        [global::ProtoBuf.ProtoMember(3, Name = @"m")]
        public uint M
        {
            get { return __pbn__M.GetValueOrDefault(); }
            set { __pbn__M = value; }
        }
        public bool ShouldSerializeM() => __pbn__M != null;
        public void ResetM() => __pbn__M = null;
        private uint? __pbn__M;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxInputType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"prev_hash", IsRequired = true)]
        public byte[] PrevHash { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"prev_index", IsRequired = true)]
        public uint PrevIndex { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"script_sig")]
        public byte[] ScriptSig
        {
            get { return __pbn__ScriptSig; }
            set { __pbn__ScriptSig = value; }
        }
        public bool ShouldSerializeScriptSig() => __pbn__ScriptSig != null;
        public void ResetScriptSig() => __pbn__ScriptSig = null;
        private byte[] __pbn__ScriptSig;

        [global::ProtoBuf.ProtoMember(5, Name = @"sequence")]
        [global::System.ComponentModel.DefaultValue(4294967295)]
        public uint Sequence
        {
            get { return __pbn__Sequence ?? 4294967295; }
            set { __pbn__Sequence = value; }
        }
        public bool ShouldSerializeSequence() => __pbn__Sequence != null;
        public void ResetSequence() => __pbn__Sequence = null;
        private uint? __pbn__Sequence;

        [global::ProtoBuf.ProtoMember(6, Name = @"script_type")]
        [global::System.ComponentModel.DefaultValue(InputScriptType.Spendaddress)]
        public InputScriptType ScriptType
        {
            get { return __pbn__ScriptType ?? InputScriptType.Spendaddress; }
            set { __pbn__ScriptType = value; }
        }
        public bool ShouldSerializeScriptType() => __pbn__ScriptType != null;
        public void ResetScriptType() => __pbn__ScriptType = null;
        private InputScriptType? __pbn__ScriptType;

        [global::ProtoBuf.ProtoMember(7, Name = @"multisig")]
        public MultisigRedeemScriptType Multisig { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"amount")]
        public ulong Amount
        {
            get { return __pbn__Amount.GetValueOrDefault(); }
            set { __pbn__Amount = value; }
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private ulong? __pbn__Amount;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxOutputType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address
        {
            get { return __pbn__Address ?? ""; }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

        [global::ProtoBuf.ProtoMember(2, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"amount", IsRequired = true)]
        public ulong Amount { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"script_type", IsRequired = true)]
        public OutputScriptType ScriptType { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"multisig")]
        public MultisigRedeemScriptType Multisig { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"op_return_data")]
        public byte[] OpReturnData
        {
            get { return __pbn__OpReturnData; }
            set { __pbn__OpReturnData = value; }
        }
        public bool ShouldSerializeOpReturnData() => __pbn__OpReturnData != null;
        public void ResetOpReturnData() => __pbn__OpReturnData = null;
        private byte[] __pbn__OpReturnData;

        [global::ProtoBuf.ProtoMember(7, Name = @"address_type")]
        [global::System.ComponentModel.DefaultValue(OutputAddressType.Spend)]
        public OutputAddressType AddressType
        {
            get { return __pbn__AddressType ?? OutputAddressType.Spend; }
            set { __pbn__AddressType = value; }
        }
        public bool ShouldSerializeAddressType() => __pbn__AddressType != null;
        public void ResetAddressType() => __pbn__AddressType = null;
        private OutputAddressType? __pbn__AddressType;

        [global::ProtoBuf.ProtoMember(8, Name = @"exchange_type")]
        public ExchangeType ExchangeType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxOutputBinType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"amount", IsRequired = true)]
        public ulong Amount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"script_pubkey", IsRequired = true)]
        public byte[] ScriptPubkey { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TransactionType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"version")]
        public uint Version
        {
            get { return __pbn__Version.GetValueOrDefault(); }
            set { __pbn__Version = value; }
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [global::ProtoBuf.ProtoMember(2, Name = @"inputs")]
        public global::System.Collections.Generic.List<TxInputType> Inputs { get; } = new global::System.Collections.Generic.List<TxInputType>();

        [global::ProtoBuf.ProtoMember(3, Name = @"bin_outputs")]
        public global::System.Collections.Generic.List<TxOutputBinType> BinOutputs { get; } = new global::System.Collections.Generic.List<TxOutputBinType>();

        [global::ProtoBuf.ProtoMember(5, Name = @"outputs")]
        public global::System.Collections.Generic.List<TxOutputType> Outputs { get; } = new global::System.Collections.Generic.List<TxOutputType>();

        [global::ProtoBuf.ProtoMember(4, Name = @"lock_time")]
        public uint LockTime
        {
            get { return __pbn__LockTime.GetValueOrDefault(); }
            set { __pbn__LockTime = value; }
        }
        public bool ShouldSerializeLockTime() => __pbn__LockTime != null;
        public void ResetLockTime() => __pbn__LockTime = null;
        private uint? __pbn__LockTime;

        [global::ProtoBuf.ProtoMember(6, Name = @"inputs_cnt")]
        public uint InputsCnt
        {
            get { return __pbn__InputsCnt.GetValueOrDefault(); }
            set { __pbn__InputsCnt = value; }
        }
        public bool ShouldSerializeInputsCnt() => __pbn__InputsCnt != null;
        public void ResetInputsCnt() => __pbn__InputsCnt = null;
        private uint? __pbn__InputsCnt;

        [global::ProtoBuf.ProtoMember(7, Name = @"outputs_cnt")]
        public uint OutputsCnt
        {
            get { return __pbn__OutputsCnt.GetValueOrDefault(); }
            set { __pbn__OutputsCnt = value; }
        }
        public bool ShouldSerializeOutputsCnt() => __pbn__OutputsCnt != null;
        public void ResetOutputsCnt() => __pbn__OutputsCnt = null;
        private uint? __pbn__OutputsCnt;

        [global::ProtoBuf.ProtoMember(8, Name = @"extra_data")]
        public byte[] ExtraData
        {
            get { return __pbn__ExtraData; }
            set { __pbn__ExtraData = value; }
        }
        public bool ShouldSerializeExtraData() => __pbn__ExtraData != null;
        public void ResetExtraData() => __pbn__ExtraData = null;
        private byte[] __pbn__ExtraData;

        [global::ProtoBuf.ProtoMember(9, Name = @"extra_data_len")]
        public uint ExtraDataLen
        {
            get { return __pbn__ExtraDataLen.GetValueOrDefault(); }
            set { __pbn__ExtraDataLen = value; }
        }
        public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
        public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
        private uint? __pbn__ExtraDataLen;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RawTransactionType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"payload", IsRequired = true)]
        public byte[] Payload { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxRequestDetailsType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"request_index")]
        public uint RequestIndex
        {
            get { return __pbn__RequestIndex.GetValueOrDefault(); }
            set { __pbn__RequestIndex = value; }
        }
        public bool ShouldSerializeRequestIndex() => __pbn__RequestIndex != null;
        public void ResetRequestIndex() => __pbn__RequestIndex = null;
        private uint? __pbn__RequestIndex;

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_hash")]
        public byte[] TxHash
        {
            get { return __pbn__TxHash; }
            set { __pbn__TxHash = value; }
        }
        public bool ShouldSerializeTxHash() => __pbn__TxHash != null;
        public void ResetTxHash() => __pbn__TxHash = null;
        private byte[] __pbn__TxHash;

        [global::ProtoBuf.ProtoMember(3, Name = @"extra_data_len")]
        public uint ExtraDataLen
        {
            get { return __pbn__ExtraDataLen.GetValueOrDefault(); }
            set { __pbn__ExtraDataLen = value; }
        }
        public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
        public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
        private uint? __pbn__ExtraDataLen;

        [global::ProtoBuf.ProtoMember(4, Name = @"extra_data_offset")]
        public uint ExtraDataOffset
        {
            get { return __pbn__ExtraDataOffset.GetValueOrDefault(); }
            set { __pbn__ExtraDataOffset = value; }
        }
        public bool ShouldSerializeExtraDataOffset() => __pbn__ExtraDataOffset != null;
        public void ResetExtraDataOffset() => __pbn__ExtraDataOffset = null;
        private uint? __pbn__ExtraDataOffset;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TxRequestSerializedType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature_index")]
        public uint SignatureIndex
        {
            get { return __pbn__SignatureIndex.GetValueOrDefault(); }
            set { __pbn__SignatureIndex = value; }
        }
        public bool ShouldSerializeSignatureIndex() => __pbn__SignatureIndex != null;
        public void ResetSignatureIndex() => __pbn__SignatureIndex = null;
        private uint? __pbn__SignatureIndex;

        [global::ProtoBuf.ProtoMember(2, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

        [global::ProtoBuf.ProtoMember(3, Name = @"serialized_tx")]
        public byte[] SerializedTx
        {
            get { return __pbn__SerializedTx; }
            set { __pbn__SerializedTx = value; }
        }
        public bool ShouldSerializeSerializedTx() => __pbn__SerializedTx != null;
        public void ResetSerializedTx() => __pbn__SerializedTx = null;
        private byte[] __pbn__SerializedTx;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IdentityType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proto")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Proto
        {
            get { return __pbn__Proto ?? ""; }
            set { __pbn__Proto = value; }
        }
        public bool ShouldSerializeProto() => __pbn__Proto != null;
        public void ResetProto() => __pbn__Proto = null;
        private string __pbn__Proto;

        [global::ProtoBuf.ProtoMember(2, Name = @"user")]
        [global::System.ComponentModel.DefaultValue("")]
        public string User
        {
            get { return __pbn__User ?? ""; }
            set { __pbn__User = value; }
        }
        public bool ShouldSerializeUser() => __pbn__User != null;
        public void ResetUser() => __pbn__User = null;
        private string __pbn__User;

        [global::ProtoBuf.ProtoMember(3, Name = @"host")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Host
        {
            get { return __pbn__Host ?? ""; }
            set { __pbn__Host = value; }
        }
        public bool ShouldSerializeHost() => __pbn__Host != null;
        public void ResetHost() => __pbn__Host = null;
        private string __pbn__Host;

        [global::ProtoBuf.ProtoMember(4, Name = @"port")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Port
        {
            get { return __pbn__Port ?? ""; }
            set { __pbn__Port = value; }
        }
        public bool ShouldSerializePort() => __pbn__Port != null;
        public void ResetPort() => __pbn__Port = null;
        private string __pbn__Port;

        [global::ProtoBuf.ProtoMember(5, Name = @"path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Path
        {
            get { return __pbn__Path ?? ""; }
            set { __pbn__Path = value; }
        }
        public bool ShouldSerializePath() => __pbn__Path != null;
        public void ResetPath() => __pbn__Path = null;
        private string __pbn__Path;

        [global::ProtoBuf.ProtoMember(6, Name = @"index")]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint Index
        {
            get { return __pbn__Index ?? 0; }
            set { __pbn__Index = value; }
        }
        public bool ShouldSerializeIndex() => __pbn__Index != null;
        public void ResetIndex() => __pbn__Index = null;
        private uint? __pbn__Index;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PolicyType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"policy_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PolicyName
        {
            get { return __pbn__PolicyName ?? ""; }
            set { __pbn__PolicyName = value; }
        }
        public bool ShouldSerializePolicyName() => __pbn__PolicyName != null;
        public void ResetPolicyName() => __pbn__PolicyName = null;
        private string __pbn__PolicyName;

        [global::ProtoBuf.ProtoMember(2, Name = @"enabled")]
        public bool Enabled
        {
            get { return __pbn__Enabled.GetValueOrDefault(); }
            set { __pbn__Enabled = value; }
        }
        public bool ShouldSerializeEnabled() => __pbn__Enabled != null;
        public void ResetEnabled() => __pbn__Enabled = null;
        private bool? __pbn__Enabled;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ExchangeType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signed_exchange_response")]
        public SignedExchangeResponse SignedExchangeResponse { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"withdrawal_coin_name")]
        [global::System.ComponentModel.DefaultValue(@"Bitcoin")]
        public string WithdrawalCoinName
        {
            get { return __pbn__WithdrawalCoinName ?? @"Bitcoin"; }
            set { __pbn__WithdrawalCoinName = value; }
        }
        public bool ShouldSerializeWithdrawalCoinName() => __pbn__WithdrawalCoinName != null;
        public void ResetWithdrawalCoinName() => __pbn__WithdrawalCoinName = null;
        private string __pbn__WithdrawalCoinName;

        [global::ProtoBuf.ProtoMember(3, Name = @"withdrawal_address_n")]
        public uint[] WithdrawalAddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"return_address_n")]
        public uint[] ReturnAddressNs { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum FailureType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_UnexpectedMessage")]
        FailureUnexpectedMessage = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_ButtonExpected")]
        FailureButtonExpected = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_SyntaxError")]
        FailureSyntaxError = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_ActionCancelled")]
        FailureActionCancelled = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinExpected")]
        FailurePinExpected = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinCancelled")]
        FailurePinCancelled = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinInvalid")]
        FailurePinInvalid = 7,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_InvalidSignature")]
        FailureInvalidSignature = 8,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_Other")]
        FailureOther = 9,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_NotEnoughFunds")]
        FailureNotEnoughFunds = 10,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_NotInitialized")]
        FailureNotInitialized = 11,
        [global::ProtoBuf.ProtoEnum(Name = @"Failure_FirmwareError")]
        FailureFirmwareError = 99,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum OutputScriptType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"PAYTOADDRESS")]
        Paytoaddress = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"PAYTOSCRIPTHASH")]
        Paytoscripthash = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"PAYTOMULTISIG")]
        Paytomultisig = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"PAYTOOPRETURN")]
        Paytoopreturn = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"PAYTOWITNESS")]
        Paytowitness = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"PAYTOP2SHWITNESS")]
        Paytop2shwitness = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum InputScriptType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDADDRESS")]
        Spendaddress = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDMULTISIG")]
        Spendmultisig = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"EXTERNAL")]
        External = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDWITNESS")]
        Spendwitness = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDP2SHWITNESS")]
        Spendp2shwitness = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum RequestType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"TXINPUT")]
        Txinput = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"TXOUTPUT")]
        Txoutput = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"TXMETA")]
        Txmeta = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"TXFINISHED")]
        Txfinished = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"TXEXTRADATA")]
        Txextradata = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum OutputAddressType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SPEND")]
        Spend = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"TRANSFER")]
        Transfer = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"CHANGE")]
        Change = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"EXCHANGE")]
        Exchange = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ButtonRequestType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Other")]
        ButtonRequestOther = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FeeOverThreshold")]
        ButtonRequestFeeOverThreshold = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmOutput")]
        ButtonRequestConfirmOutput = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ResetDevice")]
        ButtonRequestResetDevice = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmWord")]
        ButtonRequestConfirmWord = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_WipeDevice")]
        ButtonRequestWipeDevice = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ProtectCall")]
        ButtonRequestProtectCall = 7,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_SignTx")]
        ButtonRequestSignTx = 8,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FirmwareCheck")]
        ButtonRequestFirmwareCheck = 9,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Address")]
        ButtonRequestAddress = 10,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FirmwareErase")]
        ButtonRequestFirmwareErase = 11,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmTransferToAccount")]
        ButtonRequestConfirmTransferToAccount = 12,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmTransferToNodePath")]
        ButtonRequestConfirmTransferToNodePath = 13,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ChangeLabel")]
        ButtonRequestChangeLabel = 14,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ChangeLanguage")]
        ButtonRequestChangeLanguage = 15,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_EnablePassphrase")]
        ButtonRequestEnablePassphrase = 16,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_DisablePassphrase")]
        ButtonRequestDisablePassphrase = 17,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_EncryptAndSignMessage")]
        ButtonRequestEncryptAndSignMessage = 18,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_EncryptMessage")]
        ButtonRequestEncryptMessage = 19,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ImportPrivateKey")]
        ButtonRequestImportPrivateKey = 20,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ImportRecoverySentence")]
        ButtonRequestImportRecoverySentence = 21,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_SignIdentity")]
        ButtonRequestSignIdentity = 22,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Ping")]
        ButtonRequestPing = 23,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_RemovePin")]
        ButtonRequestRemovePin = 24,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ChangePin")]
        ButtonRequestChangePin = 25,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_CreatePin")]
        ButtonRequestCreatePin = 26,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_GetEntropy")]
        ButtonRequestGetEntropy = 27,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_SignMessage")]
        ButtonRequestSignMessage = 28,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ApplyPolicies")]
        ButtonRequestApplyPolicies = 29,
        [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_SignExchange")]
        ButtonRequestSignExchange = 30,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum PinMatrixRequestType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_Current")]
        PinMatrixRequestTypeCurrent = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewFirst")]
        PinMatrixRequestTypeNewFirst = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewSecond")]
        PinMatrixRequestTypeNewSecond = 3,
    }

    //Comment out the code that doesn't compile
    /*
    public static class Extensions
    {
        public static bool GetWireIn(this global::google.protobuf.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50002);

        public static void SetWireIn(this global::google.protobuf.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50002, value);

        public static bool GetWireOut(this global::google.protobuf.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50003);

        public static void SetWireOut(this global::google.protobuf.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50003, value);

        public static bool GetWireDebugIn(this global::google.protobuf.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50004);

        public static void SetWireDebugIn(this global::google.protobuf.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50004, value);

        public static bool GetWireDebugOut(this global::google.protobuf.EnumValueOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<bool>(obj, 50005);

        public static void SetWireDebugOut(this global::google.protobuf.EnumValueOptions obj, bool value)
            => global::ProtoBuf.Extensible.AppendValue<bool>(obj, 50005, value);

    }
    */
#pragma warning restore CS1591, CS0612, CS3021, IDE1006

}