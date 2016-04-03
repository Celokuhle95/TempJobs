﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebApplication1.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegistrationDatabaseOperationCompleted;
        
        private System.Threading.SendOrPostCallback LgnUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback UserNameCheckOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadEmployeesOperationCompleted;
        
        private System.Threading.SendOrPostCallback StoreSkillsOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadSkillsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::WebApplication1.Properties.Settings.Default.WebApplication1_localhost_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;
        
        /// <remarks/>
        public event RegistrationDatabaseCompletedEventHandler RegistrationDatabaseCompleted;
        
        /// <remarks/>
        public event LgnUserCompletedEventHandler LgnUserCompleted;
        
        /// <remarks/>
        public event UserNameCheckCompletedEventHandler UserNameCheckCompleted;
        
        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;
        
        /// <remarks/>
        public event ReadEmployeesCompletedEventHandler ReadEmployeesCompleted;
        
        /// <remarks/>
        public event StoreSkillsCompletedEventHandler StoreSkillsCompleted;
        
        /// <remarks/>
        public event ReadSkillsCompletedEventHandler ReadSkillsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetData(int value, [System.Xml.Serialization.XmlIgnoreAttribute()] bool valueSpecified) {
            object[] results = this.Invoke("GetData", new object[] {
                        value,
                        valueSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified) {
            this.GetDataAsync(value, valueSpecified, null);
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified, object userState) {
            if ((this.GetDataOperationCompleted == null)) {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        value,
                        valueSpecified}, this.GetDataOperationCompleted, userState);
        }
        
        private void OnGetDataOperationCompleted(object arg) {
            if ((this.GetDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/RegistrationDatabase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RegistrationDatabase([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string userName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string firstName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string lastName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string address, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string cantactNumbers, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string altanativeNumber, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, int authenticationLevel, [System.Xml.Serialization.XmlIgnoreAttribute()] bool authenticationLevelSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string profileImage) {
            this.Invoke("RegistrationDatabase", new object[] {
                        userName,
                        firstName,
                        lastName,
                        address,
                        Email,
                        cantactNumbers,
                        altanativeNumber,
                        password,
                        authenticationLevel,
                        authenticationLevelSpecified,
                        profileImage});
        }
        
        /// <remarks/>
        public void RegistrationDatabaseAsync(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, bool authenticationLevelSpecified, string profileImage) {
            this.RegistrationDatabaseAsync(userName, firstName, lastName, address, Email, cantactNumbers, altanativeNumber, password, authenticationLevel, authenticationLevelSpecified, profileImage, null);
        }
        
        /// <remarks/>
        public void RegistrationDatabaseAsync(string userName, string firstName, string lastName, string address, string Email, string cantactNumbers, string altanativeNumber, string password, int authenticationLevel, bool authenticationLevelSpecified, string profileImage, object userState) {
            if ((this.RegistrationDatabaseOperationCompleted == null)) {
                this.RegistrationDatabaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegistrationDatabaseOperationCompleted);
            }
            this.InvokeAsync("RegistrationDatabase", new object[] {
                        userName,
                        firstName,
                        lastName,
                        address,
                        Email,
                        cantactNumbers,
                        altanativeNumber,
                        password,
                        authenticationLevel,
                        authenticationLevelSpecified,
                        profileImage}, this.RegistrationDatabaseOperationCompleted, userState);
        }
        
        private void OnRegistrationDatabaseOperationCompleted(object arg) {
            if ((this.RegistrationDatabaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegistrationDatabaseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/LgnUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LgnUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool LgnUserResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool LgnUserResultSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out string message) {
            object[] results = this.Invoke("LgnUser", new object[] {
                        username,
                        password});
            LgnUserResult = ((bool)(results[0]));
            LgnUserResultSpecified = ((bool)(results[1]));
            message = ((string)(results[2]));
        }
        
        /// <remarks/>
        public void LgnUserAsync(string username, string password) {
            this.LgnUserAsync(username, password, null);
        }
        
        /// <remarks/>
        public void LgnUserAsync(string username, string password, object userState) {
            if ((this.LgnUserOperationCompleted == null)) {
                this.LgnUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLgnUserOperationCompleted);
            }
            this.InvokeAsync("LgnUser", new object[] {
                        username,
                        password}, this.LgnUserOperationCompleted, userState);
        }
        
        private void OnLgnUserOperationCompleted(object arg) {
            if ((this.LgnUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LgnUserCompleted(this, new LgnUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/UserNameCheck", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UserNameCheck([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string UserName, out bool UserNameCheckResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool UserNameCheckResultSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out string message) {
            object[] results = this.Invoke("UserNameCheck", new object[] {
                        UserName});
            UserNameCheckResult = ((bool)(results[0]));
            UserNameCheckResultSpecified = ((bool)(results[1]));
            message = ((string)(results[2]));
        }
        
        /// <remarks/>
        public void UserNameCheckAsync(string UserName) {
            this.UserNameCheckAsync(UserName, null);
        }
        
        /// <remarks/>
        public void UserNameCheckAsync(string UserName, object userState) {
            if ((this.UserNameCheckOperationCompleted == null)) {
                this.UserNameCheckOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserNameCheckOperationCompleted);
            }
            this.InvokeAsync("UserNameCheck", new object[] {
                        UserName}, this.UserNameCheckOperationCompleted, userState);
        }
        
        private void OnUserNameCheckOperationCompleted(object arg) {
            if ((this.UserNameCheckCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UserNameCheckCompleted(this, new UserNameCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetDataUsingDataContract", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType GetDataUsingDataContract([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CompositeType composite) {
            object[] results = this.Invoke("GetDataUsingDataContract", new object[] {
                        composite});
            return ((CompositeType)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite, object userState) {
            if ((this.GetDataUsingDataContractOperationCompleted == null)) {
                this.GetDataUsingDataContractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractOperationCompleted);
            }
            this.InvokeAsync("GetDataUsingDataContract", new object[] {
                        composite}, this.GetDataUsingDataContractOperationCompleted, userState);
        }
        
        private void OnGetDataUsingDataContractOperationCompleted(object arg) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/ReadEmployees", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/TempJobsWcf")]
        public Userdata[] ReadEmployees() {
            object[] results = this.Invoke("ReadEmployees", new object[0]);
            return ((Userdata[])(results[0]));
        }
        
        /// <remarks/>
        public void ReadEmployeesAsync() {
            this.ReadEmployeesAsync(null);
        }
        
        /// <remarks/>
        public void ReadEmployeesAsync(object userState) {
            if ((this.ReadEmployeesOperationCompleted == null)) {
                this.ReadEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadEmployeesOperationCompleted);
            }
            this.InvokeAsync("ReadEmployees", new object[0], this.ReadEmployeesOperationCompleted, userState);
        }
        
        private void OnReadEmployeesOperationCompleted(object arg) {
            if ((this.ReadEmployeesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadEmployeesCompleted(this, new ReadEmployeesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/StoreSkills", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StoreSkills([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Name, int UserID, [System.Xml.Serialization.XmlIgnoreAttribute()] bool UserIDSpecified) {
            this.Invoke("StoreSkills", new object[] {
                        Name,
                        UserID,
                        UserIDSpecified});
        }
        
        /// <remarks/>
        public void StoreSkillsAsync(string Name, int UserID, bool UserIDSpecified) {
            this.StoreSkillsAsync(Name, UserID, UserIDSpecified, null);
        }
        
        /// <remarks/>
        public void StoreSkillsAsync(string Name, int UserID, bool UserIDSpecified, object userState) {
            if ((this.StoreSkillsOperationCompleted == null)) {
                this.StoreSkillsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStoreSkillsOperationCompleted);
            }
            this.InvokeAsync("StoreSkills", new object[] {
                        Name,
                        UserID,
                        UserIDSpecified}, this.StoreSkillsOperationCompleted, userState);
        }
        
        private void OnStoreSkillsOperationCompleted(object arg) {
            if ((this.StoreSkillsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StoreSkillsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/ReadSkills", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/TempJobsWcf")]
        public InformalSkill[] ReadSkills() {
            object[] results = this.Invoke("ReadSkills", new object[0]);
            return ((InformalSkill[])(results[0]));
        }
        
        /// <remarks/>
        public void ReadSkillsAsync() {
            this.ReadSkillsAsync(null);
        }
        
        /// <remarks/>
        public void ReadSkillsAsync(object userState) {
            if ((this.ReadSkillsOperationCompleted == null)) {
                this.ReadSkillsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadSkillsOperationCompleted);
            }
            this.InvokeAsync("ReadSkills", new object[0], this.ReadSkillsOperationCompleted, userState);
        }
        
        private void OnReadSkillsOperationCompleted(object arg) {
            if ((this.ReadSkillsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadSkillsCompleted(this, new ReadSkillsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/TempJobsWcf")]
    public partial class CompositeType {
        
        private bool boolValueField;
        
        private bool boolValueFieldSpecified;
        
        private string stringValueField;
        
        /// <remarks/>
        public bool BoolValue {
            get {
                return this.boolValueField;
            }
            set {
                this.boolValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified {
            get {
                return this.boolValueFieldSpecified;
            }
            set {
                this.boolValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/TempJobsWcf")]
    public partial class InformalSkill {
        
        private string nameField;
        
        private int skill_IDField;
        
        private bool skill_IDFieldSpecified;
        
        private System.Nullable<int> userData_IDField;
        
        private bool userData_IDFieldSpecified;
        
        private Userdata userdataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int Skill_ID {
            get {
                return this.skill_IDField;
            }
            set {
                this.skill_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Skill_IDSpecified {
            get {
                return this.skill_IDFieldSpecified;
            }
            set {
                this.skill_IDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> UserData_ID {
            get {
                return this.userData_IDField;
            }
            set {
                this.userData_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserData_IDSpecified {
            get {
                return this.userData_IDFieldSpecified;
            }
            set {
                this.userData_IDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Userdata Userdata {
            get {
                return this.userdataField;
            }
            set {
                this.userdataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/TempJobsWcf")]
    public partial class Userdata {
        
        private string emailField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private InformalSkill[] informalSkillsField;
        
        private string profileImageField;
        
        private string usernameField;
        
        private string addressField;
        
        private string alternativeNumberField;
        
        private System.Nullable<int> authinticationLevelField;
        
        private bool authinticationLevelFieldSpecified;
        
        private string contactNumberField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public InformalSkill[] InformalSkills {
            get {
                return this.informalSkillsField;
            }
            set {
                this.informalSkillsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ProfileImage {
            get {
                return this.profileImageField;
            }
            set {
                this.profileImageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string alternativeNumber {
            get {
                return this.alternativeNumberField;
            }
            set {
                this.alternativeNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> authinticationLevel {
            get {
                return this.authinticationLevelField;
            }
            set {
                this.authinticationLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool authinticationLevelSpecified {
            get {
                return this.authinticationLevelFieldSpecified;
            }
            set {
                this.authinticationLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string contactNumber {
            get {
                return this.contactNumberField;
            }
            set {
                this.contactNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void RegistrationDatabaseCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void LgnUserCompletedEventHandler(object sender, LgnUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LgnUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LgnUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool LgnUserResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool LgnUserResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void UserNameCheckCompletedEventHandler(object sender, UserNameCheckCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UserNameCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UserNameCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool UserNameCheckResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool UserNameCheckResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CompositeType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CompositeType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void ReadEmployeesCompletedEventHandler(object sender, ReadEmployeesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Userdata[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Userdata[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void StoreSkillsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void ReadSkillsCompletedEventHandler(object sender, ReadSkillsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadSkillsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadSkillsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public InformalSkill[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((InformalSkill[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591