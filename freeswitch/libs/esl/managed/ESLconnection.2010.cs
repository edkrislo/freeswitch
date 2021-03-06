/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ESLconnection : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ESLconnection(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ESLconnection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ESLconnection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ESLPINVOKE.delete_ESLconnection(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ESLconnection(string host, int port, string user, string password) : this(ESLPINVOKE.new_ESLconnection__SWIG_0(host, port, user, password), true) {
  }

  public ESLconnection(string host, int port, string password) : this(ESLPINVOKE.new_ESLconnection__SWIG_1(host, port, password), true) {
  }

  public ESLconnection(string host, string port, string user, string password) : this(ESLPINVOKE.new_ESLconnection__SWIG_2(host, port, user, password), true) {
  }

  public ESLconnection(string host, string port, string password) : this(ESLPINVOKE.new_ESLconnection__SWIG_3(host, port, password), true) {
  }

  public ESLconnection(int socket) : this(ESLPINVOKE.new_ESLconnection__SWIG_4(socket), true) {
  }

  public int SocketDescriptor() {
    int ret = ESLPINVOKE.ESLconnection_SocketDescriptor(swigCPtr);
    return ret;
  }

  public int Connected() {
    int ret = ESLPINVOKE.ESLconnection_Connected(swigCPtr);
    return ret;
  }

  public ESLevent GetInfo() {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_GetInfo(swigCPtr);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public int Send(string cmd) {
    int ret = ESLPINVOKE.ESLconnection_Send(swigCPtr, cmd);
    return ret;
  }

  public ESLevent SendRecv(string cmd) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_SendRecv(swigCPtr, cmd);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent Api(string cmd, string arg) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_Api(swigCPtr, cmd, arg);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent Bgapi(string cmd, string arg, string job_uuid) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_Bgapi(swigCPtr, cmd, arg, job_uuid);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent SendEvent(ESLevent send_me) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_SendEvent(swigCPtr, ESLevent.getCPtr(send_me));
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public int sendMSG(ESLevent send_me, string uuid) {
    int ret = ESLPINVOKE.ESLconnection_sendMSG(swigCPtr, ESLevent.getCPtr(send_me), uuid);
    return ret;
  }

  public ESLevent RecvEvent() {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_RecvEvent(swigCPtr);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent RecvEventTimed(int ms) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_RecvEventTimed(swigCPtr, ms);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent Filter(string header, string value) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_Filter(swigCPtr, header, value);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public int Events(string etype, string value) {
    int ret = ESLPINVOKE.ESLconnection_Events(swigCPtr, etype, value);
    return ret;
  }

  public ESLevent Execute(string app, string arg, string uuid) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_Execute(swigCPtr, app, arg, uuid);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public ESLevent ExecuteAsync(string app, string arg, string uuid) {
    IntPtr cPtr = ESLPINVOKE.ESLconnection_ExecuteAsync(swigCPtr, app, arg, uuid);
    ESLevent ret = (cPtr == IntPtr.Zero) ? null : new ESLevent(cPtr, true);
    return ret;
  }

  public int SetAsyncExecute(string val) {
    int ret = ESLPINVOKE.ESLconnection_SetAsyncExecute(swigCPtr, val);
    return ret;
  }

  public int SetEventLock(string val) {
    int ret = ESLPINVOKE.ESLconnection_SetEventLock(swigCPtr, val);
    return ret;
  }

  public int Disconnect() {
    int ret = ESLPINVOKE.ESLconnection_Disconnect(swigCPtr);
    return ret;
  }

}
