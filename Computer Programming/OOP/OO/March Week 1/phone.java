/**
 * @(#)phone.java
 * Create a phone object with instance variables number and make
 * Create a student object. A student has a phone, name and id
 * Create an undergradute student, which is a student but also has course name and course length
 * Create a postgraduate student which is a student but also has degree-type and grade
 *
 * Create a test class and take in values from the user to create an array of students made up of postgraduate and
 * undergraduate student. The user will need to be asked is The student a postgrad or undergrad.
 *
 * Display all details of the students. Keep track of how many students are being created
 *
 * @author
 * @version 1.00 2016/3/3
 */


public class phone {

	private int number;
	private String make;

    public phone(int num, String m) {

    	number = ((num>0)? num : 111);
    	make = ((m.length()>0)? m : "Unknown");

    }//end constructor

    //toString
    public String toString(){
    	return "\nPhone Number: " + number + "\nPhone Make: " + make;
    }//end toString

}//end class