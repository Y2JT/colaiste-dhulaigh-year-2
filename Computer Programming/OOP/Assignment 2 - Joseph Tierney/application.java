/**
 * @(#)application.java
 *
 *
 * @author
 * @version 1.00 2016/4/7
 */


public class application {

	private String course_name;
	private int course_number;

	//constructor
    public application(String course_name, int course_number) {
    	this.course_name = ((course_name.length()>0)? course_name : "Unknown");
    	this.course_number = ((course_number>0)? course_number : 111);
    }//end constructor

    //toString
    public String toString(){
    	return "\nCourse Name: " + course_name + "\nCourse Number: " + course_number + "\n";
    }//end toString

    //set course name
    public void setcname(String course_name){
    	this.course_name = ((course_name.length()>0)? course_name : "Unknown");
    }//end course name

    //get course name
    public String getcname(){
    	return course_name;
    }//end get course name

    //set course number
    public void setcnumber(int cn){
    	this.course_number = ((cn>0)? cn : 111);
    }//end set course number

    //get course number
    public int getcnumber(){
    	return course_number;
    }//end get course number

}//end class