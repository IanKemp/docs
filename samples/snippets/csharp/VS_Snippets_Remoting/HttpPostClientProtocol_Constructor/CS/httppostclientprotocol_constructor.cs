﻿// System.Web.Services.Protocols.HttpPostClientProtocol.HttpPostClientProtocol

/* The following example demonstrates 'Constructor' of 'HttpPostClientProtocol' class
   A variable of type 'HttpPostClientProtocol' is used to set proxy information ,
   client credentials and Url on the proxy class.
*/
/*
// The following example is a proxy class generated by the Wsdl.exe utility
// for the Math Web service. The proxy class derives from 
// HttpPostClientProtocol, which derives from the abstract
// HttpSimpleClientProtocol class.

public class MyMath : System.Web.Services.Protocols.HttpPostClientProtocol 
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public MyMath() 
    {
        this.Url = "http://localhost/Mymath.Cs.asmx";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Web.Services.Protocols.HttpMethodAttribute(
        typeof(System.Web.Services.Protocols.XmlReturnReader), 
        typeof(System.Web.Services.Protocols.HtmlFormParameterWriter))]
    [return: System.Xml.Serialization.XmlRootAttribute("int",
        Namespace="http://tempuri.org/", IsNullable=false)]
    public int Add(string num1, string num2) 
    {
        return ((int)(this.Invoke("Add", (this.Url + "/Add"), 
            new object[] {num1, num2})));
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public System.IAsyncResult BeginAdd(string num1, string num2,
        System.AsyncCallback callback, object asyncState) 
    {
        return this.BeginInvoke("Add", (this.Url + "/Add"), 
            new object[] {num1, num2}, callback, asyncState);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public int EndAdd(System.IAsyncResult asyncResult) 
    {
        return ((int)(this.EndInvoke(asyncResult)));
    }
}
*/

using System;
using System.Net;
using System.Web.Services.Protocols;
using System.Web.Services;

public class Math : HttpPostClientProtocol
{
}

public class HttpPostClientProtocolClass
{
    public static void Main()
    {
        // <Snippet1>
        // Math is a proxy class derived from HttpPostClientProtocol.
        HttpPostClientProtocol myHttpPostClientProtocol = new Math();

        // Obtain password from a secure store.
        String SecurelyStoredPassword = String.Empty;

        // Set the client-side credentials using the Credentials property.
        myHttpPostClientProtocol.Credentials = System.Net.CredentialCache.DefaultCredentials;

        // Allow the server to redirect the request.
        myHttpPostClientProtocol.AllowAutoRedirect = true;
        Console.WriteLine("Auto redirect is: " + 
            myHttpPostClientProtocol.AllowAutoRedirect);
        // </Snippet1>
    }
}