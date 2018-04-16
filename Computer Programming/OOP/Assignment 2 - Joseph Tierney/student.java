/**
 * @(#)student.java
 *
 *
 * @author
 * @version 1.00 2016/4/7
 */


public class student extends applicant {

	private String address;
	private application a1;

	//constructor
    public student(String name, int id, String address, application a1) {
    	super(name,id);	//calls super class constructor
    	this.address = ((address.length()>0)? address : "Unknown");
    	this.a1 = a1;
    }//end constructor

    //toString
    public String toString(){
    	return super.toString() + "\nStudent Address: " + address + a1;
    }//end toString

   //set address
   public void setaddress(String address){
   		this.address = ((address.length()>0)? address : "Unknown");
   }//end set address

   //get address
   public String getaddress(){
   		return address;
   }//end get address
   
   //set application a1
   public void setapplication(application a1){
   	this.a1 = a1;
   }//end setapplication

   //get application a1
   public String getapplication(){
   	return a1.toString();
   }//end get application
	
   //get name
   public String getname(){
   	return super.getname();
   }//end get name

   //get id
   public int getid(){
   	return super.getid();
   }//end get id

}//end class