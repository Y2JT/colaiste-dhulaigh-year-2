/**
 * @(#)employee.java
 *
 *
 * @author 
 * @version 1.00 2016/3/2
 */


public class employee {
	
	private String name, address;
	private int id;

    public employee(String name, String address, int id) {
    	setDetails(name,address,id);
    }//end constructor
    
    public void setDetails(String name, String address, int id){
    	this.name = ((name.length()>0)? name : "Unknown");
    	this.address = ((address.length()>0)? address : "Unknown");
    	this.id = ((id>0)? id : 111);
    }//end setDetails
    
    //toString
    public String toString(){
    	return "\nName: " + name + "\nAddress: " + address + "\nID: " + id + "\n\n";
    }//end toString
    
    //setname method
    public void setname(String name){
    	this.name = ((name.length()>0)? name : "Unknown");
    }//end setname method
    
    //getname method
    public String getname(){
    	return name;
    }//end getname method
    
    //setaddress method
    public void setaddress(String address){
    	this.address = ((address.length()>0)? address : "Unknown");
    }//end setaddress method
    
    //getaddress method
    public String getaddress(){
    	return address;
    }//end getaddress
    
    //setid method
    public void setid(int id){
    	this.id = ((id>0)? id : 111);
    }//end setid method
    
    //getid method
    public int getid(){
    	return id;
    }//end getid method
    
    
}//end class