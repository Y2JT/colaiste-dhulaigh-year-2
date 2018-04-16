/**
 * @(#)applicant.java
 *
 *
 * @author
 * @version 1.00 2016/4/7
 */


public class applicant {

	private String name;
	private int id;

	//constructor
    public applicant(String name, int id) {
    	this.name = ((name.length()>0)? name : "Unknown");
    	this.id = ((id>0)? id : 111);
    }//end constructor

    //toString
    public String toString(){
    	return "\nApplicant Details\n\nStudent Name: " + name + "\nStudent ID: " + id;
    }//end toString
	
	//set name
	public void setname(String name){
		this.name = ((name.length()>0)? name : "Unknown");
	}//end set name
	
	//get name
	public String getname(){
		return name;
	}//end get name
	
	//set id
	public void setid(int id){
		this.id = ((id>0)? id : 111);
	}//end set id
	
	//get id
	public int getid(){
		return id;
	}//end get id
	
}//end class