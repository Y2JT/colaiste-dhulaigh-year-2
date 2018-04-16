/**
 * @(#)q3.java
 * Write a class employee with attributes name, id and address. The attributes should be set
 * in a setDetails method and not in the constructor. Also have set and get methods and a toString method.
 *
 * Continuing from part a above, create an employeeTest class and create an employee object.
 * Print the details of the employee object and then change the value of the name and id and show
 * the new values using the set and get methods.
 *
 * @version 1.00 2016/3/10
 */


public class q3 {

	private String name, address;
	private int id;

	//contructor
    public q3(String n, String a, int i) {
    	setDetails(n,a,i);
    }//end constructor

    //setDetails
    public void setDetails(String n, String a, int i){
    	name = ((n.length()>0)? n : "Unknown");
    	address = ((a.length()>0)? a : "Unknown");
    	id = ((i>0)? i : 111);
    }//end setDetails

    public void setname(String n){
    	name = ((n.length()>0)? n : "Unknown");
    }//end setname

    //getname method
    public String getname(){
    	return name;
    }//end getname


}