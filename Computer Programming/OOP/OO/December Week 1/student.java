/**
 * @(#)student.java
 * Create a student with attributes name, course and age
 * Print all the details for the student using the toString method
 *
 * @author
 * @version 1.00 2015/12/3
 */


public class student {
	//attributes
	private String name;
	private String course;
	private int age;

	//constructor (the purpose of the constructor is to create an object in a consistant state)
    public student(String name, String course, int age) {
    	this.name = ((name.length()>0)?name : "Unknown");
    	this.course = course;
    	this.age = ((age > 0)?age : 1);	//conditional statement
    }//end constructor

    //toString method
    public String toString(){
    	return "\nName: " + name + "\nCourse: " + course + "\nAge: " + age;
    }//end toString method


}//end class