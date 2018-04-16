/**
 * @(#)person1.java
 * Create a person1 object with attributes name, age and hobby and phone1 object
 * The phone1 object should have a number, ring_volume and colour
 * Create a person1Test with a valid instance of a person1 object
 *
 * @author
 * @version 1.00 2016/1/14
 */


public class person1 {

	//attributes
	private String name;
	private int age;
	private String hobby;
	private phone1 p1;

	//constructor
    public person1(String name, int age, String hobby, phone1 p) {
    	this.name = ((name.length()>0)? name : "Unknown");
    	this.age = ((age>0)? age : 1);
    	this.hobby = ((hobby.length()>0)? hobby : "Unknown");
    	p1 = p;
    }//end constructor

	//toString
    public String toString(){
    	return "Student Details \nName: " + name + "\nAge: " + age + "\nHobby: " + hobby + p1;
    }//end toString

}//end class