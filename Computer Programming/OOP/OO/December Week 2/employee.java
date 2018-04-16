/**
 * @(#)employee.java
 * Create an employee object with name, id and numHours (number of hours)
 * Have a constructor. Have set and get methods for each instance variable (attribute)
 * Have a toString method
 *
 * In the employeeTest class, create a valid and invalid employee and
 * change details of the invalid employee using set methods and display the new details
 * using the get methods
 *
 * Take the employee details in from the user
 *
 * Have a calculate wages input that will have a pay rate passed to it and will
 * calculate and return the wage
 *
 * @version 1.00 2015/12/10
 */

public class employee {

	private String name;
	private int id;
	private int numHours;

	//constructor
    public employee(String name, int id, int numHours) {

    	this.name = ((name.length()>0)?name: "Unknown");
    	this.id = ((id>0)?id : 1);
    	this.numHours = ((numHours>0)?numHours : 1);

    }//end constuctor

    //setname method
    public void setname(String name){
    	this.name = ((name.length()>0)?name: "Unknown");
    }//end setname method

    //getname method
    public String getname(){
    	return name;
    }//end getname method

    //setid method
    public void setid(int id){
    	this.id = ((id>0)?id : 1);
    }//end setid method

    //getid method
    public int getid(){
    	return id;
    }//end getid method

    //setnumHours method
    public void setnumHours(int numHours){
    	this.numHours = ((numHours>0)?numHours : 1);
    }//end setnumHours method

    //getnumHours method
    public int getnumHours(){
    	return numHours;
    }//end numHours

    public double calculateWages(double rate){
    	int HoursOvertime;
    	if(numHours>39){
    		HoursOvertime = numHours - 39;
    		return rate * numHours + (HoursOvertime * 1.5);
    	}//end if
    	else{
    		return rate * numHours;
    	}//end else
    }//end calculate wages

    //toString method
    public String toString(){
    	return "\nEmployee details\n\nName: " + name + "\nID: " + id + "\nHours: " + numHours;
    }//end toString method

}//end class