//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: account.txt
namespace GameStruct
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_AccountLog")]
  public partial class GM_AccountLog : global::ProtoBuf.IExtensible
  {
    public GM_AccountLog() {}
    
    private int _platformID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"platformID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int platformID
    {
      get { return _platformID; }
      set { _platformID = value; }
    }
    private string _ditchID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ditchID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ditchID
    {
      get { return _ditchID; }
      set { _ditchID = value; }
    }
    private string _version;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string version
    {
      get { return _version; }
      set { _version = value; }
    }
    private int _accountID;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"accountID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int accountID
    {
      get { return _accountID; }
      set { _accountID = value; }
    }
    private string _macAddress;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"macAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string macAddress
    {
      get { return _macAddress; }
      set { _macAddress = value; }
    }
    private string _deviceUUID;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"deviceUUID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string deviceUUID
    {
      get { return _deviceUUID; }
      set { _deviceUUID = value; }
    }

    private string _idfa = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"idfa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string idfa
    {
      get { return _idfa; }
      set { _idfa = value; }
    }

    private string _deviceType = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"deviceType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string deviceType
    {
      get { return _deviceType; }
      set { _deviceType = value; }
    }

    private string _networkType = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"networkType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string networkType
    {
      get { return _networkType; }
      set { _networkType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_AccountRequest")]
  public partial class GM_AccountRequest : global::ProtoBuf.IExtensible
  {
    public GM_AccountRequest() {}
    
    private string _m_AccountName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"m_AccountName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_AccountName
    {
      get { return _m_AccountName; }
      set { _m_AccountName = value; }
    }
    private string _m_Password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"m_Password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_Password
    {
      get { return _m_Password; }
      set { _m_Password = value; }
    }

    private int _platform = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"platform", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int platform
    {
      get { return _platform; }
      set { _platform = value; }
    }
    private GM_AccountLog _accountLogInfo;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"accountLogInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public GM_AccountLog accountLogInfo
    {
      get { return _accountLogInfo; }
      set { _accountLogInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_AccountReturn")]
  public partial class GM_AccountReturn : global::ProtoBuf.IExtensible
  {
    public GM_AccountReturn() {}
    
    private int _m_Result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"m_Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int m_Result
    {
      get { return _m_Result; }
      set { _m_Result = value; }
    }
    private int _m_AccountID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"m_AccountID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int m_AccountID
    {
      get { return _m_AccountID; }
      set { _m_AccountID = value; }
    }
    private string _m_RandStr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"m_RandStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_RandStr
    {
      get { return _m_RandStr; }
      set { _m_RandStr = value; }
    }

    private int _m_lastloginServerID = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"m_lastloginServerID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int m_lastloginServerID
    {
      get { return _m_lastloginServerID; }
      set { _m_lastloginServerID = value; }
    }

    private int _m_lastloginServerID2 = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"m_lastloginServerID2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int m_lastloginServerID2
    {
      get { return _m_lastloginServerID2; }
      set { _m_lastloginServerID2 = value; }
    }

    private int _m_lastloginServerState = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"m_lastloginServerState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int m_lastloginServerState
    {
      get { return _m_lastloginServerState; }
      set { _m_lastloginServerState = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_AccountCreate")]
  public partial class GM_AccountCreate : global::ProtoBuf.IExtensible
  {
    public GM_AccountCreate() {}
    
    private string _m_AccountName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"m_AccountName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_AccountName
    {
      get { return _m_AccountName; }
      set { _m_AccountName = value; }
    }
    private string _m_Password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"m_Password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_Password
    {
      get { return _m_Password; }
      set { _m_Password = value; }
    }
    private GM_AccountLog _accountLogInfo;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"accountLogInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public GM_AccountLog accountLogInfo
    {
      get { return _accountLogInfo; }
      set { _accountLogInfo = value; }
    }

    private string _m_activatekey = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"m_activatekey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string m_activatekey
    {
      get { return _m_activatekey; }
      set { _m_activatekey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_AccountCreateReturn")]
  public partial class GM_AccountCreateReturn : global::ProtoBuf.IExtensible
  {
    public GM_AccountCreateReturn() {}
    
    private int _m_Result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"m_Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int m_Result
    {
      get { return _m_Result; }
      set { _m_Result = value; }
    }
    private int _m_AccountID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"m_AccountID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int m_AccountID
    {
      get { return _m_AccountID; }
      set { _m_AccountID = value; }
    }
    private string _m_AccountName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"m_AccountName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_AccountName
    {
      get { return _m_AccountName; }
      set { _m_AccountName = value; }
    }
    private string _m_Password;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"m_Password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_Password
    {
      get { return _m_Password; }
      set { _m_Password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_AccountExistRequest")]
  public partial class GM_AccountExistRequest : global::ProtoBuf.IExtensible
  {
    public GM_AccountExistRequest() {}
    
    private string _m_AccountName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"m_AccountName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string m_AccountName
    {
      get { return _m_AccountName; }
      set { _m_AccountName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_VerifyVersion")]
  public partial class GM_VerifyVersion : global::ProtoBuf.IExtensible
  {
    public GM_VerifyVersion() {}
    
    private string _version;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_VerifyVersionReturn")]
  public partial class GM_VerifyVersionReturn : global::ProtoBuf.IExtensible
  {
    public GM_VerifyVersionReturn() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _serverversion;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"serverversion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string serverversion
    {
      get { return _serverversion; }
      set { _serverversion = value; }
    }

    private int _serverFlag = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"serverFlag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int serverFlag
    {
      get { return _serverFlag; }
      set { _serverFlag = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_TestAccountReturn")]
  public partial class GM_TestAccountReturn : global::ProtoBuf.IExtensible
  {
    public GM_TestAccountReturn() {}
    
    private string _accountName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"accountName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string accountName
    {
      get { return _accountName; }
      set { _accountName = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_BindTestAccountRequest")]
  public partial class GM_BindTestAccountRequest : global::ProtoBuf.IExtensible
  {
    public GM_BindTestAccountRequest() {}
    
    private string _testAccountName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"testAccountName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string testAccountName
    {
      get { return _testAccountName; }
      set { _testAccountName = value; }
    }
    private string _testPassword;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"testPassword", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string testPassword
    {
      get { return _testPassword; }
      set { _testPassword = value; }
    }
    private string _newAccountName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"newAccountName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string newAccountName
    {
      get { return _newAccountName; }
      set { _newAccountName = value; }
    }
    private string _newPassword;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"newPassword", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string newPassword
    {
      get { return _newPassword; }
      set { _newPassword = value; }
    }
    private string _platform;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"platform", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string platform
    {
      get { return _platform; }
      set { _platform = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_BindTestAccountReturn")]
  public partial class GM_BindTestAccountReturn : global::ProtoBuf.IExtensible
  {
    public GM_BindTestAccountReturn() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SP_BindTestAccountRequest")]
  public partial class SP_BindTestAccountRequest : global::ProtoBuf.IExtensible
  {
    public SP_BindTestAccountRequest() {}
    
    private GM_BindTestAccountRequest _bindTestAccountRequest;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bindTestAccountRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public GM_BindTestAccountRequest bindTestAccountRequest
    {
      get { return _bindTestAccountRequest; }
      set { _bindTestAccountRequest = value; }
    }
    private string _clientIP;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"clientIP", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string clientIP
    {
      get { return _clientIP; }
      set { _clientIP = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_TestAccountRequest")]
  public partial class GM_TestAccountRequest : global::ProtoBuf.IExtensible
  {
    public GM_TestAccountRequest() {}
    
    private string _idfa;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"idfa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string idfa
    {
      get { return _idfa; }
      set { _idfa = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GM_RecordAccountInfo")]
  public partial class GM_RecordAccountInfo : global::ProtoBuf.IExtensible
  {
    public GM_RecordAccountInfo() {}
    
    private string _username;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private string _userpassword;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"userpassword", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string userpassword
    {
      get { return _userpassword; }
      set { _userpassword = value; }
    }
    private string _userkey;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"userkey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string userkey
    {
      get { return _userkey; }
      set { _userkey = value; }
    }
    private int _platform;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"platform", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int platform
    {
      get { return _platform; }
      set { _platform = value; }
    }
    private string _channel;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"channel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string channel
    {
      get { return _channel; }
      set { _channel = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}