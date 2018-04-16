/**
 * @(#)student.java
 *
 *
 * @author
 * @version 1.00 2016/1/31
 */


public class student extends Aperson {

	private String collegeName, courseName;

	//constructor
    public student(String name, String address, int id, String collegeName, String courseName) {
    	super(name, address, id);	//calls the constructor of the super class
    	this.collegeName = collegeName;
    	this.courseName = courseName;
    }//end constructor

    //set college name method
    public void setcollegeName(String collegeName){
    	this.collegeName = collegeName;
    }//end set college name method

    //set course name method
    public void setcourseName(String courseName){
    	this.courseName = courseName;
    }//end set course name method

    //get college name method
    public String getcollegeName(){
    	return collegeName;
    }//end get college name method

    //get course name method
    public String getcourseName(){
    	return courseName;
    }//end get course name method

    //toString method
    public String toString(){
    	return super.toString() + "\nCollege Name: " + collegeName + "\nCourse Name: " + courseName;
    }//end toString method

}//end class