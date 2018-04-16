/**
 * @(#)student.java
 * Question 2, part 1
 *
 * @author 
 * @version 1.00 2016/3/2
 */


public class student {
	
	private String name;
	private int age, id;

    public student(String name, int age, int id) {
    	this.name = ((name.length()>0)? name: "Unknown");
    	this.age = ((age>0)? age : 1);
    	this.id = ((id>0)? id : 111);
    }//end constructor
    
    //talk behaviour
    public String talk(){
    	return "Talk Talk\n\n";
    }//end talk behaviour
    
    //toString
    public String toString(){
    	return "\nName: " + name + "\nAge: " + age + "\nID: " + id + "\n\n";
    }//end toString
    
    
}