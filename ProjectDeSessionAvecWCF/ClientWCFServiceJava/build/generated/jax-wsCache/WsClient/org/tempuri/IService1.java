
package org.tempuri;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebService(name = "IService1", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    com.microsoft.schemas._2003._10.serialization.ObjectFactory.class,
    org.tempuri.ObjectFactory.class
})
public interface IService1 {


    /**
     * 
     * @param date
     * @param userName
     * @param value
     * @param machineName
     * @param machineIP
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "Verifier", action = "http://tempuri.org/IService1/Verifier")
    @WebResult(name = "VerifierResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Verifier", targetNamespace = "http://tempuri.org/", className = "org.tempuri.Verifier")
    @ResponseWrapper(localName = "VerifierResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.VerifierResponse")
    public String verifier(
        @WebParam(name = "value", targetNamespace = "http://tempuri.org/")
        XMLGregorianCalendar value,
        @WebParam(name = "MachineName", targetNamespace = "http://tempuri.org/")
        String machineName,
        @WebParam(name = "MachineIP", targetNamespace = "http://tempuri.org/")
        String machineIP,
        @WebParam(name = "UserName", targetNamespace = "http://tempuri.org/")
        String userName,
        @WebParam(name = "date", targetNamespace = "http://tempuri.org/")
        XMLGregorianCalendar date);

}